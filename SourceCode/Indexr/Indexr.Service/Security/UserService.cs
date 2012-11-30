using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Indexr.Data;
using Indexr.Domain;
using System.Web.Security;
using System.Security.Cryptography;

namespace Indexr.Service
{
    public class UserService : IUserService
    {
        #region Global Variable Declaration

        private readonly IUserRepository _iUserRepository;
        private readonly IUnitOfWork _iUnitOfWork;

        #endregion

        #region Constructor

        public UserService(IUserRepository iUserRepository, IUnitOfWork iUnitOfWork)
        {
            this._iUserRepository = iUserRepository;
            this._iUnitOfWork = iUnitOfWork;
        }

        #endregion

        #region Get Method

        public IQueryable<User> GetAll()
        {
            var users = _iUserRepository.GetAll();
            return users as IQueryable<User>; ;
        }

        //public IQueryable<User> GetUsers()
        //{
        //    var users = _iUserRepository.GetAll();
        //    return users as IQueryable<User>; ;
        //}

        //public IQueryable<User> GetLoggedInUsers()
        //{
        //    var users = _iUserRepository.GetAll().Where(x => x.IsLoggedIn == true).ToList();
        //    return users as IQueryable<User>;;
        //}

        public User GetUser(string userName)
        {
            var user = _iUserRepository.GetById(userName);
            return user;
        }

        #endregion

        #region Create Method

        public void Create(User user)
        {
            _iUserRepository.Insert(user);
            Save();
        }

        #endregion

        #region Update Method

        public void Update(User user)
        {
            _iUserRepository.Update(user);
            Save();
        }

        public void AddUserToRole(string userName, List<string> roleNames)
        {
            _iUserRepository.AssignRole(userName, roleNames);
            Save();
        }

        //public void ChangeUserLogInStatus(User user, bool inout)
        //{
        //    User userDb = _iUserRepository.GetById(user.UserName);
        //    if (userDb != null)
        //    {
        //        userDb.IsLoggedIn = inout;
        //        _iUserRepository.Update(userDb);
        //        Save();
        //    }
        //}

        #endregion

        #region Delete Method

        public void Delete(User user)
        {
            var deleteUser = GetUser(user.UserName);
            _iUserRepository.Delete(deleteUser);
            Save();
        }

        #endregion

        #region Save By Commit

        public void Save()
        {
            _iUnitOfWork.Commit();
        }

        #endregion

        #region Reset Password

        //Reset Password
        public bool ForgetPassword(User user)
        {
            try
            {
                if (!String.IsNullOrEmpty(user.Email))
                {
                    SendResetEmail(user);
                    return true;
                }

                return false;

            }
            catch (ArgumentException)
            {
                return false;
            }
            catch (MembershipPasswordException)
            {
                return false;
            }
        }

        //Send Email Method
        public void SendResetEmail(User user)
        {
            //string mailBody = GetResetEmailBody(user.UserName);
            //const string mailSubject = "Your new password";
            //const string mailFrom = "rasel@syntechbd.com";
            //string mailTo = user.Email;
            //MailService mailService = new MailService();

            //MailServiceResult mailResult = mailService.SendEmail(mailTo, mailFrom, mailSubject, mailBody);
        }

        public string HashResetParams(string username)
        {
            byte[] bytesofLink = Encoding.UTF8.GetBytes(username);
            MD5 md5 = new MD5CryptoServiceProvider();
            string hashParams = BitConverter.ToString(md5.ComputeHash(bytesofLink));

            return hashParams;
        }

        private string GetResetEmailBody(string userName)
        {
            string link = "http://www.syntechbd.com/Account/ResetPassword/?username=" + userName + "&reset=" + HashResetParams(userName);

            string mailBody = "<p>Hi " + userName + "," + "</p>";
            mailBody += "<p>You just requested a new password for your my regfire account.</p>";
            mailBody += "---------------------------------------------------------------------------</br>";
            mailBody += "For creating a new password please click on the following link:</br>";
            mailBody += "<a href='" + link + "'>" + link + "</a></br>";
            mailBody += "---------------------------------------------------------------------------</br>";
            mailBody += "<p>Please keep your password safe to prevent unathorized access.</p>";
            mailBody += "---------------------</br>";
            mailBody += "Property Management</br>";
            mailBody += "Our Slogan</br>";
            mailBody += "---------------------</br>";
            mailBody += @"<p>http://www.syntechbd.com/</p>";
            mailBody += @"<p>&copy; " + DateTime.Now.Year + " - Syntech BD | Syntech Ltd. - Bangladesh</p>";

            return mailBody;
        }

        #endregion

    }
}

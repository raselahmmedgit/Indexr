/****************** Copyright Notice *****************
 
This code is licensed under Microsoft Public License (Ms-PL). 
You are free to use, modify and distribute any portion of this code. 
The only requirement to do that, you need to keep the developer name, as provided below to recognize and encourage original work:

=======================================================
   
Designed and Implemented By:
Rasel Ahmmed
Software Engineer, I Like .NET
Twitter: http://twitter.com/raselbappi | Blog: http://springsolution.net | About Me: http://springsolution.net/about-me/
   
*******************************************************/

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

        public int Create(User user)
        {
            _iUserRepository.Insert(user);
            return Save();
        }

        #endregion

        #region Update Method

        public int Update(User user)
        {
            _iUserRepository.Update(user);
            return Save();
        }

        public int AddUserToRole(string userName, List<string> roleNames)
        {
            _iUserRepository.AssignRole(userName, roleNames);
            return Save();
        }

        //public int ChangeUserLogInStatus(User user, bool inout)
        //{
        //    User userDb = _iUserRepository.GetById(user.UserName);
        //    if (userDb != null)
        //    {
        //        userDb.IsLoggedIn = inout;
        //        _iUserRepository.Update(userDb);
        //        return Save();
        //    }
        //}

        #endregion

        #region Delete Method

        public int Delete(User user)
        {
            var deleteUser = GetUser(user.UserName);
            _iUserRepository.Delete(deleteUser);
            return Save();
        }

        #endregion

        #region Save By Commit

        public int Save()
        {
            return _iUnitOfWork.Commit();
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

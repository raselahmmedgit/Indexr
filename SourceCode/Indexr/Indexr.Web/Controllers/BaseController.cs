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
using System.Web;
using System.Web.Mvc;
using Indexr.Domain;

namespace Indexr.Web.Controllers
{
    public class BaseController : Controller
    {
        //protected virtual User CurrentLoggedInUser
        //{
        //    get
        //    {
        //        User user = WebHelper.CurrentSession.Content.LoggedInUser;
        //        if (user == null)
        //        {
        //            if (HttpContext.User != null && HttpContext.User.Identity != null && HttpContext.User.Identity.IsAuthenticated)
        //            {
        //                CookieHelper newCookieHelper = new CookieHelper();
        //                int userId = newCookieHelper.GetUserDataFromLoginCookie().ToInteger(true);
        //                if (userId > 0)
        //                {
        //                    IUserRepository userRepository = DependencyResolver.Current.GetService(typeof(IUserRepository)) as IUserRepository;
        //                    user = userRepository.Find(userId);
        //                    WebHelper.CurrentSession.Content.LoggedInUser = user;
        //                }
        //            }
        //            if (user == null)
        //            {
        //                user = new User();
        //            }
        //        }
        //        return user;
        //    }
        //}

        /// <summary>
        /// Log Error to log file
        /// </summary>
        /// <param name="ex">Exception</param>
        protected virtual void ErrorLog(Exception ex)
        {
            LoggerHelper.LoggerError(ex);
        }

        /// <summary>
        /// Log Information to log file
        /// </summary>
        /// <param name="logSummery">Log Summery</param>
        /// <param name="logDetails">Log Details</param>
        protected virtual void InformLog(string logSummery, string logDetails)
        {
            LoggerHelper.LoggerInform(logSummery, logDetails);
        }
    }
}

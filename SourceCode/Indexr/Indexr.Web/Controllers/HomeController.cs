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

using System.Web.Mvc;

namespace Indexr.Web.Controllers
{
    //[System.Web.Mvc.OutputCache(NoStore = true, Duration = 0, VaryByParam = "*")]
    public class HomeController : BaseController
    {
        #region Global Variable Declaration

        #endregion

        #region Constructor

        #endregion

        #region Action Methods

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        #endregion

        #region Utility Methods

        #endregion

    }
}

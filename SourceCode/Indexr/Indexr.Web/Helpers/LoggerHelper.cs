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
using System.IO;
using System.Web;

namespace Indexr.Web
{
    public static class LoggerHelper
    {
        public static void LoggerError()
        {
            System.Exception ex = System.Web.HttpContext.Current.Server.GetLastError();
            LoggerError(ex);
        }

        public static void LoggerError(Exception ex)
        {
            var currentContext = HttpContext.Current;

            string logSummery, logDetails, filePath = "No file path found.", url = "No url found to be reported.";

            if (currentContext != null)
            {
                filePath = currentContext.Request.FilePath;
                url = currentContext.Request.Url.AbsoluteUri;
            }

            logSummery = ex.Message;
            logDetails = ex.ToString();

            //-----------------------------------------------------

            string path = System.Web.HttpContext.Current.Server.MapPath("~/App_Data/log.txt");
            FileStream fStream = new FileStream(path, FileMode.Append, FileAccess.Write);
            BufferedStream bfs = new BufferedStream(fStream);
            StreamWriter sWriter = new StreamWriter(bfs);

            //insert a separator line
            sWriter.WriteLine("=================================================================================================");

            //create log for header
            sWriter.WriteLine(logSummery);
            sWriter.WriteLine("Log time:" + DateTime.Now);
            sWriter.WriteLine("URL: " + url);
            sWriter.WriteLine("File Path: " + filePath);

            //create log for body
            sWriter.WriteLine(logDetails);

            //insert a separator line
            sWriter.WriteLine("=================================================================================================");

            sWriter.Close();

        }
    }
}
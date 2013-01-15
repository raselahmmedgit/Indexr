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
using System.Xml.Linq;

namespace Indexr.Web
{
    public static class XElementExtensions
    {
        public static string GetStringValue(this XElement element, string field)
        {
            return (element.Element(field) == null) ? null : element.Element(field).Value;
        }

        public static DateTime? GetDateTimeValue(this XElement element, string field)
        {
            if (element.Element(field) == null)
                return null;

            DateTime result = new DateTime();

            var xElement = element.Element(field);
            if (xElement != null) DateTime.TryParse(xElement.Value, out result);

            return result;
        }

        public static int? GetIntValue(this XElement element, string field)
        {
            if (element.Element(field) == null)
                return null;

            int result = 0;

            var xElement = element.Element(field);
            if (xElement != null) int.TryParse(xElement.Value, out result);

            return result;
        }

        public static byte[] GetByteArrayValue(this XElement element, string field)
        {
            return null;
        }

    }
}
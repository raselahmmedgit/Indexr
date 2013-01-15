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
using System.Reflection;
using System.Linq.Expressions;

namespace Indexr.Web
{
    public static class ObjectHelper
    {
        public static string GetName<T>(Expression<Func<T>> memberExpression)
        {
            var expression = memberExpression.Body as MemberExpression;
            if (expression != null)
            {
                return expression.Member.Name;
            }
            else
            {
                return expression.ToString();
            }
        }

        public static void CopyPropertiesValueFromBaseType<TEntity>(TEntity baseSource, TEntity destinationChild)
        {
            Type type = typeof(TEntity);

            PropertyInfo[] myObjectFields = type.GetProperties(
                BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);

            foreach (PropertyInfo fi in myObjectFields)
            {
                fi.SetValue(destinationChild, fi.GetValue(baseSource, null), null);
            }
        }
    }
}
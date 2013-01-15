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

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Indexr.Domain
{
    public class Role
    {
        [Key]
        [Display(Name = "Role Name")]
        public virtual string RoleName { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

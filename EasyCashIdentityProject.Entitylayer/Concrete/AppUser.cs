using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.Entitylayer.Concrete
{
    public class AppUser:IdentityUser
    {
        public string Name { get; set; }
        public string MyProperty { get; set; }
    }
}

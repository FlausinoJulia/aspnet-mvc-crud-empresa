using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CrudEmpresa.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace CrudEmpresa.Database
{
    public class AuthDbContext : IdentityDbContext<ApplicationUser>
    {
        public AuthDbContext() : base("DbConnection", throwIfV1Schema: false)
        {
        }

        public static AuthDbContext Create()
        {
            return new AuthDbContext();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace Skill_Code_First_Entity.Models.Siniflar
{
    public class Context : DbContext
    {
        public DbSet<Yetenekler> Yeteneklers { get; set; }
    }
}
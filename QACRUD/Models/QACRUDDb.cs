using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace QACRUD.Models
{
    public class QACRUDDb : DbContext
    {
        public QACRUDDb() : base("name=DefaultConnection")
        {

        }

        public DbSet<Accounts> Accounts { get; set; }
    }
}
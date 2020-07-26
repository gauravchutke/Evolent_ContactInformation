using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ContactInformationModels
{
    internal class ContactInformationDBContext : DbContext
    {
        public ContactInformationDBContext() : base("ContactInformationDBConnection")
        {
            Database.SetInitializer<ContactInformationDBContext>(new CreateDatabaseIfNotExists<ContactInformationDBContext>());
        }

        public DbSet<ContactInformation> ContactsInformation { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

using dbTest.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbTest.Data
{
    public class DataContextEF : DbContext
    {

        // Weche Modelle wir suchen in DB.
        public DbSet<Computer> Computer { get; set; }
        // Erstellen Verbindung mit DB. Wenn die Verbundung schon früher eingestellt wurde, dann benutzen wir das. Wenn nein - erste Verbundung schaffen.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=localhost;Database=newTestDb;Trusted_Connection=true;TrustServerCertificate=true;",
                    // Wenn erste Verbindungsversuch nicht erfolgreich war, dann wir versuchen nochmal neue Verbindung zu stellen
                    options => options.EnableRetryOnFailure()) ;
            }
        }

        // Es wird vergleicht unsere Model mit Model auf dem Db. Erstellen die Model in Db
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // "Computer" - welche table brauchen wir, "FirstSchema" - Schema, wo diese Tabelle liegt.
            modelBuilder.HasDefaultSchema("FirstSchema");

            modelBuilder.Entity<Computer>()
                /*.ToTable("Computer", "FirstSchema");*/
                // Key für EF. Ob gibt KeyTable oder nichts.
                //.HasNoKey();
                .HasKey(c => c.ComputerId);
        }
    }
}

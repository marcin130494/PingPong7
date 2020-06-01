using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using PingPong7.Models;

namespace PingPong7.Data
{
    public class PingPong7Context: DbContext
    {
        public PingPong7Context(): base ("PingPong7Context")
        {

        }

        public DbSet<Zespol> Zespols { set; get; }
        public DbSet<Zawodnik> Zawodniks { get; set; }
        public DbSet<Tabela> Tabelas { get; set; }
        public DbSet<Terminarz> Terminarzs { get; set; }
        public DbSet<Account> Accounts { get; set; }

    }

}
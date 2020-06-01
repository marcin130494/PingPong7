using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PingPong7.Models
{
    public class Zespol
        {

        [Key]
        public string TeamName { get; set; }
        public string Klub{ get; set; }
        public string Ulica { get; set; }

        public string Telefon { get; set; }

        public string Email { get; set; }

        //public List<Zawodnik> Zawodniks { get;  set;}
        public IEnumerable<Zawodnik> Zawodniks { get; set;}

        //public List<Tabela> Tabelas { get; set;}

        public IEnumerable<Tabela> Tabelas { get; set; }

        //public List<Terminarz> Terminarzs { get; set;}
        public IEnumerable<Terminarz> Terminarzs { get; set; }

    }

    


    
}
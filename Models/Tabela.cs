using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PingPong7.Models
{
    public class Tabela
    {

        [Key]
        public int TableId { get; set; }
        
        public int Rozegrano { get; set; }

        public int Wygrane { get; set; }

        public int Zremisowane { get; set; }

        public int Przegrane { get; set; }

        public int Punkty { get; set; }
        public string TeamName { get; set; }
        public Zespol Zespol { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PingPong7.Models
{
    public class Terminarz
    {
        [Key]
        public int Id_terminarz { get; set; }

        public string TeamName { get; set; }
  
        public string Wynik { get; set;}

        public string TeamName1 { get; set; }
        public Zespol Zespol { get; set; }

    }
}
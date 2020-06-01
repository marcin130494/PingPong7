using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PingPong7.Models
{
    public class Zawodnik
    {
        [Key]
        public int PlayerkId { get; set; }
        
        public string Imie { get; set; }
        
        public string Nazwisko { get; set; }

        public int Wygrane { get; set; }

        public int Przegrane { get; set; }

        public string TeamName { get; set; }
        public Zespol Zespol { get; set; }

        public List<ListaRankingowa> ListaRankingowas { get; set; }

    }
}
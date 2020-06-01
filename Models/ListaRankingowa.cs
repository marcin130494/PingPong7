using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PingPong7.Models
{
    public class ListaRankingowa
    {
        [Key]
        public int ListarankingowaId { get; set; }

        public int Punkty { get; set; }

        public int PlayerkId { get; set; }

        public Zawodnik Zawodnik{ get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PingPong7.Models;

namespace PingPong7.ViewModel
{
    public class Protokol
    {
        public IEnumerable<Zawodnik> Zawodniks { get; set; }
        public IEnumerable<Zespol> Zespols { get; set; }
        public IEnumerable<Terminarz> Terminarzs{ get; set; }
        public IEnumerable<Tabela> Tabelas { get; set; }

    }
}
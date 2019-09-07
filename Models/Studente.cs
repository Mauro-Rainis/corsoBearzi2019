using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorsoBearziWebAppMvc.Models
{
    public class Studente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public override string ToString()
        {
            return Cognome + " " + Nome;
        }

    }
}

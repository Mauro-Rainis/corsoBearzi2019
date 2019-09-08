using System.Collections.Generic;

namespace CorsoBearziWebAppMvc.Models
{
    public partial class Corso
    {
        public Corso()
        {
            Studenti = new HashSet<Studente>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public int? Anno { get; set; }

        public virtual ICollection<Studente> Studenti { get; set; }
    }
}

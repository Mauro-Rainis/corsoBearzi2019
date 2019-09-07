using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorsoBearziWebAppMvc.Models;

namespace CorsoBearziWebAppMvc.Services
{
    public class StudentiService : IStudentiService
    {
        public List<Studente> GetAll()
        {
            var lista = new List<Studente>
            {
                new Studente() { Nome = "Valentino", Cognome = "Rossi", Id = 1 },
                new Studente() { Nome = "Marco", Cognome = "Pantani", Id = 2 },
                new Studente() { Nome = "Alberto", Cognome = "Tomba", Id = 3 },
                new Studente() { Nome = "Carolina", Cognome = "Kostner", Id = 4 },
                new Studente() { Nome = "Valentina", Cognome = "Vezzali", Id = 5 },
                new Studente() { Nome = "Elena", Cognome = "Cecchini", Id = 6 },
                new Studente() { Nome = "Manuela", Cognome = "Di Centa", Id = 7 }
            };
            return lista;
        }
    }
}

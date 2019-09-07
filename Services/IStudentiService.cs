using CorsoBearziWebAppMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorsoBearziWebAppMvc.Services
{
    public interface IStudentiService
    {
        List<Studente> GetAll();
    }
}

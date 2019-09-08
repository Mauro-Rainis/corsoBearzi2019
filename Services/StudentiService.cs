using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorsoBearziWebAppMvc.EFCore;
using CorsoBearziWebAppMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace CorsoBearziWebAppMvc.Services
{
    public class StudentiService : IStudentiService
    {
        readonly CorsobearziContext ctx;
        public StudentiService(CorsobearziContext ctx)
        {
            this.ctx = ctx;
        }
        public List<Studente> GetAll()
        {
            return ctx.Studenti
                .Include(c => c.Corso)
                .ToList();
        }
    }
}

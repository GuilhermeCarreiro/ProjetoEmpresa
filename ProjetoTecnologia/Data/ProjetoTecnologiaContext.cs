using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoTecnologia.Models;

namespace ProjetoTecnologia.Data
{
    public class ProjetoTecnologiaContext : DbContext
    {
        public ProjetoTecnologiaContext (DbContextOptions<ProjetoTecnologiaContext> options)
            : base(options)
        {
        }

        public DbSet<ProjetoTecnologia.Models.Empresa> Empresa { get; set; }

        public DbSet<ProjetoTecnologia.Models.Usuario> Usuario { get; set; }
    }
}

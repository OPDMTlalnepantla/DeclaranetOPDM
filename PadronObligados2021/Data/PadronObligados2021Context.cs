using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PadronObligados2021.Models;

namespace PadronObligados2021.Data
{
    public class PadronObligados2021Context : DbContext
    {
        public PadronObligados2021Context (DbContextOptions<PadronObligados2021Context> options)
            : base(options)
        {
        }

        public DbSet<PadronObligados2021.Models.ServidorPublico> ServidorPublico { get; set; }
        public DbSet<PadronObligados2021.Models.EntidadFederativa> EntidadFederativa { get; set; }
        public DbSet<PadronObligados2021.Models.FuncionPrincipal> FuncionPrincipal { get; set; }
        public DbSet<PadronObligados2021.Models.Municipio> Municipio { get; set; }
        public DbSet<PadronObligados2021.Models.NivelEscolar> NivelEscolar { get; set; }
        public DbSet<PadronObligados2021.Models.RegimenMatrimonial> RegimenMatrimonial { get; set; }
        public DbSet<PadronObligados2021.Models.Sector> Sector { get; set; }
        public DbSet<PadronObligados2021.Models.SituacionPersonal> SituacionPersonal { get; set; }


    }
}

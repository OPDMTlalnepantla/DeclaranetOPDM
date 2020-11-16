using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PadronObligados2021.Models
{
    [Table("Municipios")]
    public class Municipio
    {
        public Municipio()
        {
            Servidores = new ObservableCollection<ServidorPublico>();
        }
        public int MunicipioId { get; set; }//                         1 Identificador único del registro, número consecutivo
        [StringLength(100)]
        public string Nombre { get; set; }//                                2 Nombre completo
        public int EntidadFederativaId { get; set; }//                         1 Identificador único del registro, número consecutivo
        public virtual ObservableCollection<ServidorPublico> Servidores { get; set; }
    }
}

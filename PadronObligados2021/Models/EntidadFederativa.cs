using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PadronObligados2021.Models
{
    [Table("EntidadesFederativas")]
    public class EntidadFederativa
    {
        public EntidadFederativa()
        {
            Municipios = new ObservableCollection<Municipio>();
        }
        public int EntidadFederativaId { get; set; }//                         1 Identificador único del registro, número consecutivo
        [StringLength(100)]
        public string Nombre { get; set; }//                                2 Nombre completo
        public virtual ObservableCollection<Municipio> Municipios { get; set; }
    }
}

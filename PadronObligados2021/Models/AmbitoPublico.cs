using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PadronObligados2021.Models
{
    [Table("AmbitosPublicos")]
    public class AmbitoPublico
    {
        public AmbitoPublico()
        {
            Servidores = new ObservableCollection<ServidorPublico>();
        }
        [StringLength(17)]
        public string AmbitoPublicoId { get; set; }//                         1 Identificador único del registro, número consecutivo
        [StringLength(17)]
        public string Nombre { get; set; }//                                2 Nombre completo
        public virtual ObservableCollection<ServidorPublico> Servidores { get; set; }
    }
}

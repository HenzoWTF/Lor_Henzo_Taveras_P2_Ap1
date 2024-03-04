using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Accesorios
    {
        [Key]
        public int AccesoriosId { get; set; }
        public string Descripcion { get; set; }
    }
}

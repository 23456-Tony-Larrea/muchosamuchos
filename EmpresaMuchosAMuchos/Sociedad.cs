using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmpresaMuchosAMuchos
{
    public class Empresa {
        [Key]
        public int EmpresaId { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public List<EmpresaClientes> EmpresaClientes{ get; set; }
    }

}
    

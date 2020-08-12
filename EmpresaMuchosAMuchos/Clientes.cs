using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmpresaMuchosAMuchos
{
    public class Clientes
    {
        [Key]
        public int ClientesId { get; set; }
        public string Nombre { get; set; }  
        public string Apellido { get; set; }
        public string Cedula { get; set; }

        public List<EmpresaClientes> EmpresaClientes { get; set; }
    }

}
    

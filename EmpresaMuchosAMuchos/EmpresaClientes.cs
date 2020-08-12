using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpresaMuchosAMuchos
{
    public class EmpresaClientes { 
    [Key]
     public int EmpresaClientesId { get; set; }
     [ForeignKey(name:"Empresa")]
        public int EmpresaId { get; set; }
        public Empresa Empresa { get; set; }
        [ForeignKey(name: "Clientes")]
        public int ClientesId { get; set; }
        public Clientes Clientes { get; set; }
    }

}
    

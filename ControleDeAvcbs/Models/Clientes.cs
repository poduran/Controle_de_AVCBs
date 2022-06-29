using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeAvcbs.Models
{
    [Table("CLIENTES")]
    public class Clientes
    {
        [Key]
        public int ID { get; set; }
        public string NomeEmpresa { get; set; }
        public string NomeCliente { get; set; }
        public string Contato { get; set; }
        public DateTime DataExpiracao { get; set; }
        public string NumeroAVCB { get; set; }
        public string Origem { get; set; }

    }
}

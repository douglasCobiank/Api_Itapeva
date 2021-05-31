using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Itapeva.Servico.DTO.ConsultarDadosVendedo
{
    public class Identity
    {
        public int ID { get; set; }
        public int ContactID { get; set; }
        public int IdentityType { get; set; }
        public string IdentityNumber { get; set; }
        public bool IsValid { get; set; }
        public bool IsDeleted { get; set; }
    }
}

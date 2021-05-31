using Itapeva.Servico.DTO.ConsultarDadosVendedo;
using System.Collections.Generic;

namespace PagouFacil_Itapeva.Controllers.Models
{
    public class OutConsultarDadosDevedor
    {
        public bool Success { get; set; }
        public Contact Contact { get; set; }
        public List<CustomerDebts> CustomerDebts { get; set; }
    }
}

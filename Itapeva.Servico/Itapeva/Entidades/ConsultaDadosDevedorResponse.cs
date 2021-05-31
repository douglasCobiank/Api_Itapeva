using Itapeva.Servico.DTO.ConsultarDadosVendedo;
using System.Collections.Generic;

namespace Itapeva.Servico.Itapeva.Entidades
{
    public class ConsultaDadosDevedorResponse
    {
        public bool Success { get; set; }
        public Contact Contact { get; set; }
        public List<CustomerDebts> CustomerDebts { get; set; }
    }
}

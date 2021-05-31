using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Itapeva.Servico.DTO.ConsultarDadosVendedo
{
    public class CustomerDebts
    {
        public List<Debts> Debts { get; set; }
        public List<int> DebtIDs { get; set; }
        public List<NegotiationOffers> NegotiationOffers { get; set; }
        public List<PromiseDateSchedules> PromiseDateSchedules { get; set; }
    }
}

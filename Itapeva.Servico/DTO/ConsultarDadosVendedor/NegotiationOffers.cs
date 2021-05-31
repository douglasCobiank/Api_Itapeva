using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Itapeva.Servico.DTO.ConsultarDadosVendedo
{
    public class NegotiationOffers
    {
        public int NegotiationOfferID { get; set; }
        public decimal DiscountRate { get; set; }
        public decimal TotalInstallments { get; set; }
        public decimal ArrangementPrincipal { get; set; }
        public decimal ArrangementFees { get; set; }
        public decimal ArrangementCosts { get; set; }
        public decimal ArrangementInterests { get; set; }
        public decimal ArrangementCorrections { get; set; }
        public decimal ArrangementAmount { get; set; }
        public decimal ArrangementDiscount { get; set; }
        public decimal DownPaymentAmount { get; set; }
        public decimal InstallmentAmount { get; set; }
    }
}

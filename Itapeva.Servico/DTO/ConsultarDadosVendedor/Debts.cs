using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Itapeva.Servico.DTO.ConsultarDadosVendedo
{
    public class Debts
    {
        public int DebtID { get; set; }
        public string OriginalCreditor { get; set; }
        public string BusinessUnitAlias { get; set; }
        public string BusinessUnitName { get; set; }
        public string DebtNumber { get; set; }
        public string ProductName { get; set; }
        public string ProductType { get; set; }
        public string RoleType { get; set; }
        public DateTime FirstDefaultDate { get; set; }
        public decimal DebtPrincipal { get; set; }
        public decimal DebtCorrection { get; set; }
        public decimal DebtInterests { get; set; }
        public decimal DebtFees { get; set; }
        public decimal DebtCosts { get; set; }
        public decimal DebtTotalBalance { get; set; }
        public decimal InterestRate { get; set; }
        public DateTime BalanceDate { get; set; }
        public DateTime NegotiationDate { get; set; }
        public bool AllowOpenNegotiation { get; set; }
        public List<NegotiationOffers> NegotiationOffers { get; set; }
    }
}

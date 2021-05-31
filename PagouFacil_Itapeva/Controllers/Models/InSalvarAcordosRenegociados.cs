using System;
using System.Collections.Generic;

namespace PagouFacil_Itapeva.Controllers.Models
{
    public class InSalvarAcordosRenegociados
    {
        public int ArrangementID { get; set; }
        public List<int> DebtIDS { get; set; }
        public DateTime TotalInstallments { get; set; }
        public decimal DownPaymentAmount { get; set; }
        public decimal InstallmentAmount { get; set; }
        public DateTime FirstInstallmentDate { get; set; }
        public int PrimaryPhoneNumber { get; set; }
        public string PrimaryEMailAddress { get; set; }
        public bool GenerateBillePdfContent { get; set; }
    }
}

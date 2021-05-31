using System;
using System.Collections.Generic;

namespace Itapeva.Servico.Itapeva.Entidades
{
    public class RenegociarAcordoInput
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

using System;
using System.Collections.Generic;

namespace Itapeva.Servico.Itapeva.Entidades
{
    public class SalvarAcordoInput
    {
        public string IdentityNumber { get; set; }
        public List<int> DebtIDS { get; set; }
        public int TotalInstallments { get; set; }
        public int DownPaymentAmount { get; set; }
        public int InstallmentAmount { get; set; }
        public DateTime FirstInstallmentDate { get; set; }
        public string PrimaryPhoneNumber { get; set; }
        public string PrimaryEMailAddress { get; set; }
        public bool GenerateBilletPDFContent { get; set; }
    }
}

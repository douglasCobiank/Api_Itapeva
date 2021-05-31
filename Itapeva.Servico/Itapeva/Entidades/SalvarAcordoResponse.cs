using System;

namespace Itapeva.Servico.Itapeva.Entidades
{
    public class SalvarAcordoResponse
    {
        public bool Success { get; set; }
        public int ArrangementID { get; set; }
        public decimal ArrangementAmount { get; set; }
        public string BilletLine { get; set; }
        public string BilletBarCode { get; set; }
        public decimal RemitIdentifier { get; set; }
        public decimal RemitAmount { get; set; }
        public DateTime RemitDueDate { get; set; }
        public DateTime DocumentDate { get; set; }
        public string DocumentNumber { get; set; }
        public string PaymentLocation { get; set; }
        public string Beneficiary { get; set; }
        public string BeneficiaryAddress { get; set; }
        public string DocumentType { get; set; }
        public DateTime ProcessingDate { get; set; }
        public string BilletServiceNumber { get; set; }
        public string BilletServiceCode { get; set; }
        public string BilletPdfContent { get; set; }
    }
}

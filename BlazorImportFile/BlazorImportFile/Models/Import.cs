namespace BlazorImportFile.Models
{
    public class Import
    {
        public int Id { get; set; } 
        public string InvoiceId { get; set; }
        public float Price { get; set; }
        public string CurrencyCode { get; set; }
        public string Date { get; set; }

        public string Status { get; set; }

    }

   
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreERPProj.Models.Companies
{
    public class ExchangeRate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public ulong ExchaRateID { get; set; } //ExchangeRateID
        public ulong CurrID { get; set; } //CurrencyID
        [Column(TypeName = "decimal(25,12)")]
        public decimal Rate1 { get; set; } //Rate1
        [Column(TypeName = "decimal(25,12)")]
        public decimal Rate2 { get; set; } //Rate2
        //----------------NotMapped-------------------------
        [NotMapped]
        public string? CurrName { get; set; } //CurrencyName
        //----------------ForeignKey-------------------------
        [ForeignKey(nameof (CurrID))]
        public required Currency Currency { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreERPProj.Models.Companies
{
    public class Currency
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public ulong CurrID { get; set; } //CurrencyID
        public required string Code {get;set;} //CurrencyCode
        public required string Name { get; set; } //CurrencyName
        public string? Description { get; set; } //Description
        public string? Symbol { get; set; } //Symbol
        //----------------NotMapped-------------------------
        [NotMapped]
        public string? Title { get; set; }
        [NotMapped]
        public string? Value { get; set; }
        //----------------ForeignKey-------------------------
    }
}

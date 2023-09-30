using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreERPProj.Models.Companies
{
    public class Company
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public ulong CompID { get; set; } //CompanyID
        public required string Code {get;set;} //CompanyCode
        public required string Name { get; set; } //CompanyName
        public string? Logo { get; set; } //CompanyLogo
        public string? Address { get; set; } //Address
        public string? Location { get; set; } //Location
        public ulong SCID { get; set; } //SystemCurrency
        public ulong LCID { get; set; } //LocalCurrency
        //----------------NotMapped-------------------------
        [NotMapped]
        public string? SCName { get; set; }
        [NotMapped]
        public string? LCName { get; set; }
    }
}

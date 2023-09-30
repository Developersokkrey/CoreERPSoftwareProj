using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using CoreERPProj.Models.Companies;

namespace CoreERPProj.Models.BusinessPartners
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public ulong CustomerID { get; set; } //CustomerID
        public ulong CompID { get; set; } //CompanyId
        public required string Code { get; set; } //CustomerCode
        public required string Name1 { get; set; } //CustomerName1
        public string? Name2 { get; set; } //CustomerName2
        public string? Phone { get; set; } //CustomerPhone
        public string? Address { get; set; } //Address
        public string? Location { get; set; } //Location
        //----------------ForeignKey-------------------------
        [ForeignKey(nameof(CompID))]
        public required Company Company { get; set; }
    }
}

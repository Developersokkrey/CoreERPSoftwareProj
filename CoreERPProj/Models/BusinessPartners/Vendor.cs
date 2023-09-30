using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using CoreERPProj.Models.Companies;

namespace CoreERPProj.Models.BusinessPartner
{
    public class Vendor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public ulong VendorID { get; set; } //VendorId
        public ulong CompID { get; set; } //CompanyId
        public required string Code { get; set; } //VendorCode
        public required string Name1 { get; set; } //VendorName1
        public string? Name2 { get; set; } //VendorName2
        public string? PhoneNumber { get; set; } //PhoneNumber
        public string? Address { get; set; } //Address
        public string? Location { get; set; } //Location
        //----------------ForeignKey-------------------------
        [ForeignKey(nameof(CompID))]
        public required Company Company { get; set; }
    }
}

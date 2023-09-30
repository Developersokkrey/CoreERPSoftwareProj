using CoreERPProj.Models.Companies;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreERPProj.Models.Branches
{
    public class Branch
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public ulong BranchID { get; set; } //BranchID
        public required string Code { get; set; } //BranchCode
        public required string Name { get; set; } //BranchName
        public string? Address { get; set; } //Address
        public string? Location { get; set; } //Location
        public ulong CompID { get; set; } //CompanyID
        //----------------ForeignKey-------------------------
        [ForeignKey(nameof(CompID))]
        public required Company Company { get; set; }
    }
}

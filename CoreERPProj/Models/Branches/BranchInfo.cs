using CoreERPProj.Models.Branches;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreERPProj.Models.Branches
{
    public class BranchInfor 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public ulong BranInforID { get; set; } //BranchInforID
        public required string Code { get; set; } //BranchInforCode
        public required string Name { get; set; } //BranchInforName
        public string? Logo { get; set; } //BranchInforLogo
        public ulong BranchID { get; set; } //BranchID
        public string? PhoneNumber1 { get; set; } //PhoneNumber1
        public string? PhoneNumber2 { get; set; } //PhoneNumber2
        public string? Description1 { get; set; } //Description1 
        public string? Description2 { get; set; } //Description2
        public string? Address { get; set; } //Address
        public string? Location { get; set; } //Location
        //----------------ForeignKey-------------------------
        [ForeignKey(nameof(BranchID))]
        public required Branch Branch { get; set; }
    }
}

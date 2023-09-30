using CoreERPProj.Models.Companies;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CoreERPProj.Models.UserAccounts
{
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public ulong DeparmentID { get; set; } //DeparmentID
        public required string Code {get;set;} //DepartmentCode
        public required string Name { get; set; } //DepartmentName
        public ulong CompID { get; set; } //CompanyID
        public bool Enable {get; set;} //Enable
        //----------------ForeignKey-------------------------
        [ForeignKey(nameof(CompID))]
        public required Company Company { get; set; }
    }      
}
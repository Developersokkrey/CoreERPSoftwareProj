using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CoreERPProj.Models.Companies;
using CoreERPProj.Models.Branches;
using static CoreERPProj.Model.EnumService.EnumServices;
using CoreERPProj.Models.UsersPrivilege;

namespace CoreERPProj.Models.UserAccounts
{
    public class UserAccount
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public ulong UserAccountID { get; set; } //UserAccountID
        public required string Code {get; set;} // EmployeeCode
        public required string Name {get;set;} //EmployeeName
        public required string Username { get; set; } //Username
        public string? PasswordHash { get; set; } //PasswordHash
        public ulong RuleID { get; set; } //RuleID
        public ulong CompID { get; set; } //CompanyID
        public ulong BranchID { get; set; } //BranchID
        public Genders Gender{ get; set; } //Gender
        public UserStatus Status { get; set; } //Status
        public ulong DepartmentID { get;set; } //DepartmentID
        //----------------NotMapped-------------------------
        [NotMapped]
        public string? Password { get; set; }
        [NotMapped]
        public string? ConfirmPassword { get; set; }
        //----------------ForeignKey-------------------------
        [ForeignKey(nameof(RuleID))]
        public required Rule Rule { get; set; }
        [ForeignKey(nameof(CompID))]
        public required Company Company { get; set; }
        [ForeignKey(nameof(BranchID))]
        public required Branch Branch { get; set; }
        [ForeignKey(nameof(DepartmentID))]
        public required Department Department { get; set; }

    }      
}

using CoreERPProj.Models.UserAccounts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreERPProj.Models.UsersPrivilege
{
    public class UsersPrivilege
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public ulong PrivilegeID { get; set; } //PrivilegeID
        public ulong UserAccountID { get; set; } //UserID
        public ulong RulePrivID { get; set; } //RulePrivilegeID
        public ulong FunctID { get; set; } //FunctionID
        public ulong DepartmentID { get;set;}   //Department
        public bool Enable { get; set; } = false; //Enable
        //----------------ForeignKey-------------------------
        [ForeignKey(nameof(UserAccountID))]
        public required UserAccount UserAccount { get; set; }
        [ForeignKey(nameof(RulePrivID))]
        public required RulePrivilege RulePrivilege { get; set; }
        [ForeignKey(nameof(FunctID))]
        public required Function Function { get; set; }
        [ForeignKey(nameof(DepartmentID))]
        public required Department Department { get; set; }

    }
}

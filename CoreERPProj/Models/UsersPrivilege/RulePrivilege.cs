using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreERPProj.Models.UsersPrivilege
{
    public class RulePrivilege
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public ulong RulePrivID { get; set; } //RulePrivilegeId
        public ulong RuleID { get; set; } //RuleID
        public ulong FunctID { get; set; } //FunctionID
        public bool Enable { get; set; } = true; //Enable
        //----------------ForeignKey-------------------------
        [ForeignKey(nameof (RuleID))]
        public required Rule Rule { get; set; }
        [ForeignKey(nameof (FunctID))]
        public required Function Function { get; set; }
    }
}

using CoreERPProj.Models.Companies;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreERPProj.Models.UsersPrivilege
{
    public class Rule
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public ulong RuleID { get; set; } //RuleID
        public required string Name { get; set; } //RuleName
        public bool Enable { get; set; } = true; //Enable
        public ulong CompID { get; set; } //CompanyID
        //----------------ForeignKey-------------------------
        [ForeignKey(nameof(CompID))]
        public required Company Company { get; set; }
    }
}

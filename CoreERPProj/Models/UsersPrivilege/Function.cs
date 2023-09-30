using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreERPProj.Models.UsersPrivilege
{
    public class Function
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public ulong FunctID { get; set; } //FunctionID
        public required string Code { get; set; } //FunctionCode
        public required string Name { get; set; } //FunctionName   
    }
}

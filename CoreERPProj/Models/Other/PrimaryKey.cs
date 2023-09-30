using System.ComponentModel.DataAnnotations;
using static CoreERPProj.Model.EnumService.EnumServices;

namespace CoreERPProj.Models.Other
{
    public class PrimaryKey
    {
        [Key]
        public int ID { get; set; }
        public TableName TableName { get; set; }
        public string? KeyNumber { get; set; }
    }
}

namespace CoreERPProj.Models.ServiceClass.Branches
{
    public class BranchVeiwModel
    {
        public ulong BranID { get; set; }
        public  string? Code { get; set; }
        public  string? Name { get; set; }
        public string? Address { get; set; }
        public string? Location { get; set; }
        public string? CompName { get; set; }
        public ulong CompID { get; set; }
    }
}

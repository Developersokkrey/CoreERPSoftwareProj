namespace CoreERPProj.Models.UserAccounts
{
    public class UserMap
    {
        public string? Username { get; set; }
        public ulong UserAccountID { get; set; }
        public string[]? Access { get; set; }
        public string? Token { get; set; }   
        public string? Avatar { get; set; }
    }
}

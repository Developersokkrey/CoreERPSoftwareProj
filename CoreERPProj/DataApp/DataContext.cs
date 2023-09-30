using CoreERPProj.Models.Branches;
using CoreERPProj.Models.BusinessPartner;
using CoreERPProj.Models.BusinessPartners;
using CoreERPProj.Models.Companies;
using CoreERPProj.Models.UserAccounts;
using CoreERPProj.Models.UsersPrivilege;
using Microsoft.EntityFrameworkCore;

namespace CoreERPProj.DataApp
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opitons) : base(opitons) {  }

        public DbSet<Branch> BRANCH { get; set; }
        public DbSet<UserAccount> UERACC { get; set; }
        public DbSet<Currency> CUREER { get; set; }
        public DbSet<Company> COMPAN { get; set; }
        public DbSet<BranchInfor> BINFOR { get; set; }
        public DbSet<ExchangeRate> EXRATE { get; set; }
        public DbSet<Rule> MARULE { get; set; }
        public DbSet<RulePrivilege> RUPRIV { get; set; }
        public DbSet<Function> FUNCTI { get; set; }
        public DbSet<UsersPrivilege> UPRIVI { get; set; }
        public DbSet<Customer> CUSMER { get; set; }
        public DbSet<Vendor> VENDOR { get; set; }
        public DbSet<Department> DEPMENT { get; set; }
    }
}

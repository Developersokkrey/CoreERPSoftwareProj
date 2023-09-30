namespace CoreERPProj.Model.EnumService
{
    public class EnumServices
    {
        public enum UserRules
        {
            SuperAdmin=1,            
            Manager=2,
            Admin=3,
            Supervisor=4,
            Staff=5,
        }
        public enum UserStatus
        {
            None=0,  
            Active=1,
            Inactive=2,
            Pending=3,
            Close=4
        }
        public enum Genders
        {
            None=0,
            Male=1,
            Female=2,
            Other=3
        }
        public enum TableName
        {
            OUSR=1,
            OCURE=2,
            COMP=3,
            BRAN=4,
            BRINFO = 5,
            EXRATE = 6,
            ROLES = 7,
            ROLEPRIVI = 8,
            FUNCTI = 9,
            USERPRIVI = 10,
            VENDOR = 11,
            CUSMER = 12,
            DEPMENT = 13,
        }

    }
}

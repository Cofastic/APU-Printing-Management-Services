using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Admin_Form_OOP_Assignement
{
    public class LoginDetails
    {
        private string profilename;
        private string role;
        private string phonenumber;
        private string id;

        public LoginDetails(string Profilename, string Role, string Phonenumber, string ID)
        {
            profilename = Profilename;
            role = Role;
            phonenumber = Phonenumber;
            id = ID;
        }
        public string Profilename
        {
            get { return profilename; }
        }
        public string Role
        {
            get { return role; }
        }
        public string Phonenumber
        {
            get { return phonenumber; }
        }
        public string ID
        {
            get { return id; }
        }
    }
}

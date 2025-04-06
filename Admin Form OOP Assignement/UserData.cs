using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Form_OOP_Assignement
{
    public class UserData
    {
        private string id;
        private string username;
        private string password;
        private string profile_name;
        private string role;
        private string phonenumber;
        public UserData(string ID, string Username, string Password, string Profile_name, string Role, string Phonenumber)
        {
            id = ID;
            username = Username;
            password = Password;
            profile_name = Profile_name;
            role = Role;
            phonenumber = Phonenumber;
        }
        public string ID
        {
            get { return id; }
        }
        public string Username
        {
            get { return username; }
        }

        public string Password
        {
            get { return password; }
        }

        public string Profile_name
        {
            get { return profile_name; }
        }
        public string Role
        {
            get { return role; }
        }
        public string Phonenumber
        {
            get { return phonenumber; }
        }
    }
}

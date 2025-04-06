using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Form_OOP_Assignement
{
    public class UserData
    {
        public string username;
        public string profile_name;
        public string password;
        private string role;
        private string phonenumber;
    }

    public UserData(string Username, string Profile_Name, string Password, string Role, string PhoneNumber)
    {
        username = Username;
        profile_name = Profile_Name;
        password = Password;
        role = Role;
        phonenumber = PhoneNumber;
    }
    public string Username
    {
        get { return username;}
    }
    public string Profile_Name
    {
        get { return profile_name;}
    }
    public string Password
    {
        get { return password;}
    }
    public string Role
    {
        get { return role;}
    }
    public string PhoneNumber
    {
        get { return phonenumber; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Admin_Form_OOP_Assignement
{
public class userLogin
    {
        private string profilename;
        private string job;
        private string phonenumber;

        public userLogin (string Profilename, string Job, string Phonenumber)
        {
            profilename = Profilename;
            job = Job;
            phonenumber = Phonenumber;
        }
        public string Profilename
        {
            get { return profilename; }
        }
        public string Job
        {
            get { return job; }
        }
        public string Phonenumber
        {
            get { return phonenumber; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Form_OOP_Assignement
{
    public class Request
    {
        private string _type;
        private int _qty;
        private double _price;
        private double _discount;
        public Request() 
        {
            _type = string.Empty;
            _qty = 0;   
            _price = 0;
            _discount = 0;
        }

        public string type
        {
            get { return _type; }
            set { _type = value; }
        }

        public int quantity
        {
            get { return _qty; }
            set { _qty = value; }
        }

        public double price
        {
            get { return _price; }  
            set { _price = value; }
        }

        public double discount
        {
            get { return _discount; }
            set { _discount = value; }
        }
    }
}

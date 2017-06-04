using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyanSizer_CE02
{
    class Customer
    {

        //fields
        private CheckingAccount account;
        private string customerName;


        //Properties
        public CheckingAccount Account
        {
            get { return this.account; }

        }


        //Constructors
        public Customer(string customerName)
        {
            this.customerName = customerName;

        }

    }
}

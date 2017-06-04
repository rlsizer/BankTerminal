using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyanSizer_CE02
{
    class CheckingAccount
    {


        //fields
        private decimal accountBal;
        private int accountNum;


        //Properties
        public decimal AccountBal
        {
            get { return this.accountBal; }

        }


        //Constructors
        public CheckingAccount(decimal accountBal, int accountNum)
        {
            this.accountBal = accountBal;
            this.accountNum = accountNum;
        }


    }
}

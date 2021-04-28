using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreReceiptApp
{
    class Receipt
    {
        private int _Id;
        public string Name;
        public string Product;
        public decimal Price;
        private decimal _Balance;
        private bool _IdAlreadySet; 
       /* public Receipt()
        {
            System.Windows.Forms.MessageBox.Show("Object is Creadted");
        }
        ~Receipt()
        {
            System.Windows.Forms.MessageBox.Show("Object is Destroyed");
        }*/
        public int Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_IdAlreadySet)
                    throw new ApplicationException("Id cannot be set more thann once");
                _Id = value;
                _IdAlreadySet = true;
            }
        }

        public decimal Balance
        {
            get
            {
                return _Balance;
            }
         //   set
           // {
             //   _Balance = value;
            //}
        }
        public void pay (decimal Paid)
        {
            if (Paid < Price )
            {
                throw new ApplicationException("The amount you paid is not enough");
            }
            else this._Balance = Paid - Price;
        }
    }
}

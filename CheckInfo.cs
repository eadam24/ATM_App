using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App
{
    internal class CheckInfo
    {
        double amount;
        int pin;
        string amount_error;
        string pin_error;

        public CheckInfo()
        {
            amount = 0;
            pin = 0;
        }

        public void AddAmount(double amount)
        {
            this.amount = amount;
        }

        public void AddPin(int pin)
        {
            this.pin = pin;
        }

    
    }
}

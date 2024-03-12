using System.Diagnostics.Eventing.Reader;

namespace ATM_App
{
    public partial class Form1 : Form
    {

        private bool _error = false;
        private string _msg = "";
        private string _msg2 = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void withdraw_button_Click(object sender, EventArgs e)
        {
         
            _error = false;
            amount_error.SetError(user_amount, "");
            pin_error.SetError(user_pin, "");



            if (user_amount.Text == String.Empty)
            {
                amount_error.SetError(user_amount, "Empty amount!");
                _error = true;
            }
            else if (!IsDigitsOnly(user_amount.Text)) 
            { 
                pin_error.SetError(user_amount, "Amount has text!");
                _error = true;
            }
            

            if (user_pin.Text == String.Empty)
            {

                pin_error.SetError(user_pin, "Empty pin!");
                _error = true;
            }
            else if (user_pin.Text.Length != 4)
            {
                pin_error.SetError(user_pin, "PIN should be 4 numbers!");
                _error = true;
            }
            else if (!IsDigitsOnly(user_pin.Text))
            {
                pin_error.SetError(user_pin, "Pin has text!");
                _error = true;
            }



            if (_error == false)
            {
                CheckAmount();
                CheckPin();
                MessageBox.Show(_msg + "\n" + _msg2);
            }

        }

        private void CheckPin()
        {
            if (!_error)
            {
                if (user_pin.Text.Contains("1234"))
                {
                    _msg = "Correct Pin!";
                }
                else
                {
                    _msg = "Incorrect Pin!";   
                }
            }
        }

        private void CheckAmount()
        {
            if (!_error)
            {
                if (Convert.ToInt32(user_amount.Text) % 10 == 0 && Convert.ToInt32(user_amount.Text) <= 1000 && _msg.Contains("Correct Pin!"))
                {
                    _msg2 = $"Okay withdrawing {user_amount.Text}$ from your account!";
                }
                else if (Convert.ToInt32(user_amount.Text) > 1000)
                {
                    _msg2 = "Limit Reached!";
                }
                else
                {
                    _msg2 = "Wrong amount!";
                }
            }
        }

        private static bool IsDigitsOnly(string str)
        {
            return str.All(c => c >= '0' && c <= '9');
        }
    }
}
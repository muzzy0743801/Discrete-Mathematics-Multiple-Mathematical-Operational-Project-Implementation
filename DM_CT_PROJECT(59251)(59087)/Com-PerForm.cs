using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DM_CT_PROJECT_59251__59087_
{
    public partial class Com_PerForm : Form
    {
        public Com_PerForm()
        {
            InitializeComponent();
        }
        
        private void Btn_back_Click(object sender, EventArgs e)
        {
            SelectionForm SF = new SelectionForm();
            SF.Show();
            this.Hide();
        }

        private void txt_nValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void Com_PerForm_Load(object sender, EventArgs e)
        {

        }
        public long Factorial(long a)
        {
            long result = 1;
            for (long i = a; i >= 1; i--)
            {
                result *= i;
            }
            return result;
        }
        public long nCr(long n, long r)
        {
            long result = 1;
            try
            {
                result = Factorial(n) / (Factorial(r) * Factorial(n - r));
            }
            catch (Exception) { }
                return result;
        }
        public long nPr(long n, long r)
        {
            long result = 1;
            try
            {
                result = Factorial(n) / Factorial(n - r);
            }
            catch (Exception) { }
            return result;
        }
        private void btn_Result_Click(object sender, EventArgs e)
        {

            if (SelectionForm.identify == "Com")
            {
                long n = Convert.ToInt64(txt_nValue.Text);
                long r = Convert.ToInt64(txt_rValue.Text);
                long result = nCr(n, r);
                if (result < 0)
                {
                    MessageBox.Show("Value too Long to Display, Sorry");
                    txt_ResultValue.Text = "Null";
                }
                else
                    txt_ResultValue.Text = result.ToString();
            }
            else if (SelectionForm.identify == "Fac")
            {
                long f = Convert.ToInt64(txtfac.Text);
                long result = Factorial(f);
                if (result <= 0)
                {
                    MessageBox.Show("Value too Long to Display, Sorry");
                    txt_ResultValue.Text = "Null";
                }
                else
                    txt_ResultValue.Text = result.ToString();
            }
            else if (SelectionForm.identify == "Ran")
            {
                int min = Convert.ToInt32(txt_nValue.Text);
                int max = Convert.ToInt32(txt_rValue.Text);
                if (min >= max)
                {
                    MessageBox.Show("Please Enter Correct Input");
                    txt_ResultValue.Text = "Null";
                }
                else
                {
                    Random Random = new Random();
                    txt_ResultValue.Text = Random.Next(min, max).ToString();
                }
            }
            else if (SelectionForm.identify == "Mul")
            {
                long ele = Convert.ToInt32(txt_nValue.Text);
                long arr = Convert.ToInt32(txt_rValue.Text);
                long result = 1;
                for (int i = 0; i < ele; i++)
                {
                    result = result * arr;
                }
                txt_ResultValue.Text = result.ToString();
            }
            else
            {
                long n = Convert.ToInt64(txt_nValue.Text);
                long r = Convert.ToInt64(txt_rValue.Text);
                long result = nPr(n, r);
                if (result < 0)
                {
                    MessageBox.Show("Value too Long to Display, Sorry");
                    txt_ResultValue.Text = "Null";
                }
                else
                    txt_ResultValue.Text = result.ToString();
            }
                
        }
        private void txt_nValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_rValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}

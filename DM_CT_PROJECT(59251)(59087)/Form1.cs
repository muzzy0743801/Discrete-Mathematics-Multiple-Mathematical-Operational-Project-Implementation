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
    public partial class SelectionForm : Form
    {
        Com_PerForm CPForm = new Com_PerForm();
        public SelectionForm()
        {
            InitializeComponent();
        }
        public static string identify = "";
        private void btn_ncr_Click(object sender, EventArgs e)
        {
            btnVisible2();
            CPForm.Lbl_title.Text = "Combination";
            identify = "Com";
            CPForm.Show();
            this.Hide();
        }

        private void btn_npr_Click(object sender, EventArgs e)
        {
            btnVisible2();
            CPForm.Lbl_title.Text = "Permutation";
            identify = "Per";
            CPForm.Show();
            this.Hide();
        }

        private void btn_Factorial_Click(object sender, EventArgs e)
        {
            CPForm.Lbl_title.Text = "Factorial";
            identify = "Fac";
            btnVisible1();
            CPForm.Show();
            this.Hide();
        }

        private void btn_Random_Click(object sender, EventArgs e)
        {
            btnVisible2();
            CPForm.Lbl_title.Text = "Random Number";
            CPForm.label1.Text = "Min";
            CPForm.label2.Text = "Max";
            identify = "Ran";
            CPForm.Show();
            this.Hide();
        }
        public void btnVisible1()
        {
            CPForm.label1.Visible = false;
            CPForm.label2.Visible = false;
            CPForm.lbl_Factorial.Visible = true;
            CPForm.txt_nValue.Visible = false;
            CPForm.txt_rValue.Visible = false;
            CPForm.txtfac.Visible = true;
        }
        public void btnVisible2()
        {
            CPForm.label1.Text = "n Value";
            CPForm.label2.Text = "r Value";
            CPForm.label1.Visible = true;
            CPForm.label2.Visible = true;
            CPForm.lbl_Factorial.Visible = false;
            CPForm.txt_nValue.Visible = true;
            CPForm.txt_rValue.Visible = true;
            CPForm.txtfac.Visible = false;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            btnVisible2();
            CPForm.Lbl_title.Text = "Multiplication Principle";
            CPForm.label1.Text = "Elements";
            CPForm.label2.Text = "Arrangement";
            identify = "Mul";
            CPForm.Show();
            this.Hide();
        }
    }
}

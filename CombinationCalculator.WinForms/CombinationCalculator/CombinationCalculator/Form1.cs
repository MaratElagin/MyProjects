using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombinationCalculator
{
    public partial class CombinationCalculator : Form
    {
        public CombinationCalculator()
        {
            InitializeComponent();
        }

        private void btn_Perm_Click(object sender, EventArgs e)
        {
            var n = txt_PermCount.Text.Length == 0 ? 0 : int.Parse(txt_PermCount.Text);
            var p = Calculator.Fact(n);
            if (cb_Perm.Checked)
            {
                var retriesData = txt_retries.Text.Trim().Split();
                int k = retriesData.Length;
                if (k != 0)
                for (int i = 0; i < k; i++)
                    p /= Calculator.Fact(int.Parse(retriesData[i]));
            }
            if (txt_PermCount.Text.Length != 0)
                lbl_PermRes.Text = p.ToString();
            else MessageBox.Show("Заполните все поля!");
        }

        private void btn_Assig_Click(object sender, EventArgs e)
        {
            var isFilled_n = int.TryParse(txt_AssigNCount.Text.ToString(), out var n);
            var isFilled_m = int.TryParse(txt_AssigMCount.Text.ToString(), out var m);
            if (isFilled_n && isFilled_m)
            lbl_AssigRes.Text = cb_Assig.Checked ? Calculator.GetAssignmentCountWithRetries(n, m).ToString() :
                Calculator.GetAssignnmentCount(n, m).ToString();
            else MessageBox.Show("Заполните все поля!");
        }

        private void btnCompr_Click(object sender, EventArgs e)
        {
            var isFilled_n = int.TryParse(txt_ComprNCount.Text, out var n);
            var isFilled_m = int.TryParse(txt_ComprMCount.Text, out var m);
            if (isFilled_n && isFilled_m)
            {
                if (cb_Compr.Checked) n += m - 1;
                lbl_ComprRes.Text = Calculator.GetBinomCoefficient(n, m).ToString();
            }
            else MessageBox.Show("Заполните все поля!");
        }

        private void cb_Perm_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Perm.Checked)
            {
                lbl_retries.Visible = true;
                txt_retries.Visible = true;
            }
            else
            {
                lbl_retries.Visible = false;
                txt_retries.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl_PermRes.Text = "";
            lbl_AssigRes.Text = "";
            lbl_ComprRes.Text = "";
            txt_PermCount.Text = "";
            txt_retries.Text = "";
            txt_AssigNCount.Text = "";
            txt_AssigMCount.Text = "";
            txt_ComprNCount.Text = "";
            txt_ComprMCount.Text = "";
            cb_Perm.Checked = false;
            cb_Assig.Checked = false;
            cb_Compr.Checked = false;
        }

        private void CombinationCalculator_Load(object sender, EventArgs e)
        {
            Text = "CombinationCalculator";
        }
    }
}

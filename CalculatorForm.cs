using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // ambil nilai dari textbox
                double num1 = Convert.ToDouble(txtNum1.Text);
                double num2 = Convert.ToDouble(txtNum2.Text);

                // lakukan operasi aritmatika sesuai dengan pilihan pengguna
                double result = 0;

                if (rbAdd.Checked)
                {
                    result = CalculatorLogic.Add(num1, num2);
                }
                else if (rbSubtract.Checked)
                {
                    result = CalculatorLogic.Subtract(num1, num2);
                }
                else if (rbMultiply.Checked)
                {
                    result = CalculatorLogic.Multiply(num1, num2);
                }
                else if (rbDivide.Checked)
                {
                    result = CalculatorLogic.Divide(num1, num2);
                }

                // tampilkan hasil perhitungan pada label
                lblResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                // tampilkan pesan error jika terjadi kesalahan
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            // kosongkan textbox dan label
            txtNum1.Clear();
            txtNum2.Clear();
            lblResult.Text = "";

            // set radio button default ke Add
            rbAdd.Checked = true;
        }

    }
}

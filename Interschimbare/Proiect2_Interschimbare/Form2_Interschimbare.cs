using System.Windows.Forms;

namespace Proiect2_Interschimbare
{
    public partial class Form2_Interschimbare : Form
    {
        public Form2_Interschimbare() { InitializeComponent(); }
        private void btn_Inchidere_Click(object sender, System.EventArgs e) { this.Close(); }

        private void btn_Interschimbare_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Mutam pe A in C");
            textBox_C.Text = textBox_A.Text; textBox_A.Clear();

            MessageBox.Show("Mutam pe B in A");
            textBox_A.Text = textBox_B.Text; textBox_B.Clear();

            MessageBox.Show("Mutam pe C in B");
            textBox_B.Text = textBox_C.Text; textBox_C.Clear();
        }
    }
}
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Form_Interschimbare : Form
    {
        public Form_Interschimbare() { InitializeComponent(); }
        private void btn_Iesire_Click(object sender, EventArgs e) { Application.Exit(); }

        private void btn_Interschimba_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox_A.Text); int a_initial = a;
            int b = int.Parse(textBox_B.Text); int b_initial = b;
            int c = a; a = b; b = c;

            textBox_A.Text = a.ToString(); textBox_A.BackColor = Color.Yellow;
            textBox_B.Text = b.ToString(); textBox_B.BackColor = Color.Yellow;

            MessageBox.Show($"Valori initiale:\nA: {a_initial} B:{b_initial}");

            textBox_A.BackColor = Color.LawnGreen; textBox_B.BackColor = Color.LawnGreen;
        }
    }
}
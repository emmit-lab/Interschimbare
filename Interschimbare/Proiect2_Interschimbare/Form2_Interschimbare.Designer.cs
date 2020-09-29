namespace Proiect2_Interschimbare
{
    partial class Form2_Interschimbare
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Inchidere = new System.Windows.Forms.Button();
            this.textBox_A = new System.Windows.Forms.TextBox();
            this.textBox_B = new System.Windows.Forms.TextBox();
            this.btn_Interschimbare = new System.Windows.Forms.Button();
            this.label_A = new System.Windows.Forms.Label();
            this.label_B = new System.Windows.Forms.Label();
            this.label_C = new System.Windows.Forms.Label();
            this.textBox_C = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Inchidere
            // 
            this.btn_Inchidere.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inchidere.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Inchidere.Location = new System.Drawing.Point(207, 12);
            this.btn_Inchidere.Name = "btn_Inchidere";
            this.btn_Inchidere.Size = new System.Drawing.Size(30, 22);
            this.btn_Inchidere.TabIndex = 0;
            this.btn_Inchidere.Text = "X";
            this.btn_Inchidere.UseVisualStyleBackColor = true;
            this.btn_Inchidere.Click += new System.EventHandler(this.btn_Inchidere_Click);
            // 
            // textBox_A
            // 
            this.textBox_A.Location = new System.Drawing.Point(11, 54);
            this.textBox_A.Name = "textBox_A";
            this.textBox_A.Size = new System.Drawing.Size(39, 20);
            this.textBox_A.TabIndex = 1;
            // 
            // textBox_B
            // 
            this.textBox_B.Location = new System.Drawing.Point(141, 54);
            this.textBox_B.Name = "textBox_B";
            this.textBox_B.Size = new System.Drawing.Size(39, 20);
            this.textBox_B.TabIndex = 2;
            // 
            // btn_Interschimbare
            // 
            this.btn_Interschimbare.Location = new System.Drawing.Point(48, 80);
            this.btn_Interschimbare.Name = "btn_Interschimbare";
            this.btn_Interschimbare.Size = new System.Drawing.Size(94, 27);
            this.btn_Interschimbare.TabIndex = 3;
            this.btn_Interschimbare.Text = "Interschimba";
            this.btn_Interschimbare.UseVisualStyleBackColor = true;
            this.btn_Interschimbare.Click += new System.EventHandler(this.btn_Interschimbare_Click);
            // 
            // label_A
            // 
            this.label_A.AutoSize = true;
            this.label_A.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label_A.Location = new System.Drawing.Point(8, 35);
            this.label_A.Name = "label_A";
            this.label_A.Size = new System.Drawing.Size(26, 16);
            this.label_A.TabIndex = 4;
            this.label_A.Text = "A:";
            // 
            // label_B
            // 
            this.label_B.AutoSize = true;
            this.label_B.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_B.Location = new System.Drawing.Point(138, 35);
            this.label_B.Name = "label_B";
            this.label_B.Size = new System.Drawing.Size(26, 16);
            this.label_B.TabIndex = 5;
            this.label_B.Text = "B:";
            // 
            // label_C
            // 
            this.label_C.AutoSize = true;
            this.label_C.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label_C.Location = new System.Drawing.Point(71, 9);
            this.label_C.Name = "label_C";
            this.label_C.Size = new System.Drawing.Size(26, 16);
            this.label_C.TabIndex = 7;
            this.label_C.Text = "C:";
            // 
            // textBox_C
            // 
            this.textBox_C.Location = new System.Drawing.Point(74, 28);
            this.textBox_C.Name = "textBox_C";
            this.textBox_C.ReadOnly = true;
            this.textBox_C.Size = new System.Drawing.Size(39, 20);
            this.textBox_C.TabIndex = 6;
            // 
            // Form2_Interschimbare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 116);
            this.ControlBox = false;
            this.Controls.Add(this.label_C);
            this.Controls.Add(this.textBox_C);
            this.Controls.Add(this.label_B);
            this.Controls.Add(this.label_A);
            this.Controls.Add(this.btn_Interschimbare);
            this.Controls.Add(this.textBox_B);
            this.Controls.Add(this.textBox_A);
            this.Controls.Add(this.btn_Inchidere);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(400, 400);
            this.Name = "Form2_Interschimbare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "INTERSCHIMBARE 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Inchidere;
        private System.Windows.Forms.TextBox textBox_A;
        private System.Windows.Forms.TextBox textBox_B;
        private System.Windows.Forms.Button btn_Interschimbare;
        private System.Windows.Forms.Label label_A;
        private System.Windows.Forms.Label label_B;
        private System.Windows.Forms.Label label_C;
        private System.Windows.Forms.TextBox textBox_C;
    }
}
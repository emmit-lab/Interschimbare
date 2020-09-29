namespace Proiect
{
    partial class Form_Interschimbare
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
            this.btn_Iesire = new System.Windows.Forms.Button();
            this.btn_Interschimba = new System.Windows.Forms.Button();
            this.textBox_A = new System.Windows.Forms.TextBox();
            this.textBox_B = new System.Windows.Forms.TextBox();
            this.label_A = new System.Windows.Forms.Label();
            this.label_B = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Iesire
            // 
            this.btn_Iesire.BackColor = System.Drawing.Color.Red;
            this.btn_Iesire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Iesire.ForeColor = System.Drawing.Color.White;
            this.btn_Iesire.Location = new System.Drawing.Point(389, 191);
            this.btn_Iesire.Name = "btn_Iesire";
            this.btn_Iesire.Size = new System.Drawing.Size(64, 55);
            this.btn_Iesire.TabIndex = 0;
            this.btn_Iesire.Text = "Iesire";
            this.btn_Iesire.UseVisualStyleBackColor = false;
            this.btn_Iesire.Click += new System.EventHandler(this.btn_Iesire_Click);
            // 
            // btn_Interschimba
            // 
            this.btn_Interschimba.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Interschimba.Location = new System.Drawing.Point(185, 102);
            this.btn_Interschimba.Name = "btn_Interschimba";
            this.btn_Interschimba.Size = new System.Drawing.Size(115, 45);
            this.btn_Interschimba.TabIndex = 1;
            this.btn_Interschimba.Text = "Interschimba";
            this.btn_Interschimba.UseVisualStyleBackColor = true;
            this.btn_Interschimba.Click += new System.EventHandler(this.btn_Interschimba_Click);
            // 
            // textBox_A
            // 
            this.textBox_A.BackColor = System.Drawing.Color.LawnGreen;
            this.textBox_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_A.Location = new System.Drawing.Point(72, 52);
            this.textBox_A.Name = "textBox_A";
            this.textBox_A.Size = new System.Drawing.Size(100, 26);
            this.textBox_A.TabIndex = 2;
            // 
            // textBox_B
            // 
            this.textBox_B.BackColor = System.Drawing.Color.LawnGreen;
            this.textBox_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.textBox_B.Location = new System.Drawing.Point(309, 52);
            this.textBox_B.Name = "textBox_B";
            this.textBox_B.Size = new System.Drawing.Size(100, 26);
            this.textBox_B.TabIndex = 3;
            // 
            // label_A
            // 
            this.label_A.AutoSize = true;
            this.label_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_A.Location = new System.Drawing.Point(68, 25);
            this.label_A.Name = "label_A";
            this.label_A.Size = new System.Drawing.Size(30, 24);
            this.label_A.TabIndex = 4;
            this.label_A.Text = "A:";
            // 
            // label_B
            // 
            this.label_B.AutoSize = true;
            this.label_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label_B.Location = new System.Drawing.Point(305, 25);
            this.label_B.Name = "label_B";
            this.label_B.Size = new System.Drawing.Size(29, 24);
            this.label_B.TabIndex = 5;
            this.label_B.Text = "B:";
            // 
            // Form_Interschimbare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(462, 254);
            this.ControlBox = false;
            this.Controls.Add(this.label_B);
            this.Controls.Add(this.label_A);
            this.Controls.Add(this.textBox_B);
            this.Controls.Add(this.textBox_A);
            this.Controls.Add(this.btn_Interschimba);
            this.Controls.Add(this.btn_Iesire);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Interschimbare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INTERSCHIMBARE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Iesire;
        private System.Windows.Forms.Button btn_Interschimba;
        private System.Windows.Forms.TextBox textBox_A;
        private System.Windows.Forms.TextBox textBox_B;
        private System.Windows.Forms.Label label_A;
        private System.Windows.Forms.Label label_B;
    }
}


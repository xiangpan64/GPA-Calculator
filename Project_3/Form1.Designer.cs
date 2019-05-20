namespace Project_3
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fnamebox = new System.Windows.Forms.TextBox();
            this.lnamebox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.unum1 = new System.Windows.Forms.TextBox();
            this.unum2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.signinbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name: ";
            // 
            // fnamebox
            // 
            this.fnamebox.Location = new System.Drawing.Point(202, 77);
            this.fnamebox.Name = "fnamebox";
            this.fnamebox.Size = new System.Drawing.Size(163, 20);
            this.fnamebox.TabIndex = 2;
            this.fnamebox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fnamebox_KeyDown);
            // 
            // lnamebox
            // 
            this.lnamebox.Location = new System.Drawing.Point(202, 105);
            this.lnamebox.Name = "lnamebox";
            this.lnamebox.Size = new System.Drawing.Size(163, 20);
            this.lnamebox.TabIndex = 3;
            this.lnamebox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lnamebox_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "U-number: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(198, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "U";
            // 
            // unum1
            // 
            this.unum1.Location = new System.Drawing.Point(226, 137);
            this.unum1.MaxLength = 4;
            this.unum1.Name = "unum1";
            this.unum1.Size = new System.Drawing.Size(56, 20);
            this.unum1.TabIndex = 6;
            this.unum1.TextChanged += new System.EventHandler(this.unum1_TextChanged);
            this.unum1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.unum1_KeyDown);
            //this.unum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.unum1_KeyPress);
            // 
            // unum2
            // 
            this.unum2.Location = new System.Drawing.Point(309, 137);
            this.unum2.MaxLength = 4;
            this.unum2.Name = "unum2";
            this.unum2.Size = new System.Drawing.Size(56, 20);
            this.unum2.TabIndex = 7;
            this.unum2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.unum2_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(288, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "-";
            // 
            // signinbtn
            // 
            this.signinbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinbtn.Location = new System.Drawing.Point(228, 177);
            this.signinbtn.Name = "signinbtn";
            this.signinbtn.Size = new System.Drawing.Size(75, 33);
            this.signinbtn.TabIndex = 9;
            this.signinbtn.Text = "Sign In";
            this.signinbtn.UseVisualStyleBackColor = true;
            this.signinbtn.Click += new System.EventHandler(this.signinbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 257);
            this.Controls.Add(this.signinbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.unum2);
            this.Controls.Add(this.unum1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lnamebox);
            this.Controls.Add(this.fnamebox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "SignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fnamebox;
        private System.Windows.Forms.TextBox lnamebox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox unum1;
        private System.Windows.Forms.TextBox unum2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button signinbtn;
    }
}


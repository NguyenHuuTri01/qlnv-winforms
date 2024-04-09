
namespace DoAnCaNhan
{
    partial class frm_DoiPass
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
            this.pbpass1 = new System.Windows.Forms.PictureBox();
            this.pbRePass = new System.Windows.Forms.PictureBox();
            this.btn_Dangki = new System.Windows.Forms.Button();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ResPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbpass1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRePass)).BeginInit();
            this.SuspendLayout();
            // 
            // pbpass1
            // 
            this.pbpass1.Image = global::DoAnCaNhan.Properties.Resources.Vision_Icon;
            this.pbpass1.Location = new System.Drawing.Point(639, 191);
            this.pbpass1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbpass1.Name = "pbpass1";
            this.pbpass1.Size = new System.Drawing.Size(35, 28);
            this.pbpass1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbpass1.TabIndex = 22;
            this.pbpass1.TabStop = false;
            this.pbpass1.Click += new System.EventHandler(this.pbpass1_Click);
            // 
            // pbRePass
            // 
            this.pbRePass.Image = global::DoAnCaNhan.Properties.Resources.Vision_Icon;
            this.pbRePass.Location = new System.Drawing.Point(639, 269);
            this.pbRePass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbRePass.Name = "pbRePass";
            this.pbRePass.Size = new System.Drawing.Size(35, 28);
            this.pbRePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRePass.TabIndex = 21;
            this.pbRePass.TabStop = false;
            this.pbRePass.Click += new System.EventHandler(this.pbRePass_Click);
            // 
            // btn_Dangki
            // 
            this.btn_Dangki.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dangki.Location = new System.Drawing.Point(382, 372);
            this.btn_Dangki.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Dangki.Name = "btn_Dangki";
            this.btn_Dangki.Size = new System.Drawing.Size(213, 49);
            this.btn_Dangki.TabIndex = 20;
            this.btn_Dangki.Text = "Lưu";
            this.btn_Dangki.UseVisualStyleBackColor = true;
            this.btn_Dangki.Click += new System.EventHandler(this.btn_Dangki_Click);
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(371, 111);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(248, 30);
            this.txt_Email.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.Location = new System.Drawing.Point(150, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Email :";
            // 
            // txt_ResPassword
            // 
            this.txt_ResPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ResPassword.Location = new System.Drawing.Point(371, 269);
            this.txt_ResPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ResPassword.Name = "txt_ResPassword";
            this.txt_ResPassword.Size = new System.Drawing.Size(248, 30);
            this.txt_ResPassword.TabIndex = 17;
            this.txt_ResPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(96, 283);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Xác Nhận Mật Khẩu :";
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(371, 189);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(248, 30);
            this.txt_Password.TabIndex = 15;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(127, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mật Khẩu :";
            // 
            // frm_DoiPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 503);
            this.Controls.Add(this.pbpass1);
            this.Controls.Add(this.pbRePass);
            this.Controls.Add(this.btn_Dangki);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_ResPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.label2);
            this.Name = "frm_DoiPass";
            this.Text = "frm_DoiPass";
            ((System.ComponentModel.ISupportInitialize)(this.pbpass1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRePass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pbpass1;
        public System.Windows.Forms.PictureBox pbRePass;
        public System.Windows.Forms.Button btn_Dangki;
        public System.Windows.Forms.TextBox txt_Email;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_ResPassword;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label2;
    }
}
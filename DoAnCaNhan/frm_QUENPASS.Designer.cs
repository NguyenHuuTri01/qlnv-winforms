namespace DoAnCaNhan
{
    partial class frm_QUENPASS
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
            this.btn_laypass = new System.Windows.Forms.Button();
            this.lb_pass = new System.Windows.Forms.Label();
            this.txt_Emaill = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.datagrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_laypass
            // 
            this.btn_laypass.AutoSize = true;
            this.btn_laypass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_laypass.Location = new System.Drawing.Point(240, 410);
            this.btn_laypass.Margin = new System.Windows.Forms.Padding(4);
            this.btn_laypass.Name = "btn_laypass";
            this.btn_laypass.Size = new System.Drawing.Size(213, 42);
            this.btn_laypass.TabIndex = 14;
            this.btn_laypass.Text = "Lấy lại mật khẩu";
            this.btn_laypass.UseVisualStyleBackColor = true;
            this.btn_laypass.Click += new System.EventHandler(this.btn_laypass_Click);
            // 
            // lb_pass
            // 
            this.lb_pass.AutoSize = true;
            this.lb_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pass.ForeColor = System.Drawing.Color.Red;
            this.lb_pass.Location = new System.Drawing.Point(91, 350);
            this.lb_pass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_pass.Name = "lb_pass";
            this.lb_pass.Size = new System.Drawing.Size(18, 25);
            this.lb_pass.TabIndex = 13;
            this.lb_pass.Text = " ";
            // 
            // txt_Emaill
            // 
            this.txt_Emaill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Emaill.Location = new System.Drawing.Point(304, 277);
            this.txt_Emaill.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Emaill.Name = "txt_Emaill";
            this.txt_Emaill.Size = new System.Drawing.Size(248, 30);
            this.txt_Emaill.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(91, 277);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Email đăng kí :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::DoAnCaNhan.Properties.Resources._1_jpg;
            this.pictureBox1.Location = new System.Drawing.Point(156, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // datagrid
            // 
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(41, 483);
            this.datagrid.Name = "datagrid";
            this.datagrid.RowHeadersWidth = 51;
            this.datagrid.RowTemplate.Height = 24;
            this.datagrid.Size = new System.Drawing.Size(590, 77);
            this.datagrid.TabIndex = 16;
            // 
            // frm_QUENPASS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(660, 602);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_laypass);
            this.Controls.Add(this.lb_pass);
            this.Controls.Add(this.txt_Emaill);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_QUENPASS";
            this.Text = "frm_QUENPASS";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_laypass;
        public System.Windows.Forms.Label lb_pass;
        public System.Windows.Forms.TextBox txt_Emaill;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView datagrid;
    }
}
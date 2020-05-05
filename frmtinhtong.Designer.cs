namespace chuong4_btvn
{
    partial class frmtinhtong
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
            this.lbA = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lbB = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnLL = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lbtong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Location = new System.Drawing.Point(124, 65);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(44, 13);
            this.lbA.TabIndex = 0;
            this.lbA.Text = "nhập A:";
            this.lbA.Click += new System.EventHandler(this.lbA_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(214, 65);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 1;
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_KeyPress);
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Location = new System.Drawing.Point(127, 125);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(47, 13);
            this.lbB.TabIndex = 2;
            this.lbB.Text = "nhập B: ";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(214, 117);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 3;
            this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(127, 219);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(75, 23);
            this.btnTong.TabIndex = 5;
            this.btnTong.Text = "tổng";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnLL
            // 
            this.btnLL.Location = new System.Drawing.Point(238, 218);
            this.btnLL.Name = "btnLL";
            this.btnLL.Size = new System.Drawing.Size(75, 23);
            this.btnLL.TabIndex = 6;
            this.btnLL.Text = "làm lại";
            this.btnLL.UseVisualStyleBackColor = true;
            this.btnLL.Click += new System.EventHandler(this.btnLL_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(378, 218);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lbtong
            // 
            this.lbtong.AutoSize = true;
            this.lbtong.Location = new System.Drawing.Point(130, 171);
            this.lbtong.Name = "lbtong";
            this.lbtong.Size = new System.Drawing.Size(81, 13);
            this.lbtong.TabIndex = 8;
            this.lbtong.Text = "tổng các số từ :";
            this.lbtong.Click += new System.EventHandler(this.lbtong_Click);
            // 
            // frmtinhtong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbtong);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLL);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.lbB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lbA);
            this.Name = "frmtinhtong";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnLL;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lbtong;
    }
}


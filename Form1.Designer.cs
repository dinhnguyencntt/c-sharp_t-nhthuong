namespace c_sharp_tínhthuong
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
            this.txtso1 = new System.Windows.Forms.TextBox();
            this.btntinhtong = new System.Windows.Forms.Button();
            this.lblso1 = new System.Windows.Forms.Label();
            this.lblso2 = new System.Windows.Forms.Label();
            this.lblkq = new System.Windows.Forms.Label();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.txtso2 = new System.Windows.Forms.TextBox();
            this.btntinhhieu = new System.Windows.Forms.Button();
            this.btntinhthuong = new System.Windows.Forms.Button();
            this.btntinhtich = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtso1
            // 
            this.txtso1.Location = new System.Drawing.Point(427, 119);
            this.txtso1.Name = "txtso1";
            this.txtso1.Size = new System.Drawing.Size(100, 20);
            this.txtso1.TabIndex = 0;
            // 
            // btntinhtong
            // 
            this.btntinhtong.Location = new System.Drawing.Point(34, 367);
            this.btntinhtong.Name = "btntinhtong";
            this.btntinhtong.Size = new System.Drawing.Size(146, 62);
            this.btntinhtong.TabIndex = 1;
            this.btntinhtong.Text = "Tổng";
            this.btntinhtong.UseVisualStyleBackColor = true;
            this.btntinhtong.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblso1
            // 
            this.lblso1.AutoSize = true;
            this.lblso1.Location = new System.Drawing.Point(258, 119);
            this.lblso1.Name = "lblso1";
            this.lblso1.Size = new System.Drawing.Size(27, 13);
            this.lblso1.TabIndex = 2;
            this.lblso1.Text = "số 1";
            this.lblso1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblso2
            // 
            this.lblso2.AutoSize = true;
            this.lblso2.Location = new System.Drawing.Point(258, 171);
            this.lblso2.Name = "lblso2";
            this.lblso2.Size = new System.Drawing.Size(27, 13);
            this.lblso2.TabIndex = 3;
            this.lblso2.Text = "số 2";
            // 
            // lblkq
            // 
            this.lblkq.AutoSize = true;
            this.lblkq.Location = new System.Drawing.Point(273, 265);
            this.lblkq.Name = "lblkq";
            this.lblkq.Size = new System.Drawing.Size(43, 13);
            this.lblkq.TabIndex = 4;
            this.lblkq.Text = "kết quả";
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(427, 262);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(100, 20);
            this.txtkq.TabIndex = 5;
            // 
            // txtso2
            // 
            this.txtso2.Location = new System.Drawing.Point(427, 171);
            this.txtso2.Name = "txtso2";
            this.txtso2.Size = new System.Drawing.Size(100, 20);
            this.txtso2.TabIndex = 6;
            // 
            // btntinhhieu
            // 
            this.btntinhhieu.Location = new System.Drawing.Point(228, 358);
            this.btntinhhieu.Name = "btntinhhieu";
            this.btntinhhieu.Size = new System.Drawing.Size(131, 62);
            this.btntinhhieu.TabIndex = 7;
            this.btntinhhieu.Text = "hiệu";
            this.btntinhhieu.UseVisualStyleBackColor = true;
            this.btntinhhieu.Click += new System.EventHandler(this.btntinhhieu_Click);
            // 
            // btntinhthuong
            // 
            this.btntinhthuong.Location = new System.Drawing.Point(445, 358);
            this.btntinhthuong.Name = "btntinhthuong";
            this.btntinhthuong.Size = new System.Drawing.Size(130, 62);
            this.btntinhthuong.TabIndex = 8;
            this.btntinhthuong.Text = "thương";
            this.btntinhthuong.UseVisualStyleBackColor = true;
            this.btntinhthuong.Click += new System.EventHandler(this.btntinhthuong_Click);
            // 
            // btntinhtich
            // 
            this.btntinhtich.Location = new System.Drawing.Point(661, 367);
            this.btntinhtich.Name = "btntinhtich";
            this.btntinhtich.Size = new System.Drawing.Size(127, 53);
            this.btntinhtich.TabIndex = 9;
            this.btntinhtich.Text = "tích";
            this.btntinhtich.UseVisualStyleBackColor = true;
            this.btntinhtich.Click += new System.EventHandler(this.btntinhtich_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btntinhtich);
            this.Controls.Add(this.btntinhthuong);
            this.Controls.Add(this.btntinhhieu);
            this.Controls.Add(this.txtso2);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.lblkq);
            this.Controls.Add(this.lblso2);
            this.Controls.Add(this.lblso1);
            this.Controls.Add(this.btntinhtong);
            this.Controls.Add(this.txtso1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtso1;
        private System.Windows.Forms.Button btntinhtong;
        private System.Windows.Forms.Label lblso1;
        private System.Windows.Forms.Label lblso2;
        private System.Windows.Forms.Label lblkq;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.TextBox txtso2;
        private System.Windows.Forms.Button btntinhhieu;
        private System.Windows.Forms.Button btntinhthuong;
        private System.Windows.Forms.Button btntinhtich;
    }
}


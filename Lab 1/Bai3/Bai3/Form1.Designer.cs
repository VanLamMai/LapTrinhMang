
namespace Bai3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPhanGiai = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtSubnetMask = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDefaultGateway = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPhanGiai);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtResult);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtInput);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(773, 217);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phân giải tên miền trang web";
            // 
            // btnPhanGiai
            // 
            this.btnPhanGiai.Location = new System.Drawing.Point(636, 24);
            this.btnPhanGiai.Name = "btnPhanGiai";
            this.btnPhanGiai.Size = new System.Drawing.Size(129, 33);
            this.btnPhanGiai.TabIndex = 4;
            this.btnPhanGiai.Text = "Phân giải";
            this.btnPhanGiai.UseVisualStyleBackColor = true;
            this.btnPhanGiai.Click += new System.EventHandler(this.btnPhanGiai_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kết quả phân giải:";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(148, 69);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(617, 143);
            this.txtResult.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập tên miền:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(148, 27);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(477, 26);
            this.txtInput.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtIP);
            this.groupBox2.Controls.Add(this.txtSubnetMask);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtDefaultGateway);
            this.groupBox2.Location = new System.Drawing.Point(13, 266);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(766, 137);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết về giao thức IP trên Local host";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(145, 28);
            this.txtIP.Margin = new System.Windows.Forms.Padding(4);
            this.txtIP.Name = "txtIP";
            this.txtIP.ReadOnly = true;
            this.txtIP.Size = new System.Drawing.Size(613, 26);
            this.txtIP.TabIndex = 6;
            // 
            // txtSubnetMask
            // 
            this.txtSubnetMask.Location = new System.Drawing.Point(145, 66);
            this.txtSubnetMask.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubnetMask.Name = "txtSubnetMask";
            this.txtSubnetMask.ReadOnly = true;
            this.txtSubnetMask.Size = new System.Drawing.Size(613, 26);
            this.txtSubnetMask.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 103);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Default Gateway:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Subnet Mask:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Địa chỉ IP:";
            // 
            // txtDefaultGateway
            // 
            this.txtDefaultGateway.Location = new System.Drawing.Point(145, 100);
            this.txtDefaultGateway.Margin = new System.Windows.Forms.Padding(4);
            this.txtDefaultGateway.Name = "txtDefaultGateway";
            this.txtDefaultGateway.ReadOnly = true;
            this.txtDefaultGateway.Size = new System.Drawing.Size(613, 26);
            this.txtDefaultGateway.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPhanGiai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtSubnetMask;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDefaultGateway;
    }
}


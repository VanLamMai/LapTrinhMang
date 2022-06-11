
namespace Client
{
    partial class Client
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbxPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbxText = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbxStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxReceive = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDisconnect);
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Controls.Add(this.tbxPort);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbxIP);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 136);
            this.panel1.TabIndex = 0;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.Location = new System.Drawing.Point(288, 70);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(147, 51);
            this.btnDisconnect.TabIndex = 10;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(126, 70);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(126, 51);
            this.btnConnect.TabIndex = 9;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tbxPort
            // 
            this.tbxPort.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbxPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPort.Location = new System.Drawing.Point(378, 23);
            this.tbxPort.Name = "tbxPort";
            this.tbxPort.Size = new System.Drawing.Size(100, 30);
            this.tbxPort.TabIndex = 8;
            this.tbxPort.Text = "9000";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(305, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Port:";
            // 
            // tbxIP
            // 
            this.tbxIP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbxIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxIP.Location = new System.Drawing.Point(95, 21);
            this.tbxIP.Multiline = true;
            this.tbxIP.Name = "tbxIP";
            this.tbxIP.Size = new System.Drawing.Size(179, 30);
            this.tbxIP.TabIndex = 6;
            this.tbxIP.Text = "127.0.0.1";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "IP:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(0, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(552, 100);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.tbxText);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter text:";
            // 
            // btnSend
            // 
            this.btnSend.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSend.Location = new System.Drawing.Point(417, 28);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(104, 39);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbxText
            // 
            this.tbxText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbxText.Location = new System.Drawing.Point(64, 28);
            this.tbxText.Multiline = true;
            this.tbxText.Name = "tbxText";
            this.tbxText.Size = new System.Drawing.Size(322, 39);
            this.tbxText.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbxStatus);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.tbxReceive);
            this.panel3.Location = new System.Drawing.Point(0, 250);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(552, 250);
            this.panel3.TabIndex = 2;
            // 
            // tbxStatus
            // 
            this.tbxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxStatus.Location = new System.Drawing.Point(239, 214);
            this.tbxStatus.Multiline = true;
            this.tbxStatus.Name = "tbxStatus";
            this.tbxStatus.ReadOnly = true;
            this.tbxStatus.Size = new System.Drawing.Size(282, 33);
            this.tbxStatus.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Connection Status:";
            // 
            // tbxReceive
            // 
            this.tbxReceive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxReceive.Location = new System.Drawing.Point(6, 3);
            this.tbxReceive.Multiline = true;
            this.tbxReceive.Name = "tbxReceive";
            this.tbxReceive.ReadOnly = true;
            this.tbxReceive.Size = new System.Drawing.Size(543, 206);
            this.tbxReceive.TabIndex = 1;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 500);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Client";
            this.Text = "Client";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox tbxPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbxText;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbxStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxReceive;
    }
}


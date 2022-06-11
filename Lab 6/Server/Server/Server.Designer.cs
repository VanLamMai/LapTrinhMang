
namespace Server
{
    partial class Server
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
            this.tbxPort = new System.Windows.Forms.TextBox();
            this.cbxClients = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxStatus = new System.Windows.Forms.TextBox();
            this.tbxReceive = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbxPort);
            this.panel1.Controls.Add(this.cbxClients);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 131);
            this.panel1.TabIndex = 0;
            // 
            // tbxPort
            // 
            this.tbxPort.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbxPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPort.Location = new System.Drawing.Point(154, 27);
            this.tbxPort.Name = "tbxPort";
            this.tbxPort.Size = new System.Drawing.Size(100, 30);
            this.tbxPort.TabIndex = 9;
            this.tbxPort.Text = "9000";
            // 
            // cbxClients
            // 
            this.cbxClients.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbxClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxClients.FormattingEnabled = true;
            this.cbxClients.Location = new System.Drawing.Point(154, 83);
            this.cbxClients.Name = "cbxClients";
            this.cbxClients.Size = new System.Drawing.Size(370, 28);
            this.cbxClients.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Clients:";
            // 
            // btnStop
            // 
            this.btnStop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(389, 13);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(92, 49);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(278, 13);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(92, 49);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxReceive);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 306);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Text received from client:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 461);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Connection Status:";
            // 
            // tbxStatus
            // 
            this.tbxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxStatus.Location = new System.Drawing.Point(226, 460);
            this.tbxStatus.Multiline = true;
            this.tbxStatus.Name = "tbxStatus";
            this.tbxStatus.ReadOnly = true;
            this.tbxStatus.Size = new System.Drawing.Size(282, 30);
            this.tbxStatus.TabIndex = 6;
            // 
            // tbxReceive
            // 
            this.tbxReceive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxReceive.Location = new System.Drawing.Point(12, 29);
            this.tbxReceive.Multiline = true;
            this.tbxReceive.Name = "tbxReceive";
            this.tbxReceive.ReadOnly = true;
            this.tbxReceive.Size = new System.Drawing.Size(541, 270);
            this.tbxReceive.TabIndex = 1;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 495);
            this.Controls.Add(this.tbxStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Server";
            this.Text = "Server";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbxClients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxStatus;
        private System.Windows.Forms.TextBox tbxPort;
        private System.Windows.Forms.TextBox tbxReceive;
    }
}


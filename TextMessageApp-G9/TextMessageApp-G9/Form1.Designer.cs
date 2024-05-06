
namespace TextMessageApp_G9
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ServerPorttxt = new System.Windows.Forms.TextBox();
            this.ServerIPtxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ClientPorttxt = new System.Windows.Forms.TextBox();
            this.ClientIPtxt = new System.Windows.Forms.TextBox();
            this.ChatScreentxt = new System.Windows.Forms.TextBox();
            this.MessageBoxtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Startbtn = new System.Windows.Forms.Button();
            this.Connectbtn = new System.Windows.Forms.Button();
            this.Sendbtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Startbtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ServerPorttxt);
            this.groupBox1.Controls.Add(this.ServerIPtxt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SERVER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "PORT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP";
            // 
            // ServerPorttxt
            // 
            this.ServerPorttxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServerPorttxt.Location = new System.Drawing.Point(326, 34);
            this.ServerPorttxt.Name = "ServerPorttxt";
            this.ServerPorttxt.Size = new System.Drawing.Size(155, 20);
            this.ServerPorttxt.TabIndex = 1;
            // 
            // ServerIPtxt
            // 
            this.ServerIPtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServerIPtxt.Location = new System.Drawing.Point(81, 34);
            this.ServerIPtxt.Name = "ServerIPtxt";
            this.ServerIPtxt.Size = new System.Drawing.Size(155, 20);
            this.ServerIPtxt.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Connectbtn);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ClientPorttxt);
            this.groupBox2.Controls.Add(this.ClientIPtxt);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(26, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(635, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CLIENT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "IP";
            // 
            // ClientPorttxt
            // 
            this.ClientPorttxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClientPorttxt.Location = new System.Drawing.Point(326, 34);
            this.ClientPorttxt.Name = "ClientPorttxt";
            this.ClientPorttxt.Size = new System.Drawing.Size(155, 20);
            this.ClientPorttxt.TabIndex = 2;
            // 
            // ClientIPtxt
            // 
            this.ClientIPtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClientIPtxt.Location = new System.Drawing.Point(81, 34);
            this.ClientIPtxt.Name = "ClientIPtxt";
            this.ClientIPtxt.Size = new System.Drawing.Size(155, 20);
            this.ClientIPtxt.TabIndex = 1;
            // 
            // ChatScreentxt
            // 
            this.ChatScreentxt.BackColor = System.Drawing.SystemColors.Window;
            this.ChatScreentxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChatScreentxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ChatScreentxt.Location = new System.Drawing.Point(26, 236);
            this.ChatScreentxt.Multiline = true;
            this.ChatScreentxt.Name = "ChatScreentxt";
            this.ChatScreentxt.Size = new System.Drawing.Size(635, 98);
            this.ChatScreentxt.TabIndex = 1;
            // 
            // MessageBoxtxt
            // 
            this.MessageBoxtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessageBoxtxt.Location = new System.Drawing.Point(26, 361);
            this.MessageBoxtxt.Multiline = true;
            this.MessageBoxtxt.Name = "MessageBoxtxt";
            this.MessageBoxtxt.Size = new System.Drawing.Size(510, 45);
            this.MessageBoxtxt.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(283, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "PORT";
            // 
            // Startbtn
            // 
            this.Startbtn.BackColor = System.Drawing.Color.Gray;
            this.Startbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Startbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Startbtn.Location = new System.Drawing.Point(516, 27);
            this.Startbtn.Name = "Startbtn";
            this.Startbtn.Size = new System.Drawing.Size(104, 33);
            this.Startbtn.TabIndex = 4;
            this.Startbtn.Text = "START";
            this.Startbtn.UseVisualStyleBackColor = false;
            this.Startbtn.Click += new System.EventHandler(this.Startbtn_Click);
            // 
            // Connectbtn
            // 
            this.Connectbtn.BackColor = System.Drawing.Color.Gray;
            this.Connectbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Connectbtn.Location = new System.Drawing.Point(516, 28);
            this.Connectbtn.Name = "Connectbtn";
            this.Connectbtn.Size = new System.Drawing.Size(104, 38);
            this.Connectbtn.TabIndex = 5;
            this.Connectbtn.Text = "CONNECT";
            this.Connectbtn.UseVisualStyleBackColor = false;
            this.Connectbtn.Click += new System.EventHandler(this.Connectbtn_Click);
            // 
            // Sendbtn
            // 
            this.Sendbtn.BackColor = System.Drawing.Color.Gray;
            this.Sendbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sendbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sendbtn.Location = new System.Drawing.Point(542, 361);
            this.Sendbtn.Name = "Sendbtn";
            this.Sendbtn.Size = new System.Drawing.Size(119, 45);
            this.Sendbtn.TabIndex = 6;
            this.Sendbtn.Text = "SEND";
            this.Sendbtn.UseVisualStyleBackColor = false;
            this.Sendbtn.Click += new System.EventHandler(this.Sendbtn_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 418);
            this.Controls.Add(this.Sendbtn);
            this.Controls.Add(this.MessageBoxtxt);
            this.Controls.Add(this.ChatScreentxt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ServerPorttxt;
        private System.Windows.Forms.TextBox ServerIPtxt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ClientPorttxt;
        private System.Windows.Forms.TextBox ClientIPtxt;
        private System.Windows.Forms.TextBox ChatScreentxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MessageBoxtxt;
        private System.Windows.Forms.Button Startbtn;
        private System.Windows.Forms.Button Connectbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Sendbtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}


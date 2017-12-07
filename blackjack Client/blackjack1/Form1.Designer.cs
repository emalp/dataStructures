namespace blackJack1
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.servText = new System.Windows.Forms.TextBox();
            this.disconnectBtn = new System.Windows.Forms.Button();
            this.connectBtn = new System.Windows.Forms.Button();
            this.statusLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.winnerStage = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.stickBtn = new System.Windows.Forms.Button();
            this.hitBtn = new System.Windows.Forms.Button();
            this.dealBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lightTheme = new System.Windows.Forms.RadioButton();
            this.darkTheme = new System.Windows.Forms.RadioButton();
            this.panel2.SuspendLayout();
            this.mainpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.winnerStage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.servText);
            this.panel2.Controls.Add(this.disconnectBtn);
            this.panel2.Controls.Add(this.connectBtn);
            this.panel2.Controls.Add(this.statusLbl);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(11, 637);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(994, 65);
            this.panel2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(423, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Server IP:";
            // 
            // servText
            // 
            this.servText.Location = new System.Drawing.Point(407, 26);
            this.servText.Name = "servText";
            this.servText.Size = new System.Drawing.Size(306, 26);
            this.servText.TabIndex = 4;
            this.servText.Text = "127.0.0.1";
            // 
            // disconnectBtn
            // 
            this.disconnectBtn.Location = new System.Drawing.Point(853, 3);
            this.disconnectBtn.Name = "disconnectBtn";
            this.disconnectBtn.Size = new System.Drawing.Size(136, 57);
            this.disconnectBtn.TabIndex = 3;
            this.disconnectBtn.Text = "Disconnect from server";
            this.disconnectBtn.UseVisualStyleBackColor = true;
            this.disconnectBtn.Click += new System.EventHandler(this.disconnectBtn_Click);
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(719, 3);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(128, 57);
            this.connectBtn.TabIndex = 2;
            this.connectBtn.Text = "Connect to server";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.statusLbl.Location = new System.Drawing.Point(75, 19);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(181, 20);
            this.statusLbl.TabIndex = 1;
            this.statusLbl.Text = "Not connected to Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(5, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Status: ";
            // 
            // mainpanel
            // 
            this.mainpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainpanel.Controls.Add(this.winnerStage);
            this.mainpanel.Controls.Add(this.pictureBox13);
            this.mainpanel.Controls.Add(this.pictureBox2);
            this.mainpanel.Controls.Add(this.pictureBox8);
            this.mainpanel.Controls.Add(this.pictureBox9);
            this.mainpanel.Controls.Add(this.pictureBox10);
            this.mainpanel.Controls.Add(this.pictureBox11);
            this.mainpanel.Controls.Add(this.pictureBox12);
            this.mainpanel.Controls.Add(this.pictureBox7);
            this.mainpanel.Controls.Add(this.pictureBox6);
            this.mainpanel.Controls.Add(this.pictureBox5);
            this.mainpanel.Controls.Add(this.pictureBox4);
            this.mainpanel.Controls.Add(this.pictureBox3);
            this.mainpanel.Controls.Add(this.pictureBox1);
            this.mainpanel.Controls.Add(this.panel3);
            this.mainpanel.Controls.Add(this.dealBtn);
            this.mainpanel.Location = new System.Drawing.Point(12, 12);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(995, 619);
            this.mainpanel.TabIndex = 11;
            // 
            // winnerStage
            // 
            this.winnerStage.Location = new System.Drawing.Point(206, 218);
            this.winnerStage.Name = "winnerStage";
            this.winnerStage.Size = new System.Drawing.Size(540, 97);
            this.winnerStage.TabIndex = 30;
            this.winnerStage.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Location = new System.Drawing.Point(666, 346);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(131, 195);
            this.pictureBox13.TabIndex = 29;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(355, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(131, 195);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(515, 3);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(131, 195);
            this.pictureBox8.TabIndex = 25;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(679, 3);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(131, 195);
            this.pictureBox9.TabIndex = 24;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Location = new System.Drawing.Point(828, 3);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(131, 195);
            this.pictureBox10.TabIndex = 23;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Location = new System.Drawing.Point(174, 3);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(131, 195);
            this.pictureBox11.TabIndex = 22;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Location = new System.Drawing.Point(11, 3);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(131, 195);
            this.pictureBox12.TabIndex = 21;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(828, 346);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(131, 195);
            this.pictureBox7.TabIndex = 20;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(0, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 50);
            this.pictureBox6.TabIndex = 27;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(11, 346);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(131, 195);
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(160, 346);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(131, 195);
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(333, 346);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(131, 195);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(497, 346);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 195);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.stickBtn);
            this.panel3.Controls.Add(this.hitBtn);
            this.panel3.Location = new System.Drawing.Point(3, 547);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(990, 65);
            this.panel3.TabIndex = 13;
            // 
            // stickBtn
            // 
            this.stickBtn.Location = new System.Drawing.Point(401, 12);
            this.stickBtn.Name = "stickBtn";
            this.stickBtn.Size = new System.Drawing.Size(382, 41);
            this.stickBtn.TabIndex = 1;
            this.stickBtn.Text = "Stick";
            this.stickBtn.UseVisualStyleBackColor = true;
            this.stickBtn.Click += new System.EventHandler(this.stickBtn_Click);
            // 
            // hitBtn
            // 
            this.hitBtn.Location = new System.Drawing.Point(7, 12);
            this.hitBtn.Name = "hitBtn";
            this.hitBtn.Size = new System.Drawing.Size(380, 41);
            this.hitBtn.TabIndex = 0;
            this.hitBtn.Text = "Hit";
            this.hitBtn.UseVisualStyleBackColor = true;
            this.hitBtn.Click += new System.EventHandler(this.hitBtn_Click);
            // 
            // dealBtn
            // 
            this.dealBtn.Location = new System.Drawing.Point(0, 0);
            this.dealBtn.Name = "dealBtn";
            this.dealBtn.Size = new System.Drawing.Size(75, 23);
            this.dealBtn.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.darkTheme);
            this.groupBox1.Controls.Add(this.lightTheme);
            this.groupBox1.Location = new System.Drawing.Point(789, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 59);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // lightTheme
            // 
            this.lightTheme.AutoSize = true;
            this.lightTheme.Location = new System.Drawing.Point(24, 9);
            this.lightTheme.Name = "lightTheme";
            this.lightTheme.Size = new System.Drawing.Size(118, 24);
            this.lightTheme.TabIndex = 0;
            this.lightTheme.TabStop = true;
            this.lightTheme.Text = "Light theme";
            this.lightTheme.UseVisualStyleBackColor = true;
            this.lightTheme.CheckedChanged += new System.EventHandler(this.lightTheme_CheckedChanged);
            // 
            // darkTheme
            // 
            this.darkTheme.AutoSize = true;
            this.darkTheme.Location = new System.Drawing.Point(24, 31);
            this.darkTheme.Name = "darkTheme";
            this.darkTheme.Size = new System.Drawing.Size(117, 24);
            this.darkTheme.TabIndex = 1;
            this.darkTheme.TabStop = true;
            this.darkTheme.Text = "Dark theme";
            this.darkTheme.UseVisualStyleBackColor = true;
            this.darkTheme.CheckedChanged += new System.EventHandler(this.darkTheme_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1026, 714);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "BlackJack Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.mainpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.winnerStage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button disconnectBtn;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox servText;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button stickBtn;
        private System.Windows.Forms.Button hitBtn;
        private System.Windows.Forms.Button dealBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox winnerStage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton darkTheme;
        private System.Windows.Forms.RadioButton lightTheme;
    }
}


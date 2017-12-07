namespace DataStructuresGui
{
    partial class dataStructUser
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
            this.startCalculation = new System.Windows.Forms.Button();
            this.inputSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sortRadio = new System.Windows.Forms.RadioButton();
            this.getRadio = new System.Windows.Forms.RadioButton();
            this.selectCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.startCalculation);
            this.panel1.Controls.Add(this.inputSize);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.selectCombo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 230);
            this.panel1.TabIndex = 0;
            // 
            // startCalculation
            // 
            this.startCalculation.Location = new System.Drawing.Point(395, 148);
            this.startCalculation.Name = "startCalculation";
            this.startCalculation.Size = new System.Drawing.Size(559, 67);
            this.startCalculation.TabIndex = 7;
            this.startCalculation.Text = "Start Calculation";
            this.startCalculation.UseVisualStyleBackColor = true;
            this.startCalculation.Click += new System.EventHandler(this.startCalculation_Click);
            // 
            // inputSize
            // 
            this.inputSize.Location = new System.Drawing.Point(112, 168);
            this.inputSize.Name = "inputSize";
            this.inputSize.Size = new System.Drawing.Size(277, 26);
            this.inputSize.TabIndex = 6;
            this.inputSize.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Input Size:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sortRadio);
            this.groupBox1.Controls.Add(this.getRadio);
            this.groupBox1.Location = new System.Drawing.Point(25, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(929, 83);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Perform Metrics on:";
            // 
            // sortRadio
            // 
            this.sortRadio.AutoSize = true;
            this.sortRadio.Location = new System.Drawing.Point(212, 38);
            this.sortRadio.Name = "sortRadio";
            this.sortRadio.Size = new System.Drawing.Size(64, 24);
            this.sortRadio.TabIndex = 3;
            this.sortRadio.TabStop = true;
            this.sortRadio.Text = "Sort";
            this.sortRadio.UseVisualStyleBackColor = true;
            // 
            // getRadio
            // 
            this.getRadio.AutoSize = true;
            this.getRadio.Location = new System.Drawing.Point(130, 38);
            this.getRadio.Name = "getRadio";
            this.getRadio.Size = new System.Drawing.Size(61, 24);
            this.getRadio.TabIndex = 2;
            this.getRadio.TabStop = true;
            this.getRadio.Text = "Get";
            this.getRadio.UseVisualStyleBackColor = true;
            // 
            // selectCombo
            // 
            this.selectCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectCombo.FormattingEnabled = true;
            this.selectCombo.Items.AddRange(new object[] {
            "Singly Linked List",
            "BinaryTree",
            "Hash Map"});
            this.selectCombo.Location = new System.Drawing.Point(196, 15);
            this.selectCombo.Name = "selectCombo";
            this.selectCombo.Size = new System.Drawing.Size(758, 28);
            this.selectCombo.TabIndex = 1;
            this.selectCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Structure Type:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(12, 248);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(957, 385);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "Summary of the Calculation:";
            // 
            // dataStructUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 645);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "dataStructUser";
            this.Text = "dataStructUser - Task3";
            this.Load += new System.EventHandler(this.dataStructUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox selectCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton sortRadio;
        private System.Windows.Forms.RadioButton getRadio;
        private System.Windows.Forms.Button startCalculation;
        private System.Windows.Forms.TextBox inputSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
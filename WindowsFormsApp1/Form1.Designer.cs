namespace WindowsFormsApp1
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
            this.cb_ranktype = new System.Windows.Forms.ComboBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.cb_Online = new System.Windows.Forms.ComboBox();
            this.lbTest = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cb_ranktype
            // 
            this.cb_ranktype.FormattingEnabled = true;
            this.cb_ranktype.Items.AddRange(new object[] {
            "Car Ranks",
            "Course Ranks"});
            this.cb_ranktype.Location = new System.Drawing.Point(140, 11);
            this.cb_ranktype.Name = "cb_ranktype";
            this.cb_ranktype.Size = new System.Drawing.Size(121, 20);
            this.cb_ranktype.TabIndex = 0;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(373, 9);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 1;
            this.btnWrite.Text = "write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // cb_Online
            // 
            this.cb_Online.FormattingEnabled = true;
            this.cb_Online.Items.AddRange(new object[] {
            "Online",
            "In-Store"});
            this.cb_Online.Location = new System.Drawing.Point(13, 11);
            this.cb_Online.Name = "cb_Online";
            this.cb_Online.Size = new System.Drawing.Size(121, 20);
            this.cb_Online.TabIndex = 2;
            // 
            // lbTest
            // 
            this.lbTest.AutoSize = true;
            this.lbTest.Location = new System.Drawing.Point(13, 93);
            this.lbTest.Name = "lbTest";
            this.lbTest.Size = new System.Drawing.Size(35, 12);
            this.lbTest.TabIndex = 3;
            this.lbTest.Text = "label1";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(267, 11);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 19);
            this.txtTime.TabIndex = 4;
            this.txtTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTime_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 117);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lbTest);
            this.Controls.Add(this.cb_Online);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.cb_ranktype);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_ranktype;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.ComboBox cb_Online;
        private System.Windows.Forms.Label lbTest;
        private System.Windows.Forms.TextBox txtTime;
    }
}


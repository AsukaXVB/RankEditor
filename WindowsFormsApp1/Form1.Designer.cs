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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cb_ranktype = new System.Windows.Forms.ComboBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.cb_Online = new System.Windows.Forms.ComboBox();
            this.lbTest = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.gvRank = new System.Windows.Forms.DataGridView();
            this.order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvRank)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_ranktype
            // 
            this.cb_ranktype.FormattingEnabled = true;
            this.cb_ranktype.Items.AddRange(new object[] {
            "Car Ranks",
            "Course Ranks"});
            this.cb_ranktype.Location = new System.Drawing.Point(140, 12);
            this.cb_ranktype.Name = "cb_ranktype";
            this.cb_ranktype.Size = new System.Drawing.Size(121, 21);
            this.cb_ranktype.TabIndex = 0;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(373, 10);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 25);
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
            this.cb_Online.Location = new System.Drawing.Point(13, 12);
            this.cb_Online.Name = "cb_Online";
            this.cb_Online.Size = new System.Drawing.Size(121, 21);
            this.cb_Online.TabIndex = 2;
            // 
            // lbTest
            // 
            this.lbTest.AutoSize = true;
            this.lbTest.Location = new System.Drawing.Point(11, 453);
            this.lbTest.Name = "lbTest";
            this.lbTest.Size = new System.Drawing.Size(0, 13);
            this.lbTest.TabIndex = 3;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(267, 12);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 20);
            this.txtTime.TabIndex = 4;
            this.txtTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTime_KeyPress);
            // 
            // gvRank
            // 
            this.gvRank.AllowUserToAddRows = false;
            this.gvRank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRank.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.order,
            this.name,
            this.time,
            this.car,
            this.area,
            this.date});
            this.gvRank.Location = new System.Drawing.Point(12, 41);
            this.gvRank.Name = "gvRank";
            this.gvRank.RowTemplate.Height = 21;
            this.gvRank.Size = new System.Drawing.Size(633, 320);
            this.gvRank.TabIndex = 5;
            // 
            // order
            // 
            this.order.HeaderText = "order";
            this.order.Name = "order";
            this.order.Width = 50;
            // 
            // name
            // 
            dataGridViewCellStyle1.NullValue = "ＳＥＧＡ";
            this.name.DefaultCellStyle = dataGridViewCellStyle1;
            this.name.HeaderText = "name";
            this.name.Name = "name";
            // 
            // time
            // 
            dataGridViewCellStyle2.NullValue = "6\'00\'\'000";
            this.time.DefaultCellStyle = dataGridViewCellStyle2;
            this.time.HeaderText = "time";
            this.time.Name = "time";
            this.time.Width = 50;
            // 
            // car
            // 
            dataGridViewCellStyle3.NullValue = "TRUENO GT-APEX (AE86)";
            this.car.DefaultCellStyle = dataGridViewCellStyle3;
            this.car.HeaderText = "car";
            this.car.Name = "car";
            this.car.Width = 220;
            // 
            // area
            // 
            dataGridViewCellStyle4.NullValue = "群馬";
            this.area.DefaultCellStyle = dataGridViewCellStyle4;
            this.area.HeaderText = "area";
            this.area.Name = "area";
            // 
            // date
            // 
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = "2014.01.01";
            this.date.DefaultCellStyle = dataGridViewCellStyle5;
            this.date.HeaderText = "date";
            this.date.Name = "date";
            this.date.Width = 70;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 476);
            this.Controls.Add(this.gvRank);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lbTest);
            this.Controls.Add(this.cb_Online);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.cb_ranktype);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvRank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_ranktype;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.ComboBox cb_Online;
        private System.Windows.Forms.Label lbTest;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.DataGridView gvRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn order;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn car;
        private System.Windows.Forms.DataGridViewTextBoxColumn area;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}


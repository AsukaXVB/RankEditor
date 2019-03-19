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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cb_ranktype = new System.Windows.Forms.ComboBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.cb_Online = new System.Windows.Forms.ComboBox();
            this.lbTest = new System.Windows.Forms.Label();
            this.gvRank = new System.Windows.Forms.DataGridView();
            this.order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_Course = new System.Windows.Forms.ComboBox();
            this.cb_Direction = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cb_maker = new System.Windows.Forms.ComboBox();
            this.cb_car = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvRank)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_ranktype
            // 
            this.cb_ranktype.FormattingEnabled = true;
            this.cb_ranktype.Items.AddRange(new object[] {
            "Car Ranks",
            "Course Ranks"});
            this.cb_ranktype.Location = new System.Drawing.Point(13, 12);
            this.cb_ranktype.Name = "cb_ranktype";
            this.cb_ranktype.Size = new System.Drawing.Size(121, 20);
            this.cb_ranktype.TabIndex = 0;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(571, 365);
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
            "In-Store",
            "Online"});
            this.cb_Online.Location = new System.Drawing.Point(13, 38);
            this.cb_Online.Name = "cb_Online";
            this.cb_Online.Size = new System.Drawing.Size(121, 20);
            this.cb_Online.TabIndex = 2;
            this.cb_Online.SelectedIndexChanged += new System.EventHandler(this.cb_Online_SelectedIndexChanged);
            // 
            // lbTest
            // 
            this.lbTest.AutoSize = true;
            this.lbTest.Location = new System.Drawing.Point(11, 418);
            this.lbTest.Name = "lbTest";
            this.lbTest.Size = new System.Drawing.Size(0, 12);
            this.lbTest.TabIndex = 3;
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
            this.gvRank.Location = new System.Drawing.Point(13, 64);
            this.gvRank.Name = "gvRank";
            this.gvRank.RowTemplate.Height = 21;
            this.gvRank.Size = new System.Drawing.Size(633, 295);
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
            dataGridViewCellStyle21.NullValue = "ＳＥＧＡ";
            this.name.DefaultCellStyle = dataGridViewCellStyle21;
            this.name.HeaderText = "name";
            this.name.Name = "name";
            // 
            // time
            // 
            dataGridViewCellStyle22.NullValue = "6\'00\'\'000";
            this.time.DefaultCellStyle = dataGridViewCellStyle22;
            this.time.HeaderText = "time";
            this.time.Name = "time";
            this.time.Width = 50;
            // 
            // car
            // 
            dataGridViewCellStyle23.NullValue = "TRUENO GT-APEX (AE86)";
            this.car.DefaultCellStyle = dataGridViewCellStyle23;
            this.car.HeaderText = "car";
            this.car.Name = "car";
            this.car.Width = 220;
            // 
            // area
            // 
            dataGridViewCellStyle24.NullValue = "群馬";
            this.area.DefaultCellStyle = dataGridViewCellStyle24;
            this.area.HeaderText = "area";
            this.area.Name = "area";
            // 
            // date
            // 
            dataGridViewCellStyle25.Format = "d";
            dataGridViewCellStyle25.NullValue = "2014.01.01";
            this.date.DefaultCellStyle = dataGridViewCellStyle25;
            this.date.HeaderText = "date";
            this.date.Name = "date";
            this.date.Width = 70;
            // 
            // cb_Course
            // 
            this.cb_Course.FormattingEnabled = true;
            this.cb_Course.Items.AddRange(new object[] {
            "Akina Lake",
            "Myogi",
            "Akagi",
            "Akina",
            "Irohazaka",
            "Tsukuba",
            "Happogahara",
            "Nagao",
            "Tsubaki",
            "Usui",
            "Sadamine",
            "Tsuchisaka",
            "Akina Snow",
            "Hakone",
            "Momiji",
            "Nanamagari"});
            this.cb_Course.Location = new System.Drawing.Point(140, 38);
            this.cb_Course.Name = "cb_Course";
            this.cb_Course.Size = new System.Drawing.Size(121, 20);
            this.cb_Course.TabIndex = 6;
            this.cb_Course.SelectedIndexChanged += new System.EventHandler(this.cb_Course_SelectedIndexChanged);
            // 
            // cb_Direction
            // 
            this.cb_Direction.FormattingEnabled = true;
            this.cb_Direction.Items.AddRange(new object[] {
            "Direction 1",
            "Direciont 2"});
            this.cb_Direction.Location = new System.Drawing.Point(267, 38);
            this.cb_Direction.Name = "cb_Direction";
            this.cb_Direction.Size = new System.Drawing.Size(100, 20);
            this.cb_Direction.TabIndex = 7;
            this.cb_Direction.SelectedIndexChanged += new System.EventHandler(this.cb_Direction_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 365);
            this.textBox1.MaxLength = 6;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 19);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(118, 365);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 19);
            this.textBox2.TabIndex = 9;
            // 
            // cb_maker
            // 
            this.cb_maker.FormattingEnabled = true;
            this.cb_maker.Items.AddRange(new object[] {
            "TOYOTA",
            "NISSAN",
            "HONDA",
            "MAZDA",
            "SUBARU",
            "MITSUBISHI",
            "SUZUKI",
            "INITIALD",
            "COMPLETE"});
            this.cb_maker.Location = new System.Drawing.Point(224, 365);
            this.cb_maker.Name = "cb_maker";
            this.cb_maker.Size = new System.Drawing.Size(121, 20);
            this.cb_maker.TabIndex = 10;
            this.cb_maker.SelectedIndexChanged += new System.EventHandler(this.cb_maker_SelectedIndexChanged);
            // 
            // cb_car
            // 
            this.cb_car.FormattingEnabled = true;
            this.cb_car.Location = new System.Drawing.Point(351, 365);
            this.cb_car.Name = "cb_car";
            this.cb_car.Size = new System.Drawing.Size(211, 20);
            this.cb_car.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(224, 391);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 19);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "北海道",
            "青森県",
            "岩手県",
            "宮城県",
            "福島県",
            "山形県",
            "秋田県",
            "茨城県",
            "栃木県",
            "群馬県",
            "千葉県",
            "埼玉県",
            "東京都",
            "神奈川県",
            "山梨県",
            "新潟県",
            "長野県",
            "富山県",
            "石川県",
            "愛知県",
            "静岡県",
            "岐阜県",
            "三重県",
            "福井県",
            "大阪府",
            "京都府",
            "奈良県",
            "滋賀県",
            "和歌山県",
            "兵庫県",
            "広島県",
            "鳥取県",
            "島根県",
            "岡山県",
            "山口県",
            "徳島県",
            "香川県",
            "愛媛県",
            "高知県",
            "福岡県",
            "佐賀県",
            "長崎県",
            "熊本県",
            "大分県",
            "宮崎県",
            "鹿児島県",
            "沖縄県",
            "China/Macau",
            "Hong Kong",
            "Korea",
            "Malaysia",
            "Singapore",
            "Taiwan",
            "Indonesia",
            "Philippine",
            "Thailand",
            "America",
            "* * *"});
            this.comboBox3.Location = new System.Drawing.Point(12, 392);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 20);
            this.comboBox3.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 439);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cb_car);
            this.Controls.Add(this.cb_maker);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cb_Direction);
            this.Controls.Add(this.cb_Course);
            this.Controls.Add(this.gvRank);
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
        private System.Windows.Forms.DataGridView gvRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn order;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn car;
        private System.Windows.Forms.DataGridViewTextBoxColumn area;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.ComboBox cb_Course;
        private System.Windows.Forms.ComboBox cb_Direction;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cb_maker;
        private System.Windows.Forms.ComboBox cb_car;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}


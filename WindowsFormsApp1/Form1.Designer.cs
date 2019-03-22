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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cb_ranktype = new System.Windows.Forms.ComboBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.cb_Online = new System.Windows.Forms.ComboBox();
            this.lbTest = new System.Windows.Forms.Label();
            this.gvRank = new System.Windows.Forms.DataGridView();
            this.cb_Course = new System.Windows.Forms.ComboBox();
            this.cb_Direction = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.cb_maker = new System.Windows.Forms.ComboBox();
            this.cb_car = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_maker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvRank)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_ranktype
            // 
            this.cb_ranktype.FormattingEnabled = true;
            this.cb_ranktype.Items.AddRange(new object[] {
            "Car Ranks",
            "Course Ranks"});
            this.cb_ranktype.Location = new System.Drawing.Point(13, 13);
            this.cb_ranktype.Name = "cb_ranktype";
            this.cb_ranktype.Size = new System.Drawing.Size(121, 21);
            this.cb_ranktype.TabIndex = 0;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(570, 365);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 25);
            this.btnWrite.TabIndex = 1;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // cb_Online
            // 
            this.cb_Online.FormattingEnabled = true;
            this.cb_Online.Items.AddRange(new object[] {
            "In-Store",
            "Online"});
            this.cb_Online.Location = new System.Drawing.Point(13, 41);
            this.cb_Online.Name = "cb_Online";
            this.cb_Online.Size = new System.Drawing.Size(121, 21);
            this.cb_Online.TabIndex = 2;
            this.cb_Online.SelectedIndexChanged += new System.EventHandler(this.cb_Online_SelectedIndexChanged);
            // 
            // lbTest
            // 
            this.lbTest.AutoSize = true;
            this.lbTest.Location = new System.Drawing.Point(10, 367);
            this.lbTest.Name = "lbTest";
            this.lbTest.Size = new System.Drawing.Size(0, 13);
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
            this.date,
            this.car_maker,
            this.car_id,
            this.areaID});
            this.gvRank.Location = new System.Drawing.Point(13, 69);
            this.gvRank.Name = "gvRank";
            this.gvRank.RowTemplate.Height = 21;
            this.gvRank.Size = new System.Drawing.Size(633, 234);
            this.gvRank.TabIndex = 5;
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
            this.cb_Course.Location = new System.Drawing.Point(140, 41);
            this.cb_Course.Name = "cb_Course";
            this.cb_Course.Size = new System.Drawing.Size(121, 21);
            this.cb_Course.TabIndex = 6;
            this.cb_Course.SelectedIndexChanged += new System.EventHandler(this.cb_Course_SelectedIndexChanged);
            // 
            // cb_Direction
            // 
            this.cb_Direction.FormattingEnabled = true;
            this.cb_Direction.Items.AddRange(new object[] {
            "Direction 1",
            "Direciont 2"});
            this.cb_Direction.Location = new System.Drawing.Point(267, 41);
            this.cb_Direction.Name = "cb_Direction";
            this.cb_Direction.Size = new System.Drawing.Size(100, 21);
            this.cb_Direction.TabIndex = 7;
            this.cb_Direction.SelectedIndexChanged += new System.EventHandler(this.cb_Direction_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(11, 309);
            this.txtName.MaxLength = 6;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 8;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(117, 309);
            this.txtTime.MaxLength = 9;
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 20);
            this.txtTime.TabIndex = 9;
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
            this.cb_maker.Location = new System.Drawing.Point(223, 309);
            this.cb_maker.Name = "cb_maker";
            this.cb_maker.Size = new System.Drawing.Size(121, 21);
            this.cb_maker.TabIndex = 10;
            this.cb_maker.SelectedIndexChanged += new System.EventHandler(this.cb_maker_SelectedIndexChanged);
            // 
            // cb_car
            // 
            this.cb_car.FormattingEnabled = true;
            this.cb_car.Location = new System.Drawing.Point(350, 309);
            this.cb_car.Name = "cb_car";
            this.cb_car.Size = new System.Drawing.Size(211, 21);
            this.cb_car.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(223, 338);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // cbArea
            // 
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Items.AddRange(new object[] {
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
            this.cbArea.Location = new System.Drawing.Point(11, 339);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(121, 21);
            this.cbArea.TabIndex = 13;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(570, 309);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // order
            // 
            this.order.HeaderText = "order";
            this.order.Name = "order";
            this.order.ReadOnly = true;
            this.order.Width = 50;
            // 
            // name
            // 
            dataGridViewCellStyle16.NullValue = "ＳＥＧＡ";
            this.name.DefaultCellStyle = dataGridViewCellStyle16;
            this.name.HeaderText = "name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // time
            // 
            dataGridViewCellStyle17.NullValue = "6\'00\'\'000";
            this.time.DefaultCellStyle = dataGridViewCellStyle17;
            this.time.HeaderText = "time";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.Width = 50;
            // 
            // car
            // 
            dataGridViewCellStyle18.NullValue = "TRUENO GT-APEX (AE86)";
            this.car.DefaultCellStyle = dataGridViewCellStyle18;
            this.car.HeaderText = "car";
            this.car.Name = "car";
            this.car.ReadOnly = true;
            this.car.Width = 220;
            // 
            // area
            // 
            dataGridViewCellStyle19.NullValue = "群馬";
            this.area.DefaultCellStyle = dataGridViewCellStyle19;
            this.area.HeaderText = "area";
            this.area.Name = "area";
            this.area.ReadOnly = true;
            // 
            // date
            // 
            dataGridViewCellStyle20.Format = "d";
            dataGridViewCellStyle20.NullValue = "2014.01.01";
            this.date.DefaultCellStyle = dataGridViewCellStyle20;
            this.date.HeaderText = "date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 70;
            // 
            // car_maker
            // 
            this.car_maker.HeaderText = "car_maker";
            this.car_maker.Name = "car_maker";
            this.car_maker.ReadOnly = true;
            this.car_maker.Visible = false;
            // 
            // car_id
            // 
            this.car_id.HeaderText = "car_id";
            this.car_id.Name = "car_id";
            this.car_id.ReadOnly = true;
            this.car_id.Visible = false;
            // 
            // areaID
            // 
            this.areaID.HeaderText = "areaID";
            this.areaID.Name = "areaID";
            this.areaID.ReadOnly = true;
            this.areaID.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 400);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cbArea);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cb_car);
            this.Controls.Add(this.cb_maker);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cb_Direction);
            this.Controls.Add(this.cb_Course);
            this.Controls.Add(this.gvRank);
            this.Controls.Add(this.lbTest);
            this.Controls.Add(this.cb_Online);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.cb_ranktype);
            this.Name = "Form1";
            this.Text = "Rank Editor for Initial D Arcade Stage 8";
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
        private System.Windows.Forms.ComboBox cb_Course;
        private System.Windows.Forms.ComboBox cb_Direction;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.ComboBox cb_maker;
        private System.Windows.Forms.ComboBox cb_car;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbArea;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn order;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn car;
        private System.Windows.Forms.DataGridViewTextBoxColumn area;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_maker;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaID;
    }
}


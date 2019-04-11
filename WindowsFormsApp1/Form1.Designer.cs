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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.car_maker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_Course = new System.Windows.Forms.ComboBox();
            this.cb_Direction = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.cb_maker = new System.Windows.Forms.ComboBox();
            this.cb_car = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvRank)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_ranktype
            // 
            resources.ApplyResources(this.cb_ranktype, "cb_ranktype");
            this.cb_ranktype.FormattingEnabled = true;
            this.cb_ranktype.Items.AddRange(new object[] {
            resources.GetString("cb_ranktype.Items"),
            resources.GetString("cb_ranktype.Items1")});
            this.cb_ranktype.Name = "cb_ranktype";
            // 
            // btnWrite
            // 
            resources.ApplyResources(this.btnWrite, "btnWrite");
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // cb_Online
            // 
            resources.ApplyResources(this.cb_Online, "cb_Online");
            this.cb_Online.FormattingEnabled = true;
            this.cb_Online.Items.AddRange(new object[] {
            resources.GetString("cb_Online.Items"),
            resources.GetString("cb_Online.Items1")});
            this.cb_Online.Name = "cb_Online";
            this.cb_Online.SelectedIndexChanged += new System.EventHandler(this.cb_Online_SelectedIndexChanged);
            // 
            // lbTest
            // 
            resources.ApplyResources(this.lbTest, "lbTest");
            this.lbTest.Name = "lbTest";
            // 
            // gvRank
            // 
            resources.ApplyResources(this.gvRank, "gvRank");
            this.gvRank.AllowUserToAddRows = false;
            this.gvRank.AllowUserToDeleteRows = false;
            this.gvRank.AllowUserToResizeColumns = false;
            this.gvRank.AllowUserToResizeRows = false;
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
            this.gvRank.MultiSelect = false;
            this.gvRank.Name = "gvRank";
            this.gvRank.RowHeadersVisible = false;
            this.gvRank.RowTemplate.Height = 21;
            // 
            // order
            // 
            resources.ApplyResources(this.order, "order");
            this.order.Name = "order";
            this.order.ReadOnly = true;
            // 
            // name
            // 
            dataGridViewCellStyle1.NullValue = "ＳＥＧＡ";
            this.name.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.name, "name");
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // time
            // 
            dataGridViewCellStyle2.NullValue = "6\'00\'\'000";
            this.time.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.time, "time");
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // car
            // 
            dataGridViewCellStyle3.NullValue = "TRUENO GT-APEX (AE86)";
            this.car.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.car, "car");
            this.car.Name = "car";
            this.car.ReadOnly = true;
            // 
            // area
            // 
            dataGridViewCellStyle4.NullValue = "群馬";
            this.area.DefaultCellStyle = dataGridViewCellStyle4;
            resources.ApplyResources(this.area, "area");
            this.area.Name = "area";
            this.area.ReadOnly = true;
            // 
            // date
            // 
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = "2014.01.01";
            this.date.DefaultCellStyle = dataGridViewCellStyle5;
            resources.ApplyResources(this.date, "date");
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // car_maker
            // 
            resources.ApplyResources(this.car_maker, "car_maker");
            this.car_maker.Name = "car_maker";
            this.car_maker.ReadOnly = true;
            // 
            // car_id
            // 
            resources.ApplyResources(this.car_id, "car_id");
            this.car_id.Name = "car_id";
            this.car_id.ReadOnly = true;
            // 
            // areaID
            // 
            resources.ApplyResources(this.areaID, "areaID");
            this.areaID.Name = "areaID";
            this.areaID.ReadOnly = true;
            // 
            // cb_Course
            // 
            resources.ApplyResources(this.cb_Course, "cb_Course");
            this.cb_Course.FormattingEnabled = true;
            this.cb_Course.Items.AddRange(new object[] {
            resources.GetString("cb_Course.Items"),
            resources.GetString("cb_Course.Items1"),
            resources.GetString("cb_Course.Items2"),
            resources.GetString("cb_Course.Items3"),
            resources.GetString("cb_Course.Items4"),
            resources.GetString("cb_Course.Items5"),
            resources.GetString("cb_Course.Items6"),
            resources.GetString("cb_Course.Items7"),
            resources.GetString("cb_Course.Items8"),
            resources.GetString("cb_Course.Items9"),
            resources.GetString("cb_Course.Items10"),
            resources.GetString("cb_Course.Items11"),
            resources.GetString("cb_Course.Items12"),
            resources.GetString("cb_Course.Items13"),
            resources.GetString("cb_Course.Items14"),
            resources.GetString("cb_Course.Items15")});
            this.cb_Course.Name = "cb_Course";
            this.cb_Course.SelectedIndexChanged += new System.EventHandler(this.cb_Course_SelectedIndexChanged);
            // 
            // cb_Direction
            // 
            resources.ApplyResources(this.cb_Direction, "cb_Direction");
            this.cb_Direction.FormattingEnabled = true;
            this.cb_Direction.Items.AddRange(new object[] {
            resources.GetString("cb_Direction.Items"),
            resources.GetString("cb_Direction.Items1")});
            this.cb_Direction.Name = "cb_Direction";
            this.cb_Direction.SelectedIndexChanged += new System.EventHandler(this.cb_Direction_SelectedIndexChanged);
            // 
            // txtName
            // 
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.Name = "txtName";
            // 
            // txtTime
            // 
            resources.ApplyResources(this.txtTime, "txtTime");
            this.txtTime.Name = "txtTime";
            // 
            // cb_maker
            // 
            resources.ApplyResources(this.cb_maker, "cb_maker");
            this.cb_maker.FormattingEnabled = true;
            this.cb_maker.Items.AddRange(new object[] {
            resources.GetString("cb_maker.Items"),
            resources.GetString("cb_maker.Items1"),
            resources.GetString("cb_maker.Items2"),
            resources.GetString("cb_maker.Items3"),
            resources.GetString("cb_maker.Items4"),
            resources.GetString("cb_maker.Items5"),
            resources.GetString("cb_maker.Items6"),
            resources.GetString("cb_maker.Items7"),
            resources.GetString("cb_maker.Items8")});
            this.cb_maker.Name = "cb_maker";
            this.cb_maker.SelectedIndexChanged += new System.EventHandler(this.cb_maker_SelectedIndexChanged);
            // 
            // cb_car
            // 
            resources.ApplyResources(this.cb_car, "cb_car");
            this.cb_car.FormattingEnabled = true;
            this.cb_car.Name = "cb_car";
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Name = "dateTimePicker1";
            // 
            // cbArea
            // 
            resources.ApplyResources(this.cbArea, "cbArea");
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Items.AddRange(new object[] {
            resources.GetString("cbArea.Items"),
            resources.GetString("cbArea.Items1"),
            resources.GetString("cbArea.Items2"),
            resources.GetString("cbArea.Items3"),
            resources.GetString("cbArea.Items4"),
            resources.GetString("cbArea.Items5"),
            resources.GetString("cbArea.Items6"),
            resources.GetString("cbArea.Items7"),
            resources.GetString("cbArea.Items8"),
            resources.GetString("cbArea.Items9"),
            resources.GetString("cbArea.Items10"),
            resources.GetString("cbArea.Items11"),
            resources.GetString("cbArea.Items12"),
            resources.GetString("cbArea.Items13"),
            resources.GetString("cbArea.Items14"),
            resources.GetString("cbArea.Items15"),
            resources.GetString("cbArea.Items16"),
            resources.GetString("cbArea.Items17"),
            resources.GetString("cbArea.Items18"),
            resources.GetString("cbArea.Items19"),
            resources.GetString("cbArea.Items20"),
            resources.GetString("cbArea.Items21"),
            resources.GetString("cbArea.Items22"),
            resources.GetString("cbArea.Items23"),
            resources.GetString("cbArea.Items24"),
            resources.GetString("cbArea.Items25"),
            resources.GetString("cbArea.Items26"),
            resources.GetString("cbArea.Items27"),
            resources.GetString("cbArea.Items28"),
            resources.GetString("cbArea.Items29"),
            resources.GetString("cbArea.Items30"),
            resources.GetString("cbArea.Items31"),
            resources.GetString("cbArea.Items32"),
            resources.GetString("cbArea.Items33"),
            resources.GetString("cbArea.Items34"),
            resources.GetString("cbArea.Items35"),
            resources.GetString("cbArea.Items36"),
            resources.GetString("cbArea.Items37"),
            resources.GetString("cbArea.Items38"),
            resources.GetString("cbArea.Items39"),
            resources.GetString("cbArea.Items40"),
            resources.GetString("cbArea.Items41"),
            resources.GetString("cbArea.Items42"),
            resources.GetString("cbArea.Items43"),
            resources.GetString("cbArea.Items44"),
            resources.GetString("cbArea.Items45"),
            resources.GetString("cbArea.Items46"),
            resources.GetString("cbArea.Items47"),
            resources.GetString("cbArea.Items48"),
            resources.GetString("cbArea.Items49"),
            resources.GetString("cbArea.Items50"),
            resources.GetString("cbArea.Items51"),
            resources.GetString("cbArea.Items52"),
            resources.GetString("cbArea.Items53"),
            resources.GetString("cbArea.Items54"),
            resources.GetString("cbArea.Items55"),
            resources.GetString("cbArea.Items56"),
            resources.GetString("cbArea.Items57")});
            this.cbArea.Name = "cbArea";
            // 
            // btnUpdate
            // 
            resources.ApplyResources(this.btnUpdate, "btnUpdate");
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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


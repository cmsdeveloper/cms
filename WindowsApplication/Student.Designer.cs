namespace WindowsFormsApplication1
{
    partial class Student
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stuidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stulnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stufnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stustandingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.standingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmsDataSet = new WindowsFormsApplication1.cmsDataSet();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new WindowsFormsApplication1.cmsDataSetTableAdapters.studentTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enrollstatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fkEnrollStudent1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.majcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.majorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.themareacodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkStudentMajorStudent1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.mincodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.minorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fkStudentMinorStudent1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enrollTableAdapter = new WindowsFormsApplication1.cmsDataSetTableAdapters.enrollTableAdapter();
            this.studentmajorTableAdapter = new WindowsFormsApplication1.cmsDataSetTableAdapters.studentmajorTableAdapter();
            this.studentminorTableAdapter = new WindowsFormsApplication1.cmsDataSetTableAdapters.studentminorTableAdapter();
            this.standingTableAdapter = new WindowsFormsApplication1.cmsDataSetTableAdapters.standingTableAdapter();
            this.courseTableAdapter = new WindowsFormsApplication1.cmsDataSetTableAdapters.courseTableAdapter();
            this.enrollstatusTableAdapter = new WindowsFormsApplication1.cmsDataSetTableAdapters.enrollstatusTableAdapter();
            this.majorTableAdapter = new WindowsFormsApplication1.cmsDataSetTableAdapters.majorTableAdapter();
            this.minorTableAdapter = new WindowsFormsApplication1.cmsDataSetTableAdapters.minorTableAdapter();
            this.button7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.crs_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crscodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.enrcompletedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollstatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkEnrollStudent1BindingSource)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.majorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkStudentMajorStudent1BindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkStudentMinorStudent1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Students";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stuidDataGridViewTextBoxColumn,
            this.stulnameDataGridViewTextBoxColumn,
            this.stufnameDataGridViewTextBoxColumn,
            this.stustandingDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(659, 187);
            this.dataGridView1.TabIndex = 2;
            // 
            // stuidDataGridViewTextBoxColumn
            // 
            this.stuidDataGridViewTextBoxColumn.DataPropertyName = "stu_id";
            this.stuidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.stuidDataGridViewTextBoxColumn.Name = "stuidDataGridViewTextBoxColumn";
            this.stuidDataGridViewTextBoxColumn.Width = 70;
            // 
            // stulnameDataGridViewTextBoxColumn
            // 
            this.stulnameDataGridViewTextBoxColumn.DataPropertyName = "stu_lname";
            this.stulnameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.stulnameDataGridViewTextBoxColumn.Name = "stulnameDataGridViewTextBoxColumn";
            this.stulnameDataGridViewTextBoxColumn.Width = 200;
            // 
            // stufnameDataGridViewTextBoxColumn
            // 
            this.stufnameDataGridViewTextBoxColumn.DataPropertyName = "stu_fname";
            this.stufnameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.stufnameDataGridViewTextBoxColumn.Name = "stufnameDataGridViewTextBoxColumn";
            this.stufnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // stustandingDataGridViewTextBoxColumn
            // 
            this.stustandingDataGridViewTextBoxColumn.DataPropertyName = "stu_standing";
            this.stustandingDataGridViewTextBoxColumn.DataSource = this.standingBindingSource;
            this.stustandingDataGridViewTextBoxColumn.DisplayMember = "std_name";
            this.stustandingDataGridViewTextBoxColumn.HeaderText = "Standing";
            this.stustandingDataGridViewTextBoxColumn.Name = "stustandingDataGridViewTextBoxColumn";
            this.stustandingDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stustandingDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.stustandingDataGridViewTextBoxColumn.ValueMember = "std_id";
            this.stustandingDataGridViewTextBoxColumn.Width = 150;
            // 
            // standingBindingSource
            // 
            this.standingBindingSource.DataMember = "standing";
            this.standingBindingSource.DataSource = this.cmsDataSet;
            // 
            // cmsDataSet
            // 
            this.cmsDataSet.DataSetName = "cmsDataSet";
            this.cmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.cmsDataSet;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(5, 234);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(69, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(678, 227);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.dataGridView4);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(670, 195);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "   Enrollment   ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(420, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "delete selected course";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.crs_code,
            this.crscodeDataGridViewTextBoxColumn,
            this.enrcompletedDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.fkEnrollStudent1BindingSource;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView4.Location = new System.Drawing.Point(3, 3);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(664, 160);
            this.dataGridView4.TabIndex = 0;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "course";
            this.courseBindingSource.DataSource = this.cmsDataSet;
            // 
            // enrollstatusBindingSource
            // 
            this.enrollstatusBindingSource.DataMember = "enrollstatus";
            this.enrollstatusBindingSource.DataSource = this.cmsDataSet;
            // 
            // fkEnrollStudent1BindingSource
            // 
            this.fkEnrollStudent1BindingSource.DataMember = "fk_Enroll_Student1";
            this.fkEnrollStudent1BindingSource.DataSource = this.studentBindingSource;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(670, 195);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "      Majors      ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(420, 170);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "delete selected major";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.majcodeDataGridViewTextBoxColumn,
            this.themareacodeDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.fkStudentMajorStudent1BindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.Size = new System.Drawing.Size(664, 160);
            this.dataGridView2.TabIndex = 0;
            // 
            // majcodeDataGridViewTextBoxColumn
            // 
            this.majcodeDataGridViewTextBoxColumn.DataPropertyName = "maj_code";
            this.majcodeDataGridViewTextBoxColumn.DataSource = this.majorBindingSource;
            this.majcodeDataGridViewTextBoxColumn.DisplayMember = "maj_title";
            this.majcodeDataGridViewTextBoxColumn.HeaderText = "Major";
            this.majcodeDataGridViewTextBoxColumn.Name = "majcodeDataGridViewTextBoxColumn";
            this.majcodeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.majcodeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.majcodeDataGridViewTextBoxColumn.ValueMember = "maj_code";
            this.majcodeDataGridViewTextBoxColumn.Width = 350;
            // 
            // majorBindingSource
            // 
            this.majorBindingSource.DataMember = "major";
            this.majorBindingSource.DataSource = this.cmsDataSet;
            // 
            // themareacodeDataGridViewTextBoxColumn
            // 
            this.themareacodeDataGridViewTextBoxColumn.DataPropertyName = "themarea_code";
            this.themareacodeDataGridViewTextBoxColumn.HeaderText = "Elective Area";
            this.themareacodeDataGridViewTextBoxColumn.Name = "themareacodeDataGridViewTextBoxColumn";
            this.themareacodeDataGridViewTextBoxColumn.Width = 200;
            // 
            // fkStudentMajorStudent1BindingSource
            // 
            this.fkStudentMajorStudent1BindingSource.DataMember = "fk_StudentMajor_Student1";
            this.fkStudentMajorStudent1BindingSource.DataSource = this.studentBindingSource;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.dataGridView3);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(670, 195);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "      Minors      ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(420, 170);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "delete selected minor";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mincodeDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.fkStudentMinorStudent1BindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView3.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView3.Size = new System.Drawing.Size(664, 161);
            this.dataGridView3.TabIndex = 0;
            // 
            // mincodeDataGridViewTextBoxColumn
            // 
            this.mincodeDataGridViewTextBoxColumn.DataPropertyName = "min_code";
            this.mincodeDataGridViewTextBoxColumn.DataSource = this.minorBindingSource;
            this.mincodeDataGridViewTextBoxColumn.DisplayMember = "min_title";
            this.mincodeDataGridViewTextBoxColumn.HeaderText = "Minor";
            this.mincodeDataGridViewTextBoxColumn.Name = "mincodeDataGridViewTextBoxColumn";
            this.mincodeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.mincodeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.mincodeDataGridViewTextBoxColumn.ValueMember = "min_code";
            this.mincodeDataGridViewTextBoxColumn.Width = 400;
            // 
            // minorBindingSource
            // 
            this.minorBindingSource.DataMember = "minor";
            this.minorBindingSource.DataSource = this.cmsDataSet;
            // 
            // fkStudentMinorStudent1BindingSource
            // 
            this.fkStudentMinorStudent1BindingSource.DataMember = "fk_StudentMinor_Student1";
            this.fkStudentMinorStudent1BindingSource.DataSource = this.studentBindingSource;
            // 
            // enrollTableAdapter
            // 
            this.enrollTableAdapter.ClearBeforeFill = true;
            // 
            // studentmajorTableAdapter
            // 
            this.studentmajorTableAdapter.ClearBeforeFill = true;
            // 
            // studentminorTableAdapter
            // 
            this.studentminorTableAdapter.ClearBeforeFill = true;
            // 
            // standingTableAdapter
            // 
            this.standingTableAdapter.ClearBeforeFill = true;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // enrollstatusTableAdapter
            // 
            this.enrollstatusTableAdapter.ClearBeforeFill = true;
            // 
            // majorTableAdapter
            // 
            this.majorTableAdapter.ClearBeforeFill = true;
            // 
            // minorTableAdapter
            // 
            this.minorTableAdapter.ClearBeforeFill = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(15, 432);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(150, 23);
            this.button7.TabIndex = 5;
            this.button7.Text = "delete selected student";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(576, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "save changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // crs_code
            // 
            this.crs_code.DataPropertyName = "crs_code";
            this.crs_code.HeaderText = "Code";
            this.crs_code.Name = "crs_code";
            this.crs_code.Width = 70;
            // 
            // crscodeDataGridViewTextBoxColumn
            // 
            this.crscodeDataGridViewTextBoxColumn.DataPropertyName = "crs_code";
            this.crscodeDataGridViewTextBoxColumn.DataSource = this.courseBindingSource;
            this.crscodeDataGridViewTextBoxColumn.DisplayMember = "crs_title";
            this.crscodeDataGridViewTextBoxColumn.HeaderText = "Course";
            this.crscodeDataGridViewTextBoxColumn.Name = "crscodeDataGridViewTextBoxColumn";
            this.crscodeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.crscodeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.crscodeDataGridViewTextBoxColumn.ValueMember = "crs_code";
            this.crscodeDataGridViewTextBoxColumn.Width = 350;
            // 
            // enrcompletedDataGridViewTextBoxColumn
            // 
            this.enrcompletedDataGridViewTextBoxColumn.DataPropertyName = "enr_completed";
            this.enrcompletedDataGridViewTextBoxColumn.DataSource = this.enrollstatusBindingSource;
            this.enrcompletedDataGridViewTextBoxColumn.DisplayMember = "est_title";
            this.enrcompletedDataGridViewTextBoxColumn.HeaderText = "Status";
            this.enrcompletedDataGridViewTextBoxColumn.Name = "enrcompletedDataGridViewTextBoxColumn";
            this.enrcompletedDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.enrcompletedDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.enrcompletedDataGridViewTextBoxColumn.ValueMember = "est_code";
            this.enrcompletedDataGridViewTextBoxColumn.Width = 150;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Student";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollstatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkEnrollStudent1BindingSource)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.majorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkStudentMajorStudent1BindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkStudentMinorStudent1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private cmsDataSet cmsDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private cmsDataSetTableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource fkEnrollStudent1BindingSource;
        private cmsDataSetTableAdapters.enrollTableAdapter enrollTableAdapter;
        private System.Windows.Forms.BindingSource fkStudentMajorStudent1BindingSource;
        private cmsDataSetTableAdapters.studentmajorTableAdapter studentmajorTableAdapter;
        private System.Windows.Forms.BindingSource fkStudentMinorStudent1BindingSource;
        private cmsDataSetTableAdapters.studentminorTableAdapter studentminorTableAdapter;
        private System.Windows.Forms.BindingSource standingBindingSource;
        private cmsDataSetTableAdapters.standingTableAdapter standingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stulnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stufnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn stustandingDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private cmsDataSetTableAdapters.courseTableAdapter courseTableAdapter;
        private System.Windows.Forms.BindingSource enrollstatusBindingSource;
        private cmsDataSetTableAdapters.enrollstatusTableAdapter enrollstatusTableAdapter;
        private System.Windows.Forms.BindingSource majorBindingSource;
        private cmsDataSetTableAdapters.majorTableAdapter majorTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn majcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn themareacodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource minorBindingSource;
        private cmsDataSetTableAdapters.minorTableAdapter minorTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn mincodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn crs_code;
        private System.Windows.Forms.DataGridViewComboBoxColumn crscodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn enrcompletedDataGridViewTextBoxColumn;
    }
}
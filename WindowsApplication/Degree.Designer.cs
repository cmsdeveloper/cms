namespace WindowsFormsApplication1
{
    partial class Degree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Degree));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.majorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmsDataSet = new WindowsFormsApplication1.cmsDataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.minorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.majorTableAdapter = new WindowsFormsApplication1.cmsDataSetTableAdapters.majorTableAdapter();
            this.minorTableAdapter = new WindowsFormsApplication1.cmsDataSetTableAdapters.minorTableAdapter();
            this.schoolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolTableAdapter = new WindowsFormsApplication1.cmsDataSetTableAdapters.schoolTableAdapter();
            this.majcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majtitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.majthemarearequiredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mincodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mintitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schcodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.majorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmsDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Degrees";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(574, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "save changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(13, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(138, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(659, 325);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(651, 293);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Majors";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.majcodeDataGridViewTextBoxColumn,
            this.majtitleDataGridViewTextBoxColumn,
            this.schcodeDataGridViewTextBoxColumn,
            this.majthemarearequiredDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.majorBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(645, 247);
            this.dataGridView1.TabIndex = 0;
            // 
            // majorBindingSource
            // 
            this.majorBindingSource.DataMember = "major";
            this.majorBindingSource.DataSource = this.cmsDataSet;
            // 
            // cmsDataSet
            // 
            this.cmsDataSet.DataSetName = "cmsDataSet";
            this.cmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(651, 293);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Minors";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mincodeDataGridViewTextBoxColumn,
            this.mintitleDataGridViewTextBoxColumn,
            this.schcodeDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.minorBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(645, 247);
            this.dataGridView2.TabIndex = 0;
            // 
            // minorBindingSource
            // 
            this.minorBindingSource.DataMember = "minor";
            this.minorBindingSource.DataSource = this.cmsDataSet;
            // 
            // majorTableAdapter
            // 
            this.majorTableAdapter.ClearBeforeFill = true;
            // 
            // minorTableAdapter
            // 
            this.minorTableAdapter.ClearBeforeFill = true;
            // 
            // schoolBindingSource
            // 
            this.schoolBindingSource.DataMember = "school";
            this.schoolBindingSource.DataSource = this.cmsDataSet;
            // 
            // schoolTableAdapter
            // 
            this.schoolTableAdapter.ClearBeforeFill = true;
            // 
            // majcodeDataGridViewTextBoxColumn
            // 
            this.majcodeDataGridViewTextBoxColumn.DataPropertyName = "maj_code";
            this.majcodeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.majcodeDataGridViewTextBoxColumn.Name = "majcodeDataGridViewTextBoxColumn";
            this.majcodeDataGridViewTextBoxColumn.Width = 50;
            // 
            // majtitleDataGridViewTextBoxColumn
            // 
            this.majtitleDataGridViewTextBoxColumn.DataPropertyName = "maj_title";
            this.majtitleDataGridViewTextBoxColumn.HeaderText = "Major";
            this.majtitleDataGridViewTextBoxColumn.Name = "majtitleDataGridViewTextBoxColumn";
            this.majtitleDataGridViewTextBoxColumn.Width = 260;
            // 
            // schcodeDataGridViewTextBoxColumn
            // 
            this.schcodeDataGridViewTextBoxColumn.DataPropertyName = "sch_code";
            this.schcodeDataGridViewTextBoxColumn.DataSource = this.schoolBindingSource;
            this.schcodeDataGridViewTextBoxColumn.DisplayMember = "sch_name";
            this.schcodeDataGridViewTextBoxColumn.HeaderText = "School";
            this.schcodeDataGridViewTextBoxColumn.Name = "schcodeDataGridViewTextBoxColumn";
            this.schcodeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.schcodeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.schcodeDataGridViewTextBoxColumn.ValueMember = "sch_code";
            this.schcodeDataGridViewTextBoxColumn.Width = 230;
            // 
            // majthemarearequiredDataGridViewTextBoxColumn
            // 
            this.majthemarearequiredDataGridViewTextBoxColumn.DataPropertyName = "maj_themarea_required";
            this.majthemarearequiredDataGridViewTextBoxColumn.HeaderText = "Thematic Area Req";
            this.majthemarearequiredDataGridViewTextBoxColumn.Name = "majthemarearequiredDataGridViewTextBoxColumn";
            this.majthemarearequiredDataGridViewTextBoxColumn.Width = 60;
            // 
            // mincodeDataGridViewTextBoxColumn
            // 
            this.mincodeDataGridViewTextBoxColumn.DataPropertyName = "min_code";
            this.mincodeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.mincodeDataGridViewTextBoxColumn.Name = "mincodeDataGridViewTextBoxColumn";
            this.mincodeDataGridViewTextBoxColumn.Width = 50;
            // 
            // mintitleDataGridViewTextBoxColumn
            // 
            this.mintitleDataGridViewTextBoxColumn.DataPropertyName = "min_title";
            this.mintitleDataGridViewTextBoxColumn.HeaderText = "Minor";
            this.mintitleDataGridViewTextBoxColumn.Name = "mintitleDataGridViewTextBoxColumn";
            this.mintitleDataGridViewTextBoxColumn.Width = 260;
            // 
            // schcodeDataGridViewTextBoxColumn1
            // 
            this.schcodeDataGridViewTextBoxColumn1.DataPropertyName = "sch_code";
            this.schcodeDataGridViewTextBoxColumn1.DataSource = this.schoolBindingSource;
            this.schcodeDataGridViewTextBoxColumn1.DisplayMember = "sch_name";
            this.schcodeDataGridViewTextBoxColumn1.HeaderText = "School";
            this.schcodeDataGridViewTextBoxColumn1.Name = "schcodeDataGridViewTextBoxColumn1";
            this.schcodeDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.schcodeDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.schcodeDataGridViewTextBoxColumn1.ValueMember = "sch_code";
            this.schcodeDataGridViewTextBoxColumn1.Width = 230;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(415, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "delete selected major";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(415, 263);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "delete selected minor";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Degree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 362);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Degree";
            this.Text = "Degree";
            this.Load += new System.EventHandler(this.Degree_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.majorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmsDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private cmsDataSet cmsDataSet;
        private System.Windows.Forms.BindingSource majorBindingSource;
        private cmsDataSetTableAdapters.majorTableAdapter majorTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource minorBindingSource;
        private cmsDataSetTableAdapters.minorTableAdapter minorTableAdapter;
        private System.Windows.Forms.BindingSource schoolBindingSource;
        private cmsDataSetTableAdapters.schoolTableAdapter schoolTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn majcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn majtitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn schcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn majthemarearequiredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mincodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mintitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn schcodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}
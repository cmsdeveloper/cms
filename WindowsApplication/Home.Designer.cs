namespace WindowsFormsApplication1
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_student = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.button_courses = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_degrees = new System.Windows.Forms.Button();
            this.button_schools = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the CMS Administration Tool";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(618, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "This application allows you to retrieve, insert, update and delete all relevant d" +
    "ata concerning the Curriculum Management System. \r\nPlease select the data you wo" +
    "uld like to access below.";
            // 
            // button_student
            // 
            this.button_student.Location = new System.Drawing.Point(89, 183);
            this.button_student.Name = "button_student";
            this.button_student.Size = new System.Drawing.Size(158, 23);
            this.button_student.TabIndex = 2;
            this.button_student.Text = "Student Relevant Data";
            this.button_student.UseVisualStyleBackColor = true;
            this.button_student.Click += new System.EventHandler(this.button_student_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Click here to edit data regarding students\'\r\ncourses, majors and minors.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(684, 362);
            this.shapeContainer1.TabIndex = 4;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 344;
            this.lineShape1.X2 = 344;
            this.lineShape1.Y1 = 330;
            this.lineShape1.Y2 = 127;
            // 
            // button_courses
            // 
            this.button_courses.Location = new System.Drawing.Point(482, 159);
            this.button_courses.Name = "button_courses";
            this.button_courses.Size = new System.Drawing.Size(75, 23);
            this.button_courses.TabIndex = 6;
            this.button_courses.Text = "Courses";
            this.button_courses.UseVisualStyleBackColor = true;
            this.button_courses.Click += new System.EventHandler(this.button_courses_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(86, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Student Relevant Data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(449, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Administrative Data";
            // 
            // button_degrees
            // 
            this.button_degrees.Location = new System.Drawing.Point(482, 209);
            this.button_degrees.Name = "button_degrees";
            this.button_degrees.Size = new System.Drawing.Size(75, 23);
            this.button_degrees.TabIndex = 9;
            this.button_degrees.Text = "Degrees";
            this.button_degrees.UseVisualStyleBackColor = true;
            this.button_degrees.Click += new System.EventHandler(this.button_degrees_Click);
            // 
            // button_schools
            // 
            this.button_schools.Location = new System.Drawing.Point(482, 258);
            this.button_schools.Name = "button_schools";
            this.button_schools.Size = new System.Drawing.Size(75, 23);
            this.button_schools.TabIndex = 10;
            this.button_schools.Text = "Schools";
            this.button_schools.UseVisualStyleBackColor = true;
            this.button_schools.Click += new System.EventHandler(this.button_schools_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 362);
            this.Controls.Add(this.button_schools);
            this.Controls.Add(this.button_degrees);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_courses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_student);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_student;
        private System.Windows.Forms.Label label3;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button button_courses;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_degrees;
        private System.Windows.Forms.Button button_schools;
    }
}
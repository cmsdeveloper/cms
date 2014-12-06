using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button_student_Click(object sender, EventArgs e)
        {
            Form student = new Student();
            student.Show();
        }

        private void button_schools_Click(object sender, EventArgs e)
        {
            Form school = new School();
            school.Show();
        }

        private void button_degrees_Click(object sender, EventArgs e)
        {
            Form degree = new Degree();
            degree.Show();
        }

        private void button_courses_Click(object sender, EventArgs e)
        {
            Form course = new Course();
            course.Show();
        }
    }
}

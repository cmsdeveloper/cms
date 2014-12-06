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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cmsDataSet.minor' table. You can move, or remove it, as needed.
            this.minorTableAdapter.Fill(this.cmsDataSet.minor);
            // TODO: This line of code loads data into the 'cmsDataSet.major' table. You can move, or remove it, as needed.
            this.majorTableAdapter.Fill(this.cmsDataSet.major);
            // TODO: This line of code loads data into the 'cmsDataSet.enrollstatus' table. You can move, or remove it, as needed.
            this.enrollstatusTableAdapter.Fill(this.cmsDataSet.enrollstatus);
            // TODO: This line of code loads data into the 'cmsDataSet.course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.cmsDataSet.course);
            // TODO: This line of code loads data into the 'cmsDataSet.standing' table. You can move, or remove it, as needed.
            this.standingTableAdapter.Fill(this.cmsDataSet.standing);
            // TODO: This line of code loads data into the 'cmsDataSet.studentminor' table. You can move, or remove it, as needed.
            this.studentminorTableAdapter.Fill(this.cmsDataSet.studentminor);
            // TODO: This line of code loads data into the 'cmsDataSet.studentmajor' table. You can move, or remove it, as needed.
            this.studentmajorTableAdapter.Fill(this.cmsDataSet.studentmajor);
            // TODO: This line of code loads data into the 'cmsDataSet.enroll' table. You can move, or remove it, as needed.
            this.enrollTableAdapter.Fill(this.cmsDataSet.enroll);
            // TODO: This line of code loads data into the 'cmsDataSet.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.cmsDataSet.student);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView4.Rows.Remove(dataGridView4.CurrentRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView3.Rows.Remove(dataGridView3.CurrentRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.studentTableAdapter.Update(this.cmsDataSet.student);
                this.enrollTableAdapter.Update(this.cmsDataSet.enroll);
                this.studentmajorTableAdapter.Update(this.cmsDataSet.studentmajor);
                this.studentminorTableAdapter.Update(this.cmsDataSet.studentminor);
                MessageBox.Show("Database successfully updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

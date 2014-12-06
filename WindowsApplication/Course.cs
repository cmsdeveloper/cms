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
    public partial class Course : Form
    {
        public Course()
        {
            InitializeComponent();
        }

        private void Course_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cmsDataSet.standing' table. You can move, or remove it, as needed.
            this.standingTableAdapter.Fill(this.cmsDataSet.standing);
            // TODO: This line of code loads data into the 'cmsDataSet.courseequivalent' table. You can move, or remove it, as needed.
            this.courseequivalentTableAdapter.Fill(this.cmsDataSet.courseequivalent);
            // TODO: This line of code loads data into the 'cmsDataSet.coursecorequisite' table. You can move, or remove it, as needed.
            this.coursecorequisiteTableAdapter.Fill(this.cmsDataSet.coursecorequisite);
            // TODO: This line of code loads data into the 'cmsDataSet.otherprerequisite' table. You can move, or remove it, as needed.
            this.otherprerequisiteTableAdapter.Fill(this.cmsDataSet.otherprerequisite);
            // TODO: This line of code loads data into the 'cmsDataSet.standingprerequisite' table. You can move, or remove it, as needed.
            this.standingprerequisiteTableAdapter.Fill(this.cmsDataSet.standingprerequisite);
            // TODO: This line of code loads data into the 'cmsDataSet.courseprerequisite' table. You can move, or remove it, as needed.
            this.courseprerequisiteTableAdapter.Fill(this.cmsDataSet.courseprerequisite);
            // TODO: This line of code loads data into the 'cmsDataSet.course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.cmsDataSet.course);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.courseTableAdapter.Update(this.cmsDataSet.course);
                this.courseprerequisiteTableAdapter.Update(this.cmsDataSet.courseprerequisite);
                this.standingprerequisiteTableAdapter.Update(this.cmsDataSet.standingprerequisite);
                this.otherprerequisiteTableAdapter.Update(this.cmsDataSet.otherprerequisite);
                this.coursecorequisiteTableAdapter.Update(this.cmsDataSet.coursecorequisite);
                this.courseequivalentTableAdapter.Update(this.cmsDataSet.courseequivalent);
                MessageBox.Show("Database successfully updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView5.Rows.Remove(dataGridView5.CurrentRow);
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
                dataGridView6.Rows.Remove(dataGridView6.CurrentRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

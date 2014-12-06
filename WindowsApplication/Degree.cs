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
    public partial class Degree : Form
    {
        public Degree()
        {
            InitializeComponent();
        }

        private void Degree_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cmsDataSet.school' table. You can move, or remove it, as needed.
            this.schoolTableAdapter.Fill(this.cmsDataSet.school);
            // TODO: This line of code loads data into the 'cmsDataSet.minor' table. You can move, or remove it, as needed.
            this.minorTableAdapter.Fill(this.cmsDataSet.minor);
            // TODO: This line of code loads data into the 'cmsDataSet.major' table. You can move, or remove it, as needed.
            this.majorTableAdapter.Fill(this.cmsDataSet.major);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.majorTableAdapter.Update(this.cmsDataSet.major);
                this.minorTableAdapter.Update(this.cmsDataSet.minor);
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
    }
}

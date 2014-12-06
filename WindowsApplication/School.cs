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
    public partial class School : Form
    {
        public School()
        {
            InitializeComponent();
        }

        private void School_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cmsDataSet.school' table. You can move, or remove it, as needed.
            this.schoolTableAdapter.Fill(this.cmsDataSet.school);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.schoolTableAdapter.Update(this.cmsDataSet.school);
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
    }
}

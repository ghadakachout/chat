using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetChatBot
{
    public partial class Responses : Form
    {
        public Responses()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this record ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK) ;
            {
                tbllogBindingSource.RemoveCurrent();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Responses_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'questionDBDataSet.tbllog'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.tbllogTableAdapter.Fill(this.questionDBDataSet.tbllog);
            Edit(false);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Edit(bool value)
        {
            textBox1.Enabled=value;
            textBox2.Enabled = value;
            textBox3.Enabled = value;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true);
                questionDBDataSet.tbllog.AddtbllogRow(questionDBDataSet.tbllog.NewtbllogRow());
                tbllogBindingSource.MoveLast();
                textBox1.Focus();
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                questionDBDataSet.tbllog.RejectChanges();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Edit(true);
            textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false);
                tbllogBindingSource.EndEdit();
                tbllogTableAdapter.Update(questionDBDataSet.tbllog);
                dataGridView1.Refresh();
                textBox1.Focus();
                MessageBox.Show("Your data has been successfully saved ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                questionDBDataSet.tbllog.RejectChanges();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

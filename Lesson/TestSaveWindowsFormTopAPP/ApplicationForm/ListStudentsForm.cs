using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationForm
{
    public partial class ListStudentsForm : Form
    {
        private SaveStudentsClass students = new SaveStudentsClass();
        public ListStudentsForm()
        {
            InitializeComponent();
            SaveDataGridView();
        }


        private void SaveDataGridView()
        {
            foreach (var el in students.studentClasses)
            {
                dataGridView1.Rows.Add(el.Id, el.Name, el.Phone, el.Gender);
            }
        }
        private void ListStudentsForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

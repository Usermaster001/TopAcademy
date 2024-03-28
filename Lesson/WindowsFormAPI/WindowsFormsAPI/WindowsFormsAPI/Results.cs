using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAPI
{
    public partial class Results : Form
    {
        public Results(Response response)
        {
            InitializeComponent();

            foreach (var el in response.Suggestions)
            {
                dataGridView1.Rows.Add(el.value);
            }
        }

        private void Results_Load(object sender, EventArgs e)
        {

        }
    }
}

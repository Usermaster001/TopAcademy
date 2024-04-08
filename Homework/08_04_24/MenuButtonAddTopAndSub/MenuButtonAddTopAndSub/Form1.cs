using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MenuButtonAddTopAndSub
{
    public partial class Form1 : Form
    {
        private List<ToolStripMenuItem> toolStripMenuItems = new List<ToolStripMenuItem>();
        public Form1()
        {
            InitializeComponent();
        }

        // добавление главного меню
        private void button1_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem fileItem = new ToolStripMenuItem(textBox1.Text);

            toolStripMenuItems.Add(fileItem);

            menuStrip1.Items.Add(fileItem);
        }

        // добавление подглавного меню
        private void button2_Click(object sender, EventArgs e)
        {
            if (toolStripMenuItems.Count > 0)
            {
                ToolStripMenuItem newItem = new ToolStripMenuItem(textBox2.Text);

                toolStripMenuItems[toolStripMenuItems.Count - 1].DropDownItems.Add(newItem);
            }
        }
    }
}

using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace Conductor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ViewDrives();
        }

        // Показ всех дисков
        public void ViewDrives()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();

            listBox1.Items.Clear();
            textBox1.Text = "";

            foreach (DriveInfo drive in drives)
            {
                listBox1.Items.Add(drive.Name);
            }
        }

        // загрузка папок и файлов, кнопка перейти в директорию
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            DirectoryInfo directoryInfo = new DirectoryInfo(textBox1.Text);
            DirectoryInfo[] directoryInfos = directoryInfo.GetDirectories();

            foreach(DirectoryInfo el in directoryInfos)
            {
                listBox1.Items.Add(el);
            }

            FileInfo[] fileInfos = directoryInfo.GetFiles();

            foreach (FileInfo el in fileInfos)
            {
                listBox1.Items.Add(el);
            }
        }


        // двойной щелчок по элементу listbox
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Path.GetExtension(Path.Combine(textBox1.Text, listBox1.SelectedItem.ToString())) == "")
            {

                textBox1.Text = Path.Combine(textBox1.Text, listBox1.SelectedItem.ToString());

                listBox1.Items.Clear();

                DirectoryInfo directoryInfo = new DirectoryInfo(textBox1.Text);
                DirectoryInfo[] directoryInfos = directoryInfo.GetDirectories();

                foreach (DirectoryInfo el in directoryInfos)
                {
                    listBox1.Items.Add(el);
                }

                FileInfo[] fileInfos = directoryInfo.GetFiles();

                foreach (FileInfo el in fileInfos)
                {
                    listBox1.Items.Add(el);
                }
            }
            else
            {
                Process.Start(Path.Combine(textBox1.Text, listBox1.SelectedItem.ToString()));
            }
        }
        

        // загрузка папок и файлов, кнопка назад
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 3)
            {
                if (textBox1.Text[textBox1.Text.Length - 1] == '\\')
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                }

                while (textBox1.Text[textBox1.Text.Length - 1] != '\\')
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                }

                listBox1.Items.Clear();

                DirectoryInfo directoryInfo = new DirectoryInfo(textBox1.Text);
                DirectoryInfo[] directoryInfos = directoryInfo.GetDirectories();

                foreach (DirectoryInfo el in directoryInfos)
                {
                    listBox1.Items.Add(el);
                }

                FileInfo[] fileInfos = directoryInfo.GetFiles();

                foreach (FileInfo el in fileInfos)
                {
                    listBox1.Items.Add(el);
                }
            }
            else
            {
                ViewDrives();
            }
        }
    }
}

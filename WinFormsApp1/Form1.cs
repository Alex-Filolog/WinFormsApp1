using System.Security.Cryptography;
using System.Text.Json;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        string path = "C:\\";

        public MainForm()
        {
            InitializeComponent();

        }

        private void OpenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt|*.txt|rtf|*.rtf|*.*|*.*";

            ofd.InitialDirectory = path;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (Path.GetExtension(ofd.FileName) == ".rtf")
                    {
                        OpenRichTextBox.LoadFile(ofd.FileName, RichTextBoxStreamType.RichText);
                    }

                    if (Path.GetExtension(ofd.FileName) == ".txt")
                    {
                        OpenRichTextBox.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);
                    }
                    

                    MessageBox.Show("Файл открыт");
                }
                catch (JsonException ex)
                {
                    MessageBox.Show("Ошибка txt", "Ошибка");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка");
                }
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {


            SaveFileDialog.InitialDirectory = path;
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {

                if (Path.GetExtension(SaveFileDialog.FileName) == ".rtf")
                {
                    OpenRichTextBox.SaveFile(SaveFileDialog.FileName, RichTextBoxStreamType.RichText);
                }

                if (Path.GetExtension(SaveFileDialog.FileName) == ".txt")
                {
                    OpenRichTextBox.SaveFile(SaveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                }




            }
        }

        private void ColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                OpenRichTextBox.SelectionColor = ColorDialog.Color;
            }
        }

        private void ShriftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FontDialog.ShowDialog() == DialogResult.OK)
            {
                OpenRichTextBox.SelectionFont = FontDialog.Font;
            }
        }

        private void PapkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                path = FolderBrowserDialog.SelectedPath;
            }
        }
        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenRichTextBox.Clear();
            this.Text = "Безымянный";
        }

        private void NotchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (NotchToolStripMenuItem.Checked != true)
            {
                NotchToolStripMenuItem.Checked = true;
                OpenRichTextBox.BackColor = Color.Black;
                OpenRichTextBox.ForeColor = Color.White;
            }
            else
            {
                NotchToolStripMenuItem.Checked = false;
                OpenRichTextBox.BackColor = Color.White;
                OpenRichTextBox.ForeColor = Color.Black;
            }
        }

        private void DrugayaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 from = new Form2();

            this.Hide();

            from.ShowDialog();

            this.Show();
        }

        private void LeftToolStripButton_Click(object sender, EventArgs e)
        {
            OpenRichTextBox.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void CentrToolStripButton_Click(object sender, EventArgs e)
        {
            OpenRichTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void RightToolStripButton_Click(object sender, EventArgs e)
        {
            OpenRichTextBox.SelectionAlignment = HorizontalAlignment.Right;
        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            TimeStatusLabel.Text = $"{DateTime.Now}";
            MainTimer.Start();

            foreach (var item in FontFamily.Families)
            {
                ShriftToolStripButton.Items.Add(item.Name);
            }

        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            TimeStatusLabel.Text = $"{DateTime.Now}";
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainTimer.Stop();
        }

        private void OpenRichTextBox_TextChanged(object sender, EventArgs e)
        {
            SimvolToolLabel.Text = $"Кол-во символов: {OpenRichTextBox.Text.Length}";
            int sum = 0;
            foreach (var ch in OpenRichTextBox.Text)
            {
                if (ch == ' ') { }
                else
                {
                    sum++;
                }

            }
            BezProbSimvolToolLabel.Text = $"Кол-во символов(без пробела): {sum}";
        }

        private void Color1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                OpenRichTextBox.SelectionColor = ColorDialog.Color;
            }
        }

        private void Shrift1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FontDialog.ShowDialog() == DialogResult.OK)
            {
                OpenRichTextBox.SelectionFont = FontDialog.Font;
            }
        }

        private void ShriftToolStripButton_Click(object sender, EventArgs e)
        {

            OpenRichTextBox.SelectionFont = new Font(ShriftToolStripButton.Text, OpenRichTextBox.SelectionFont.Size);

        }
    }
}
//Zadanie2 from = new Zadanie2();

//this.Hide();

//from.ShowDialog();

//this.Show();
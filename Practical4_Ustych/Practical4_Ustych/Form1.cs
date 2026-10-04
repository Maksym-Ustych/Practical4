namespace Practical4_Ustych
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void відкритиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter =
    "txt files (*.txt)|*.txt|rtf files (*.rtf)|*.rtf|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.Text.Encoding kod =
                    System.Text.Encoding.GetEncoding("utf-8");

                System.IO.StreamReader read =
                    new System.IO.StreamReader(openFileDialog1.FileName, kod);

                richTextBox1.Text = read.ReadToEnd();
                read.Close();

                this.Text = "Текстовий редактор - " + openFileDialog1.FileName;
            }
        }

        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = openFileDialog1.FileName;
            saveFileDialog1.Filter =
                "txt files (*.txt)|*.txt|rtf files (*.rtf)|*.rtf|All files (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter write =
                    new System.IO.StreamWriter(
                        saveFileDialog1.FileName,
                        false,
                        System.Text.Encoding.GetEncoding("utf-8")
                    );

                write.Write(richTextBox1.Text);
                write.Close();

                richTextBox1.Modified = false;
            }
        }

        private void друкToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void копіюватиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Копіювати
            richTextBox1.Copy();
        }

        private void вирізатиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Вирізати
            richTextBox1.Cut();
        }

        private void вставитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Вставити
            richTextBox1.Paste();
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
    "Текстовий редактор\nРозробник: Устич Максим\nГрупа: alk-43",
    "Про програму",
    MessageBoxButtons.OK,
    MessageBoxIcon.Information
);
        }

        private void копіюватиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Копіювати
            richTextBox1.Copy();
        }

        private void вирізатиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Вирізати
            richTextBox1.Cut();
        }

        private void вставитиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Вставити
            richTextBox1.Paste();
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.SelectionFont = fontDialog1.Font;
        }
    }
}

namespace Practical4_Ustych
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            richTextBox1 = new RichTextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            копіюватиToolStripMenuItem1 = new ToolStripMenuItem();
            вирізатиToolStripMenuItem1 = new ToolStripMenuItem();
            вставитиToolStripMenuItem1 = new ToolStripMenuItem();
            шрифтToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            відкритиToolStripMenuItem = new ToolStripMenuItem();
            зберегтиToolStripMenuItem = new ToolStripMenuItem();
            друкToolStripMenuItem = new ToolStripMenuItem();
            вихідToolStripMenuItem = new ToolStripMenuItem();
            правкаToolStripMenuItem = new ToolStripMenuItem();
            копіюватиToolStripMenuItem = new ToolStripMenuItem();
            вирізатиToolStripMenuItem = new ToolStripMenuItem();
            вставитиToolStripMenuItem = new ToolStripMenuItem();
            довідкаToolStripMenuItem = new ToolStripMenuItem();
            проПрограмуToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            fontDialog1 = new FontDialog();
            printDialog1 = new PrintDialog();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.ContextMenuStrip = contextMenuStrip1;
            richTextBox1.Location = new Point(12, 105);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(707, 326);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { копіюватиToolStripMenuItem1, вирізатиToolStripMenuItem1, вставитиToolStripMenuItem1, шрифтToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 114);
            // 
            // копіюватиToolStripMenuItem1
            // 
            копіюватиToolStripMenuItem1.Name = "копіюватиToolStripMenuItem1";
            копіюватиToolStripMenuItem1.Size = new Size(180, 22);
            копіюватиToolStripMenuItem1.Text = "Копіювати";
            копіюватиToolStripMenuItem1.Click += копіюватиToolStripMenuItem1_Click;
            // 
            // вирізатиToolStripMenuItem1
            // 
            вирізатиToolStripMenuItem1.Name = "вирізатиToolStripMenuItem1";
            вирізатиToolStripMenuItem1.Size = new Size(180, 22);
            вирізатиToolStripMenuItem1.Text = "Вирізати";
            вирізатиToolStripMenuItem1.Click += вирізатиToolStripMenuItem1_Click;
            // 
            // вставитиToolStripMenuItem1
            // 
            вставитиToolStripMenuItem1.Name = "вставитиToolStripMenuItem1";
            вставитиToolStripMenuItem1.Size = new Size(180, 22);
            вставитиToolStripMenuItem1.Text = "Вставити";
            вставитиToolStripMenuItem1.Click += вставитиToolStripMenuItem1_Click;
            // 
            // шрифтToolStripMenuItem
            // 
            шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            шрифтToolStripMenuItem.Size = new Size(180, 22);
            шрифтToolStripMenuItem.Text = "Шрифт";
            шрифтToolStripMenuItem.Click += шрифтToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, правкаToolStripMenuItem, довідкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(731, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { відкритиToolStripMenuItem, зберегтиToolStripMenuItem, друкToolStripMenuItem, вихідToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // відкритиToolStripMenuItem
            // 
            відкритиToolStripMenuItem.Name = "відкритиToolStripMenuItem";
            відкритиToolStripMenuItem.Size = new Size(124, 22);
            відкритиToolStripMenuItem.Text = "Відкрити";
            відкритиToolStripMenuItem.Click += відкритиToolStripMenuItem_Click;
            // 
            // зберегтиToolStripMenuItem
            // 
            зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            зберегтиToolStripMenuItem.Size = new Size(124, 22);
            зберегтиToolStripMenuItem.Text = "Зберегти";
            зберегтиToolStripMenuItem.Click += зберегтиToolStripMenuItem_Click;
            // 
            // друкToolStripMenuItem
            // 
            друкToolStripMenuItem.Name = "друкToolStripMenuItem";
            друкToolStripMenuItem.Size = new Size(124, 22);
            друкToolStripMenuItem.Text = "Друк";
            друкToolStripMenuItem.Click += друкToolStripMenuItem_Click;
            // 
            // вихідToolStripMenuItem
            // 
            вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            вихідToolStripMenuItem.Size = new Size(124, 22);
            вихідToolStripMenuItem.Text = "Вихід";
            вихідToolStripMenuItem.Click += вихідToolStripMenuItem_Click;
            // 
            // правкаToolStripMenuItem
            // 
            правкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { копіюватиToolStripMenuItem, вирізатиToolStripMenuItem, вставитиToolStripMenuItem });
            правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            правкаToolStripMenuItem.Size = new Size(59, 20);
            правкаToolStripMenuItem.Text = "Правка";
            // 
            // копіюватиToolStripMenuItem
            // 
            копіюватиToolStripMenuItem.Name = "копіюватиToolStripMenuItem";
            копіюватиToolStripMenuItem.Size = new Size(132, 22);
            копіюватиToolStripMenuItem.Text = "Копіювати";
            копіюватиToolStripMenuItem.Click += копіюватиToolStripMenuItem_Click;
            // 
            // вирізатиToolStripMenuItem
            // 
            вирізатиToolStripMenuItem.Name = "вирізатиToolStripMenuItem";
            вирізатиToolStripMenuItem.Size = new Size(132, 22);
            вирізатиToolStripMenuItem.Text = "Вирізати";
            вирізатиToolStripMenuItem.Click += вирізатиToolStripMenuItem_Click;
            // 
            // вставитиToolStripMenuItem
            // 
            вставитиToolStripMenuItem.Name = "вставитиToolStripMenuItem";
            вставитиToolStripMenuItem.Size = new Size(132, 22);
            вставитиToolStripMenuItem.Text = "Вставити";
            вставитиToolStripMenuItem.Click += вставитиToolStripMenuItem_Click;
            // 
            // довідкаToolStripMenuItem
            // 
            довідкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { проПрограмуToolStripMenuItem });
            довідкаToolStripMenuItem.Name = "довідкаToolStripMenuItem";
            довідкаToolStripMenuItem.Size = new Size(61, 20);
            довідкаToolStripMenuItem.Text = "Довідка";
            // 
            // проПрограмуToolStripMenuItem
            // 
            проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            проПрограмуToolStripMenuItem.Size = new Size(154, 22);
            проПрограмуToolStripMenuItem.Text = "Про програму";
            проПрограмуToolStripMenuItem.Click += проПрограмуToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 456);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Текстовий редактор";
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem відкритиToolStripMenuItem;
        private ToolStripMenuItem зберегтиToolStripMenuItem;
        private ToolStripMenuItem друкToolStripMenuItem;
        private ToolStripMenuItem вихідToolStripMenuItem;
        private ToolStripMenuItem правкаToolStripMenuItem;
        private ToolStripMenuItem копіюватиToolStripMenuItem;
        private ToolStripMenuItem довідкаToolStripMenuItem;
        private ToolStripMenuItem вирізатиToolStripMenuItem;
        private ToolStripMenuItem вставитиToolStripMenuItem;
        private ToolStripMenuItem проПрограмуToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private FontDialog fontDialog1;
        private PrintDialog printDialog1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem копіюватиToolStripMenuItem1;
        private ToolStripMenuItem вирізатиToolStripMenuItem1;
        private ToolStripMenuItem вставитиToolStripMenuItem1;
        private ToolStripMenuItem шрифтToolStripMenuItem;
    }
}

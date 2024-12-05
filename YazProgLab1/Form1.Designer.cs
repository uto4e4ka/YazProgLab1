namespace YazProgLab1
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
            menuStrip1 = new MenuStrip();
            заданиеToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            перезапуститьToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            трассаВычисленийToolStripMenuItem = new ToolStripMenuItem();
            информацияToolStripMenuItem = new ToolStripMenuItem();
            mainPanel = new Panel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            mainPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { заданиеToolStripMenuItem, оПрограммеToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(653, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // заданиеToolStripMenuItem
            // 
            заданиеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem, перезапуститьToolStripMenuItem, выходToolStripMenuItem });
            заданиеToolStripMenuItem.Name = "заданиеToolStripMenuItem";
            заданиеToolStripMenuItem.Size = new Size(64, 20);
            заданиеToolStripMenuItem.Text = "Задание";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(155, 22);
            открытьToolStripMenuItem.Text = "Открыть";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // перезапуститьToolStripMenuItem
            // 
            перезапуститьToolStripMenuItem.Name = "перезапуститьToolStripMenuItem";
            перезапуститьToolStripMenuItem.Size = new Size(155, 22);
            перезапуститьToolStripMenuItem.Text = "Перезапустить";
            перезапуститьToolStripMenuItem.Click += перезапуститьToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(155, 22);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { трассаВычисленийToolStripMenuItem, информацияToolStripMenuItem });
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(94, 20);
            оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // трассаВычисленийToolStripMenuItem
            // 
            трассаВычисленийToolStripMenuItem.Name = "трассаВычисленийToolStripMenuItem";
            трассаВычисленийToolStripMenuItem.Size = new Size(183, 22);
            трассаВычисленийToolStripMenuItem.Text = "Трасса вычислений";
            трассаВычисленийToolStripMenuItem.Click += трассаВычисленийToolStripMenuItem_Click;
            // 
            // информацияToolStripMenuItem
            // 
            информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            информацияToolStripMenuItem.Size = new Size(183, 22);
            информацияToolStripMenuItem.Text = "Информация";
            информацияToolStripMenuItem.Click += информацияToolStripMenuItem_Click_1;
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(panel1);
            mainPanel.Controls.Add(label5);
            mainPanel.Controls.Add(label4);
            mainPanel.Controls.Add(label3);
            mainPanel.Controls.Add(label2);
            mainPanel.Controls.Add(textBox3);
            mainPanel.Controls.Add(textBox2);
            mainPanel.Controls.Add(label1);
            mainPanel.Controls.Add(textBox1);
            mainPanel.Controls.Add(button1);
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(653, 450);
            mainPanel.TabIndex = 1;
            mainPanel.VisibleChanged += mainPanel_VisibleChanged;
            mainPanel.Paint += mainPanel_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(653, 450);
            panel1.TabIndex = 9;
            panel1.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Снимок_экрана_2024_10_28_125157;
            pictureBox1.Location = new Point(120, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(429, 274);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(46, 356);
            label5.Name = "label5";
            label5.Size = new Size(209, 28);
            label5.TabIndex = 8;
            label5.Text = "Строка симметрична.";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(46, 317);
            label4.Name = "label4";
            label4.Size = new Size(68, 28);
            label4.TabIndex = 7;
            label4.Text = "Ответ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(425, 115);
            label3.Name = "label3";
            label3.Size = new Size(22, 15);
            label3.TabIndex = 6;
            label3.Text = "До";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(425, 71);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 5;
            label2.Text = "От";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(425, 131);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(75, 23);
            textBox3.TabIndex = 4;
            textBox3.TextChanged += textBox3_TextChanged;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(425, 89);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(75, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(152, 71);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 2;
            label1.Text = "Введите строку.";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(152, 89);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(235, 112);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(425, 178);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Проверить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 450);
            Controls.Add(menuStrip1);
            Controls.Add(mainPanel);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem заданиеToolStripMenuItem;
        private ToolStripMenuItem перезапуститьToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStripMenuItem трассаВычисленийToolStripMenuItem;
        private ToolStripMenuItem информацияToolStripMenuItem;
        private Panel mainPanel;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private ToolStripMenuItem выходToolStripMenuItem;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label4;
        private Panel panel1;
        private PictureBox pictureBox1;
        private ToolStripMenuItem открытьToolStripMenuItem;
    }
}

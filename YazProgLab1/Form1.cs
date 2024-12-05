namespace YazProgLab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i1 = 0, j1 = 0;

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int size = textBox1.Text.Length - 1;
            if (i1 > j1 || i1 < 0 || i1 > size) textBox2.Text = "0";
            if (j1 < 0 || j1 > size) textBox3.Text = size + "";
            label5.Text = "Строка " + (strIs(textBox1.Text, i1, j1) ? "симметрична" : "не симметрична");
        }
        bool strIs(string str1, int i, int j)
        {
            if (i >= j) return true;
            if (str1[i] != str1[j]) return false;
            return strIs(str1, i + 1, j - 1);
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            if (int.TryParse(textBox2.Text, out int i))
            {
                i1 = i;
            }
            else
            {
                textBox2.Text = "0";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = textBox1.Text.Length - 1 + "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Вы точно хотите выйти из программы",
        "Выход",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.DefaultDesktopOnly);
            if (dialog == DialogResult.Yes) { Application.Exit(); }
        }

        private void mainPanel_VisibleChanged(object sender, EventArgs e)
        {
            textBox2.Text = "0";
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back) e.Handled = true;

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back) e.Handled = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //int size = textBox1.Text.Length;
            if (int.TryParse(textBox3.Text, out int j) && j > 0)
            {
                j1 = j;
            }
            //else
            //{
            //    textBox3.Text = size + "";
            //}
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void перезапуститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
          "Вы точно хотите начать заново?",
          "Перезапуск",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Question,
          MessageBoxDefaultButton.Button1,
          MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes) { Application.Restart(); }
            // else { Application.Exit(); }
        }

        private void трассаВычисленийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainPanel.Visible = true;
            panel1.Visible = false;
        }

 

        private void информацияToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
        MessageBox.Show(
       "Задание:\n15. Задана строка S из N символов. Реализуйте рекурсивный алгоритм проверки,  является ли симметричной часть строки, начинающаяся i-м и заканчивающаяся j-м ее  элементом.\n\nВыполнил: студент группы 6204-090301D\nЖестков А.С.",
       "Сообщение",
       MessageBoxButtons.OK,
       MessageBoxIcon.Information,
       MessageBoxDefaultButton.Button1,
       MessageBoxOptions.DefaultDesktopOnly);
        }
    }
}

namespace Nguyenthanhtung_Buoi2_bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt_a.Text);
            int b = int.Parse(txt_b.Text);
            int c = int.Parse(txt_c.Text);
            int max = a;
            if (max < b) max = b;
            if (max > c) max = c;
            txt_Max.Text = max.ToString();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txt_a.Text = string.Empty;
            txt_b.Text = string.Empty;
            txt_c.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

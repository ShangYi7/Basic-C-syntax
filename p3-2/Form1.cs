namespace p3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Beige; //更改textBox1 顏色/Change textBox1 color
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile("R:\\code\\program\\C#\\p3-2\\bin\\Debug\\4448.png_1200.png"); // 更改背景圖片/Change background image
            BackgroundImageLayout = ImageLayout.Stretch; // 背景圖片布局/Background image layout
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("標楷體", 50, FontStyle.Italic); // 更改 label1 裡的字體 (字型, 大小, 形狀)/Change the font (font, size, shape) in label1
        }

    }
}



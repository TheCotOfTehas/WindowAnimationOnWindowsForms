namespace WindowAnimationOnWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            panel2.MouseEnter += async (x, y) =>
            {
                while (panel2.Location.X > panel1.Location.X + 15)
                {
                    await Task.Delay(1);
                    panel2.Location = new Point(panel2.Location.X - 1, panel2.Location.Y);
                }
            };

            panel1.MouseEnter += async (x, y) =>
            {
                while (panel2.Location.X != panel2.Width + 15)
                {
                    await Task.Delay(1);
                    panel2.Location = new Point(panel2.Location.X + 1, panel2.Location.Y);
                }
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
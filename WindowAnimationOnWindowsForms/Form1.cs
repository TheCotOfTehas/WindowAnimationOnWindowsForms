namespace WindowAnimationOnWindowsForms
{
    public partial class Form1 : Form
    {
        bool workingForm;
        bool oldAnimation;
        public Form1()
        {
            InitializeComponent();

            panel2.MouseEnter += async (x, y) =>
            {
                while (!workingForm && panel2.Location.X > panel1.Location.X + 15)
                {
                    workingForm = true;

                    await Task.Delay(1);
                    if (!oldAnimation)
                        panel2.Location = new Point(panel2.Location.X - 1, panel2.Location.Y);
                    else
                        panel2.Location = new Point(panel2.Location.X - panel2.Location.X / 8, panel2.Location.Y);

                    workingForm = false;
                }
            };

            panel1.MouseEnter += async (x, y) =>
            {
                while (!workingForm && panel2.Location.X <= panel2.Width)
                {
                    workingForm = true;

                    await Task.Delay(1);
                    if (!oldAnimation)
                        panel2.Location = new Point(panel2.Location.X + 1, panel2.Location.Y);
                    else
                        panel2.Location = new Point(panel2.Location.X + (panel2.Width - panel2.Location.X) / 8, panel2.Location.Y);

                    workingForm = false;
                }
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oldAnimation = !oldAnimation;
        }
    }
}
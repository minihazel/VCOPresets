namespace VCOPresets
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void mainSeparator1_Paint(object sender, PaintEventArgs e)
        {
            int y = mainSeparator1.Height / 2;
            using (var pen = new Pen(Color.FromArgb(100, 100, 100), 1))
            {
                e.Graphics.DrawLine(pen, 0, y, mainSeparator1.Width, y);
            }
        }

        private void separator4_Paint(object sender, PaintEventArgs e)
        {
            int x = separator4.Width / 2;
            using (var pen = new Pen(Color.FromArgb(220, 220, 220), 1))
            {
                e.Graphics.DrawLine(pen, x, 0, x, separator4.Height);
            }
        }
    }
}

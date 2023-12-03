namespace Stars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int row = (int)rowChooser.Value;
            string result = "";
            for(int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    result += "*";
                }
                result += "\r\n";
            }
            MessageBox.Show(result);
        }
    }
}
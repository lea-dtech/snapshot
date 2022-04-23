namespace snapshot
{
    public partial class snapshotMainForm : Form
    {
        public snapshotMainForm()
        {
            InitializeComponent();
        }

        private void snapshotMainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            String fileName = DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".jpg";
            Thread.Sleep(1000);
            SendKeys.Send("{PRTSC}");
            Image myImage = Clipboard.GetImage();
            myImage.Save("screenshot/"+fileName);
            this.Show();
        }
    }
}
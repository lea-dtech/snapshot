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
            if (myImage != null)
            {
                if (!(Directory.Exists("C:/screenshot")))
                {
                    Directory.CreateDirectory("C:/screenshot");
                }
                try
                {   
                    myImage.Save("C:/screenshot/" + fileName, myImage.RawFormat);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else
            {
                MessageBox.Show("Null Image pointer Received!");
            }
            this.Show();
        }
    }
}
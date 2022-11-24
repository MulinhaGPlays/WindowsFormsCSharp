namespace Forms.Interface
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void SalvarClick(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void SalvarOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string caminho = saveFileDialog1.FileName;
            File.WriteAllText($"{caminho}.txt", txtbJanela.Text);
            txtbJanela.Text = "";
        }
    }
}
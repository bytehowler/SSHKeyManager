namespace SSHKeyManager
{
    public partial class SSHKeyManager : Form
    {
        public SSHKeyManager()
        {
            InitializeComponent();
        }

        private void SSHKeyManager_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonRemove.Enabled = true;
        }

        private void SSHKeyManager_Add(object sender, EventArgs e)
        {
            //(sender as Button)!.Text = "A";
            listSSHViewer.Items.Add("Lorem Ipsum");
        }

        private void SSHKeyManager_Remove(object sender, EventArgs e)
        {
            listSSHViewer.Items.Remove(listSSHViewer.SelectedItem!);
        }
    }
}
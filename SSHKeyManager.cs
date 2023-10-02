using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

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
            String sshDirectory =
                Environment.ExpandEnvironmentVariables("%USERPROFILE%\\.ssh");

            String algorithm = "";
            String comment = "";

            foreach (String file in Directory.GetFiles(sshDirectory))
            {
                FileStream fs = File.OpenRead(file);

                String fileContent = File.ReadAllText(file);

                if (fileContent.ToLower().StartsWith("ssh-rsa"))
                {
                    algorithm = "SSH-RSA";
                    comment = AlgorithmChecker.getComment(fileContent);
                }
                else if (fileContent.ToLower().StartsWith("ssh-dss"))
                {
                    algorithm = "SSH-DSS";
                    comment = AlgorithmChecker.getComment(fileContent);
                }
                else if (fileContent.ToLower().StartsWith("ssh-ed25519"))
                {
                    algorithm = "SSH-Ed25519";
                    comment = AlgorithmChecker.getComment(fileContent);
                }
                else
                {
                    continue;
                }

                ListViewItem item = new ListViewItem(algorithm);
                item.SubItems.Add(comment);

                listSSHViewer.Items.Add(item);

            }

        }

        private void SSHKeyManager_Add(object sender, EventArgs e)
        {
            //(sender as Button)!.Text = "A";
            listSSHViewer.Items.Add("Lorem Ipsum");
        }

        private void SSHKeyManager_Remove(object sender, EventArgs e)
        {
            listSSHViewer.Items.Remove(listSSHViewer.FocusedItem);
        }

        private void listSSHViewer_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listSSHViewer.Columns[e.ColumnIndex].Width;
        }

        private void listSSHViewer_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonRemove.Enabled = (listSSHViewer.SelectedItems.Count > 0) ?
                true : false;
        }
    }
}
namespace SSHKeyManager
{
    partial class SSHKeyManager
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SSHKeyManager));
            listSSHViewer = new ListBox();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonRemove = new Button();
            SuspendLayout();
            // 
            // listSSHViewer
            // 
            listSSHViewer.FormattingEnabled = true;
            listSSHViewer.ItemHeight = 20;
            listSSHViewer.Location = new Point(12, 54);
            listSSHViewer.Name = "listSSHViewer";
            listSSHViewer.Size = new Size(776, 384);
            listSSHViewer.TabIndex = 1;
            listSSHViewer.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(12, 12);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 36);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.Enabled = false;
            buttonEdit.FlatStyle = FlatStyle.System;
            buttonEdit.Location = new Point(112, 12);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(94, 36);
            buttonEdit.TabIndex = 3;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonRemove
            // 
            buttonRemove.Enabled = false;
            buttonRemove.Location = new Point(694, 12);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(94, 36);
            buttonRemove.TabIndex = 4;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = true;
            // 
            // SSHKeyManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonRemove);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(listSSHViewer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SSHKeyManager";
            Text = "SSH Key Manager";
            Load += SSHKeyManager_Load;
            ResumeLayout(false);
        }

        #endregion
        private ListBox listSSHViewer;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonRemove;
    }
}
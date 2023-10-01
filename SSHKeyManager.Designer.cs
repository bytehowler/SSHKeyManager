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
            listSSHViewer.ItemHeight = 15;
            listSSHViewer.Location = new Point(10, 40);
            listSSHViewer.Margin = new Padding(3, 2, 3, 2);
            listSSHViewer.Name = "listSSHViewer";
            listSSHViewer.Size = new Size(680, 289);
            listSSHViewer.TabIndex = 1;
            listSSHViewer.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(10, 9);
            buttonAdd.Margin = new Padding(3, 2, 3, 2);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(82, 27);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += SSHKeyManager_Add;
            // 
            // buttonEdit
            // 
            buttonEdit.Enabled = false;
            buttonEdit.FlatStyle = FlatStyle.System;
            buttonEdit.Location = new Point(98, 9);
            buttonEdit.Margin = new Padding(3, 2, 3, 2);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(82, 27);
            buttonEdit.TabIndex = 3;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonRemove
            // 
            buttonRemove.Enabled = false;
            buttonRemove.Location = new Point(607, 9);
            buttonRemove.Margin = new Padding(3, 2, 3, 2);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(82, 27);
            buttonRemove.TabIndex = 4;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += SSHKeyManager_Remove;
            // 
            // SSHKeyManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(buttonRemove);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(listSSHViewer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
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
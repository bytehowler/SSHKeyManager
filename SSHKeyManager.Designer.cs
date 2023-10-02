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
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonRemove = new Button();
            listSSHViewer = new ListView();
            keyAlgorithm = new ColumnHeader();
            keyComment = new ColumnHeader();
            SuspendLayout();
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
            // listSSHViewer
            // 
            listSSHViewer.Columns.AddRange(new ColumnHeader[] { keyAlgorithm, keyComment });
            listSSHViewer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listSSHViewer.FullRowSelect = true;
            listSSHViewer.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listSSHViewer.Location = new Point(12, 40);
            listSSHViewer.Margin = new Padding(3, 2, 3, 2);
            listSSHViewer.Name = "listSSHViewer";
            listSSHViewer.RightToLeft = RightToLeft.No;
            listSSHViewer.Size = new Size(676, 287);
            listSSHViewer.TabIndex = 5;
            listSSHViewer.UseCompatibleStateImageBehavior = false;
            listSSHViewer.View = View.Details;
            listSSHViewer.ColumnWidthChanging += listSSHViewer_ColumnWidthChanging;
            listSSHViewer.SelectedIndexChanged += listSSHViewer_SelectedIndexChanged;
            // 
            // keyAlgorithm
            // 
            keyAlgorithm.Text = "Algorithm";
            keyAlgorithm.Width = 125;
            // 
            // keyComment
            // 
            keyComment.Text = "Comment";
            keyComment.Width = 545;
            // 
            // SSHKeyManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(listSSHViewer);
            Controls.Add(buttonRemove);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
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
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonRemove;
        private ListView listSSHViewer;
        private ColumnHeader keyAlgorithm;
        private ColumnHeader keyComment;
    }
}
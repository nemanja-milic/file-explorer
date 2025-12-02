namespace FileExplorer
{
    partial class Form1
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
            btnBack = new Button();
            btnForward = new Button();
            currentAddress = new TextBox();
            listViewResources = new ListView();
            name = new ColumnHeader();
            dateModified = new ColumnHeader();
            type = new ColumnHeader();
            size = new ColumnHeader();
            treeView1 = new TreeView();
            btnSettings = new Button();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(13, 23);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(38, 31);
            btnBack.TabIndex = 0;
            btnBack.Text = "<<";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnForward
            // 
            btnForward.Location = new Point(57, 23);
            btnForward.Margin = new Padding(3, 4, 3, 4);
            btnForward.Name = "btnForward";
            btnForward.Size = new Size(38, 31);
            btnForward.TabIndex = 2;
            btnForward.Text = ">>";
            btnForward.UseVisualStyleBackColor = true;
            // 
            // currentAddress
            // 
            currentAddress.Location = new Point(102, 23);
            currentAddress.Margin = new Padding(3, 4, 3, 4);
            currentAddress.Name = "currentAddress";
            currentAddress.Size = new Size(700, 27);
            currentAddress.TabIndex = 3;
            // 
            // listViewResources
            // 
            listViewResources.Columns.AddRange(new ColumnHeader[] { name, dateModified, type, size });
            listViewResources.FullRowSelect = true;
            listViewResources.Location = new Point(175, 88);
            listViewResources.Margin = new Padding(3, 4, 3, 4);
            listViewResources.Name = "listViewResources";
            listViewResources.Size = new Size(671, 411);
            listViewResources.TabIndex = 4;
            listViewResources.UseCompatibleStateImageBehavior = false;
            listViewResources.View = View.Details;
            listViewResources.MouseClick += listViewResources_MouseClick;
            // 
            // name
            // 
            name.Text = "Name";
            name.Width = 200;
            // 
            // dateModified
            // 
            dateModified.Text = "Date modified";
            dateModified.Width = 150;
            // 
            // type
            // 
            type.Text = "Type";
            type.Width = 150;
            // 
            // size
            // 
            size.Text = "Size";
            size.Width = 150;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(13, 88);
            treeView1.Margin = new Padding(3, 4, 3, 4);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(141, 411);
            treeView1.TabIndex = 5;
            // 
            // btnSettings
            // 
            btnSettings.Image = Properties.Resources.settings_svgrepo_com3;
            btnSettings.Location = new Point(809, 23);
            btnSettings.Margin = new Padding(3, 4, 3, 4);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(38, 31);
            btnSettings.TabIndex = 6;
            btnSettings.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 516);
            Controls.Add(btnSettings);
            Controls.Add(treeView1);
            Controls.Add(listViewResources);
            Controls.Add(currentAddress);
            Controls.Add(btnForward);
            Controls.Add(btnBack);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnForward;
        private TextBox currentAddress;
        private ListView listViewResources;
        private TreeView treeView1;
        private Button btnSettings;
        private ColumnHeader name;
        private ColumnHeader dateModified;
        private ColumnHeader type;
        private ColumnHeader size;
    }
}

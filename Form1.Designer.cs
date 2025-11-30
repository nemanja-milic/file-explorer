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
            textBox1 = new TextBox();
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
            btnBack.Location = new Point(11, 17);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(33, 23);
            btnBack.TabIndex = 0;
            btnBack.Text = "<<";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // btnForward
            // 
            btnForward.Location = new Point(50, 17);
            btnForward.Name = "btnForward";
            btnForward.Size = new Size(33, 23);
            btnForward.TabIndex = 2;
            btnForward.Text = ">>";
            btnForward.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(89, 17);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(613, 23);
            textBox1.TabIndex = 3;
            // 
            // listViewResources
            // 
            listViewResources.Columns.AddRange(new ColumnHeader[] { name, dateModified, type, size });
            listViewResources.FullRowSelect = true;
            listViewResources.Location = new Point(153, 66);
            listViewResources.Name = "listViewResources";
            listViewResources.Size = new Size(588, 309);
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
            treeView1.Location = new Point(11, 66);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(124, 309);
            treeView1.TabIndex = 5;
            // 
            // btnSettings
            // 
            btnSettings.Image = Properties.Resources.settings_svgrepo_com3;
            btnSettings.Location = new Point(708, 17);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(33, 23);
            btnSettings.TabIndex = 6;
            btnSettings.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 387);
            Controls.Add(btnSettings);
            Controls.Add(treeView1);
            Controls.Add(listViewResources);
            Controls.Add(textBox1);
            Controls.Add(btnForward);
            Controls.Add(btnBack);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnForward;
        private TextBox textBox1;
        private ListView listViewResources;
        private TreeView treeView1;
        private Button btnSettings;
        private ColumnHeader name;
        private ColumnHeader dateModified;
        private ColumnHeader type;
        private ColumnHeader size;
    }
}

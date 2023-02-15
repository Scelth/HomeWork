namespace DZ
{
    partial class MainForm
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
            this.peopleListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.addButton = new System.Windows.Forms.Button();
            this.adressLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.skillLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.skillTextBox = new System.Windows.Forms.TextBox();
            this.imgLabel = new System.Windows.Forms.Label();
            this.imgButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // peopleListBox
            // 
            this.peopleListBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.peopleListBox.FormattingEnabled = true;
            this.peopleListBox.ItemHeight = 15;
            this.peopleListBox.Location = new System.Drawing.Point(559, 0);
            this.peopleListBox.Name = "peopleListBox";
            this.peopleListBox.Size = new System.Drawing.Size(241, 450);
            this.peopleListBox.TabIndex = 0;
            this.peopleListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.peopleListBox_MouseDoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.addButton, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.adressLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.nameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.skillLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.nameTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.adressTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.skillTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.imgLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.imgButton, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.20588F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.79412F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(559, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // addButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.addButton, 2);
            this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addButton.Location = new System.Drawing.Point(3, 352);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(553, 95);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // adressLabel
            // 
            this.adressLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.adressLabel.AutoSize = true;
            this.adressLabel.Location = new System.Drawing.Point(118, 140);
            this.adressLabel.Name = "adressLabel";
            this.adressLabel.Size = new System.Drawing.Size(42, 15);
            this.adressLabel.TabIndex = 3;
            this.adressLabel.Text = "Adress";
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(109, 23);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(61, 15);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Full Name";
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(124, 81);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(31, 15);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "Date";
            // 
            // skillLabel
            // 
            this.skillLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skillLabel.AutoSize = true;
            this.skillLabel.Location = new System.Drawing.Point(123, 205);
            this.skillLabel.Name = "skillLabel";
            this.skillLabel.Size = new System.Drawing.Size(33, 15);
            this.skillLabel.TabIndex = 4;
            this.skillLabel.Text = "Skills";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.Location = new System.Drawing.Point(282, 19);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(274, 23);
            this.nameTextBox.TabIndex = 6;
            // 
            // dateTextBox
            // 
            this.dateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTextBox.Location = new System.Drawing.Point(282, 77);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(274, 23);
            this.dateTextBox.TabIndex = 7;
            // 
            // adressTextBox
            // 
            this.adressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.adressTextBox.Location = new System.Drawing.Point(282, 136);
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(274, 23);
            this.adressTextBox.TabIndex = 8;
            // 
            // skillTextBox
            // 
            this.skillTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.skillTextBox.Location = new System.Drawing.Point(282, 201);
            this.skillTextBox.Name = "skillTextBox";
            this.skillTextBox.Size = new System.Drawing.Size(274, 23);
            this.skillTextBox.TabIndex = 9;
            // 
            // imgLabel
            // 
            this.imgLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgLabel.AutoSize = true;
            this.imgLabel.Location = new System.Drawing.Point(119, 290);
            this.imgLabel.Name = "imgLabel";
            this.imgLabel.Size = new System.Drawing.Size(40, 15);
            this.imgLabel.TabIndex = 11;
            this.imgLabel.Text = "Image";
            // 
            // imgButton
            // 
            this.imgButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgButton.Location = new System.Drawing.Point(371, 278);
            this.imgButton.Name = "imgButton";
            this.imgButton.Size = new System.Drawing.Size(95, 40);
            this.imgButton.TabIndex = 12;
            this.imgButton.Text = "Browse";
            this.imgButton.UseVisualStyleBackColor = true;
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.peopleListBox);
            this.Name = "MyForm";
            this.Text = "CV";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox peopleListBox;
        private TableLayoutPanel tableLayoutPanel1;
        private Label adressLabel;
        private Label nameLabel;
        private Label dateLabel;
        private Label skillLabel;
        private TextBox nameTextBox;
        private TextBox dateTextBox;
        private TextBox adressTextBox;
        private TextBox skillTextBox;
        private Button addButton;
        private Label imgLabel;
        private Button imgButton;
    }
}
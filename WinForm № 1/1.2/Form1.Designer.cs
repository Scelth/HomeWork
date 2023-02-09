namespace DZ2
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Label = new System.Windows.Forms.Label();
            this.guessTextBox = new System.Windows.Forms.TextBox();
            this.guessButton = new System.Windows.Forms.Button();
            this.guessListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            this.tableLayoutPanel1.Controls.Add(this.Label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.guessTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.guessButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.guessListBox, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(391, 232);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Label
            // 
            this.Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.Label, 2);
            this.Label.Location = new System.Drawing.Point(50, 17);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(153, 15);
            this.Label.TabIndex = 0;
            this.Label.Text = "Guess the intended number";
            // 
            // guessTextBox
            // 
            this.guessTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.guessTextBox, 2);
            this.guessTextBox.Location = new System.Drawing.Point(3, 86);
            this.guessTextBox.Name = "guessTextBox";
            this.guessTextBox.Size = new System.Drawing.Size(248, 23);
            this.guessTextBox.TabIndex = 1;
            // 
            // guessButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.guessButton, 2);
            this.guessButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guessButton.Location = new System.Drawing.Point(3, 150);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(248, 79);
            this.guessButton.TabIndex = 2;
            this.guessButton.Text = "Guess";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            // 
            // guessListBox
            // 
            this.guessListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guessListBox.FormattingEnabled = true;
            this.guessListBox.ItemHeight = 15;
            this.guessListBox.Location = new System.Drawing.Point(257, 3);
            this.guessListBox.Name = "guessListBox";
            this.tableLayoutPanel1.SetRowSpan(this.guessListBox, 3);
            this.guessListBox.Size = new System.Drawing.Size(131, 226);
            this.guessListBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 232);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "1.2";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label Label;
        private TextBox guessTextBox;
        private Button guessButton;
        private ListBox guessListBox;
    }
}
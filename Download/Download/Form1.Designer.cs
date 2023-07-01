namespace Download
{
    partial class Torrent
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
            tableLayoutPanel1 = new TableLayoutPanel();
            downloadProgressBar = new ProgressBar();
            downloadButton = new Button();
            gamesListBox = new ListBox();
            completedTextBox = new RichTextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 395F));
            tableLayoutPanel1.Controls.Add(downloadProgressBar, 0, 2);
            tableLayoutPanel1.Controls.Add(downloadButton, 0, 1);
            tableLayoutPanel1.Controls.Add(gamesListBox, 0, 0);
            tableLayoutPanel1.Controls.Add(completedTextBox, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90.442894F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.55711F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // downloadProgressBar
            // 
            tableLayoutPanel1.SetColumnSpan(downloadProgressBar, 3);
            downloadProgressBar.Dock = DockStyle.Fill;
            downloadProgressBar.Location = new Point(3, 413);
            downloadProgressBar.Name = "downloadProgressBar";
            downloadProgressBar.Size = new Size(794, 34);
            downloadProgressBar.TabIndex = 0;
            // 
            // downloadButton
            // 
            downloadButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tableLayoutPanel1.SetColumnSpan(downloadButton, 3);
            downloadButton.Location = new Point(301, 374);
            downloadButton.Name = "downloadButton";
            downloadButton.Size = new Size(197, 33);
            downloadButton.TabIndex = 1;
            downloadButton.Text = "Download";
            downloadButton.UseVisualStyleBackColor = true;
            downloadButton.Click += downloadButton_Click;
            // 
            // gamesListBox
            // 
            gamesListBox.Dock = DockStyle.Fill;
            gamesListBox.FormattingEnabled = true;
            gamesListBox.ItemHeight = 15;
            gamesListBox.Location = new Point(3, 3);
            gamesListBox.Name = "gamesListBox";
            gamesListBox.Size = new Size(399, 365);
            gamesListBox.TabIndex = 2;
            // 
            // completedTextBox
            // 
            completedTextBox.Dock = DockStyle.Fill;
            completedTextBox.Location = new Point(408, 3);
            completedTextBox.Name = "completedTextBox";
            completedTextBox.Size = new Size(389, 365);
            completedTextBox.TabIndex = 3;
            completedTextBox.Text = "";
            // 
            // Torrent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Torrent";
            Text = "μTorrent";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ProgressBar downloadProgressBar;
        private Button downloadButton;
        private ListBox gamesListBox;
        private RichTextBox completedTextBox;
    }
}
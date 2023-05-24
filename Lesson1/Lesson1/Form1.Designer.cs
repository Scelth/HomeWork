namespace Lesson1
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
            splitContainer1 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            allButton = new Button();
            maxButton = new Button();
            minButton = new Button();
            dataGridView = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            youtTextBox = new TextBox();
            youtButton = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView);
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel2);
            splitContainer1.Size = new Size(858, 450);
            splitContainer1.SplitterDistance = 211;
            splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(allButton, 0, 0);
            tableLayoutPanel1.Controls.Add(maxButton, 0, 1);
            tableLayoutPanel1.Controls.Add(minButton, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.78157F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 52.21843F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 156F));
            tableLayoutPanel1.Size = new Size(211, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // allButton
            // 
            allButton.Dock = DockStyle.Fill;
            allButton.Location = new Point(3, 3);
            allButton.Name = "allButton";
            allButton.Size = new Size(205, 134);
            allButton.TabIndex = 0;
            allButton.Text = "Output all";
            allButton.UseVisualStyleBackColor = true;
            allButton.Click += allButton_Click;
            // 
            // maxButton
            // 
            maxButton.Dock = DockStyle.Fill;
            maxButton.Location = new Point(3, 143);
            maxButton.Name = "maxButton";
            maxButton.Size = new Size(205, 147);
            maxButton.TabIndex = 1;
            maxButton.Text = "Output maximum salary";
            maxButton.UseVisualStyleBackColor = true;
            maxButton.Click += maxButton_Click;
            // 
            // minButton
            // 
            minButton.Dock = DockStyle.Fill;
            minButton.Location = new Point(3, 296);
            minButton.Name = "minButton";
            minButton.Size = new Size(205, 151);
            minButton.TabIndex = 2;
            minButton.Text = "Output minimum salary";
            minButton.UseVisualStyleBackColor = true;
            minButton.Click += minButton_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(0, 35);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(643, 415);
            dataGridView.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.57525F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.42475F));
            tableLayoutPanel2.Controls.Add(youtTextBox, 0, 0);
            tableLayoutPanel2.Controls.Add(youtButton, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(643, 35);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // youtTextBox
            // 
            youtTextBox.Anchor = AnchorStyles.None;
            youtTextBox.Location = new Point(11, 6);
            youtTextBox.Name = "youtTextBox";
            youtTextBox.Size = new Size(444, 23);
            youtTextBox.TabIndex = 0;
            // 
            // youtButton
            // 
            youtButton.Dock = DockStyle.Fill;
            youtButton.Location = new Point(469, 3);
            youtButton.Name = "youtButton";
            youtButton.Size = new Size(171, 29);
            youtButton.TabIndex = 1;
            youtButton.Text = "Output";
            youtButton.UseVisualStyleBackColor = true;
            youtButton.Click += youtButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 450);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button allButton;
        private Button maxButton;
        private Button minButton;
        private DataGridView dataGridView;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox youtTextBox;
        private Button youtButton;
    }
}
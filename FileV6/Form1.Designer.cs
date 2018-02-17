namespace FileV6
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.filePathRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fileExtensionComboBox = new System.Windows.Forms.ComboBox();
            this.clearListBoxButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.opentPathButton = new System.Windows.Forms.Button();
            this.findFileButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.filesFoundRichTextBox = new System.Windows.Forms.RichTextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // filePathRichTextBox
            // 
            this.filePathRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filePathRichTextBox.Location = new System.Drawing.Point(12, 33);
            this.filePathRichTextBox.Name = "filePathRichTextBox";
            this.filePathRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.filePathRichTextBox.Size = new System.Drawing.Size(702, 32);
            this.filePathRichTextBox.TabIndex = 4;
            this.filePathRichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "enter path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(709, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = " file extension ";
            // 
            // fileExtensionComboBox
            // 
            this.fileExtensionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fileExtensionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileExtensionComboBox.FormattingEnabled = true;
            this.fileExtensionComboBox.Location = new System.Drawing.Point(713, 33);
            this.fileExtensionComboBox.Name = "fileExtensionComboBox";
            this.fileExtensionComboBox.Size = new System.Drawing.Size(121, 32);
            this.fileExtensionComboBox.TabIndex = 6;
            this.fileExtensionComboBox.SelectedIndexChanged += new System.EventHandler(this.fileExtensionComboBox_SelectedIndexChanged);
            // 
            // clearListBoxButton
            // 
            this.clearListBoxButton.Location = new System.Drawing.Point(290, 94);
            this.clearListBoxButton.Name = "clearListBoxButton";
            this.clearListBoxButton.Size = new System.Drawing.Size(75, 23);
            this.clearListBoxButton.TabIndex = 14;
            this.clearListBoxButton.Text = "Clear";
            this.clearListBoxButton.UseVisualStyleBackColor = true;
            this.clearListBoxButton.Click += new System.EventHandler(this.clearListBoxButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(197, 94);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 13;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            // 
            // opentPathButton
            // 
            this.opentPathButton.Location = new System.Drawing.Point(15, 94);
            this.opentPathButton.Name = "opentPathButton";
            this.opentPathButton.Size = new System.Drawing.Size(75, 23);
            this.opentPathButton.TabIndex = 11;
            this.opentPathButton.Text = "Open";
            this.opentPathButton.UseVisualStyleBackColor = true;
            this.opentPathButton.Click += new System.EventHandler(this.opentPathButton_Click);
            // 
            // findFileButton
            // 
            this.findFileButton.Location = new System.Drawing.Point(107, 94);
            this.findFileButton.Name = "findFileButton";
            this.findFileButton.Size = new System.Drawing.Size(75, 23);
            this.findFileButton.TabIndex = 12;
            this.findFileButton.Text = "Find";
            this.findFileButton.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(15, 224);
            this.listBox1.Name = "listBox1";
            this.listBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBox1.Size = new System.Drawing.Size(819, 532);
            this.listBox1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(17, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = " files list";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = " files found";
            // 
            // filesFoundRichTextBox
            // 
            this.filesFoundRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filesFoundRichTextBox.Location = new System.Drawing.Point(15, 158);
            this.filesFoundRichTextBox.Name = "filesFoundRichTextBox";
            this.filesFoundRichTextBox.ReadOnly = true;
            this.filesFoundRichTextBox.Size = new System.Drawing.Size(167, 36);
            this.filesFoundRichTextBox.TabIndex = 17;
            this.filesFoundRichTextBox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 774);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.filesFoundRichTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.clearListBoxButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.opentPathButton);
            this.Controls.Add(this.findFileButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fileExtensionComboBox);
            this.Controls.Add(this.filePathRichTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "File";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox filePathRichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox fileExtensionComboBox;
        private System.Windows.Forms.Button clearListBoxButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button opentPathButton;
        private System.Windows.Forms.Button findFileButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox filesFoundRichTextBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}


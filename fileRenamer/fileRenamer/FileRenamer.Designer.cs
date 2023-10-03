namespace fileRenamer
{
    partial class FileRenamer
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.OriginalNameField = new System.Windows.Forms.RichTextBox();
            this.RenameButton = new System.Windows.Forms.Button();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NewNameField = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DestinationFolderPath = new System.Windows.Forms.RichTextBox();
            this.InfoField = new System.Windows.Forms.RichTextBox();
            this.FolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.OriginalFolderPath = new System.Windows.Forms.RichTextBox();
            this.OriginalFolderButton = new System.Windows.Forms.Button();
            this.OutputFolderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OriginalNameField
            // 
            this.OriginalNameField.Location = new System.Drawing.Point(15, 32);
            this.OriginalNameField.Name = "OriginalNameField";
            this.OriginalNameField.Size = new System.Drawing.Size(195, 28);
            this.OriginalNameField.TabIndex = 0;
            this.OriginalNameField.Text = "";
            // 
            // RenameButton
            // 
            this.RenameButton.Location = new System.Drawing.Point(255, 240);
            this.RenameButton.Name = "RenameButton";
            this.RenameButton.Size = new System.Drawing.Size(195, 41);
            this.RenameButton.TabIndex = 1;
            this.RenameButton.Text = "Rename";
            this.RenameButton.UseVisualStyleBackColor = true;
            this.RenameButton.Click += new System.EventHandler(this.RenameButton_Click);
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Location = new System.Drawing.Point(12, 12);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(148, 13);
            this.NumberLabel.TabIndex = 2;
            this.NumberLabel.Text = "Enter original part in file name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter new part in file name:";
            // 
            // NewNameField
            // 
            this.NewNameField.Location = new System.Drawing.Point(255, 32);
            this.NewNameField.Name = "NewNameField";
            this.NewNameField.Size = new System.Drawing.Size(195, 28);
            this.NewNameField.TabIndex = 3;
            this.NewNameField.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter output folder path (optional): ";
            // 
            // NewFolderPath
            // 
            this.DestinationFolderPath.Location = new System.Drawing.Point(15, 177);
            this.DestinationFolderPath.Name = "NewFolderPath";
            this.DestinationFolderPath.Size = new System.Drawing.Size(402, 28);
            this.DestinationFolderPath.TabIndex = 7;
            this.DestinationFolderPath.Text = "";
            // 
            // InfoField
            // 
            this.InfoField.Location = new System.Drawing.Point(15, 240);
            this.InfoField.Name = "InfoField";
            this.InfoField.Size = new System.Drawing.Size(195, 137);
            this.InfoField.TabIndex = 9;
            this.InfoField.Text = "INFO FIELD";
            // 
            // FolderDialog
            // 
            this.FolderDialog.ShowNewFolderButton = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter original folder path (optional):";
            // 
            // OriginalFolderPath
            // 
            this.OriginalFolderPath.Location = new System.Drawing.Point(15, 105);
            this.OriginalFolderPath.Name = "OriginalFolderPath";
            this.OriginalFolderPath.Size = new System.Drawing.Size(402, 28);
            this.OriginalFolderPath.TabIndex = 5;
            this.OriginalFolderPath.Text = "";
            // 
            // OriginalFolderButton
            // 
            this.OriginalFolderButton.Location = new System.Drawing.Point(423, 105);
            this.OriginalFolderButton.Name = "OriginalFolderButton";
            this.OriginalFolderButton.Size = new System.Drawing.Size(27, 28);
            this.OriginalFolderButton.TabIndex = 10;
            this.OriginalFolderButton.Text = "...";
            this.OriginalFolderButton.UseVisualStyleBackColor = true;
            this.OriginalFolderButton.Click += new System.EventHandler(this.OriginalFolderDialog_Click);
            // 
            // OutputFolderButton
            // 
            this.OutputFolderButton.Location = new System.Drawing.Point(424, 177);
            this.OutputFolderButton.Name = "OutputFolderButton";
            this.OutputFolderButton.Size = new System.Drawing.Size(27, 28);
            this.OutputFolderButton.TabIndex = 11;
            this.OutputFolderButton.Text = "...";
            this.OutputFolderButton.UseVisualStyleBackColor = true;
            this.OutputFolderButton.Click += new System.EventHandler(this.OutputFolderButton_Click);
            // 
            // FileRenamer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 394);
            this.Controls.Add(this.OutputFolderButton);
            this.Controls.Add(this.OriginalFolderButton);
            this.Controls.Add(this.InfoField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DestinationFolderPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OriginalFolderPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewNameField);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.RenameButton);
            this.Controls.Add(this.OriginalNameField);
            this.Name = "FileRenamer";
            this.Text = "File Renamer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox OriginalNameField;
        private System.Windows.Forms.Button RenameButton;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox NewNameField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox DestinationFolderPath;
        private System.Windows.Forms.RichTextBox InfoField;
        private System.Windows.Forms.FolderBrowserDialog FolderDialog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox OriginalFolderPath;
        private System.Windows.Forms.Button OriginalFolderButton;
        private System.Windows.Forms.Button OutputFolderButton;
    }
}


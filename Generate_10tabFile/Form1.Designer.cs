namespace Generate_10tabFile
{
    partial class Form1
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
            this.fileDirInput = new System.Windows.Forms.TextBox();
            this.importFileButton = new System.Windows.Forms.Button();
            this.exportFileButton = new System.Windows.Forms.Button();
            this.fileDirOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fileDirInput
            // 
            this.fileDirInput.Location = new System.Drawing.Point(139, 40);
            this.fileDirInput.Name = "fileDirInput";
            this.fileDirInput.Size = new System.Drawing.Size(242, 20);
            this.fileDirInput.TabIndex = 0;
            // 
            // importFileButton
            // 
            this.importFileButton.Location = new System.Drawing.Point(42, 40);
            this.importFileButton.Name = "importFileButton";
            this.importFileButton.Size = new System.Drawing.Size(75, 23);
            this.importFileButton.TabIndex = 1;
            this.importFileButton.Text = "Hent fil";
            this.importFileButton.UseVisualStyleBackColor = true;
            this.importFileButton.Click += new System.EventHandler(this.ImportFileButton_Click);
            // 
            // exportFileButton
            // 
            this.exportFileButton.Location = new System.Drawing.Point(42, 98);
            this.exportFileButton.Name = "exportFileButton";
            this.exportFileButton.Size = new System.Drawing.Size(75, 23);
            this.exportFileButton.TabIndex = 1;
            this.exportFileButton.Text = "Eksporter fil";
            this.exportFileButton.UseVisualStyleBackColor = true;
            this.exportFileButton.Click += new System.EventHandler(this.ExportFileButton_Click);
            // 
            // fileDirOutput
            // 
            this.fileDirOutput.Location = new System.Drawing.Point(139, 98);
            this.fileDirOutput.Name = "fileDirOutput";
            this.fileDirOutput.Size = new System.Drawing.Size(242, 20);
            this.fileDirOutput.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 176);
            this.Controls.Add(this.exportFileButton);
            this.Controls.Add(this.importFileButton);
            this.Controls.Add(this.fileDirOutput);
            this.Controls.Add(this.fileDirInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fileDirInput;
        private System.Windows.Forms.Button importFileButton;
        private System.Windows.Forms.Button exportFileButton;
        private System.Windows.Forms.TextBox fileDirOutput;
    }
}


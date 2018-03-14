namespace Untar_Sample
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Button_Extract = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_FilePath = new System.Windows.Forms.TextBox();
            this.Button_ChooseFile = new System.Windows.Forms.Button();
            this.OFDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TextBox_DestDir = new System.Windows.Forms.TextBox();
            this.Button_SelectOutputDir = new System.Windows.Forms.Button();
            this.FBDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // Button_Extract
            // 
            this.Button_Extract.ForeColor = System.Drawing.Color.Black;
            this.Button_Extract.Location = new System.Drawing.Point(276, 72);
            this.Button_Extract.Name = "Button_Extract";
            this.Button_Extract.Size = new System.Drawing.Size(60, 23);
            this.Button_Extract.TabIndex = 0;
            this.Button_Extract.Text = "Extract!";
            this.Button_Extract.UseVisualStyleBackColor = true;
            this.Button_Extract.Click += new System.EventHandler(this.Button_Extract_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tar File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dest Folder";
            // 
            // TextBox_FilePath
            // 
            this.TextBox_FilePath.Location = new System.Drawing.Point(95, 15);
            this.TextBox_FilePath.Name = "TextBox_FilePath";
            this.TextBox_FilePath.Size = new System.Drawing.Size(205, 22);
            this.TextBox_FilePath.TabIndex = 3;
            // 
            // Button_ChooseFile
            // 
            this.Button_ChooseFile.Location = new System.Drawing.Point(305, 14);
            this.Button_ChooseFile.Name = "Button_ChooseFile";
            this.Button_ChooseFile.Size = new System.Drawing.Size(30, 23);
            this.Button_ChooseFile.TabIndex = 4;
            this.Button_ChooseFile.Text = "…";
            this.Button_ChooseFile.UseVisualStyleBackColor = true;
            this.Button_ChooseFile.Click += new System.EventHandler(this.Button_ChooseFile_Click);
            // 
            // OFDialog1
            // 
            this.OFDialog1.FileName = "openFileDialog1";
            // 
            // TextBox_DestDir
            // 
            this.TextBox_DestDir.Location = new System.Drawing.Point(95, 44);
            this.TextBox_DestDir.Name = "TextBox_DestDir";
            this.TextBox_DestDir.Size = new System.Drawing.Size(205, 22);
            this.TextBox_DestDir.TabIndex = 5;
            // 
            // Button_SelectOutputDir
            // 
            this.Button_SelectOutputDir.Location = new System.Drawing.Point(305, 43);
            this.Button_SelectOutputDir.Name = "Button_SelectOutputDir";
            this.Button_SelectOutputDir.Size = new System.Drawing.Size(30, 23);
            this.Button_SelectOutputDir.TabIndex = 6;
            this.Button_SelectOutputDir.Text = "…";
            this.Button_SelectOutputDir.UseVisualStyleBackColor = true;
            this.Button_SelectOutputDir.Click += new System.EventHandler(this.Button_SelectOutputDir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 104);
            this.Controls.Add(this.Button_SelectOutputDir);
            this.Controls.Add(this.TextBox_DestDir);
            this.Controls.Add(this.Button_ChooseFile);
            this.Controls.Add(this.TextBox_FilePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Extract);
            this.Name = "Form1";
            this.Text = "UnTar Sample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Extract;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBox_FilePath;
        private System.Windows.Forms.Button Button_ChooseFile;
        private System.Windows.Forms.OpenFileDialog OFDialog1;
        private System.Windows.Forms.TextBox TextBox_DestDir;
        private System.Windows.Forms.Button Button_SelectOutputDir;
        private System.Windows.Forms.FolderBrowserDialog FBDialog1;
    }
}


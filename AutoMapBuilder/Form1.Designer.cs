namespace AutoMapBuilder
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
            this.btnImportSong = new System.Windows.Forms.Button();
            this.lblSongPathStatic = new System.Windows.Forms.Label();
            this.lblSongPath = new System.Windows.Forms.Label();
            this.btnAnalyzeSong = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnImportSong
            // 
            this.btnImportSong.Location = new System.Drawing.Point(30, 26);
            this.btnImportSong.Name = "btnImportSong";
            this.btnImportSong.Size = new System.Drawing.Size(96, 23);
            this.btnImportSong.TabIndex = 0;
            this.btnImportSong.Text = "Import Song";
            this.btnImportSong.UseVisualStyleBackColor = true;
            this.btnImportSong.Click += new System.EventHandler(this.btnImportSong_Click);
            // 
            // lblSongPathStatic
            // 
            this.lblSongPathStatic.AutoSize = true;
            this.lblSongPathStatic.Location = new System.Drawing.Point(144, 31);
            this.lblSongPathStatic.Name = "lblSongPathStatic";
            this.lblSongPathStatic.Size = new System.Drawing.Size(60, 13);
            this.lblSongPathStatic.TabIndex = 1;
            this.lblSongPathStatic.Text = "Song Path:";
            // 
            // lblSongPath
            // 
            this.lblSongPath.AutoSize = true;
            this.lblSongPath.Location = new System.Drawing.Point(210, 31);
            this.lblSongPath.Name = "lblSongPath";
            this.lblSongPath.Size = new System.Drawing.Size(36, 13);
            this.lblSongPath.TabIndex = 2;
            this.lblSongPath.Text = "Empty";
            // 
            // btnAnalyzeSong
            // 
            this.btnAnalyzeSong.Location = new System.Drawing.Point(30, 70);
            this.btnAnalyzeSong.Name = "btnAnalyzeSong";
            this.btnAnalyzeSong.Size = new System.Drawing.Size(96, 23);
            this.btnAnalyzeSong.TabIndex = 3;
            this.btnAnalyzeSong.Text = "Analyze Song";
            this.btnAnalyzeSong.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(30, 114);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(256, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(317, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Show JSON";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnAnalyzeSong);
            this.Controls.Add(this.lblSongPath);
            this.Controls.Add(this.lblSongPathStatic);
            this.Controls.Add(this.btnImportSong);
            this.Name = "Form1";
            this.Text = "Auto Map Builder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImportSong;
        private System.Windows.Forms.Label lblSongPathStatic;
        private System.Windows.Forms.Label lblSongPath;
        private System.Windows.Forms.Button btnAnalyzeSong;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
    }
}


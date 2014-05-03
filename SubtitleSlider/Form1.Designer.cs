namespace SubtitleSlider
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
            this.FileLocation = new System.Windows.Forms.TextBox();
            this.GetFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SlideTB = new System.Windows.Forms.TextBox();
            this.Slide = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.DirectionCB = new System.Windows.Forms.ComboBox();
            this.Content = new System.Windows.Forms.RichTextBox();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FileLocation
            // 
            this.FileLocation.Location = new System.Drawing.Point(12, 99);
            this.FileLocation.Name = "FileLocation";
            this.FileLocation.Size = new System.Drawing.Size(179, 20);
            this.FileLocation.TabIndex = 0;
            // 
            // GetFile
            // 
            this.GetFile.Location = new System.Drawing.Point(197, 97);
            this.GetFile.Name = "GetFile";
            this.GetFile.Size = new System.Drawing.Size(75, 23);
            this.GetFile.TabIndex = 1;
            this.GetFile.Text = "Gözat";
            this.GetFile.UseVisualStyleBackColor = true;
            this.GetFile.Click += new System.EventHandler(this.GetFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dosya :";
            // 
            // SlideTB
            // 
            this.SlideTB.Location = new System.Drawing.Point(12, 147);
            this.SlideTB.Name = "SlideTB";
            this.SlideTB.Size = new System.Drawing.Size(179, 20);
            this.SlideTB.TabIndex = 0;
            // 
            // Slide
            // 
            this.Slide.Location = new System.Drawing.Point(197, 145);
            this.Slide.Name = "Slide";
            this.Slide.Size = new System.Drawing.Size(75, 23);
            this.Slide.TabIndex = 1;
            this.Slide.Text = "Kaydır";
            this.Slide.UseVisualStyleBackColor = true;
            this.Slide.Click += new System.EventHandler(this.Slide_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kayma (ms) :";
            // 
            // FileDialog
            // 
            this.FileDialog.Filter = ".srt|";
            this.FileDialog.Title = "File Select";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kayma yönü :";
            // 
            // DirectionCB
            // 
            this.DirectionCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DirectionCB.FormattingEnabled = true;
            this.DirectionCB.Items.AddRange(new object[] {
            "Öne",
            "Arkaya"});
            this.DirectionCB.Location = new System.Drawing.Point(93, 171);
            this.DirectionCB.MaxDropDownItems = 2;
            this.DirectionCB.Name = "DirectionCB";
            this.DirectionCB.Size = new System.Drawing.Size(98, 21);
            this.DirectionCB.TabIndex = 4;
            // 
            // Content
            // 
            this.Content.Location = new System.Drawing.Point(278, 13);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(294, 236);
            this.Content.TabIndex = 5;
            this.Content.Text = "";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(197, 225);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 6;
            this.Save.Text = "Kaydet";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.DirectionCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Slide);
            this.Controls.Add(this.GetFile);
            this.Controls.Add(this.SlideTB);
            this.Controls.Add(this.FileLocation);
            this.Name = "Form1";
            this.Text = "Subtitle Slider";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FileLocation;
        private System.Windows.Forms.Button GetFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SlideTB;
        private System.Windows.Forms.Button Slide;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog FileDialog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DirectionCB;
        private System.Windows.Forms.RichTextBox Content;
        private System.Windows.Forms.Button Save;
    }
}


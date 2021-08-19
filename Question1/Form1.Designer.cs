
namespace Albums
{
    partial class windowAlbum
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
            this.albumsListBox = new System.Windows.Forms.ListBox();
            this.albumDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.albumsGroupBox = new System.Windows.Forms.GroupBox();
            this.albumDetailsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.albumDetailsGroupBox.SuspendLayout();
            this.albumsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // albumsListBox
            // 
            this.albumsListBox.FormattingEnabled = true;
            this.albumsListBox.ItemHeight = 16;
            this.albumsListBox.Location = new System.Drawing.Point(18, 21);
            this.albumsListBox.Name = "albumsListBox";
            this.albumsListBox.Size = new System.Drawing.Size(243, 292);
            this.albumsListBox.TabIndex = 0;
            this.albumsListBox.SelectedIndexChanged += new System.EventHandler(this.albumsListBox_SelectedIndexChanged);
            // 
            // albumDetailsGroupBox
            // 
            this.albumDetailsGroupBox.Controls.Add(this.albumDetailsRichTextBox);
            this.albumDetailsGroupBox.Location = new System.Drawing.Point(341, 22);
            this.albumDetailsGroupBox.Name = "albumDetailsGroupBox";
            this.albumDetailsGroupBox.Size = new System.Drawing.Size(368, 324);
            this.albumDetailsGroupBox.TabIndex = 1;
            this.albumDetailsGroupBox.TabStop = false;
            this.albumDetailsGroupBox.Text = "Album Details";
            // 
            // albumsGroupBox
            // 
            this.albumsGroupBox.Controls.Add(this.albumsListBox);
            this.albumsGroupBox.Location = new System.Drawing.Point(12, 22);
            this.albumsGroupBox.Name = "albumsGroupBox";
            this.albumsGroupBox.Size = new System.Drawing.Size(323, 324);
            this.albumsGroupBox.TabIndex = 2;
            this.albumsGroupBox.TabStop = false;
            this.albumsGroupBox.Text = "Albums";
            // 
            // albumDetailsRichTextBox
            // 
            this.albumDetailsRichTextBox.Location = new System.Drawing.Point(19, 21);
            this.albumDetailsRichTextBox.Name = "albumDetailsRichTextBox";
            this.albumDetailsRichTextBox.Size = new System.Drawing.Size(384, 292);
            this.albumDetailsRichTextBox.TabIndex = 0;
            this.albumDetailsRichTextBox.Text = "";
            // 
            // windowAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 376);
            this.Controls.Add(this.albumsGroupBox);
            this.Controls.Add(this.albumDetailsGroupBox);
            this.Name = "windowAlbum";
            this.Text = "Albums";
            this.albumDetailsGroupBox.ResumeLayout(false);
            this.albumsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox albumsListBox;
        private System.Windows.Forms.GroupBox albumDetailsGroupBox;
        private System.Windows.Forms.GroupBox albumsGroupBox;
        private System.Windows.Forms.RichTextBox albumDetailsRichTextBox;
    }
}


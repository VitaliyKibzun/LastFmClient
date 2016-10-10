namespace LastFMClientWinForm
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
            this.label1Genre = new System.Windows.Forms.Label();
            this.comboBox1Tags = new System.Windows.Forms.ComboBox();
            this.textBox1Tracks = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1Genre
            // 
            this.label1Genre.AutoSize = true;
            this.label1Genre.Location = new System.Drawing.Point(13, 13);
            this.label1Genre.Name = "label1Genre";
            this.label1Genre.Size = new System.Drawing.Size(69, 13);
            this.label1Genre.TabIndex = 1;
            this.label1Genre.Text = "Select Genre";
            // 
            // comboBox1Tags
            // 
            this.comboBox1Tags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1Tags.Location = new System.Drawing.Point(13, 30);
            this.comboBox1Tags.Name = "comboBox1Tags";
            this.comboBox1Tags.Size = new System.Drawing.Size(353, 21);
            this.comboBox1Tags.TabIndex = 2;
            this.comboBox1Tags.SelectedIndexChanged += new System.EventHandler(this.comboBox1Tags_SelectedIndexChanged);
            // 
            // textBox1Tracks
            // 
            this.textBox1Tracks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1Tracks.Location = new System.Drawing.Point(12, 57);
            this.textBox1Tracks.Multiline = true;
            this.textBox1Tracks.Name = "textBox1Tracks";
            this.textBox1Tracks.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1Tracks.Size = new System.Drawing.Size(354, 564);
            this.textBox1Tracks.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 630);
            this.Controls.Add(this.textBox1Tracks);
            this.Controls.Add(this.comboBox1Tags);
            this.Controls.Add(this.label1Genre);
            this.Name = "Form1";
            this.Text = "Show Top Tracks";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1Genre;
        private System.Windows.Forms.ComboBox comboBox1Tags;
        private System.Windows.Forms.TextBox textBox1Tracks;
    }
}


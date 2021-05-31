
namespace LAB4
{
    partial class BAI2
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
            this.btnPost = new System.Windows.Forms.Button();
            this.URL = new System.Windows.Forms.TextBox();
            this.dataBox = new System.Windows.Forms.TextBox();
            this.HTMLcontent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPost
            // 
            this.btnPost.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnPost.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPost.Location = new System.Drawing.Point(627, 25);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(149, 36);
            this.btnPost.TabIndex = 0;
            this.btnPost.Text = "POST";
            this.btnPost.UseVisualStyleBackColor = false;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // URL
            // 
            this.URL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URL.Location = new System.Drawing.Point(28, 26);
            this.URL.Multiline = true;
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(552, 34);
            this.URL.TabIndex = 1;
            // 
            // dataBox
            // 
            this.dataBox.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataBox.Location = new System.Drawing.Point(28, 86);
            this.dataBox.Multiline = true;
            this.dataBox.Name = "dataBox";
            this.dataBox.Size = new System.Drawing.Size(552, 34);
            this.dataBox.TabIndex = 2;
            // 
            // HTMLcontent
            // 
            this.HTMLcontent.BackColor = System.Drawing.Color.White;
            this.HTMLcontent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HTMLcontent.Location = new System.Drawing.Point(27, 147);
            this.HTMLcontent.Multiline = true;
            this.HTMLcontent.Name = "HTMLcontent";
            this.HTMLcontent.ReadOnly = true;
            this.HTMLcontent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.HTMLcontent.Size = new System.Drawing.Size(748, 315);
            this.HTMLcontent.TabIndex = 3;
            // 
            // BAI2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.HTMLcontent);
            this.Controls.Add(this.dataBox);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.btnPost);
            this.Name = "BAI2";
            this.Text = "BAI2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.TextBox URL;
        private System.Windows.Forms.TextBox dataBox;
        private System.Windows.Forms.TextBox HTMLcontent;
    }
}

namespace LAB4
{
    partial class ViewSourcePage
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
            this.HTMLcontent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HTMLcontent
            // 
            this.HTMLcontent.BackColor = System.Drawing.Color.White;
            this.HTMLcontent.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HTMLcontent.Location = new System.Drawing.Point(12, 12);
            this.HTMLcontent.Multiline = true;
            this.HTMLcontent.Name = "HTMLcontent";
            this.HTMLcontent.ReadOnly = true;
            this.HTMLcontent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.HTMLcontent.Size = new System.Drawing.Size(776, 426);
            this.HTMLcontent.TabIndex = 4;
            // 
            // ViewSourcePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HTMLcontent);
            this.Name = "ViewSourcePage";
            this.Text = "Properties";
            this.Load += new System.EventHandler(this.ViewSourcePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HTMLcontent;
    }
}
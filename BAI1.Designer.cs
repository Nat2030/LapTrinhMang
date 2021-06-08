namespace Lab4_LTM
{
    partial class Bai1
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
            this.richTextBox_Data_html = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_URL = new System.Windows.Forms.TextBox();
            this.btn_Get = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox_Data_html
            // 
            this.richTextBox_Data_html.Location = new System.Drawing.Point(49, 83);
            this.richTextBox_Data_html.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox_Data_html.Name = "richTextBox_Data_html";
            this.richTextBox_Data_html.Size = new System.Drawing.Size(524, 244);
            this.richTextBox_Data_html.TabIndex = 7;
            this.richTextBox_Data_html.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "URL :";
            // 
            // txb_URL
            // 
            this.txb_URL.Location = new System.Drawing.Point(109, 33);
            this.txb_URL.Margin = new System.Windows.Forms.Padding(2);
            this.txb_URL.Name = "txb_URL";
            this.txb_URL.Size = new System.Drawing.Size(165, 20);
            this.txb_URL.TabIndex = 5;
            // 
            // btn_Get
            // 
            this.btn_Get.Location = new System.Drawing.Point(467, 22);
            this.btn_Get.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Get.Name = "btn_Get";
            this.btn_Get.Size = new System.Drawing.Size(105, 40);
            this.btn_Get.TabIndex = 4;
            this.btn_Get.Text = "GET";
            this.btn_Get.UseVisualStyleBackColor = true;
            this.btn_Get.Click += new System.EventHandler(this.btn_Get_Click);
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox_Data_html);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_URL);
            this.Controls.Add(this.btn_Get);
            this.Name = "Bai1";
            this.Text = "BAI1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_Data_html;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_URL;
        private System.Windows.Forms.Button btn_Get;
    }
}


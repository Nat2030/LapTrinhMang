
namespace LAB4
{
    partial class MENUFORM
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
            this.BAI1 = new System.Windows.Forms.Button();
            this.BAI4 = new System.Windows.Forms.Button();
            this.BAI3 = new System.Windows.Forms.Button();
            this.BAI2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BAI1
            // 
            this.BAI1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BAI1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAI1.Location = new System.Drawing.Point(127, 51);
            this.BAI1.Name = "BAI1";
            this.BAI1.Size = new System.Drawing.Size(190, 47);
            this.BAI1.TabIndex = 0;
            this.BAI1.Text = "BAI1";
            this.BAI1.UseVisualStyleBackColor = false;
            this.BAI1.Click += new System.EventHandler(this.BAI1_Click);
            // 
            // BAI4
            // 
            this.BAI4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BAI4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAI4.Location = new System.Drawing.Point(462, 149);
            this.BAI4.Name = "BAI4";
            this.BAI4.Size = new System.Drawing.Size(190, 47);
            this.BAI4.TabIndex = 1;
            this.BAI4.Text = "BAI4";
            this.BAI4.UseVisualStyleBackColor = false;
            this.BAI4.Click += new System.EventHandler(this.BAI4_Click);
            // 
            // BAI3
            // 
            this.BAI3.BackColor = System.Drawing.Color.Gold;
            this.BAI3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAI3.Location = new System.Drawing.Point(127, 149);
            this.BAI3.Name = "BAI3";
            this.BAI3.Size = new System.Drawing.Size(190, 47);
            this.BAI3.TabIndex = 2;
            this.BAI3.Text = "BAI3";
            this.BAI3.UseVisualStyleBackColor = false;
            this.BAI3.Click += new System.EventHandler(this.BAI3_Click);
            // 
            // BAI2
            // 
            this.BAI2.BackColor = System.Drawing.Color.Peru;
            this.BAI2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAI2.Location = new System.Drawing.Point(462, 51);
            this.BAI2.Name = "BAI2";
            this.BAI2.Size = new System.Drawing.Size(190, 47);
            this.BAI2.TabIndex = 3;
            this.BAI2.Text = "BAI2";
            this.BAI2.UseVisualStyleBackColor = false;
            this.BAI2.Click += new System.EventHandler(this.BAI2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(54, 249);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(408, 40);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "19521906 - Nguyễn Bảo Ngọc";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(54, 319);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(466, 40);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "19522175 - Nguyễn Trương Duy Tân";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(54, 387);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(408, 40);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "19522415 - Lương Trung Trực";
            // 
            // MENUFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BAI2);
            this.Controls.Add(this.BAI3);
            this.Controls.Add(this.BAI4);
            this.Controls.Add(this.BAI1);
            this.Name = "MENUFORM";
            this.Text = "MENUFORM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BAI1;
        private System.Windows.Forms.Button BAI4;
        private System.Windows.Forms.Button BAI3;
        private System.Windows.Forms.Button BAI2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}


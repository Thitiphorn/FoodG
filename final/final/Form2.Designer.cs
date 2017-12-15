namespace final
{
    partial class Form2
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
            this.Tb_fg = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tb_fg
            // 
            this.Tb_fg.Location = new System.Drawing.Point(86, 55);
            this.Tb_fg.Multiline = true;
            this.Tb_fg.Name = "Tb_fg";
            this.Tb_fg.Size = new System.Drawing.Size(116, 39);
            this.Tb_fg.TabIndex = 0;
            this.Tb_fg.TextChanged += new System.EventHandler(this.Tb_fg_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "ตกลง";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Tb_fg);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tb_fg;
        private System.Windows.Forms.Button button1;
    }
}
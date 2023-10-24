namespace sınavor
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rbTek = new System.Windows.Forms.RadioButton();
            this.rbCift = new System.Windows.Forms.RadioButton();
            this.btnDagit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(447, 85);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(135, 238);
            this.listBox1.TabIndex = 0;
            // 
            // rbTek
            // 
            this.rbTek.AutoSize = true;
            this.rbTek.Location = new System.Drawing.Point(339, 128);
            this.rbTek.Name = "rbTek";
            this.rbTek.Size = new System.Drawing.Size(44, 17);
            this.rbTek.TabIndex = 1;
            this.rbTek.TabStop = true;
            this.rbTek.Text = "Tek";
            this.rbTek.UseVisualStyleBackColor = true;
            // 
            // rbCift
            // 
            this.rbCift.AutoSize = true;
            this.rbCift.Location = new System.Drawing.Point(339, 181);
            this.rbCift.Name = "rbCift";
            this.rbCift.Size = new System.Drawing.Size(40, 17);
            this.rbCift.TabIndex = 2;
            this.rbCift.TabStop = true;
            this.rbCift.Text = "Çift";
            this.rbCift.UseVisualStyleBackColor = true;
            // 
            // btnDagit
            // 
            this.btnDagit.Location = new System.Drawing.Point(138, 128);
            this.btnDagit.Name = "btnDagit";
            this.btnDagit.Size = new System.Drawing.Size(112, 51);
            this.btnDagit.TabIndex = 3;
            this.btnDagit.Text = "Dağıt";
            this.btnDagit.UseVisualStyleBackColor = true;
            this.btnDagit.Click += new System.EventHandler(this.btnDagit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDagit);
            this.Controls.Add(this.rbCift);
            this.Controls.Add(this.rbTek);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton rbTek;
        private System.Windows.Forms.RadioButton rbCift;
        private System.Windows.Forms.Button btnDagit;
    }
}


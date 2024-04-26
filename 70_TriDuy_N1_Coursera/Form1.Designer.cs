
namespace _70_TriDuy_N1_Coursera
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
            this.btTestCase1_1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btTestCase1_1
            // 
            this.btTestCase1_1.AutoSize = true;
            this.btTestCase1_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTestCase1_1.Location = new System.Drawing.Point(82, 105);
            this.btTestCase1_1.Name = "btTestCase1_1";
            this.btTestCase1_1.Size = new System.Drawing.Size(140, 44);
            this.btTestCase1_1.TabIndex = 0;
            this.btTestCase1_1.Text = "TestCase1_1";
            this.btTestCase1_1.UseVisualStyleBackColor = true;
            this.btTestCase1_1.Click += new System.EventHandler(this.btTestCase1_1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1590, 800);
            this.Controls.Add(this.btTestCase1_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btTestCase1_1;
    }
}


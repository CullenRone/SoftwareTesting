
namespace Triangle
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbCanh1 = new System.Windows.Forms.Label();
            this.lbCanh2 = new System.Windows.Forms.Label();
            this.lbCanh3 = new System.Windows.Forms.Label();
            this.btnKiemtra = new System.Windows.Forms.Button();
            this.txtCanh1 = new System.Windows.Forms.TextBox();
            this.txtCanh2 = new System.Windows.Forms.TextBox();
            this.txtCanh3 = new System.Windows.Forms.TextBox();
            this.txtThongbao = new System.Windows.Forms.TextBox();
            this.btnTinhCV = new System.Windows.Forms.Button();
            this.btnTinhDT = new System.Windows.Forms.Button();
            this.txtCV = new System.Windows.Forms.TextBox();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "KIỂM TRA TAM GIÁC";
            // 
            // lbCanh1
            // 
            this.lbCanh1.AutoSize = true;
            this.lbCanh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCanh1.Location = new System.Drawing.Point(40, 108);
            this.lbCanh1.Name = "lbCanh1";
            this.lbCanh1.Size = new System.Drawing.Size(193, 24);
            this.lbCanh1.TabIndex = 1;
            this.lbCanh1.Text = "Nhập cạnh thứ nhắt";
            // 
            // lbCanh2
            // 
            this.lbCanh2.AutoSize = true;
            this.lbCanh2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCanh2.Location = new System.Drawing.Point(40, 167);
            this.lbCanh2.Name = "lbCanh2";
            this.lbCanh2.Size = new System.Drawing.Size(181, 24);
            this.lbCanh2.TabIndex = 2;
            this.lbCanh2.Text = "Nhập cạnh thứ hai";
            // 
            // lbCanh3
            // 
            this.lbCanh3.AutoSize = true;
            this.lbCanh3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCanh3.Location = new System.Drawing.Point(40, 227);
            this.lbCanh3.Name = "lbCanh3";
            this.lbCanh3.Size = new System.Drawing.Size(176, 24);
            this.lbCanh3.TabIndex = 3;
            this.lbCanh3.Text = "Nhập cạnh thứ ba";
            // 
            // btnKiemtra
            // 
            this.btnKiemtra.AutoSize = true;
            this.btnKiemtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKiemtra.Location = new System.Drawing.Point(533, 108);
            this.btnKiemtra.Name = "btnKiemtra";
            this.btnKiemtra.Size = new System.Drawing.Size(88, 34);
            this.btnKiemtra.TabIndex = 4;
            this.btnKiemtra.Text = "Kiểm tra";
            this.btnKiemtra.UseVisualStyleBackColor = true;
            this.btnKiemtra.Click += new System.EventHandler(this.btnKiemtra_Click);
            // 
            // txtCanh1
            // 
            this.txtCanh1.Location = new System.Drawing.Point(282, 108);
            this.txtCanh1.Name = "txtCanh1";
            this.txtCanh1.Size = new System.Drawing.Size(100, 20);
            this.txtCanh1.TabIndex = 5;
            // 
            // txtCanh2
            // 
            this.txtCanh2.Location = new System.Drawing.Point(282, 167);
            this.txtCanh2.Name = "txtCanh2";
            this.txtCanh2.Size = new System.Drawing.Size(100, 20);
            this.txtCanh2.TabIndex = 6;
            // 
            // txtCanh3
            // 
            this.txtCanh3.Location = new System.Drawing.Point(282, 232);
            this.txtCanh3.Name = "txtCanh3";
            this.txtCanh3.Size = new System.Drawing.Size(100, 20);
            this.txtCanh3.TabIndex = 7;
            // 
            // txtThongbao
            // 
            this.txtThongbao.Location = new System.Drawing.Point(485, 172);
            this.txtThongbao.Name = "txtThongbao";
            this.txtThongbao.Size = new System.Drawing.Size(198, 20);
            this.txtThongbao.TabIndex = 8;
            // 
            // btnTinhCV
            // 
            this.btnTinhCV.AutoSize = true;
            this.btnTinhCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhCV.Location = new System.Drawing.Point(44, 291);
            this.btnTinhCV.Name = "btnTinhCV";
            this.btnTinhCV.Size = new System.Drawing.Size(88, 34);
            this.btnTinhCV.TabIndex = 9;
            this.btnTinhCV.Text = "Chu vi";
            this.btnTinhCV.UseVisualStyleBackColor = true;
            this.btnTinhCV.Click += new System.EventHandler(this.btnTinhCV_Click);
            // 
            // btnTinhDT
            // 
            this.btnTinhDT.AutoSize = true;
            this.btnTinhDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhDT.Location = new System.Drawing.Point(405, 291);
            this.btnTinhDT.Name = "btnTinhDT";
            this.btnTinhDT.Size = new System.Drawing.Size(93, 34);
            this.btnTinhDT.TabIndex = 10;
            this.btnTinhDT.Text = "Diện tích";
            this.btnTinhDT.UseVisualStyleBackColor = true;
            this.btnTinhDT.Click += new System.EventHandler(this.btnTinhDT_Click);
            // 
            // txtCV
            // 
            this.txtCV.Location = new System.Drawing.Point(44, 356);
            this.txtCV.Name = "txtCV";
            this.txtCV.Size = new System.Drawing.Size(122, 20);
            this.txtCV.TabIndex = 11;
            // 
            // txtDT
            // 
            this.txtDT.Location = new System.Drawing.Point(405, 356);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(122, 20);
            this.txtDT.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDT);
            this.Controls.Add(this.txtCV);
            this.Controls.Add(this.btnTinhDT);
            this.Controls.Add(this.btnTinhCV);
            this.Controls.Add(this.txtThongbao);
            this.Controls.Add(this.txtCanh3);
            this.Controls.Add(this.txtCanh2);
            this.Controls.Add(this.txtCanh1);
            this.Controls.Add(this.btnKiemtra);
            this.Controls.Add(this.lbCanh3);
            this.Controls.Add(this.lbCanh2);
            this.Controls.Add(this.lbCanh1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "TAM GIÁC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCanh1;
        private System.Windows.Forms.Label lbCanh2;
        private System.Windows.Forms.Label lbCanh3;
        private System.Windows.Forms.Button btnKiemtra;
        private System.Windows.Forms.TextBox txtCanh1;
        private System.Windows.Forms.TextBox txtCanh2;
        private System.Windows.Forms.TextBox txtCanh3;
        private System.Windows.Forms.TextBox txtThongbao;
        private System.Windows.Forms.Button btnTinhCV;
        private System.Windows.Forms.Button btnTinhDT;
        private System.Windows.Forms.TextBox txtCV;
        private System.Windows.Forms.TextBox txtDT;
    }
}


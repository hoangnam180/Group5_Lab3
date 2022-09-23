
namespace WindowsFormsApp1
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
            this.btn_reset = new System.Windows.Forms.Button();
            this.kq = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.btn_cong = new System.Windows.Forms.Button();
            this.bnt_chia = new System.Windows.Forms.Button();
            this.btn_nhan = new System.Windows.Forms.Button();
            this.btn_tru = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(573, 274);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 24;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // kq
            // 
            this.kq.Location = new System.Drawing.Point(563, 172);
            this.kq.Name = "kq";
            this.kq.Size = new System.Drawing.Size(75, 23);
            this.kq.TabIndex = 23;
            this.kq.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Kết quả : ";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(270, 206);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(166, 20);
            this.txtB.TabIndex = 21;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(270, 154);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(166, 20);
            this.txtA.TabIndex = 20;
            // 
            // btn_cong
            // 
            this.btn_cong.Location = new System.Drawing.Point(152, 274);
            this.btn_cong.Name = "btn_cong";
            this.btn_cong.Size = new System.Drawing.Size(75, 23);
            this.btn_cong.TabIndex = 19;
            this.btn_cong.Text = "Cộng";
            this.btn_cong.UseVisualStyleBackColor = true;
            this.btn_cong.Click += new System.EventHandler(this.btn_cong_Click);
            // 
            // bnt_chia
            // 
            this.bnt_chia.Location = new System.Drawing.Point(464, 274);
            this.bnt_chia.Name = "bnt_chia";
            this.bnt_chia.Size = new System.Drawing.Size(75, 23);
            this.bnt_chia.TabIndex = 18;
            this.bnt_chia.Text = "Chia";
            this.bnt_chia.UseVisualStyleBackColor = true;
            this.bnt_chia.Click += new System.EventHandler(this.bnt_chia_Click);
            // 
            // btn_nhan
            // 
            this.btn_nhan.Location = new System.Drawing.Point(361, 274);
            this.btn_nhan.Name = "btn_nhan";
            this.btn_nhan.Size = new System.Drawing.Size(75, 23);
            this.btn_nhan.TabIndex = 17;
            this.btn_nhan.Text = "Nhân ";
            this.btn_nhan.UseVisualStyleBackColor = true;
            this.btn_nhan.Click += new System.EventHandler(this.btn_nhan_Click);
            // 
            // btn_tru
            // 
            this.btn_tru.Location = new System.Drawing.Point(258, 274);
            this.btn_tru.Name = "btn_tru";
            this.btn_tru.Size = new System.Drawing.Size(75, 23);
            this.btn_tru.TabIndex = 16;
            this.btn_tru.Text = "Trừ ";
            this.btn_tru.UseVisualStyleBackColor = true;
            this.btn_tru.Click += new System.EventHandler(this.btn_tru_Click);
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.Location = new System.Drawing.Point(166, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 15;
            this.button1.Text = "\\";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Số B :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Số A :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.kq);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.btn_cong);
            this.Controls.Add(this.bnt_chia);
            this.Controls.Add(this.btn_nhan);
            this.Controls.Add(this.btn_tru);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button kq;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtB;
        public System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Button btn_cong;
        private System.Windows.Forms.Button bnt_chia;
        private System.Windows.Forms.Button btn_nhan;
        private System.Windows.Forms.Button btn_tru;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}


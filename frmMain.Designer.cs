namespace CShar_loginform
{
    partial class frmMain
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
            this.txtso = new System.Windows.Forms.TextBox();
            this.btntinh = new System.Windows.Forms.Button();
            this.lbxkq = new System.Windows.Forms.ListBox();
            this.btnboi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtgioihan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số";
            // 
            // txtso
            // 
            this.txtso.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtso.Location = new System.Drawing.Point(138, 22);
            this.txtso.Name = "txtso";
            this.txtso.Size = new System.Drawing.Size(161, 30);
            this.txtso.TabIndex = 2;
            this.txtso.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtso_MouseClick);
            this.txtso.TextChanged += new System.EventHandler(this.txtso_TextChanged);
            // 
            // btntinh
            // 
            this.btntinh.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntinh.Location = new System.Drawing.Point(39, 154);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(136, 36);
            this.btntinh.TabIndex = 3;
            this.btntinh.Text = "Ước";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // lbxkq
            // 
            this.lbxkq.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxkq.FormattingEnabled = true;
            this.lbxkq.ItemHeight = 23;
            this.lbxkq.Location = new System.Drawing.Point(38, 239);
            this.lbxkq.Name = "lbxkq";
            this.lbxkq.Size = new System.Drawing.Size(276, 165);
            this.lbxkq.TabIndex = 4;
            // 
            // btnboi
            // 
            this.btnboi.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnboi.Location = new System.Drawing.Point(212, 154);
            this.btnboi.Name = "btnboi";
            this.btnboi.Size = new System.Drawing.Size(122, 36);
            this.btnboi.TabIndex = 5;
            this.btnboi.Text = "Bội";
            this.btnboi.UseVisualStyleBackColor = true;
            this.btnboi.Click += new System.EventHandler(this.btnboi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Giới hạn";
            // 
            // txtgioihan
            // 
            this.txtgioihan.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgioihan.Location = new System.Drawing.Point(138, 89);
            this.txtgioihan.Name = "txtgioihan";
            this.txtgioihan.Size = new System.Drawing.Size(161, 30);
            this.txtgioihan.TabIndex = 7;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(408, 450);
            this.ControlBox = false;
            this.Controls.Add(this.txtgioihan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnboi);
            this.Controls.Add(this.lbxkq);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.txtso);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtso;
        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.ListBox lbxkq;
        private System.Windows.Forms.Button btnboi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtgioihan;
    }
}
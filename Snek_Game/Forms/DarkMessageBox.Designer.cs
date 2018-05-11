namespace Snek_Game
{
    partial class DarkMessageBox
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_WndInfo = new System.Windows.Forms.Label();
            this.btn_CloseWnd = new System.Windows.Forms.Button();
            this.lbl_text = new System.Windows.Forms.Label();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_WndInfo
            // 
            this.lbl_WndInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_WndInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_WndInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WndInfo.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_WndInfo.Location = new System.Drawing.Point(0, 0);
            this.lbl_WndInfo.Name = "lbl_WndInfo";
            this.lbl_WndInfo.Size = new System.Drawing.Size(539, 27);
            this.lbl_WndInfo.TabIndex = 0;
            this.lbl_WndInfo.Text = this.Text;
            this.lbl_WndInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.lbl_WndInfo_Paint);
            this.lbl_WndInfo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_WndInfo_MouseDown);
            this.lbl_WndInfo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_WndInfo_MouseMove);
            this.lbl_WndInfo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbl_WndInfo_MouseUp);
            // 
            // btn_CloseWnd
            // 
            this.btn_CloseWnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CloseWnd.BackColor = System.Drawing.Color.Maroon;
            this.btn_CloseWnd.FlatAppearance.BorderSize = 0;
            this.btn_CloseWnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CloseWnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CloseWnd.Location = new System.Drawing.Point(498, 0);
            this.btn_CloseWnd.Name = "btn_CloseWnd";
            this.btn_CloseWnd.Size = new System.Drawing.Size(36, 22);
            this.btn_CloseWnd.TabIndex = 4;
            this.btn_CloseWnd.Text = "X";
            this.btn_CloseWnd.UseVisualStyleBackColor = false;
            this.btn_CloseWnd.Click += new System.EventHandler(this.btn_CloseWnd_Click);
            // 
            // lbl_text
            // 
            this.lbl_text.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_text.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_text.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_text.Location = new System.Drawing.Point(0, 27);
            this.lbl_text.Name = "lbl_text";
            this.lbl_text.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_text.Size = new System.Drawing.Size(539, 159);
            this.lbl_text.TabIndex = 5;
            this.lbl_text.Text = "Hi im gonna\r\nbe the message\r\nhere";
            this.lbl_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_text.Paint += new System.Windows.Forms.PaintEventHandler(this.lbl_text_Paint);
            // 
            // btn_Ok
            // 
            this.btn_Ok.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Ok.BackColor = System.Drawing.Color.Maroon;
            this.btn_Ok.FlatAppearance.BorderSize = 0;
            this.btn_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ok.Location = new System.Drawing.Point(215, 194);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(103, 22);
            this.btn_Ok.TabIndex = 6;
            this.btn_Ok.Text = "Ok";
            this.btn_Ok.UseVisualStyleBackColor = false;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // DarkMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(539, 228);
            this.Controls.Add(this.lbl_text);
            this.Controls.Add(this.btn_CloseWnd);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.lbl_WndInfo);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DarkMessageBox";
            this.Text = "DarkMessageBox";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DarkMessageBox_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_WndInfo;
        private System.Windows.Forms.Button btn_CloseWnd;
        private System.Windows.Forms.Label lbl_text;
        private System.Windows.Forms.Button btn_Ok;
    }
}


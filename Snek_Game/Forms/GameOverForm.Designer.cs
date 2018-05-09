namespace Snek_Game.Forms
{
    partial class GameOverForm
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
            this.lbl_score = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
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
            this.lbl_WndInfo.Size = new System.Drawing.Size(448, 27);
            this.lbl_WndInfo.TabIndex = 0;
            this.lbl_WndInfo.Text = this.Text;
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
            this.btn_CloseWnd.Location = new System.Drawing.Point(407, 0);
            this.btn_CloseWnd.Name = "btn_CloseWnd";
            this.btn_CloseWnd.Size = new System.Drawing.Size(36, 22);
            this.btn_CloseWnd.TabIndex = 4;
            this.btn_CloseWnd.Text = "X";
            this.btn_CloseWnd.UseVisualStyleBackColor = false;
            this.btn_CloseWnd.Click += new System.EventHandler(this.btn_CloseWnd_Click);
            // 
            // lbl_score
            // 
            this.lbl_score.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_score.Location = new System.Drawing.Point(0, 27);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(448, 85);
            this.lbl_score.TabIndex = 5;
            this.lbl_score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txt_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_name.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(0, 149);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(448, 55);
            this.txt_name.TabIndex = 8;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_submit
            // 
            this.btn_submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_submit.BackColor = System.Drawing.Color.Maroon;
            this.btn_submit.FlatAppearance.BorderSize = 0;
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.Location = new System.Drawing.Point(129, 225);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(135, 37);
            this.btn_submit.TabIndex = 9;
            this.btn_submit.Text = "Submit Score";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // GameOverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(448, 274);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.btn_CloseWnd);
            this.Controls.Add(this.lbl_WndInfo);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameOverForm";
            this.Text = "Game Over!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_WndInfo;
        private System.Windows.Forms.Button btn_CloseWnd;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
    }
}


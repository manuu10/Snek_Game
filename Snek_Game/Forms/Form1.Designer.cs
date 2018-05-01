namespace Snek_Game
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lbl_WndInfo = new System.Windows.Forms.Label();
            this.btn_CloseWnd = new System.Windows.Forms.Button();
            this.pbGameCanvas = new System.Windows.Forms.PictureBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnright = new System.Windows.Forms.Button();
            this.btnleft = new System.Windows.Forms.Button();
            this.btndown = new System.Windows.Forms.Button();
            this.tmr_Game = new System.Windows.Forms.Timer(this.components);
            this.btnadd = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.tmr_Draw = new System.Windows.Forms.Timer(this.components);
            this.btn_reset = new System.Windows.Forms.Button();
            this.chk_toggleGrid = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbljoyinfo = new System.Windows.Forms.Label();
            this.grpBox_info = new System.Windows.Forms.GroupBox();
            this.lbl_info_bullets = new System.Windows.Forms.Label();
            this.lbl_info_obstacles = new System.Windows.Forms.Label();
            this.lbl_info_speedy = new System.Windows.Forms.Label();
            this.lbl_info_slow = new System.Windows.Forms.Label();
            this.lbl_info_invincible = new System.Windows.Forms.Label();
            this.lbl_info_doubleFood = new System.Windows.Forms.Label();
            this.lbl_snekSpeed = new System.Windows.Forms.Label();
            this.lbl_snekSize = new System.Windows.Forms.Label();
            this.btn_Help = new System.Windows.Forms.Button();
            this.btn_opencfg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameCanvas)).BeginInit();
            this.panel1.SuspendLayout();
            this.grpBox_info.SuspendLayout();
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
            this.lbl_WndInfo.Size = new System.Drawing.Size(1468, 27);
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
            this.btn_CloseWnd.Location = new System.Drawing.Point(1427, 0);
            this.btn_CloseWnd.Name = "btn_CloseWnd";
            this.btn_CloseWnd.Size = new System.Drawing.Size(36, 22);
            this.btn_CloseWnd.TabIndex = 4;
            this.btn_CloseWnd.Text = "X";
            this.btn_CloseWnd.UseVisualStyleBackColor = false;
            this.btn_CloseWnd.Click += new System.EventHandler(this.btn_CloseWnd_Click);
            // 
            // pbGameCanvas
            // 
            this.pbGameCanvas.BackColor = System.Drawing.Color.Black;
            this.pbGameCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbGameCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbGameCanvas.Location = new System.Drawing.Point(0, 164);
            this.pbGameCanvas.Name = "pbGameCanvas";
            this.pbGameCanvas.Size = new System.Drawing.Size(1468, 791);
            this.pbGameCanvas.TabIndex = 5;
            this.pbGameCanvas.TabStop = false;
            this.pbGameCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbGameCanvas_Paint);
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.Maroon;
            this.btn_start.FlatAppearance.BorderSize = 0;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(24, 15);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(114, 35);
            this.btn_start.TabIndex = 6;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(444, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 25);
            this.button2.TabIndex = 7;
            this.button2.Text = "up";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnControlss);
            // 
            // btnright
            // 
            this.btnright.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnright.FlatAppearance.BorderSize = 0;
            this.btnright.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnright.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnright.Location = new System.Drawing.Point(501, 46);
            this.btnright.Name = "btnright";
            this.btnright.Size = new System.Drawing.Size(60, 25);
            this.btnright.TabIndex = 8;
            this.btnright.Text = "right";
            this.btnright.UseVisualStyleBackColor = false;
            this.btnright.Click += new System.EventHandler(this.btnControlss);
            // 
            // btnleft
            // 
            this.btnleft.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnleft.FlatAppearance.BorderSize = 0;
            this.btnleft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnleft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnleft.Location = new System.Drawing.Point(386, 46);
            this.btnleft.Name = "btnleft";
            this.btnleft.Size = new System.Drawing.Size(60, 25);
            this.btnleft.TabIndex = 9;
            this.btnleft.Text = "left";
            this.btnleft.UseVisualStyleBackColor = false;
            this.btnleft.Click += new System.EventHandler(this.btnControlss);
            // 
            // btndown
            // 
            this.btndown.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btndown.FlatAppearance.BorderSize = 0;
            this.btndown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndown.Location = new System.Drawing.Point(444, 77);
            this.btndown.Name = "btndown";
            this.btndown.Size = new System.Drawing.Size(60, 25);
            this.btndown.TabIndex = 10;
            this.btndown.Text = "down";
            this.btndown.UseVisualStyleBackColor = false;
            this.btndown.Click += new System.EventHandler(this.btnControlss);
            // 
            // tmr_Game
            // 
            this.tmr_Game.Tick += new System.EventHandler(this.tmr_Game_Tick);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(144, 40);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(85, 37);
            this.btnadd.TabIndex = 11;
            this.btnadd.Text = "add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.Color.Maroon;
            this.btn_stop.FlatAppearance.BorderSize = 0;
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stop.Location = new System.Drawing.Point(24, 56);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(114, 35);
            this.btn_stop.TabIndex = 12;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // tmr_Draw
            // 
            this.tmr_Draw.Tick += new System.EventHandler(this.tmr_Draw_Tick);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.Black;
            this.btn_reset.FlatAppearance.BorderSize = 0;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(235, 40);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(60, 37);
            this.btn_reset.TabIndex = 13;
            this.btn_reset.Text = "reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // chk_toggleGrid
            // 
            this.chk_toggleGrid.AutoSize = true;
            this.chk_toggleGrid.Location = new System.Drawing.Point(24, 97);
            this.chk_toggleGrid.Name = "chk_toggleGrid";
            this.chk_toggleGrid.Size = new System.Drawing.Size(121, 17);
            this.chk_toggleGrid.TabIndex = 14;
            this.chk_toggleGrid.Text = "Enable/Disable Grid";
            this.chk_toggleGrid.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbljoyinfo);
            this.panel1.Controls.Add(this.grpBox_info);
            this.panel1.Controls.Add(this.btn_start);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Controls.Add(this.btnleft);
            this.panel1.Controls.Add(this.chk_toggleGrid);
            this.panel1.Controls.Add(this.btndown);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btn_stop);
            this.panel1.Controls.Add(this.btn_reset);
            this.panel1.Controls.Add(this.btnright);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1468, 137);
            this.panel1.TabIndex = 15;
            // 
            // lbljoyinfo
            // 
            this.lbljoyinfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbljoyinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljoyinfo.Location = new System.Drawing.Point(576, 15);
            this.lbljoyinfo.Name = "lbljoyinfo";
            this.lbljoyinfo.Size = new System.Drawing.Size(266, 115);
            this.lbljoyinfo.TabIndex = 16;
            // 
            // grpBox_info
            // 
            this.grpBox_info.Controls.Add(this.lbl_info_bullets);
            this.grpBox_info.Controls.Add(this.lbl_info_obstacles);
            this.grpBox_info.Controls.Add(this.lbl_info_speedy);
            this.grpBox_info.Controls.Add(this.lbl_info_slow);
            this.grpBox_info.Controls.Add(this.lbl_info_invincible);
            this.grpBox_info.Controls.Add(this.lbl_info_doubleFood);
            this.grpBox_info.Controls.Add(this.lbl_snekSpeed);
            this.grpBox_info.Controls.Add(this.lbl_snekSize);
            this.grpBox_info.Font = new System.Drawing.Font("SketchFlow Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_info.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grpBox_info.Location = new System.Drawing.Point(848, 3);
            this.grpBox_info.Name = "grpBox_info";
            this.grpBox_info.Size = new System.Drawing.Size(607, 127);
            this.grpBox_info.TabIndex = 15;
            this.grpBox_info.TabStop = false;
            this.grpBox_info.Text = "Information";
            // 
            // lbl_info_bullets
            // 
            this.lbl_info_bullets.AutoSize = true;
            this.lbl_info_bullets.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info_bullets.Location = new System.Drawing.Point(405, 53);
            this.lbl_info_bullets.Name = "lbl_info_bullets";
            this.lbl_info_bullets.Size = new System.Drawing.Size(56, 21);
            this.lbl_info_bullets.TabIndex = 7;
            this.lbl_info_bullets.Text = "Bullets";
            // 
            // lbl_info_obstacles
            // 
            this.lbl_info_obstacles.AutoSize = true;
            this.lbl_info_obstacles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info_obstacles.Location = new System.Drawing.Point(6, 78);
            this.lbl_info_obstacles.Name = "lbl_info_obstacles";
            this.lbl_info_obstacles.Size = new System.Drawing.Size(97, 21);
            this.lbl_info_obstacles.TabIndex = 6;
            this.lbl_info_obstacles.Text = "Obstacles : 0";
            // 
            // lbl_info_speedy
            // 
            this.lbl_info_speedy.AutoSize = true;
            this.lbl_info_speedy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info_speedy.Location = new System.Drawing.Point(405, 26);
            this.lbl_info_speedy.Name = "lbl_info_speedy";
            this.lbl_info_speedy.Size = new System.Drawing.Size(61, 21);
            this.lbl_info_speedy.TabIndex = 5;
            this.lbl_info_speedy.Text = "Speedy";
            // 
            // lbl_info_slow
            // 
            this.lbl_info_slow.AutoSize = true;
            this.lbl_info_slow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info_slow.Location = new System.Drawing.Point(242, 78);
            this.lbl_info_slow.Name = "lbl_info_slow";
            this.lbl_info_slow.Size = new System.Drawing.Size(44, 21);
            this.lbl_info_slow.TabIndex = 4;
            this.lbl_info_slow.Text = "Slow";
            // 
            // lbl_info_invincible
            // 
            this.lbl_info_invincible.AutoSize = true;
            this.lbl_info_invincible.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info_invincible.Location = new System.Drawing.Point(242, 26);
            this.lbl_info_invincible.Name = "lbl_info_invincible";
            this.lbl_info_invincible.Size = new System.Drawing.Size(76, 21);
            this.lbl_info_invincible.TabIndex = 3;
            this.lbl_info_invincible.Text = "Invincible";
            // 
            // lbl_info_doubleFood
            // 
            this.lbl_info_doubleFood.AutoSize = true;
            this.lbl_info_doubleFood.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info_doubleFood.Location = new System.Drawing.Point(242, 53);
            this.lbl_info_doubleFood.Name = "lbl_info_doubleFood";
            this.lbl_info_doubleFood.Size = new System.Drawing.Size(95, 21);
            this.lbl_info_doubleFood.TabIndex = 2;
            this.lbl_info_doubleFood.Text = "DoubleFood";
            // 
            // lbl_snekSpeed
            // 
            this.lbl_snekSpeed.AutoSize = true;
            this.lbl_snekSpeed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_snekSpeed.Location = new System.Drawing.Point(6, 53);
            this.lbl_snekSpeed.Name = "lbl_snekSpeed";
            this.lbl_snekSpeed.Size = new System.Drawing.Size(73, 21);
            this.lbl_snekSpeed.TabIndex = 1;
            this.lbl_snekSpeed.Text = "Speed : 0";
            // 
            // lbl_snekSize
            // 
            this.lbl_snekSize.AutoSize = true;
            this.lbl_snekSize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_snekSize.Location = new System.Drawing.Point(6, 26);
            this.lbl_snekSize.Name = "lbl_snekSize";
            this.lbl_snekSize.Size = new System.Drawing.Size(78, 21);
            this.lbl_snekSize.TabIndex = 0;
            this.lbl_snekSize.Text = "Lenght : 0";
            // 
            // btn_Help
            // 
            this.btn_Help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Help.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Help.FlatAppearance.BorderSize = 0;
            this.btn_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Help.Location = new System.Drawing.Point(1077, 0);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(90, 27);
            this.btn_Help.TabIndex = 16;
            this.btn_Help.Text = "Help";
            this.btn_Help.UseVisualStyleBackColor = false;
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // btn_opencfg
            // 
            this.btn_opencfg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_opencfg.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_opencfg.FlatAppearance.BorderSize = 0;
            this.btn_opencfg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_opencfg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_opencfg.Location = new System.Drawing.Point(862, 0);
            this.btn_opencfg.Name = "btn_opencfg";
            this.btn_opencfg.Size = new System.Drawing.Size(90, 27);
            this.btn_opencfg.TabIndex = 17;
            this.btn_opencfg.Text = "Config";
            this.btn_opencfg.UseVisualStyleBackColor = false;
            this.btn_opencfg.Click += new System.EventHandler(this.btn_opencfg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1468, 955);
            this.Controls.Add(this.btn_opencfg);
            this.Controls.Add(this.btn_Help);
            this.Controls.Add(this.pbGameCanvas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_CloseWnd);
            this.Controls.Add(this.lbl_WndInfo);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Snek";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbGameCanvas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpBox_info.ResumeLayout(false);
            this.grpBox_info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_WndInfo;
        private System.Windows.Forms.Button btn_CloseWnd;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.PictureBox pbGameCanvas;
        private System.Windows.Forms.Button btndown;
        private System.Windows.Forms.Button btnleft;
        private System.Windows.Forms.Button btnright;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer tmr_Game;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Timer tmr_Draw;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.CheckBox chk_toggleGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpBox_info;
        private System.Windows.Forms.Label lbl_snekSpeed;
        private System.Windows.Forms.Label lbl_snekSize;
        private System.Windows.Forms.Label lbl_info_slow;
        private System.Windows.Forms.Label lbl_info_invincible;
        private System.Windows.Forms.Label lbl_info_doubleFood;
        private System.Windows.Forms.Label lbl_info_speedy;
        private System.Windows.Forms.Label lbl_info_obstacles;
        private System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.Label lbl_info_bullets;
        private System.Windows.Forms.Label lbljoyinfo;
        private System.Windows.Forms.Button btn_opencfg;
    }


}


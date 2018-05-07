namespace Snek_Game
{
    partial class ConfigWindow
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
            this.btn_loadcfg = new System.Windows.Forms.Button();
            this.btn_savecfg = new System.Windows.Forms.Button();
            this.btn_applycfg = new System.Windows.Forms.Button();
            this.txt_startspeed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_maxspeed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_speedySpeed = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_slowSpeed = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_speedUpTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_pwupTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_maxPwup = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_obsTime = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_maxObs = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.debuglabel = new System.Windows.Forms.Label();
            this.btn_res_def = new System.Windows.Forms.Button();
            this.chk_glowing = new System.Windows.Forms.CheckBox();
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
            this.lbl_WndInfo.Size = new System.Drawing.Size(933, 27);
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
            this.btn_CloseWnd.Location = new System.Drawing.Point(892, 0);
            this.btn_CloseWnd.Name = "btn_CloseWnd";
            this.btn_CloseWnd.Size = new System.Drawing.Size(36, 22);
            this.btn_CloseWnd.TabIndex = 4;
            this.btn_CloseWnd.Text = "X";
            this.btn_CloseWnd.UseVisualStyleBackColor = false;
            this.btn_CloseWnd.Click += new System.EventHandler(this.btn_CloseWnd_Click);
            // 
            // btn_loadcfg
            // 
            this.btn_loadcfg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_loadcfg.BackColor = System.Drawing.Color.Maroon;
            this.btn_loadcfg.FlatAppearance.BorderSize = 0;
            this.btn_loadcfg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loadcfg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loadcfg.Location = new System.Drawing.Point(12, 390);
            this.btn_loadcfg.Name = "btn_loadcfg";
            this.btn_loadcfg.Size = new System.Drawing.Size(158, 35);
            this.btn_loadcfg.TabIndex = 7;
            this.btn_loadcfg.Text = "Load Configuration";
            this.btn_loadcfg.UseVisualStyleBackColor = false;
            this.btn_loadcfg.Click += new System.EventHandler(this.btn_loadcfg_Click);
            // 
            // btn_savecfg
            // 
            this.btn_savecfg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_savecfg.BackColor = System.Drawing.Color.Maroon;
            this.btn_savecfg.FlatAppearance.BorderSize = 0;
            this.btn_savecfg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_savecfg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_savecfg.Location = new System.Drawing.Point(176, 390);
            this.btn_savecfg.Name = "btn_savecfg";
            this.btn_savecfg.Size = new System.Drawing.Size(158, 35);
            this.btn_savecfg.TabIndex = 8;
            this.btn_savecfg.Text = "Save Configuration";
            this.btn_savecfg.UseVisualStyleBackColor = false;
            this.btn_savecfg.Click += new System.EventHandler(this.btn_savecfg_Click);
            // 
            // btn_applycfg
            // 
            this.btn_applycfg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_applycfg.BackColor = System.Drawing.Color.Maroon;
            this.btn_applycfg.FlatAppearance.BorderSize = 0;
            this.btn_applycfg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_applycfg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_applycfg.Location = new System.Drawing.Point(763, 390);
            this.btn_applycfg.Name = "btn_applycfg";
            this.btn_applycfg.Size = new System.Drawing.Size(158, 35);
            this.btn_applycfg.TabIndex = 9;
            this.btn_applycfg.Text = "Apply Configuration";
            this.btn_applycfg.UseVisualStyleBackColor = false;
            this.btn_applycfg.Click += new System.EventHandler(this.btn_applycfg_Click);
            // 
            // txt_startspeed
            // 
            this.txt_startspeed.BackColor = System.Drawing.Color.Black;
            this.txt_startspeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_startspeed.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_startspeed.Location = new System.Drawing.Point(222, 38);
            this.txt_startspeed.Name = "txt_startspeed";
            this.txt_startspeed.Size = new System.Drawing.Size(169, 31);
            this.txt_startspeed.TabIndex = 10;
            this.txt_startspeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_startspeed.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Start Speed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Max Speed";
            // 
            // txt_maxspeed
            // 
            this.txt_maxspeed.BackColor = System.Drawing.Color.Black;
            this.txt_maxspeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maxspeed.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_maxspeed.Location = new System.Drawing.Point(222, 75);
            this.txt_maxspeed.Name = "txt_maxspeed";
            this.txt_maxspeed.Size = new System.Drawing.Size(169, 31);
            this.txt_maxspeed.TabIndex = 13;
            this.txt_maxspeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_maxspeed.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Speedy Speed";
            // 
            // txt_speedySpeed
            // 
            this.txt_speedySpeed.BackColor = System.Drawing.Color.Black;
            this.txt_speedySpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_speedySpeed.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_speedySpeed.Location = new System.Drawing.Point(222, 112);
            this.txt_speedySpeed.Name = "txt_speedySpeed";
            this.txt_speedySpeed.Size = new System.Drawing.Size(169, 31);
            this.txt_speedySpeed.TabIndex = 15;
            this.txt_speedySpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_speedySpeed.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Slow Speed";
            // 
            // txt_slowSpeed
            // 
            this.txt_slowSpeed.BackColor = System.Drawing.Color.Black;
            this.txt_slowSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_slowSpeed.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_slowSpeed.Location = new System.Drawing.Point(222, 149);
            this.txt_slowSpeed.Name = "txt_slowSpeed";
            this.txt_slowSpeed.Size = new System.Drawing.Size(169, 31);
            this.txt_slowSpeed.TabIndex = 17;
            this.txt_slowSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_slowSpeed.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "SpeedUp Time";
            // 
            // txt_speedUpTime
            // 
            this.txt_speedUpTime.BackColor = System.Drawing.Color.Black;
            this.txt_speedUpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_speedUpTime.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_speedUpTime.Location = new System.Drawing.Point(222, 186);
            this.txt_speedUpTime.Name = "txt_speedUpTime";
            this.txt_speedUpTime.Size = new System.Drawing.Size(169, 31);
            this.txt_speedUpTime.TabIndex = 19;
            this.txt_speedUpTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_speedUpTime.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(440, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "PowerUp Spawn Time";
            // 
            // txt_pwupTime
            // 
            this.txt_pwupTime.BackColor = System.Drawing.Color.Black;
            this.txt_pwupTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pwupTime.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_pwupTime.Location = new System.Drawing.Point(688, 41);
            this.txt_pwupTime.Name = "txt_pwupTime";
            this.txt_pwupTime.Size = new System.Drawing.Size(169, 31);
            this.txt_pwupTime.TabIndex = 21;
            this.txt_pwupTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_pwupTime.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(440, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "Max Powerups";
            // 
            // txt_maxPwup
            // 
            this.txt_maxPwup.BackColor = System.Drawing.Color.Black;
            this.txt_maxPwup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maxPwup.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_maxPwup.Location = new System.Drawing.Point(688, 78);
            this.txt_maxPwup.Name = "txt_maxPwup";
            this.txt_maxPwup.Size = new System.Drawing.Size(169, 31);
            this.txt_maxPwup.TabIndex = 23;
            this.txt_maxPwup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_maxPwup.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(440, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 25);
            this.label8.TabIndex = 26;
            this.label8.Text = "Obstacle Spawn Time";
            // 
            // txt_obsTime
            // 
            this.txt_obsTime.BackColor = System.Drawing.Color.Black;
            this.txt_obsTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_obsTime.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_obsTime.Location = new System.Drawing.Point(688, 146);
            this.txt_obsTime.Name = "txt_obsTime";
            this.txt_obsTime.Size = new System.Drawing.Size(169, 31);
            this.txt_obsTime.TabIndex = 25;
            this.txt_obsTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_obsTime.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(440, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 25);
            this.label9.TabIndex = 28;
            this.label9.Text = "Max Obstacles";
            // 
            // txt_maxObs
            // 
            this.txt_maxObs.BackColor = System.Drawing.Color.Black;
            this.txt_maxObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maxObs.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_maxObs.Location = new System.Drawing.Point(688, 183);
            this.txt_maxObs.Name = "txt_maxObs";
            this.txt_maxObs.Size = new System.Drawing.Size(169, 31);
            this.txt_maxObs.TabIndex = 27;
            this.txt_maxObs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_maxObs.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(237, 132);
            this.label10.TabIndex = 29;
            this.label10.Text = "Umso nidriger ein Speed Wert ist desto schneller ist die Snake, wenn z.B 10 einge" +
    "geben wird, wird die Snake alle 10 milisekunden sich um ein Feld nach vorn beweg" +
    "en";
            // 
            // debuglabel
            // 
            this.debuglabel.AutoSize = true;
            this.debuglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debuglabel.Location = new System.Drawing.Point(334, 322);
            this.debuglabel.Name = "debuglabel";
            this.debuglabel.Size = new System.Drawing.Size(0, 13);
            this.debuglabel.TabIndex = 30;
            // 
            // btn_res_def
            // 
            this.btn_res_def.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_res_def.BackColor = System.Drawing.Color.Maroon;
            this.btn_res_def.FlatAppearance.BorderSize = 0;
            this.btn_res_def.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_res_def.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_res_def.Location = new System.Drawing.Point(382, 390);
            this.btn_res_def.Name = "btn_res_def";
            this.btn_res_def.Size = new System.Drawing.Size(158, 35);
            this.btn_res_def.TabIndex = 31;
            this.btn_res_def.Text = "Restore default";
            this.btn_res_def.UseVisualStyleBackColor = false;
            this.btn_res_def.Click += new System.EventHandler(this.btn_res_def_Click);
            // 
            // chk_glowing
            // 
            this.chk_glowing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_glowing.Location = new System.Drawing.Point(688, 239);
            this.chk_glowing.Name = "chk_glowing";
            this.chk_glowing.Size = new System.Drawing.Size(128, 38);
            this.chk_glowing.TabIndex = 32;
            this.chk_glowing.Text = "Glowing ";
            this.chk_glowing.UseVisualStyleBackColor = true;
            // 
            // ConfigWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(933, 437);
            this.Controls.Add(this.chk_glowing);
            this.Controls.Add(this.btn_res_def);
            this.Controls.Add(this.debuglabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_maxObs);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_obsTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_maxPwup);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_pwupTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_speedUpTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_slowSpeed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_speedySpeed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_maxspeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_startspeed);
            this.Controls.Add(this.btn_applycfg);
            this.Controls.Add(this.btn_savecfg);
            this.Controls.Add(this.btn_loadcfg);
            this.Controls.Add(this.btn_CloseWnd);
            this.Controls.Add(this.lbl_WndInfo);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfigWindow";
            this.Text = "Config";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_WndInfo;
        private System.Windows.Forms.Button btn_CloseWnd;
        private System.Windows.Forms.Button btn_applycfg;
        private System.Windows.Forms.Button btn_savecfg;
        private System.Windows.Forms.Button btn_loadcfg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_startspeed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_obsTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_maxPwup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_pwupTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_speedUpTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_slowSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_speedySpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_maxspeed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_maxObs;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label debuglabel;
        private System.Windows.Forms.Button btn_res_def;
        private System.Windows.Forms.CheckBox chk_glowing;
    }
}


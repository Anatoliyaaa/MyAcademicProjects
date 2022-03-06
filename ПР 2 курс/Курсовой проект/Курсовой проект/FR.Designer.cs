namespace Курсовой_проект
{
    partial class FR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FR));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tpassword = new System.Windows.Forms.TextBox();
            this.tlogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tph = new System.Windows.Forms.TextBox();
            this.tname = new System.Windows.Forms.TextBox();
            this.bExit = new System.Windows.Forms.Button();
            this.labelR = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(33, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 35);
            this.label3.TabIndex = 12;
            this.label3.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Fuchsia;
            this.label2.Location = new System.Drawing.Point(33, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 35);
            this.label2.TabIndex = 11;
            this.label2.Text = "Пароль:";
            // 
            // tpassword
            // 
            this.tpassword.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tpassword.Location = new System.Drawing.Point(39, 457);
            this.tpassword.Name = "tpassword";
            this.tpassword.Size = new System.Drawing.Size(301, 42);
            this.tpassword.TabIndex = 10;
            this.tpassword.UseSystemPasswordChar = true;
            // 
            // tlogin
            // 
            this.tlogin.BackColor = System.Drawing.Color.White;
            this.tlogin.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tlogin.Location = new System.Drawing.Point(39, 350);
            this.tlogin.Multiline = true;
            this.tlogin.Name = "tlogin";
            this.tlogin.Size = new System.Drawing.Size(301, 42);
            this.tlogin.TabIndex = 9;
            this.tlogin.Enter += new System.EventHandler(this.tlogin_Enter);
            this.tlogin.Leave += new System.EventHandler(this.tlogin_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(135, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 43);
            this.label1.TabIndex = 7;
            this.label1.Text = "Регистрация";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(351, 472);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRegister.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegister.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonRegister.Location = new System.Drawing.Point(761, 402);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(252, 68);
            this.buttonRegister.TabIndex = 8;
            this.buttonRegister.Text = "Создать УЗ";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(33, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 35);
            this.label4.TabIndex = 17;
            this.label4.Text = "Имя:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(33, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 35);
            this.label5.TabIndex = 16;
            this.label5.Text = "Фамилия:";
            // 
            // tph
            // 
            this.tph.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tph.Location = new System.Drawing.Point(39, 248);
            this.tph.Name = "tph";
            this.tph.Size = new System.Drawing.Size(301, 42);
            this.tph.TabIndex = 15;
            this.tph.Enter += new System.EventHandler(this.tph_Enter);
            this.tph.Leave += new System.EventHandler(this.tph_Leave);
            // 
            // tname
            // 
            this.tname.BackColor = System.Drawing.Color.White;
            this.tname.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tname.Location = new System.Drawing.Point(39, 145);
            this.tname.Multiline = true;
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(301, 42);
            this.tname.TabIndex = 14;
            this.tname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.tname.Enter += new System.EventHandler(this.tname_Enter);
            this.tname.Leave += new System.EventHandler(this.tname_Leave);
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.Color.Transparent;
            this.bExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bExit.FlatAppearance.BorderSize = 0;
            this.bExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bExit.Location = new System.Drawing.Point(966, 12);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(56, 49);
            this.bExit.TabIndex = 18;
            this.bExit.Text = "Х";
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.BackColor = System.Drawing.Color.Black;
            this.labelR.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelR.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelR.Location = new System.Drawing.Point(812, 473);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(145, 38);
            this.labelR.TabIndex = 19;
            this.labelR.Text = "Зарегестрированы?\r\n    Авторизуйтесь!";
            this.labelR.Click += new System.EventHandler(this.labelR_Click);
            // 
            // FR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Курсовой_проект.Properties.Resources.fon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1034, 535);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tph);
            this.Controls.Add(this.tname);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tpassword);
            this.Controls.Add(this.tlogin);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FR";
            this.Load += new System.EventHandler(this.FR_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tpassword;
        private System.Windows.Forms.TextBox tlogin;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tph;
        private System.Windows.Forms.TextBox tname;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Label labelR;
    }
}
namespace Курсовой_проект
{
    partial class FVT
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
            this.bExit = new System.Windows.Forms.Button();
            this.vt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bz = new System.Windows.Forms.Button();
            this.rm = new System.Windows.Forms.RadioButton();
            this.rv = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.bd = new System.Windows.Forms.Button();
            this.bA = new System.Windows.Forms.Button();
            this.tbIDA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.Color.Transparent;
            this.bExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bExit.FlatAppearance.BorderSize = 0;
            this.bExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bExit.Location = new System.Drawing.Point(652, 12);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(56, 49);
            this.bExit.TabIndex = 19;
            this.bExit.Text = "Х";
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // vt
            // 
            this.vt.BackColor = System.Drawing.SystemColors.MenuText;
            this.vt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vt.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.vt.FormattingEnabled = true;
            this.vt.Location = new System.Drawing.Point(16, 171);
            this.vt.Name = "vt";
            this.vt.Size = new System.Drawing.Size(287, 34);
            this.vt.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "Выберите тренера:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 22);
            this.label2.TabIndex = 24;
            this.label2.Text = "Выберите время для тренеровок:";
            // 
            // bz
            // 
            this.bz.BackColor = System.Drawing.Color.Black;
            this.bz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bz.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bz.Location = new System.Drawing.Point(16, 233);
            this.bz.Name = "bz";
            this.bz.Size = new System.Drawing.Size(190, 40);
            this.bz.TabIndex = 25;
            this.bz.Text = "Записаться";
            this.bz.UseVisualStyleBackColor = false;
            this.bz.Click += new System.EventHandler(this.button1_Click);
            // 
            // rm
            // 
            this.rm.AutoSize = true;
            this.rm.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rm.Location = new System.Drawing.Point(26, 75);
            this.rm.Name = "rm";
            this.rm.Size = new System.Drawing.Size(72, 25);
            this.rm.TabIndex = 26;
            this.rm.TabStop = true;
            this.rm.Text = "Утро";
            this.rm.UseVisualStyleBackColor = true;
            this.rm.Click += new System.EventHandler(this.rm_Click);
            // 
            // rv
            // 
            this.rv.AutoSize = true;
            this.rv.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rv.Location = new System.Drawing.Point(26, 103);
            this.rv.Name = "rv";
            this.rv.Size = new System.Drawing.Size(79, 25);
            this.rv.TabIndex = 27;
            this.rv.TabStop = true;
            this.rv.Text = "Вечер";
            this.rv.UseVisualStyleBackColor = true;
            this.rv.Click += new System.EventHandler(this.rv_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(12, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 35);
            this.button2.TabIndex = 28;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bd
            // 
            this.bd.BackColor = System.Drawing.Color.Black;
            this.bd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bd.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bd.Location = new System.Drawing.Point(16, 294);
            this.bd.Name = "bd";
            this.bd.Size = new System.Drawing.Size(268, 40);
            this.bd.TabIndex = 29;
            this.bd.Text = "Удалиться из группы";
            this.bd.UseVisualStyleBackColor = false;
            this.bd.Click += new System.EventHandler(this.bd_Click);
            // 
            // bA
            // 
            this.bA.BackColor = System.Drawing.Color.Black;
            this.bA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bA.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bA.Location = new System.Drawing.Point(16, 294);
            this.bA.Name = "bA";
            this.bA.Size = new System.Drawing.Size(268, 40);
            this.bA.TabIndex = 30;
            this.bA.Text = "Удалить из группы";
            this.bA.UseVisualStyleBackColor = false;
            this.bA.Click += new System.EventHandler(this.bA_Click);
            // 
            // tbIDA
            // 
            this.tbIDA.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbIDA.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbIDA.ForeColor = System.Drawing.SystemColors.Window;
            this.tbIDA.Location = new System.Drawing.Point(182, 220);
            this.tbIDA.Multiline = true;
            this.tbIDA.Name = "tbIDA";
            this.tbIDA.Size = new System.Drawing.Size(102, 55);
            this.tbIDA.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(22, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 22);
            this.label3.TabIndex = 32;
            this.label3.Text = "ID пользователя";
            // 
            // FVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Курсовой_проект.Properties.Resources.fon4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(720, 356);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbIDA);
            this.Controls.Add(this.bA);
            this.Controls.Add(this.bd);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rv);
            this.Controls.Add(this.rm);
            this.Controls.Add(this.bz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vt);
            this.Controls.Add(this.bExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FVT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FVT";
            this.Load += new System.EventHandler(this.FVT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.ComboBox vt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bz;
        private System.Windows.Forms.RadioButton rm;
        private System.Windows.Forms.RadioButton rv;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bd;
        private System.Windows.Forms.Button bA;
        private System.Windows.Forms.TextBox tbIDA;
        private System.Windows.Forms.Label label3;
    }
}
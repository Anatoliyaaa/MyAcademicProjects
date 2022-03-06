namespace Приложение_V_0._1
{
    partial class FMap
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
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.bExit = new System.Windows.Forms.Button();
            this.lNrc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // mapControl1
            // 
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.Location = new System.Drawing.Point(0, 0);
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.NavigationPanelOptions.BackgroundStyle.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(62)))), ((int)(((byte)(63)))));
            this.mapControl1.NavigationPanelOptions.CoordinatesStyle.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mapControl1.NavigationPanelOptions.CoordinatesStyle.TextColor = System.Drawing.Color.White;
            this.mapControl1.NavigationPanelOptions.HotTrackedItemStyle.Fill = System.Drawing.Color.White;
            this.mapControl1.NavigationPanelOptions.ItemStyle.Fill = System.Drawing.Color.White;
            this.mapControl1.NavigationPanelOptions.PressedItemStyle.Fill = System.Drawing.Color.White;
            this.mapControl1.NavigationPanelOptions.ScaleStyle.TextColor = System.Drawing.Color.White;
            this.mapControl1.Size = new System.Drawing.Size(1061, 564);
            this.mapControl1.TabIndex = 0;
            this.mapControl1.Click += new System.EventHandler(this.mapControl1_Click);
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(62)))), ((int)(((byte)(63)))));
            this.bExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bExit.FlatAppearance.BorderSize = 0;
            this.bExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bExit.ForeColor = System.Drawing.Color.White;
            this.bExit.Location = new System.Drawing.Point(1009, 0);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(52, 45);
            this.bExit.TabIndex = 22;
            this.bExit.Text = "Х";
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // lNrc
            // 
            this.lNrc.AutoSize = true;
            this.lNrc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(62)))), ((int)(((byte)(63)))));
            this.lNrc.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lNrc.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lNrc.Location = new System.Drawing.Point(0, 0);
            this.lNrc.Name = "lNrc";
            this.lNrc.Size = new System.Drawing.Size(83, 33);
            this.lNrc.TabIndex = 23;
            this.lNrc.Text = "label1";
            this.lNrc.Click += new System.EventHandler(this.lNrc_Click);
            // 
            // FMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 564);
            this.Controls.Add(this.lNrc);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.mapControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FMap";
            this.Load += new System.EventHandler(this.FMap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraMap.MapControl mapControl1;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Label lNrc;
    }
}
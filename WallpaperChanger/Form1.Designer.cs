namespace WallpaperChanger
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.verticalRB = new System.Windows.Forms.RadioButton();
            this.horizontalRB = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.searchLB = new System.Windows.Forms.Label();
            this.randomizeBT = new System.Windows.Forms.Button();
            this.applyBT = new System.Windows.Forms.Button();
            this.searchBT = new System.Windows.Forms.Button();
            this.searchQueryTB = new System.Windows.Forms.TextBox();
            this.pixabayLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pixabayLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.verticalRB);
            this.groupBox1.Controls.Add(this.horizontalRB);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(184, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 73);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Orientation";
            // 
            // verticalRB
            // 
            this.verticalRB.AutoSize = true;
            this.verticalRB.Location = new System.Drawing.Point(7, 44);
            this.verticalRB.Name = "verticalRB";
            this.verticalRB.Size = new System.Drawing.Size(77, 23);
            this.verticalRB.TabIndex = 1;
            this.verticalRB.TabStop = true;
            this.verticalRB.Text = "Vertical";
            this.verticalRB.UseVisualStyleBackColor = true;
            // 
            // horizontalRB
            // 
            this.horizontalRB.AutoSize = true;
            this.horizontalRB.Checked = true;
            this.horizontalRB.Location = new System.Drawing.Point(7, 20);
            this.horizontalRB.Name = "horizontalRB";
            this.horizontalRB.Size = new System.Drawing.Size(98, 23);
            this.horizontalRB.TabIndex = 0;
            this.horizontalRB.TabStop = true;
            this.horizontalRB.Text = "Horizontal";
            this.horizontalRB.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(12, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Images provided by:";
            // 
            // searchLB
            // 
            this.searchLB.AutoSize = true;
            this.searchLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.searchLB.Location = new System.Drawing.Point(12, 220);
            this.searchLB.Name = "searchLB";
            this.searchLB.Size = new System.Drawing.Size(41, 13);
            this.searchLB.TabIndex = 15;
            this.searchLB.Text = "Search";
            // 
            // randomizeBT
            // 
            this.randomizeBT.Location = new System.Drawing.Point(214, 269);
            this.randomizeBT.Name = "randomizeBT";
            this.randomizeBT.Size = new System.Drawing.Size(75, 23);
            this.randomizeBT.TabIndex = 14;
            this.randomizeBT.Text = "Randomize";
            this.randomizeBT.UseVisualStyleBackColor = true;
            this.randomizeBT.Click += new System.EventHandler(this.randomizeBT_Click);
            // 
            // applyBT
            // 
            this.applyBT.Location = new System.Drawing.Point(118, 269);
            this.applyBT.Name = "applyBT";
            this.applyBT.Size = new System.Drawing.Size(75, 23);
            this.applyBT.TabIndex = 13;
            this.applyBT.Text = "Apply";
            this.applyBT.UseVisualStyleBackColor = true;
            this.applyBT.Click += new System.EventHandler(this.applyBT_Click);
            // 
            // searchBT
            // 
            this.searchBT.Location = new System.Drawing.Point(23, 269);
            this.searchBT.Name = "searchBT";
            this.searchBT.Size = new System.Drawing.Size(75, 23);
            this.searchBT.TabIndex = 20;
            this.searchBT.Text = "Search";
            this.searchBT.UseVisualStyleBackColor = true;
            this.searchBT.Click += new System.EventHandler(this.searchBT_Click);
            // 
            // searchQueryTB
            // 
            this.searchQueryTB.Location = new System.Drawing.Point(59, 217);
            this.searchQueryTB.Name = "searchQueryTB";
            this.searchQueryTB.Size = new System.Drawing.Size(100, 20);
            this.searchQueryTB.TabIndex = 19;
            // 
            // pixabayLogo
            // 
            this.pixabayLogo.Image = global::WallpaperChanger.Properties.Resources.pixabay_logo;
            this.pixabayLogo.Location = new System.Drawing.Point(12, 320);
            this.pixabayLogo.Name = "pixabayLogo";
            this.pixabayLogo.Size = new System.Drawing.Size(100, 50);
            this.pixabayLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pixabayLogo.TabIndex = 17;
            this.pixabayLogo.TabStop = false;
            this.pixabayLogo.Click += new System.EventHandler(this.pixabayLogo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(11, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(309, 387);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchLB);
            this.Controls.Add(this.randomizeBT);
            this.Controls.Add(this.applyBT);
            this.Controls.Add(this.searchBT);
            this.Controls.Add(this.searchQueryTB);
            this.Controls.Add(this.pixabayLogo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Wallpaper Changer v2.0";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pixabayLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton verticalRB;
        private System.Windows.Forms.RadioButton horizontalRB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label searchLB;
        private System.Windows.Forms.Button randomizeBT;
        private System.Windows.Forms.Button applyBT;
        private System.Windows.Forms.Button searchBT;
        private System.Windows.Forms.TextBox searchQueryTB;
        private System.Windows.Forms.PictureBox pixabayLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


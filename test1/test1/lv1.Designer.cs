﻿namespace test1
{
    partial class lv1
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
            this.level1 = new System.Windows.Forms.PictureBox();
            this.ruch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.level1)).BeginInit();
            this.SuspendLayout();
            // 
            // level1
            // 
            this.level1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.level1.Location = new System.Drawing.Point(-1, -1);
            this.level1.Name = "level1";
            this.level1.Size = new System.Drawing.Size(835, 513);
            this.level1.TabIndex = 0;
            this.level1.TabStop = false;
            this.level1.Click += new System.EventHandler(this.level1_Click);
            this.level1.Paint += new System.Windows.Forms.PaintEventHandler(this.level1_Paint);
            this.level1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.level1_MouseMove);
            // 
            // ruch
            // 
            this.ruch.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ruch.Location = new System.Drawing.Point(484, 104);
            this.ruch.Name = "ruch";
            this.ruch.Size = new System.Drawing.Size(75, 75);
            this.ruch.TabIndex = 1;
            this.ruch.UseVisualStyleBackColor = false;
            this.ruch.Click += new System.EventHandler(this.ruch_Click);
            // 
            // lv1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.ruch);
            this.Controls.Add(this.level1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "lv1";
            this.Text = "Super Racing Sim - poziom 1";
            this.Load += new System.EventHandler(this.lv1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lv1_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lv1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.level1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox level1;
        private System.Windows.Forms.Button ruch;
    }
}
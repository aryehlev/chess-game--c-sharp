using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GameBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.leftBlackCastle = new System.Windows.Forms.PictureBox();
            this.rightBlackCastle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.leftBlackCastle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightBlackCastle)).BeginInit();
            this.SuspendLayout();
            // 
            // leftBlackCastle
            // 
            this.leftBlackCastle.BackColor = System.Drawing.Color.Transparent;
            this.leftBlackCastle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.leftBlackCastle.Image = ((System.Drawing.Image)(resources.GetObject("leftBlackCastle.Image")));
            this.leftBlackCastle.Location = new System.Drawing.Point(21, 12);
            this.leftBlackCastle.Name = "leftBlackCastle";
            this.leftBlackCastle.Size = new System.Drawing.Size(54, 69);
            this.leftBlackCastle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftBlackCastle.TabIndex = 33;
            this.leftBlackCastle.TabStop = false;
            // 
            // rightBlackCastle
            // 
            this.rightBlackCastle.BackColor = System.Drawing.Color.Transparent;
            this.rightBlackCastle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rightBlackCastle.Image = ((System.Drawing.Image)(resources.GetObject("rightBlackCastle.Image")));
            this.rightBlackCastle.Location = new System.Drawing.Point(717, 12);
            this.rightBlackCastle.Name = "rightBlackCastle";
            this.rightBlackCastle.Size = new System.Drawing.Size(54, 69);
            this.rightBlackCastle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightBlackCastle.TabIndex = 34;
            this.rightBlackCastle.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 801);
            this.Controls.Add(this.rightBlackCastle);
            this.Controls.Add(this.leftBlackCastle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aryeh-Chess";
            this.TransparencyKey = System.Drawing.Color.White;
            ((System.ComponentModel.ISupportInitialize)(this.leftBlackCastle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightBlackCastle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
       
        private System.Windows.Forms.PictureBox leftBlackCastle;
        private PictureBox rightBlackCastle;
    }
}


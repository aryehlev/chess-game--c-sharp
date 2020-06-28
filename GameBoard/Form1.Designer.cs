using System;
using System.Drawing;
using System.IO;

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
            this.transparentControl1 = new GameBoard.TransparentControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // transparentControl1
            // 
            this.transparentControl1.BackColor = System.Drawing.Color.Transparent;
            this.transparentControl1.Image = ((System.Drawing.Image)(resources.GetObject("transparentControl1.Image")));
            this.transparentControl1.Location = new System.Drawing.Point(18, 896);
            this.transparentControl1.Margin = new System.Windows.Forms.Padding(4);
            this.transparentControl1.Name = "transparentControl1";
            this.transparentControl1.Size = new System.Drawing.Size(67, 84);
            this.transparentControl1.TabIndex = 103;
            this.transparentControl1.Text = "transparentControl1";
            this.transparentControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.transparentControl1_MouseDown);
            this.transparentControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.transparentControl1_MouseMove);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(67, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 479);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Aryeh-Chess";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        //private System.Windows.Forms.PictureBox pictureBox1;
        //private System.Windows.Forms.PictureBox pictureBox94;
        //private System.Windows.Forms.PictureBox pictureBox93;
        //private System.Windows.Forms.PictureBox pictureBox92;
        //private System.Windows.Forms.PictureBox pictureBox91;
        //private System.Windows.Forms.PictureBox pictureBox90;
        //private System.Windows.Forms.PictureBox pictureBox89;
        //private System.Windows.Forms.PictureBox pictureBox88;
        //private System.Windows.Forms.PictureBox pictureBox87;
        //private System.Windows.Forms.PictureBox pictureBox86;
        //private System.Windows.Forms.PictureBox pictureBox85;
        //private System.Windows.Forms.PictureBox pictureBox84;
        //private System.Windows.Forms.PictureBox pictureBox83;
        //private System.Windows.Forms.PictureBox pictureBox82;
        //private System.Windows.Forms.PictureBox pictureBox81;
        //private System.Windows.Forms.PictureBox pictureBox80;
        //private System.Windows.Forms.PictureBox pictureBox79;
        //private System.Windows.Forms.PictureBox pictureBox78;
        //private System.Windows.Forms.PictureBox pictureBox77;
        //private System.Windows.Forms.PictureBox pictureBox76;
        //private System.Windows.Forms.PictureBox pictureBox75;
        //private System.Windows.Forms.PictureBox pictureBox74;
        //private System.Windows.Forms.PictureBox pictureBox73;
        //private System.Windows.Forms.PictureBox pictureBox72;
        //private System.Windows.Forms.PictureBox pictureBox71;
        //private System.Windows.Forms.PictureBox pictureBox70;
        //private System.Windows.Forms.PictureBox pictureBox69;
        //private System.Windows.Forms.PictureBox pictureBox68;
        //private System.Windows.Forms.PictureBox pictureBox67;
        //private System.Windows.Forms.PictureBox pictureBox66;
        //private System.Windows.Forms.PictureBox pictureBox65;
        //private System.Windows.Forms.PictureBox pictureBox64;
        //private System.Windows.Forms.PictureBox pictureBox63;
        //private System.Windows.Forms.PictureBox pictureBox62;
        //private System.Windows.Forms.PictureBox pictureBox61;
        //private System.Windows.Forms.PictureBox pictureBox60;
        //private System.Windows.Forms.PictureBox pictureBox59;
        //private System.Windows.Forms.PictureBox pictureBox58;
        //private System.Windows.Forms.PictureBox pictureBox57;
        //private System.Windows.Forms.PictureBox pictureBox56;
        //private System.Windows.Forms.PictureBox pictureBox55;
        //private System.Windows.Forms.PictureBox pictureBox53;
        //private System.Windows.Forms.PictureBox pictureBox44;
        //private System.Windows.Forms.PictureBox pictureBox2;
        //private System.Windows.Forms.PictureBox pictureBox54;
        //private System.Windows.Forms.PictureBox pictureBox52;
        //private System.Windows.Forms.PictureBox pictureBox51;
        //private System.Windows.Forms.PictureBox pictureBox50;
        //private System.Windows.Forms.PictureBox pictureBox49;
        //private System.Windows.Forms.PictureBox pictureBox48;
        //private System.Windows.Forms.PictureBox pictureBox47;
        //private System.Windows.Forms.PictureBox pictureBox46;
        //private System.Windows.Forms.PictureBox pictureBox45;
        //private System.Windows.Forms.PictureBox pictureBox43;
        //private System.Windows.Forms.PictureBox pictureBox42;
        //private System.Windows.Forms.PictureBox pictureBox41;
        //private System.Windows.Forms.PictureBox pictureBox40;
        //private System.Windows.Forms.PictureBox pictureBox39;
        //private System.Windows.Forms.PictureBox pictureBox38;
        //private System.Windows.Forms.PictureBox pictureBox37;
        //private System.Windows.Forms.PictureBox pictureBox36;
        //private System.Windows.Forms.PictureBox pictureBox35;
        //private System.Windows.Forms.PictureBox pictureBox34;
        //private System.Windows.Forms.PictureBox pictureBox33;
        //private System.Windows.Forms.PictureBox pictureBox32;
        //private System.Windows.Forms.PictureBox pictureBox31;
        //private System.Windows.Forms.PictureBox pictureBox30;
        //private System.Windows.Forms.PictureBox pictureBox29;
        //private System.Windows.Forms.PictureBox pictureBox28;
        //private System.Windows.Forms.PictureBox pictureBox27;
        //private System.Windows.Forms.PictureBox pictureBox26;
        //private System.Windows.Forms.PictureBox pictureBox25;
        //private System.Windows.Forms.PictureBox pictureBox24;
        //private System.Windows.Forms.PictureBox pictureBox23;
        //private System.Windows.Forms.PictureBox pictureBox22;
        //private System.Windows.Forms.PictureBox pictureBox21;
        //private System.Windows.Forms.PictureBox pictureBox20;
        //private System.Windows.Forms.PictureBox pictureBox19;
        //private System.Windows.Forms.PictureBox pictureBox18;
        //private System.Windows.Forms.PictureBox pictureBox17;
        //private System.Windows.Forms.PictureBox pictureBox16;
        //private System.Windows.Forms.PictureBox pictureBox15;
        //private System.Windows.Forms.PictureBox pictureBox14;
        //private System.Windows.Forms.PictureBox pictureBox13;
        //private System.Windows.Forms.PictureBox pictureBox12;
        //private System.Windows.Forms.PictureBox pictureBox11;
        //private System.Windows.Forms.PictureBox pictureBox10;
        //private System.Windows.Forms.PictureBox pictureBox9;
        //private System.Windows.Forms.PictureBox pictureBox8;
        //private System.Windows.Forms.PictureBox pictureBox7;
        //private System.Windows.Forms.PictureBox pictureBox6;
        //private System.Windows.Forms.PictureBox pictureBox5;
        //private System.Windows.Forms.PictureBox pictureBox4;
        //private System.Windows.Forms.PictureBox pictureBox3;
        //private System.Windows.Forms.PictureBox pictureBox99;
        //private System.Windows.Forms.PictureBox pictureBox98;
        //private System.Windows.Forms.PictureBox pictureBox97;
        //private System.Windows.Forms.PictureBox pictureBox96;
        //private System.Windows.Forms.PictureBox pictureBox95;
        //private System.Windows.Forms.PictureBox pictureBox100;
        internal TransparentControl transparentControl1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}


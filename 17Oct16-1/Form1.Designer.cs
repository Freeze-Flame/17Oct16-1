﻿namespace _17Oct16_1
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
            this.btnDog = new System.Windows.Forms.Button();
            this.btnCat = new System.Windows.Forms.Button();
            this.btnHuman = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDog
            // 
            this.btnDog.Location = new System.Drawing.Point(50, 52);
            this.btnDog.Name = "btnDog";
            this.btnDog.Size = new System.Drawing.Size(75, 23);
            this.btnDog.TabIndex = 0;
            this.btnDog.Text = "Dog";
            this.btnDog.UseVisualStyleBackColor = true;
            this.btnDog.Click += new System.EventHandler(this.btnDog_Click);
            // 
            // btnCat
            // 
            this.btnCat.Location = new System.Drawing.Point(50, 128);
            this.btnCat.Name = "btnCat";
            this.btnCat.Size = new System.Drawing.Size(75, 23);
            this.btnCat.TabIndex = 1;
            this.btnCat.Text = "Cat";
            this.btnCat.UseVisualStyleBackColor = true;
            this.btnCat.Click += new System.EventHandler(this.btnCat_Click);
            // 
            // btnHuman
            // 
            this.btnHuman.Location = new System.Drawing.Point(50, 197);
            this.btnHuman.Name = "btnHuman";
            this.btnHuman.Size = new System.Drawing.Size(75, 23);
            this.btnHuman.TabIndex = 2;
            this.btnHuman.Text = "Human";
            this.btnHuman.UseVisualStyleBackColor = true;
            this.btnHuman.Click += new System.EventHandler(this.btnHuman_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnHuman);
            this.Controls.Add(this.btnCat);
            this.Controls.Add(this.btnDog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDog;
        private System.Windows.Forms.Button btnCat;
        private System.Windows.Forms.Button btnHuman;
    }
}


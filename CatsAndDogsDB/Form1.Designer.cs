﻿namespace CatsAndDogsDB
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
            this.label1 = new System.Windows.Forms.Label();
            this.listCars = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listCarName = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cars";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listCars
            // 
            this.listCars.FormattingEnabled = true;
            this.listCars.Location = new System.Drawing.Point(318, 25);
            this.listCars.Name = "listCars";
            this.listCars.Size = new System.Drawing.Size(120, 95);
            this.listCars.TabIndex = 1;
            this.listCars.SelectedIndexChanged += new System.EventHandler(this.listCars_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Car Names";
            // 
            // listCarName
            // 
            this.listCarName.FormattingEnabled = true;
            this.listCarName.Location = new System.Drawing.Point(318, 139);
            this.listCarName.Name = "listCarName";
            this.listCarName.Size = new System.Drawing.Size(120, 95);
            this.listCarName.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listCarName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listCars);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listCars;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listCarName;
    }
}


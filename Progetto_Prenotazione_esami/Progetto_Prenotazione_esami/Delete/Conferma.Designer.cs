﻿namespace Progetto_Prenotazione_esami
{
    partial class Conferma
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 67);
            this.button1.TabIndex = 1;
            this.button1.Text = "Conferma";
            this.button1.UseVisualStyleBackColor = true;
            //this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(379, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prima di confermare ricontrolla bene tutti i dati inseriti";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(217, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 67);
            this.button2.TabIndex = 3;
            this.button2.Text = "Torna Indietro";
            this.button2.UseVisualStyleBackColor = true;
            //this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Conferma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 374);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Conferma";
            this.Text = "Conferma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}
﻿namespace FirstWindowsFormsApplication
{
    partial class frmMessageBox
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
            this.btnMessageForm = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMessageForm
            // 
            this.btnMessageForm.Location = new System.Drawing.Point(124, 60);
            this.btnMessageForm.Name = "btnMessageForm";
            this.btnMessageForm.Size = new System.Drawing.Size(206, 54);
            this.btnMessageForm.TabIndex = 0;
            this.btnMessageForm.Text = "Show Message ";
            this.btnMessageForm.UseVisualStyleBackColor = true;
            this.btnMessageForm.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(124, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "Show Message With Title";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show Message With Title, Buttons and Icon";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(124, 320);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(206, 54);
            this.button3.TabIndex = 3;
            this.button3.Text = "Show Message With Title, Buttons ,Icon and Default Button";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // frmMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnMessageForm);
            this.Name = "frmMessageBox";
            this.Text = "frmMessageBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMessageForm;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}
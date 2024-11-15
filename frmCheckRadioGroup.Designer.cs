namespace FirstWindowsFormsApplication
{
    partial class frmCheckRadioGroup
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
            this.chkReceiveEmail = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMeduim = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.gbBox2 = new System.Windows.Forms.GroupBox();
            this.rbThick = new System.Windows.Forms.RadioButton();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.gbSize.SuspendLayout();
            this.gbBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkReceiveEmail
            // 
            this.chkReceiveEmail.AutoSize = true;
            this.chkReceiveEmail.Location = new System.Drawing.Point(105, 54);
            this.chkReceiveEmail.Name = "chkReceiveEmail";
            this.chkReceiveEmail.Size = new System.Drawing.Size(211, 20);
            this.chkReceiveEmail.TabIndex = 0;
            this.chkReceiveEmail.Text = "Do you want to receive Email ?";
            this.chkReceiveEmail.UseVisualStyleBackColor = true;
            this.chkReceiveEmail.CheckedChanged += new System.EventHandler(this.chkReceiveEmail_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(122, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbMeduim);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Location = new System.Drawing.Point(347, 76);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(239, 199);
            this.gbSize.TabIndex = 7;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Pizza Size";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(81, 146);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(63, 20);
            this.rbLarge.TabIndex = 7;
            this.rbLarge.TabStop = true;
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            // 
            // rbMeduim
            // 
            this.rbMeduim.AutoSize = true;
            this.rbMeduim.Location = new System.Drawing.Point(81, 85);
            this.rbMeduim.Name = "rbMeduim";
            this.rbMeduim.Size = new System.Drawing.Size(76, 20);
            this.rbMeduim.TabIndex = 6;
            this.rbMeduim.TabStop = true;
            this.rbMeduim.Text = "Meduim";
            this.rbMeduim.UseVisualStyleBackColor = true;
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(81, 32);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(62, 20);
            this.rbSmall.TabIndex = 5;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            // 
            // gbBox2
            // 
            this.gbBox2.Controls.Add(this.rbThick);
            this.gbBox2.Controls.Add(this.rbThin);
            this.gbBox2.Location = new System.Drawing.Point(695, 89);
            this.gbBox2.Name = "gbBox2";
            this.gbBox2.Size = new System.Drawing.Size(200, 186);
            this.gbBox2.TabIndex = 8;
            this.gbBox2.TabStop = false;
            this.gbBox2.Text = "Crust";
            // 
            // rbThick
            // 
            this.rbThick.AutoSize = true;
            this.rbThick.Location = new System.Drawing.Point(70, 104);
            this.rbThick.Name = "rbThick";
            this.rbThick.Size = new System.Drawing.Size(61, 20);
            this.rbThick.TabIndex = 8;
            this.rbThick.TabStop = true;
            this.rbThick.Text = "Thick";
            this.rbThick.UseVisualStyleBackColor = true;
            // 
            // rbThin
            // 
            this.rbThin.AutoSize = true;
            this.rbThin.Location = new System.Drawing.Point(70, 51);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(54, 20);
            this.rbThin.TabIndex = 7;
            this.rbThin.TabStop = true;
            this.rbThin.Text = "Thin";
            this.rbThin.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(387, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 39);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(590, 312);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 39);
            this.button3.TabIndex = 10;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmCheckRadioGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gbBox2);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkReceiveEmail);
            this.Name = "frmCheckRadioGroup";
            this.Text = "frmCheckRadioGroup";
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbBox2.ResumeLayout(false);
            this.gbBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkReceiveEmail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMeduim;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox gbBox2;
        private System.Windows.Forms.RadioButton rbThick;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
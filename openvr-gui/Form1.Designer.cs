namespace openvr_gui
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkbox_move = new System.Windows.Forms.CheckBox();
            this.checkbox_freepie = new System.Windows.Forms.CheckBox();
            this.checkbox_freepieb = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Test Cameras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(164, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Calibrate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(164, 56);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 38);
            this.button3.TabIndex = 2;
            this.button3.Text = "Start VR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkbox_move
            // 
            this.checkbox_move.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkbox_move.Enabled = false;
            this.checkbox_move.Location = new System.Drawing.Point(76, 139);
            this.checkbox_move.Name = "checkbox_move";
            this.checkbox_move.Size = new System.Drawing.Size(123, 25);
            this.checkbox_move.TabIndex = 3;
            this.checkbox_move.Text = "PS Move Service";
            this.checkbox_move.UseVisualStyleBackColor = true;
            // 
            // checkbox_freepie
            // 
            this.checkbox_freepie.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkbox_freepie.Enabled = false;
            this.checkbox_freepie.Location = new System.Drawing.Point(76, 163);
            this.checkbox_freepie.Name = "checkbox_freepie";
            this.checkbox_freepie.Size = new System.Drawing.Size(123, 18);
            this.checkbox_freepie.TabIndex = 4;
            this.checkbox_freepie.Text = "Freepie Service";
            this.checkbox_freepie.UseVisualStyleBackColor = true;
            // 
            // checkbox_freepieb
            // 
            this.checkbox_freepieb.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkbox_freepieb.Enabled = false;
            this.checkbox_freepieb.Location = new System.Drawing.Point(76, 186);
            this.checkbox_freepieb.Name = "checkbox_freepieb";
            this.checkbox_freepieb.Size = new System.Drawing.Size(123, 18);
            this.checkbox_freepieb.TabIndex = 5;
            this.checkbox_freepieb.Text = "Freepie Bridge";
            this.checkbox_freepieb.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Running?";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-3, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 2);
            this.label3.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 216);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkbox_freepieb);
            this.Controls.Add(this.checkbox_freepie);
            this.Controls.Add(this.checkbox_move);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenVR Launcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkbox_move;
        private System.Windows.Forms.CheckBox checkbox_freepie;
        private System.Windows.Forms.CheckBox checkbox_freepieb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


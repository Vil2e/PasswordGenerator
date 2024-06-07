namespace PasswordGenerator
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
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordLength = new System.Windows.Forms.Label();
            this.passwordLengthBar = new System.Windows.Forms.TrackBar();
            this.copyPassBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLengthBar)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordLabel
            // 
            this.passwordLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(84, 37);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(648, 90);
            this.passwordLabel.TabIndex = 0;
            this.passwordLabel.Text = "label";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordLength
            // 
            this.passwordLength.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLength.Location = new System.Drawing.Point(84, 206);
            this.passwordLength.Name = "passwordLength";
            this.passwordLength.Size = new System.Drawing.Size(648, 102);
            this.passwordLength.TabIndex = 1;
            this.passwordLength.Text = "Password Length : 5";
            this.passwordLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordLengthBar
            // 
            this.passwordLengthBar.Location = new System.Drawing.Point(202, 295);
            this.passwordLengthBar.Name = "passwordLengthBar";
            this.passwordLengthBar.Size = new System.Drawing.Size(415, 45);
            this.passwordLengthBar.TabIndex = 2;
            this.passwordLengthBar.Scroll += new System.EventHandler(this.passwordLengthBar_Scroll);
            // 
            // copyPassBtn
            // 
            this.copyPassBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyPassBtn.Location = new System.Drawing.Point(241, 356);
            this.copyPassBtn.Name = "copyPassBtn";
            this.copyPassBtn.Size = new System.Drawing.Size(353, 45);
            this.copyPassBtn.TabIndex = 3;
            this.copyPassBtn.Text = "Copy Password";
            this.copyPassBtn.UseVisualStyleBackColor = true;
            this.copyPassBtn.Click += new System.EventHandler(this.copyPassBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.copyPassBtn);
            this.Controls.Add(this.passwordLengthBar);
            this.Controls.Add(this.passwordLength);
            this.Controls.Add(this.passwordLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passwordLengthBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label passwordLength;
        private System.Windows.Forms.TrackBar passwordLengthBar;
        private System.Windows.Forms.Button copyPassBtn;
    }
}


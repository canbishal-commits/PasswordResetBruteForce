namespace PasswordResetBruteForce
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGeneratePassword = new Button();
            label1 = new Label();
            progressBar1 = new ProgressBar();
            lblPassword = new Label();
            label2 = new Label();
            lblHash = new Label();
            label3 = new Label();
            lblCurrentAttempt = new Label();
            SuspendLayout();
            // 
            // btnGeneratePassword
            // 
            btnGeneratePassword.Location = new Point(1, 5);
            btnGeneratePassword.Name = "btnGeneratePassword";
            btnGeneratePassword.Size = new Size(243, 34);
            btnGeneratePassword.TabIndex = 0;
            btnGeneratePassword.Text = "Generate Password";
            btnGeneratePassword.UseVisualStyleBackColor = true;
            btnGeneratePassword.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1, 42);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 1;
            label1.Text = "Password:";
            label1.Click += label1_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(1, 126);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(243, 34);
            progressBar1.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(98, 42);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(19, 25);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 71);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 4;
            label2.Text = "Hash:";
            // 
            // lblHash
            // 
            lblHash.AutoSize = true;
            lblHash.Location = new Point(57, 73);
            lblHash.Name = "lblHash";
            lblHash.Size = new Size(19, 25);
            lblHash.TabIndex = 5;
            lblHash.Text = "-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1, 98);
            label3.Name = "label3";
            label3.Size = new Size(145, 25);
            label3.TabIndex = 6;
            label3.Text = "Current Attempt:";
            label3.Click += label3_Click;
            // 
            // lblCurrentAttempt
            // 
            lblCurrentAttempt.AutoSize = true;
            lblCurrentAttempt.Location = new Point(152, 98);
            lblCurrentAttempt.Name = "lblCurrentAttempt";
            lblCurrentAttempt.Size = new Size(19, 25);
            lblCurrentAttempt.TabIndex = 7;
            lblCurrentAttempt.Text = "-";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCurrentAttempt);
            Controls.Add(label3);
            Controls.Add(lblHash);
            Controls.Add(label2);
            Controls.Add(lblPassword);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            Controls.Add(btnGeneratePassword);
            Name = "Form1";
            Text = "Password Reset Brute Force Attack";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGeneratePassword;
        private Label label1;
        private ProgressBar progressBar1;
        private Label lblPassword;
        private Label label2;
        private Label lblHash;
        private Label label3;
        private Label lblCurrentAttempt;
    }
}

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
            btnStartAttack = new Button();
            label4 = new Label();
            lblFoundPassword = new Label();
            label5 = new Label();
            lblElapsedTime = new Label();
            btnStopAttack = new Button();
            btnSingleThreadTest = new Button();
            btnMultiThreadTest = new Button();
            lblSingleResult = new Label();
            lblMultiResult = new Label();
            lblWinner = new Label();
            SuspendLayout();
            // 
            // btnGeneratePassword
            // 
            btnGeneratePassword.Location = new Point(4, 5);
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
            progressBar1.Location = new Point(4, 216);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(243, 34);
            progressBar1.TabIndex = 2;
            progressBar1.Click += progressBar1_Click;
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
            // btnStartAttack
            // 
            btnStartAttack.Location = new Point(4, 126);
            btnStartAttack.Name = "btnStartAttack";
            btnStartAttack.Size = new Size(112, 34);
            btnStartAttack.TabIndex = 8;
            btnStartAttack.Text = "Start Attack";
            btnStartAttack.UseVisualStyleBackColor = true;
            btnStartAttack.Click += btnStartAttack_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(-1, 163);
            label4.Name = "label4";
            label4.Size = new Size(147, 25);
            label4.TabIndex = 9;
            label4.Text = "Found Password:";
            label4.Click += label4_Click;
            // 
            // lblFoundPassword
            // 
            lblFoundPassword.AutoSize = true;
            lblFoundPassword.Location = new Point(152, 163);
            lblFoundPassword.Name = "lblFoundPassword";
            lblFoundPassword.Size = new Size(19, 25);
            lblFoundPassword.TabIndex = 10;
            lblFoundPassword.Text = "-";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1, 188);
            label5.Name = "label5";
            label5.Size = new Size(120, 25);
            label5.TabIndex = 11;
            label5.Text = "Elapsed Time:";
            label5.Click += label5_Click;
            // 
            // lblElapsedTime
            // 
            lblElapsedTime.AutoSize = true;
            lblElapsedTime.Location = new Point(127, 188);
            lblElapsedTime.Name = "lblElapsedTime";
            lblElapsedTime.Size = new Size(22, 25);
            lblElapsedTime.TabIndex = 12;
            lblElapsedTime.Text = "0";
            // 
            // btnStopAttack
            // 
            btnStopAttack.Location = new Point(122, 126);
            btnStopAttack.Name = "btnStopAttack";
            btnStopAttack.Size = new Size(112, 34);
            btnStopAttack.TabIndex = 13;
            btnStopAttack.Text = "Stop Attack";
            btnStopAttack.UseVisualStyleBackColor = true;
            btnStopAttack.Click += button1_Click_1;
            // 
            // btnSingleThreadTest
            // 
            btnSingleThreadTest.Location = new Point(4, 256);
            btnSingleThreadTest.Name = "btnSingleThreadTest";
            btnSingleThreadTest.Size = new Size(112, 34);
            btnSingleThreadTest.TabIndex = 14;
            btnSingleThreadTest.Text = "Single Thread Test";
            btnSingleThreadTest.UseVisualStyleBackColor = true;
            btnSingleThreadTest.Click += button1_Click_2;
            // 
            // btnMultiThreadTest
            // 
            btnMultiThreadTest.Location = new Point(4, 301);
            btnMultiThreadTest.Name = "btnMultiThreadTest";
            btnMultiThreadTest.Size = new Size(112, 34);
            btnMultiThreadTest.TabIndex = 15;
            btnMultiThreadTest.Text = "Multi Thread Test";
            btnMultiThreadTest.UseVisualStyleBackColor = true;
            btnMultiThreadTest.Click += btnMultiThreadTest_Click;
            // 
            // lblSingleResult
            // 
            lblSingleResult.AutoSize = true;
            lblSingleResult.Location = new Point(117, 265);
            lblSingleResult.Name = "lblSingleResult";
            lblSingleResult.Size = new Size(135, 25);
            lblSingleResult.TabIndex = 17;
            lblSingleResult.Text = "Single Thread: -";
            lblSingleResult.Click += label6_Click;
            // 
            // lblMultiResult
            // 
            lblMultiResult.AutoSize = true;
            lblMultiResult.Location = new Point(117, 306);
            lblMultiResult.Name = "lblMultiResult";
            lblMultiResult.Size = new Size(127, 25);
            lblMultiResult.TabIndex = 18;
            lblMultiResult.Text = "Multi Thread: -";
            lblMultiResult.Click += label7_Click;
            // 
            // lblWinner
            // 
            lblWinner.AutoSize = true;
            lblWinner.Location = new Point(4, 338);
            lblWinner.Name = "lblWinner";
            lblWinner.Size = new Size(84, 25);
            lblWinner.TabIndex = 19;
            lblWinner.Text = "Winner: -";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 450);
            Controls.Add(lblWinner);
            Controls.Add(lblMultiResult);
            Controls.Add(lblSingleResult);
            Controls.Add(btnMultiThreadTest);
            Controls.Add(btnSingleThreadTest);
            Controls.Add(btnStopAttack);
            Controls.Add(lblElapsedTime);
            Controls.Add(label5);
            Controls.Add(lblFoundPassword);
            Controls.Add(label4);
            Controls.Add(btnStartAttack);
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
        private Button btnStartAttack;
        private Label label4;
        private Label lblFoundPassword;
        private Label label5;
        private Label lblElapsedTime;
        private Button btnStopAttack;
        private Button btnSingleThreadTest;
        private Button btnMultiThreadTest;
        private Label lblSingleResult;
        private Label lblMultiResult;
        private Label lblWinner;
    }
}

namespace GitBranchNameGenerator
{
    partial class MainForm
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
            this.TaskNumberLabel = new System.Windows.Forms.Label();
            this.TaskTitleLabel = new System.Windows.Forms.Label();
            this.TaskNumberTB = new System.Windows.Forms.TextBox();
            this.TaskTitleTB = new System.Windows.Forms.TextBox();
            this.GenerateGitBranchNameBtn = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ResultTB = new System.Windows.Forms.TextBox();
            this.BugfixRB = new System.Windows.Forms.RadioButton();
            this.FeatureRB = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // TaskNumberLabel
            // 
            this.TaskNumberLabel.AutoSize = true;
            this.TaskNumberLabel.Location = new System.Drawing.Point(52, 37);
            this.TaskNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TaskNumberLabel.Name = "TaskNumberLabel";
            this.TaskNumberLabel.Size = new System.Drawing.Size(50, 17);
            this.TaskNumberLabel.TabIndex = 0;
            this.TaskNumberLabel.Text = "Numer";
            // 
            // TaskTitleLabel
            // 
            this.TaskTitleLabel.AutoSize = true;
            this.TaskTitleLabel.Location = new System.Drawing.Point(52, 118);
            this.TaskTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TaskTitleLabel.Name = "TaskTitleLabel";
            this.TaskTitleLabel.Size = new System.Drawing.Size(39, 17);
            this.TaskTitleLabel.TabIndex = 1;
            this.TaskTitleLabel.Text = "Tytuł";
            // 
            // TaskNumberTB
            // 
            this.TaskNumberTB.Location = new System.Drawing.Point(56, 70);
            this.TaskNumberTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TaskNumberTB.Name = "TaskNumberTB";
            this.TaskNumberTB.Size = new System.Drawing.Size(952, 22);
            this.TaskNumberTB.TabIndex = 2;
            // 
            // TaskTitleTB
            // 
            this.TaskTitleTB.Location = new System.Drawing.Point(56, 154);
            this.TaskTitleTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TaskTitleTB.Name = "TaskTitleTB";
            this.TaskTitleTB.Size = new System.Drawing.Size(952, 22);
            this.TaskTitleTB.TabIndex = 3;
            // 
            // GenerateGitBranchNameBtn
            // 
            this.GenerateGitBranchNameBtn.Image = global::GitBranchNameGenerator.Properties.Resources.Button;
            this.GenerateGitBranchNameBtn.Location = new System.Drawing.Point(56, 325);
            this.GenerateGitBranchNameBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GenerateGitBranchNameBtn.Name = "GenerateGitBranchNameBtn";
            this.GenerateGitBranchNameBtn.Size = new System.Drawing.Size(76, 66);
            this.GenerateGitBranchNameBtn.TabIndex = 4;
            this.GenerateGitBranchNameBtn.UseVisualStyleBackColor = true;
            this.GenerateGitBranchNameBtn.Click += new System.EventHandler(this.GenerateGitBranchNameBtn_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(56, 437);
            this.ResultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(46, 17);
            this.ResultLabel.TabIndex = 5;
            this.ResultLabel.Text = "Wynik";
            // 
            // ResultTB
            // 
            this.ResultTB.Location = new System.Drawing.Point(60, 470);
            this.ResultTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ResultTB.Name = "ResultTB";
            this.ResultTB.Size = new System.Drawing.Size(948, 22);
            this.ResultTB.TabIndex = 6;
            // 
            // BugfixRB
            // 
            this.BugfixRB.AutoSize = true;
            this.BugfixRB.Location = new System.Drawing.Point(56, 208);
            this.BugfixRB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BugfixRB.Name = "BugfixRB";
            this.BugfixRB.Size = new System.Drawing.Size(57, 21);
            this.BugfixRB.TabIndex = 7;
            this.BugfixRB.TabStop = true;
            this.BugfixRB.Text = "Błąd";
            this.BugfixRB.UseVisualStyleBackColor = true;
            // 
            // FeatureRB
            // 
            this.FeatureRB.AutoSize = true;
            this.FeatureRB.Location = new System.Drawing.Point(56, 254);
            this.FeatureRB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FeatureRB.Name = "FeatureRB";
            this.FeatureRB.Size = new System.Drawing.Size(144, 21);
            this.FeatureRB.TabIndex = 8;
            this.FeatureRB.TabStop = true;
            this.FeatureRB.Text = "Wniosek o zmianę";
            this.FeatureRB.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.FeatureRB);
            this.Controls.Add(this.BugfixRB);
            this.Controls.Add(this.ResultTB);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.GenerateGitBranchNameBtn);
            this.Controls.Add(this.TaskTitleTB);
            this.Controls.Add(this.TaskNumberTB);
            this.Controls.Add(this.TaskTitleLabel);
            this.Controls.Add(this.TaskNumberLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Murankowy generator nazwy brancha do Git";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TaskNumberLabel;
        private System.Windows.Forms.Label TaskTitleLabel;
        private System.Windows.Forms.TextBox TaskNumberTB;
        private System.Windows.Forms.TextBox TaskTitleTB;
        private System.Windows.Forms.Button GenerateGitBranchNameBtn;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TextBox ResultTB;
        private System.Windows.Forms.RadioButton BugfixRB;
        private System.Windows.Forms.RadioButton FeatureRB;
    }
}


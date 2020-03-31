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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TaskNumberLabel = new System.Windows.Forms.Label();
            this.TaskTitleLabel = new System.Windows.Forms.Label();
            this.TaskNumberTB = new System.Windows.Forms.TextBox();
            this.TaskTitleTB = new System.Windows.Forms.TextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ResultTB = new System.Windows.Forms.TextBox();
            this.BugfixRB = new System.Windows.Forms.RadioButton();
            this.FeatureRB = new System.Windows.Forms.RadioButton();
            this.GenerateGitBranchNameBtn5 = new System.Windows.Forms.Button();
            this.GenerateGitBranchNameBtn6 = new System.Windows.Forms.Button();
            this.GenerateGitBranchNameBtn2 = new System.Windows.Forms.Button();
            this.GenerateGitBranchNameBtn4 = new System.Windows.Forms.Button();
            this.GenerateGitBranchNameBtn3 = new System.Windows.Forms.Button();
            this.GenerateGitBranchNameBtn = new System.Windows.Forms.Button();
            this.PlaySoundCB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // TaskNumberLabel
            // 
            this.TaskNumberLabel.AutoSize = true;
            this.TaskNumberLabel.Location = new System.Drawing.Point(52, 37);
            this.TaskNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TaskNumberLabel.Name = "TaskNumberLabel";
            this.TaskNumberLabel.Size = new System.Drawing.Size(104, 17);
            this.TaskNumberLabel.TabIndex = 0;
            this.TaskNumberLabel.Text = "Numer zadania";
            // 
            // TaskTitleLabel
            // 
            this.TaskTitleLabel.AutoSize = true;
            this.TaskTitleLabel.Location = new System.Drawing.Point(52, 118);
            this.TaskTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TaskTitleLabel.Name = "TaskTitleLabel";
            this.TaskTitleLabel.Size = new System.Drawing.Size(93, 17);
            this.TaskTitleLabel.TabIndex = 1;
            this.TaskTitleLabel.Text = "Tytuł zadania";
            // 
            // TaskNumberTB
            // 
            this.TaskNumberTB.Location = new System.Drawing.Point(56, 70);
            this.TaskNumberTB.Margin = new System.Windows.Forms.Padding(4);
            this.TaskNumberTB.Name = "TaskNumberTB";
            this.TaskNumberTB.Size = new System.Drawing.Size(952, 22);
            this.TaskNumberTB.TabIndex = 2;
            // 
            // TaskTitleTB
            // 
            this.TaskTitleTB.Location = new System.Drawing.Point(56, 154);
            this.TaskTitleTB.Margin = new System.Windows.Forms.Padding(4);
            this.TaskTitleTB.Name = "TaskTitleTB";
            this.TaskTitleTB.Size = new System.Drawing.Size(952, 22);
            this.TaskTitleTB.TabIndex = 3;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(53, 392);
            this.ResultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(148, 17);
            this.ResultLabel.TabIndex = 5;
            this.ResultLabel.Text = "Nazwa brancha do Git";
            // 
            // ResultTB
            // 
            this.ResultTB.Location = new System.Drawing.Point(55, 432);
            this.ResultTB.Margin = new System.Windows.Forms.Padding(4);
            this.ResultTB.Name = "ResultTB";
            this.ResultTB.Size = new System.Drawing.Size(948, 22);
            this.ResultTB.TabIndex = 6;
            // 
            // BugfixRB
            // 
            this.BugfixRB.AutoSize = true;
            this.BugfixRB.Location = new System.Drawing.Point(56, 208);
            this.BugfixRB.Margin = new System.Windows.Forms.Padding(4);
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
            this.FeatureRB.Margin = new System.Windows.Forms.Padding(4);
            this.FeatureRB.Name = "FeatureRB";
            this.FeatureRB.Size = new System.Drawing.Size(144, 21);
            this.FeatureRB.TabIndex = 8;
            this.FeatureRB.TabStop = true;
            this.FeatureRB.Text = "Wniosek o zmianę";
            this.FeatureRB.UseVisualStyleBackColor = true;
            // 
            // GenerateGitBranchNameBtn5
            // 
            this.GenerateGitBranchNameBtn5.Image = global::GitBranchNameGenerator.Properties.Resources.Button;
            this.GenerateGitBranchNameBtn5.Location = new System.Drawing.Point(978, 197);
            this.GenerateGitBranchNameBtn5.Margin = new System.Windows.Forms.Padding(4);
            this.GenerateGitBranchNameBtn5.Name = "GenerateGitBranchNameBtn5";
            this.GenerateGitBranchNameBtn5.Size = new System.Drawing.Size(76, 66);
            this.GenerateGitBranchNameBtn5.TabIndex = 13;
            this.GenerateGitBranchNameBtn5.UseVisualStyleBackColor = true;
            this.GenerateGitBranchNameBtn5.Click += new System.EventHandler(this.GenerateGitBranchNameBtn5_Click);
            // 
            // GenerateGitBranchNameBtn6
            // 
            this.GenerateGitBranchNameBtn6.Image = global::GitBranchNameGenerator.Properties.Resources.Button;
            this.GenerateGitBranchNameBtn6.Location = new System.Drawing.Point(179, -12);
            this.GenerateGitBranchNameBtn6.Margin = new System.Windows.Forms.Padding(4);
            this.GenerateGitBranchNameBtn6.Name = "GenerateGitBranchNameBtn6";
            this.GenerateGitBranchNameBtn6.Size = new System.Drawing.Size(76, 66);
            this.GenerateGitBranchNameBtn6.TabIndex = 12;
            this.GenerateGitBranchNameBtn6.UseVisualStyleBackColor = true;
            this.GenerateGitBranchNameBtn6.Click += new System.EventHandler(this.GenerateGitBranchNameBtn6_Click);
            // 
            // GenerateGitBranchNameBtn2
            // 
            this.GenerateGitBranchNameBtn2.Image = global::GitBranchNameGenerator.Properties.Resources.Button;
            this.GenerateGitBranchNameBtn2.Location = new System.Drawing.Point(317, 197);
            this.GenerateGitBranchNameBtn2.Margin = new System.Windows.Forms.Padding(4);
            this.GenerateGitBranchNameBtn2.Name = "GenerateGitBranchNameBtn2";
            this.GenerateGitBranchNameBtn2.Size = new System.Drawing.Size(76, 66);
            this.GenerateGitBranchNameBtn2.TabIndex = 11;
            this.GenerateGitBranchNameBtn2.UseVisualStyleBackColor = true;
            this.GenerateGitBranchNameBtn2.Click += new System.EventHandler(this.GenerateGitBranchNameBtn2_Click);
            // 
            // GenerateGitBranchNameBtn4
            // 
            this.GenerateGitBranchNameBtn4.Image = global::GitBranchNameGenerator.Properties.Resources.Button;
            this.GenerateGitBranchNameBtn4.Location = new System.Drawing.Point(885, 343);
            this.GenerateGitBranchNameBtn4.Margin = new System.Windows.Forms.Padding(4);
            this.GenerateGitBranchNameBtn4.Name = "GenerateGitBranchNameBtn4";
            this.GenerateGitBranchNameBtn4.Size = new System.Drawing.Size(76, 66);
            this.GenerateGitBranchNameBtn4.TabIndex = 10;
            this.GenerateGitBranchNameBtn4.UseVisualStyleBackColor = true;
            this.GenerateGitBranchNameBtn4.Click += new System.EventHandler(this.GenerateGitBranchNameBtn4_Click);
            // 
            // GenerateGitBranchNameBtn3
            // 
            this.GenerateGitBranchNameBtn3.Image = global::GitBranchNameGenerator.Properties.Resources.Button;
            this.GenerateGitBranchNameBtn3.Location = new System.Drawing.Point(495, 244);
            this.GenerateGitBranchNameBtn3.Margin = new System.Windows.Forms.Padding(4);
            this.GenerateGitBranchNameBtn3.Name = "GenerateGitBranchNameBtn3";
            this.GenerateGitBranchNameBtn3.Size = new System.Drawing.Size(76, 66);
            this.GenerateGitBranchNameBtn3.TabIndex = 9;
            this.GenerateGitBranchNameBtn3.UseVisualStyleBackColor = true;
            this.GenerateGitBranchNameBtn3.Click += new System.EventHandler(this.GenerateGitBranchNameBtn3_Click);
            // 
            // GenerateGitBranchNameBtn
            // 
            this.GenerateGitBranchNameBtn.Image = global::GitBranchNameGenerator.Properties.Resources.Button;
            this.GenerateGitBranchNameBtn.Location = new System.Drawing.Point(55, 299);
            this.GenerateGitBranchNameBtn.Margin = new System.Windows.Forms.Padding(4);
            this.GenerateGitBranchNameBtn.Name = "GenerateGitBranchNameBtn";
            this.GenerateGitBranchNameBtn.Size = new System.Drawing.Size(76, 66);
            this.GenerateGitBranchNameBtn.TabIndex = 4;
            this.GenerateGitBranchNameBtn.UseVisualStyleBackColor = true;
            this.GenerateGitBranchNameBtn.Click += new System.EventHandler(this.GenerateGitBranchNameBtn_Click);
            // 
            // PlaySoundCB
            // 
            this.PlaySoundCB.AutoSize = true;
            this.PlaySoundCB.Checked = true;
            this.PlaySoundCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PlaySoundCB.Location = new System.Drawing.Point(56, 493);
            this.PlaySoundCB.Name = "PlaySoundCB";
            this.PlaySoundCB.Size = new System.Drawing.Size(139, 21);
            this.PlaySoundCB.TabIndex = 14;
            this.PlaySoundCB.Text = "Odtwarzaj dźwięk";
            this.PlaySoundCB.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.PlaySoundCB);
            this.Controls.Add(this.GenerateGitBranchNameBtn5);
            this.Controls.Add(this.GenerateGitBranchNameBtn6);
            this.Controls.Add(this.GenerateGitBranchNameBtn2);
            this.Controls.Add(this.GenerateGitBranchNameBtn4);
            this.Controls.Add(this.GenerateGitBranchNameBtn3);
            this.Controls.Add(this.FeatureRB);
            this.Controls.Add(this.BugfixRB);
            this.Controls.Add(this.ResultTB);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.GenerateGitBranchNameBtn);
            this.Controls.Add(this.TaskTitleTB);
            this.Controls.Add(this.TaskNumberTB);
            this.Controls.Add(this.TaskTitleLabel);
            this.Controls.Add(this.TaskNumberLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button GenerateGitBranchNameBtn3;
        private System.Windows.Forms.Button GenerateGitBranchNameBtn4;
        private System.Windows.Forms.Button GenerateGitBranchNameBtn2;
        private System.Windows.Forms.Button GenerateGitBranchNameBtn6;
        private System.Windows.Forms.Button GenerateGitBranchNameBtn5;
        private System.Windows.Forms.CheckBox PlaySoundCB;
    }
}


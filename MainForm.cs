using GitBranchNameGenerator.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitBranchNameGenerator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void GenerateGitBranchName()
        {

            string type = BugfixRB.Checked ? "bugfix" : FeatureRB.Checked ? "feature" : "";

            string numberWithNoPolishLetters = TaskNumberTB.Text.Trim().ToLower().Replace("ł", "l").Replace("ą", "a").Replace("ę", "e").Replace("ó", "o").Replace("ś", "s").Replace("ź", "z")
                .Replace("ż", "z").Replace("ń", "n").Replace("ć", "c");
            string number = Regex.Replace(numberWithNoPolishLetters.Trim(), "[^A-Za-z0-9 ]", "");

            string titleWithNoPolishLetters = TaskTitleTB.Text.Trim().ToLower().Replace("ł", "l").Replace("ą", "a").Replace("ę", "e").Replace("ó", "o").Replace("ś", "s").Replace("ź", "z")
                .Replace("ż", "z").Replace("ń", "n").Replace("ć", "c");
            string title = Regex.Replace(titleWithNoPolishLetters, "[^A-Za-z0-9_]", "_");

            string connector1 = !String.IsNullOrEmpty(type) && (!String.IsNullOrEmpty(number) || !String.IsNullOrEmpty(title)) ? "/" : "";

            string connector2 = !String.IsNullOrEmpty(number) && !String.IsNullOrEmpty(title) ? "-" : "";

            string result = type + connector1 + number + connector2 + title;

            Regex regex = new Regex("[_]{2,}");
            result = regex.Replace(result, "_");

            if (result.EndsWith("_"))
            {
                result = result.Remove(result.Length - 1);
            }

            ResultTB.Text = result;

            if (!String.IsNullOrEmpty(result))
                Clipboard.SetText(result);

            if (PlaySoundCB.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Resources.sound);
                player.Play();
            }
        }

        private void GenerateGitBranchNameBtn_Click(object sender, EventArgs e)
        {
            GenerateGitBranchName();
        }

        private void GenerateGitBranchNameBtn2_Click(object sender, EventArgs e)
        {
            GenerateGitBranchName();
        }

        private void GenerateGitBranchNameBtn3_Click(object sender, EventArgs e)
        {
            GenerateGitBranchName();
        }

        private void GenerateGitBranchNameBtn4_Click(object sender, EventArgs e)
        {
            GenerateGitBranchName();
        }

        private void GenerateGitBranchNameBtn5_Click(object sender, EventArgs e)
        {
            GenerateGitBranchName();
        }

        private void GenerateGitBranchNameBtn6_Click(object sender, EventArgs e)
        {
            GenerateGitBranchName();
        }
    }
}

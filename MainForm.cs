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

        private void GenerateGitBranchNameBtn_Click(object sender, EventArgs e)
        {

            string type = BugfixRB.Checked ? "bugfix" : FeatureRB.Checked ? "feature" : "";

            string numberWithNoPolishLetters = TaskNumberTB.Text.Trim().ToLower().Replace("ł", "l").Replace("ą", "a").Replace("ę", "e").Replace("ó", "o").Replace("ś", "s").Replace("ź", "z")
                .Replace("ż", "z").Replace("ń", "n").Replace("ć", "c").Replace(" ", "_"); ;
            string number = Regex.Replace(numberWithNoPolishLetters.Trim(), "[^A-Za-z0-9 ]", "");

            string titleWithNoPolishLetters = TaskTitleTB.Text.Trim().ToLower().Replace("ł", "l").Replace("ą", "a").Replace("ę", "e").Replace("ó", "o").Replace("ś", "s").Replace("ź", "z")
                .Replace("ż", "z").Replace("ń", "n").Replace("ć", "c").Replace(" ", "_"); ;
            string title = Regex.Replace(titleWithNoPolishLetters, "[^A-Za-z0-9_]", "");

            string connector1 = !String.IsNullOrEmpty(type) && (!String.IsNullOrEmpty(number) || !String.IsNullOrEmpty(title)) ? "/" : "";

            string connector2 = !String.IsNullOrEmpty(number) && !String.IsNullOrEmpty(title) ? "-" : "";

            string result = type + connector1 + number + connector2 + title;

            ResultTB.Text = result;

            if (!String.IsNullOrEmpty(result))
                Clipboard.SetText(result);
        }
    }
}

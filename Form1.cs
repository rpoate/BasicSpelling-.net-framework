using System;
using System.Windows.Forms;
using Zoople;

namespace BasicSpelling.net_frameword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            winformsSpell1.SetLicense("", "");
            winformsSpell1.InitSpelling_AllTextBoxes();
            winformsSpell1.SpellCheckDialogCurrentTextboxShortcutKey = Shortcut.F7;

            this.textBox1.Text = "Pre-existing text here. With spelllling mistakkes.";
        }
    }
}

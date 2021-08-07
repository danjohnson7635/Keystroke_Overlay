using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeystrokeCounter
{
    public partial class Form2 : Form
    {
        public Form1 MyParent;
        bool showKPS = true;
        bool countByKey = true;
        Dictionary<string, Color> form2ColorDict = new Dictionary<string, Color>();
        Dictionary<string, Color> defaultColors = new Dictionary<string, Color>();


        public Form2()
        {
            InitializeComponent();
            MakeDefaultColorDict();
            form2ColorDict = defaultColors;



            UpdateColorPreviews();
        }
        
        public Form2(Form1 p, Dictionary<string, Color> startColors)
        {
            MyParent = p;
            form2ColorDict = startColors;
            MakeDefaultColorDict();
            InitializeComponent();
            UpdateColorPreviews();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxKPS.Checked )
            {
                showKPS = true; 
            }
            else
            {
                showKPS = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                form2ColorDict["unpressed"] = colorDialog.Color;
            }
            UpdateColorPreviews();
        }
        
        private void btnPressedColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                form2ColorDict["pressed"] = colorDialog.Color;
            }
            UpdateColorPreviews();
        }
        
        private void btnBackgroundColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                form2ColorDict["background"] = colorDialog.Color;

            }
            UpdateColorPreviews();
        }

        private void btnFontColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                form2ColorDict["font"] = colorDialog.Color;
            }
            UpdateColorPreviews();
        }
        
        
        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            MyParent.ApplySettings(showKPS,countByKey, form2ColorDict);
        }

        private void btnRestoreDefaultSettings_Click(object sender, EventArgs e)
        {
            form2ColorDict = defaultColors;
            MyParent.RestoreDefaultSettings();
            UpdateColorPreviews();
        }
        private void UpdateColorPreviews()
        {
            lblUP.BackColor = form2ColorDict["unpressed"];
            lblP.BackColor = form2ColorDict["pressed"];
            lblBG.BackColor = form2ColorDict["background"];
            lblF.BackColor = form2ColorDict["font"];
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxCountByKey_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCountByKey.Checked)
            {
                countByKey = true;
            }
            else
            {
                countByKey = false;
            }
        }

        private void MakeDefaultColorDict()
        {
            defaultColors = new Dictionary<string, Color>();
            defaultColors.Add("unpressed", Color.White);
            defaultColors.Add("pressed", Color.FromArgb(85, 159, 230));
            defaultColors.Add("background", Color.Gray);
            defaultColors.Add("font", Color.Black);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FormProfile profileForm = new FormProfile();
            profileForm.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OsuOverlay
{
    public partial class FormProfile : Form
    {
        
        public FormProfile()
        {
            InitializeComponent();

        }

        private void btnProfileCreate_Click(object sender, EventArgs e)
        {
            Profile newProf = new Profile(txtName.Text);
            //Form1.profileList.Add(newProf);
            this.Close();
        }

        private void btnProfileCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

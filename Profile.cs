using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace KeystrokeCounter
{
    class Profile
    {
        private int profileCount = 10;
        //private int test1 = Form1.test;

        public Profile()
        {
            ID = profileCount;
            Name = $"profile {profileCount}";
            resetData();
            profileCount++;
        }
        public Profile(string n)
        {
            ID = profileCount;
            Name = n;
            resetData();
            profileCount++;
            newProfile();
        }

        public Profile(int idNum, string n, Dictionary<string, Color> clrs, int[] data )
        {
            ID = idNum;
            Name = n;
            Colors = clrs;
            ClickData = data;
        }

        //updates the file for new profiles
        private void newProfile()
        {
            //Form1.updateProfiles();
        }

        public int ID
        {
            get;
            private set;
        }
        public string Name
        {
            get;
            private set;
        }
        public Dictionary<string, Color> Colors
        {
            get;
            set;
        }

        public int[] ClickData
        {
            get;
            private set;
        }

        public void updateFile()
        {

        }

        private void resetData()
        {
            ClickData = new int[59];
            for(int i =0; i<59; i++)
            {
                ClickData[i]=0;
            }
        }



    }
}

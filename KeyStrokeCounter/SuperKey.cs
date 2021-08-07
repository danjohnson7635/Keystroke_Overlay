using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using label = System.Windows.Forms.Label;
using Gma.System.MouseKeyHook;
using System.Windows.Forms;
using System.Drawing;

namespace KeystrokeCounter
{
    class SuperKey
    {
        public SuperKey()
        {
            Key = Keys.X;
            Count = 0;
            LblNum = new label();
            Lbl = new label();

        }
        public SuperKey(Keys key, label l, label lnum)
        {
            Key=key;
            Lbl = l;
            LblNum = lnum;
            Count = 0;

        }

        public Keys Key
        {
            get;
            set;
        }
        public label Lbl
        {
            get;
            set;
        }
        public label LblNum
        {
            get;
            set;
        }

        public int Count
        {
            get;
            set;
        }

        public void Increment()
        {
            Count++;
        }

        public void Down(Color downColor)
        {
            Lbl.BackColor = downColor;
            LblNum.BackColor = downColor;
        }

        public void Up(Color upColor) {
            Increment();
            Lbl.BackColor = upColor;            
            LblNum.Text = Count.ToString();
            LblNum.BackColor = upColor;

        }

        public void Update()
        {
            LblNum.Text = Count.ToString();
        }
    }
}

using System;
using System.Windows.Input;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Loamen.KeyMouseHook;
using Gma.System.MouseKeyHook;
using KeyEventArgs = System.Windows.Forms.KeyEventArgs;
using System.Diagnostics;
using System.Threading;
using System.IO;


namespace KeystrokeCounter
{
	public partial class Form1 : Form
	{
		//declare the counter for keys clicked in a timer tick (125ms)
		public int tickCounter = 0;

		//superkey list declaration
		List<SuperKey> keySet = new List<SuperKey>();

		//Superkeys declaration
		SuperKey D0SK = new SuperKey();
		SuperKey D1SK = new SuperKey();
		SuperKey D2SK = new SuperKey();
		SuperKey D3SK = new SuperKey();
		SuperKey D4SK = new SuperKey();
		SuperKey D5SK = new SuperKey();
		SuperKey D6SK = new SuperKey();
		SuperKey D7SK = new SuperKey();
		SuperKey D8SK = new SuperKey();
		SuperKey D9SK = new SuperKey();
		SuperKey QSK = new SuperKey();
		SuperKey WSK = new SuperKey();
		SuperKey ESK = new SuperKey();
		SuperKey RSK = new SuperKey();
		SuperKey TSK = new SuperKey();
		SuperKey YSK = new SuperKey();
		SuperKey USK = new SuperKey();
		SuperKey ISK = new SuperKey();
		SuperKey OSK = new SuperKey();
		SuperKey PSK = new SuperKey();
		SuperKey ASK = new SuperKey();
		SuperKey SSK = new SuperKey();
		SuperKey DSK = new SuperKey();
		SuperKey FSK = new SuperKey();
		SuperKey GSK = new SuperKey();
		SuperKey HSK = new SuperKey();
		SuperKey JSK = new SuperKey();
		SuperKey KSK = new SuperKey();
		SuperKey LSK = new SuperKey();
		SuperKey ZSK = new SuperKey();
		SuperKey XSK = new SuperKey();
		SuperKey CSK = new SuperKey();
		SuperKey VSK = new SuperKey();
		SuperKey BSK = new SuperKey();
		SuperKey NSK = new SuperKey();
		SuperKey MSK = new SuperKey();
		SuperKey LShiftKeySK = new SuperKey();
		SuperKey RShiftKeySK = new SuperKey();
		SuperKey LControlKeySK = new SuperKey();
		SuperKey RControlKeySK = new SuperKey();
		SuperKey BackSK = new SuperKey();
		SuperKey LMenuSK = new SuperKey();
		SuperKey RMenuSK = new SuperKey();
		SuperKey LWinSK = new SuperKey();
		SuperKey SpaceSK = new SuperKey();
		SuperKey EnterSK = new SuperKey();
		SuperKey OemMinusSK = new SuperKey();
		SuperKey OemcommaSK = new SuperKey();
		SuperKey OemOpenBracketsSK = new SuperKey();
		SuperKey OemPeriodSK = new SuperKey();
		SuperKey OemPipeSK = new SuperKey();
		SuperKey OemplusSK = new SuperKey();
		SuperKey OemQuestionSK = new SuperKey();
		SuperKey OemCloseBracketsSK = new SuperKey();
		SuperKey OemQuotesSK = new SuperKey();
		SuperKey OemSemicolonSK = new SuperKey();
		SuperKey OemtildeSK = new SuperKey();
		SuperKey OemBackslashSK = new SuperKey();
		SuperKey TabSK = new SuperKey();
		SuperKey CapsLockSK = new SuperKey();
		
		//declare the queue for measuring KPS(keys per second)
		Queue<int> KPSQueue = new Queue<int>();
		
		//declare the key/mouse hook event manager
		private IKeyboardMouseEvents m_GlobalHook;

		//declare the colors for the form style
		public Dictionary<string, Color> defaultColorDict = new Dictionary<string, Color>();
		Color DefaultUnpressedColor = Color.White;
		Color DefaultPressedColor = Color.FromArgb(85, 159, 230);
		Color DefaultBackgroundColor = Color.Gray;
		Color DefaultFontColor = Color.Black;

		//These are for the user defined colors
		//List<Color> colorSet;
		Dictionary<string, Color> colorDict = new Dictionary<string, Color>();
		Color UnpressedColor;
		Color PressedColor;
		Color BackgroundColor;
		Color FontColor;

		//get the user keyCount information from the text file
		string[] currentData= System.IO.File.ReadAllLines(@"currentData.txt");
		string[] lifetimeData = System.IO.File.ReadAllLines(@"lifetimeData.txt");

		//create a profile to be the main profile and a set of all profiles
		//Profile currentProfile;
		//List<Profile> profileList = new List<Profile>();

		//get the list of profile numbers from the profileNumbers.txt file
		/**
		string[] profileStartData = System.IO.File.ReadAllLines(@"profileNumbers.txt");
		public int profileNumStart;
		string[] profileNumbers; 
		*/

		



		//get the user Style information from the text file
		string[] colorData = System.IO.File.ReadAllLines(@"colorData.txt");

		public Form1()
		{	
			InitializeComponent();
			
			//set up the KPS tier queue with size 8
			for (int i = 0; i <8; i++)
            {
				KPSQueue.Enqueue(0);
            }
			/**
			//organize the profile data from the string arrays and update the starting index for profiles
			profileNumStart = Int32.Parse(profileStartData[0]);
			profileNumbers = new string[profileStartData.Length - 2];

			for(int i = 2; i < profileStartData.Length; i++)
            {
				profileNumbers[i - 2] = profileStartData[i];
            }




			//load all the profiles from their txt files
			foreach (string s in profileNumbers)
			{
				string[] profileData = System.IO.File.ReadAllLines($@"profile{s}.txt");
				
				//get the color data
				string[] colorStrings = new string[4];
				for(int i = 4; i<8; i++)
                {
					colorStrings[i - 4] = profileData[i];
                }

				int[] clickData = new int[60];
				//get the key data
				for (int i = 10; i < profileData.Length; i++)
				{
					clickData[i - 10] = Int32.Parse(profileData[i]);
				}


				Dictionary<string, Color> tempColors = colorDataParse(colorStrings);

				//create the profile and add it to the profile list
				Profile temp = new Profile(Int32.Parse(profileData[0]),profileData[2], tempColors, clickData);

				profileList.Add(temp);

			}
			*/
			//the default current profile will be the first one added
			//currentProfile = profileList[0];
			//currentData = currentProfile.ClickData;

			//Superkeys declaration and adding them to list
			//this if statement is just to be able to minimize this section
			if (true) { 
			D0SK = new SuperKey(Keys.D0, lblD0, lblD0Num);
			D1SK = new SuperKey(Keys.D1, lblD1, lblD1Num);
			D2SK = new SuperKey(Keys.D2, lblD2, lblD2Num);
			D3SK = new SuperKey(Keys.D3, lblD3, lblD3Num);
			D4SK = new SuperKey(Keys.D4, lblD4, lblD4Num);
			D5SK = new SuperKey(Keys.D5, lblD5, lblD5Num);
			D6SK = new SuperKey(Keys.D6, lblD6, lblD6Num);
			D7SK = new SuperKey(Keys.D7, lblD7, lblD7Num);
			D8SK = new SuperKey(Keys.D8, lblD8, lblD8Num);
			D9SK = new SuperKey(Keys.D9, lblD9, lblD9Num);
			QSK = new SuperKey(Keys.Q, lblQ, lblQNum);
			WSK = new SuperKey(Keys.W, lblW, lblWNum);
			ESK = new SuperKey(Keys.E, lblE, lblENum);
			RSK = new SuperKey(Keys.R, lblR, lblRNum);
			TSK = new SuperKey(Keys.T, lblT, lblTNum);
			YSK = new SuperKey(Keys.Y, lblY, lblYNum);
			USK = new SuperKey(Keys.U, lblU, lblUNum);
			ISK = new SuperKey(Keys.I, lblI, lblINum);
			OSK = new SuperKey(Keys.O, lblO, lblONum);
			PSK = new SuperKey(Keys.P, lblP, lblPNum);
			ASK = new SuperKey(Keys.A, lblA, lblANum);
			SSK = new SuperKey(Keys.S, lblS, lblSNum);
			DSK = new SuperKey(Keys.D, lblD, lblDNum);
			FSK = new SuperKey(Keys.F, lblF, lblFNum);
			GSK = new SuperKey(Keys.G, lblG, lblGNum);
			HSK = new SuperKey(Keys.H, lblH, lblHNum);
			JSK = new SuperKey(Keys.J, lblJ, lblJNum);
			KSK = new SuperKey(Keys.K, lblK, lblKNum);
			LSK = new SuperKey(Keys.L, lblL, lblLNum);
			ZSK = new SuperKey(Keys.Z, lblZ, lblZNum);
			XSK = new SuperKey(Keys.X, lblX, lblXNum);
			CSK = new SuperKey(Keys.C, lblC, lblCNum);
			VSK = new SuperKey(Keys.V, lblV, lblVNum);
			BSK = new SuperKey(Keys.B, lblB, lblBNum);
			NSK = new SuperKey(Keys.N, lblN, lblNNum);
			MSK = new SuperKey(Keys.M, lblM, lblMNum);
			LShiftKeySK = new SuperKey(Keys.LShiftKey, lblLShiftKey, lblLShiftKeyNum);
			RShiftKeySK = new SuperKey(Keys.RShiftKey, lblRShiftKey, lblRShiftKeyNum);
			LControlKeySK = new SuperKey(Keys.LControlKey, lblLControlKey, lblLControlKeyNum);
			RControlKeySK = new SuperKey(Keys.RControlKey, lblRControlKey, lblRControlKeyNum);
			BackSK = new SuperKey(Keys.Back, lblBack, lblBackNum);
			LMenuSK = new SuperKey(Keys.LMenu, lblLMenu, lblLMenuNum);
			RMenuSK = new SuperKey(Keys.RMenu, lblRMenu, lblRMenuNum);
			LWinSK = new SuperKey(Keys.LWin, lblLWin, lblLWinNum);
			SpaceSK = new SuperKey(Keys.Space, lblSpace, lblSpaceNum);
			EnterSK = new SuperKey(Keys.Enter, lblEnter, lblEnterNum);
			OemMinusSK = new SuperKey(Keys.OemMinus, lblOemMinus, lblOemMinusNum);
			OemcommaSK = new SuperKey(Keys.Oemcomma, lblOemcomma, lblOemcommaNum);
			OemOpenBracketsSK = new SuperKey(Keys.OemOpenBrackets, lblOemOpenBrackets, lblOemOpenBracketsNum);
			OemPeriodSK = new SuperKey(Keys.OemPeriod, lblOemPeriod, lblOemPeriodNum);
			OemPipeSK = new SuperKey(Keys.OemPipe, lblOemPipe, lblOemPipeNum);
			OemplusSK = new SuperKey(Keys.Oemplus, lblOemplus, lblOemplusNum);
			OemQuestionSK = new SuperKey(Keys.OemQuestion, lblOemQuestion, lblOemQuestionNum);
			OemCloseBracketsSK = new SuperKey(Keys.OemCloseBrackets, lblOemCloseBrackets, lblOemCloseBracketsNum);
			OemQuotesSK = new SuperKey(Keys.OemQuotes, lblOemQuotes, lblOemQuotesNum);
			OemSemicolonSK = new SuperKey(Keys.OemSemicolon, lblOemSemicolon, lblOemSemicolonNum);
			OemtildeSK = new SuperKey(Keys.Oemtilde, lblOemtilde, lblOemtildeNum);
			//OemBackslashSK = new SuperKey(Keys.OemBackslash, lblOemBackslash, lblOemBackslashNum);
			TabSK = new SuperKey(Keys.Tab, lblTab, lblTabNum);
			CapsLockSK = new SuperKey(Keys.CapsLock, lblCapsLock, lblCapsLockNum); 
			keySet.Add(D0SK);
			keySet.Add(D1SK);
			keySet.Add(D2SK);
			keySet.Add(D3SK);
			keySet.Add(D4SK);
			keySet.Add(D5SK);
			keySet.Add(D6SK);
			keySet.Add(D7SK);
			keySet.Add(D8SK);
			keySet.Add(D9SK);
			keySet.Add(QSK);
			keySet.Add(WSK);
			keySet.Add(ESK);
			keySet.Add(RSK);
			keySet.Add(TSK);
			keySet.Add(YSK);
			keySet.Add(USK);
			keySet.Add(ISK);
			keySet.Add(OSK);
			keySet.Add(PSK);
			keySet.Add(ASK);
			keySet.Add(SSK);
			keySet.Add(DSK);
			keySet.Add(FSK);
			keySet.Add(GSK);
			keySet.Add(HSK);
			keySet.Add(JSK);
			keySet.Add(KSK);
			keySet.Add(LSK);
			keySet.Add(ZSK);
			keySet.Add(XSK);
			keySet.Add(CSK);
			keySet.Add(VSK);
			keySet.Add(BSK);
			keySet.Add(NSK);
			keySet.Add(MSK);
			keySet.Add(LShiftKeySK);
			keySet.Add(RShiftKeySK);
			keySet.Add(LControlKeySK);
			keySet.Add(RControlKeySK);
			keySet.Add(BackSK);
			keySet.Add(LMenuSK);
			keySet.Add(RMenuSK);
			keySet.Add(LWinSK);
			keySet.Add(SpaceSK);
			keySet.Add(EnterSK);
			keySet.Add(OemMinusSK);
			keySet.Add(OemcommaSK);
			keySet.Add(OemOpenBracketsSK);
			keySet.Add(OemPeriodSK);
			keySet.Add(OemPipeSK);
			keySet.Add(OemplusSK);
			keySet.Add(OemQuestionSK);
			keySet.Add(OemCloseBracketsSK);
			keySet.Add(OemQuotesSK);
			keySet.Add(OemSemicolonSK);
			keySet.Add(OemtildeSK);
			keySet.Add(OemBackslashSK);
			keySet.Add(TabSK);
			keySet.Add(CapsLockSK);
			}


			int loopCounter = 0;
			foreach(SuperKey SK in keySet)
            {
				SK.Count = Int32.Parse(currentData[loopCounter]);
				loopCounter++;
            }
			
			DisplayTotal();

			//load the user style info from text

			colorDataParse(colorData);

			

			//add the colors retrieved to the dictionary
			//colorSet = new List<Color> { UnpressedColor, PressedColor, BackgroundColor, FontColor };
			colorDict.Add("unpressed", UnpressedColor);
			colorDict.Add("pressed", PressedColor);
			colorDict.Add("background", BackgroundColor);
			colorDict.Add("font", FontColor);

			//initialize the default colors dictionary
			defaultColorDict.Add("unpressed", DefaultUnpressedColor);
			defaultColorDict.Add("pressed", DefaultPressedColor);
			defaultColorDict.Add("background", DefaultBackgroundColor);
			defaultColorDict.Add("font", DefaultFontColor);


			LoadColorSettings();

			//set up the global keyhook and link methods
            m_GlobalHook = Hook.GlobalEvents();
            if (m_GlobalHook == null) return;
            m_GlobalHook.KeyDown += GlobalHookKeyDown;
            m_GlobalHook.KeyUp += GlobalHookKeyUp;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
			//updateProfileSelection();

        }


		private void GlobalHookKeyDown(object sender, KeyEventArgs e)
		{
			foreach (SuperKey SK in keySet)
			{
				if (e.KeyCode == SK.Key)
				{
					SK.Down(colorDict["pressed"]);
					break;
				}
			}
		}

        private void GlobalHookKeyUp(object sender, KeyEventArgs e)
        {

			tickCounter++;
			foreach (SuperKey SK in keySet)
			{
				if (e.KeyCode == SK.Key)
				{
					SK.Up(colorDict["unpressed"]);
					break;
				}
			}
			DisplayTotal();
		}

        private void GlobalHookMouseDownExt(object sender, MouseEventExtArgs e)
        {
            Console.WriteLine("MouseDown: \t{0}; \t System Timestamp: \t{1}", e.Button, e.Timestamp);

            // uncommenting the following line will suppress the middle mouse button click
            // if (e.Buttons == MouseButtons.Middle) { e.Handled = true; }
        }

		private void UpdateKeys()
        {
			foreach (SuperKey SK in keySet)
			{
				SK.Update();
			}
		}

        private void UpdateData()
        {
			int loopCounter = 0;
			foreach(SuperKey SK in keySet)
            {
				currentData[loopCounter] = SK.Count.ToString();
				lifetimeData[loopCounter] = (Int32.Parse(lifetimeData[loopCounter]) + SK.Count).ToString();
				loopCounter++;
			}

			//clear the files then write the new info to them
			File.WriteAllText(@"currentData.txt", string.Empty);
			//currentProfile.updateFile();
			File.WriteAllText(@"lifetimeData.txt", string.Empty);

			File.WriteAllLines(@"currentData.txt", currentData);
			File.WriteAllLines(@"lifetimeData.txt", lifetimeData);

		}

        private void DisplayTotal()
        {
			UpdateKeys();
			int total = 0;
            foreach(SuperKey SK in keySet){
				total += SK.Count;
            }
			String totalString = String.Format("{0:n0}", total);
			lblTotal.Text = totalString + " Key Presses";

        }

        private void timer_Tick(object sender, EventArgs e)
        {
			KPSQueue.Enqueue(tickCounter);
			KPSQueue.Dequeue();
			int KeysIn1Sec = 0;

			foreach(int i in KPSQueue)
            {
				KeysIn1Sec += i;
			}

			double KPS = KeysIn1Sec;



			lblKPS.Text = String.Format("{0:0.00}", KPS) + " KPS";
			tickCounter = 0;

		}

		private void Form1_Closing(object sender, FormClosingEventArgs e)
		{
			//write the user data to the text file
			UpdateData();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
			UpdateData();
        }

        private void timerSave_Tick(object sender, EventArgs e)
        {
			UpdateData();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
			Form2 Settings = new Form2(this, colorDict);
			Settings.MyParent = this;
			Settings.Show();
        }

		private void LoadColorSettings()
        {
			
			lblKPS.BackColor = colorDict["background"];
			lblTotal.BackColor = colorDict["background"];
			BackColor = colorDict["background"];


			foreach (SuperKey SK in keySet)
            {
				SK.Lbl.BackColor = colorDict["unpressed"];
				SK.LblNum.BackColor = colorDict["unpressed"];
				SK.Lbl.ForeColor = colorDict["font"];
				SK.LblNum.ForeColor = colorDict["font"];
			}
			lblKPS.ForeColor = colorDict["font"];
			lblTotal.ForeColor = colorDict["font"];
		}

		public void ApplySettings(bool kps, bool countByKey, Dictionary<string, Color> newColors )
        {
			foreach (SuperKey SK in keySet)
			{
				SK.LblNum.Visible = countByKey;				
			}
			lblKPS.Visible = kps;
			colorDict = newColors;
			//currentProfile.Colors = newColors;
			LoadColorSettings();
        }
		public void RestoreDefaultSettings()
        {
			lblKPS.Visible = true;
			colorDict = defaultColorDict;
			LoadColorSettings();
		}

		public Dictionary<string, Color> colorDataParse(string[] colorData)
        {
			int colorLoopCounter = 0;

			Dictionary<string, Color> returnColors = new Dictionary<string, Color>();
			foreach (string s in colorData)
			{
				Color tempColor = Color.White;
				if (s.Contains(","))
				{
					string[] rgbValues = s.Split(',');
					int redVal = Int32.Parse(rgbValues[0]);
					int greenVal = Int32.Parse(rgbValues[1]);
					int blueVal = Int32.Parse(rgbValues[2]);
					tempColor = Color.FromArgb(redVal, greenVal, blueVal);
				}
				else
				{
					tempColor = Color.FromName(s);
				}

				switch (colorLoopCounter)
				{
					case 0:
						UnpressedColor = tempColor;
						break;
					case 1:
						PressedColor = tempColor;
						break;
					case 2:
						BackgroundColor = tempColor;
						break;
					case 3:
						FontColor = tempColor;
						break;
				}
				colorLoopCounter++;

			}

			returnColors.Add("unpressed", UnpressedColor);
			returnColors.Add("pressed", PressedColor);
			returnColors.Add("background", BackgroundColor);
            returnColors.Add("font", FontColor);

			return returnColors;


		}
		
		//makes sure all the profiles can be seen
		/**
		public void updateProfiles()
        {
            foreach (Profile p in profileList)
            {
				//profileSelection.Items.Add(p.Name);
            }
        }
		
        private void profileSelection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
		*/
    }
}

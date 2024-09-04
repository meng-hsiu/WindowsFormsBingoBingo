using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsBingoBingoUI
{
    internal class Animation
    {
        public Timer mytimer;
        public Panel mypanel;
        public Button mybutton;
        public int currentIndex = 0;
        public int maxCount = 5;
        public int FPS = 120;

        public void TimerSet()
        {
            
        }

        public void MenuAnimation(Button buttonname,Panel panelanimationname,bool action)
        {//true是打開 false是關閉                    
            mytimer = new Timer();
            mytimer.Interval = 1000/FPS;
            mytimer.Enabled = true;
            mytimer.Start();
            currentIndex = 0;
            mypanel = panelanimationname; //將Menu.cs輸入的panel名字傳進mypanel中
            mybutton = buttonname;

            if (action == true)
            {
                mytimer.Tick += Open;
                mypanel.Height = 0;
                mypanel.Visible = true;
            }
            else
            {
                mytimer.Tick += Close;
            }
            
        }


        //打開的動畫
        public void Open(object sender, EventArgs e)
        {

            if (currentIndex < maxCount)
            {
                mybutton.Enabled = false;
                //Console.WriteLine($"Processing index {currentIndex}");
                currentIndex += 1;
                mypanel.Height += 26;
            }
            else
            {
                mytimer.Stop();
                mybutton.Enabled = true;
            }
        }

        //關閉的動畫
        public void Close(object sender, EventArgs e)
        {
            if (currentIndex < maxCount)
            {
                mybutton.Enabled = false;
                //Console.WriteLine($"Processing index {currentIndex}");
                currentIndex += 1;
                mypanel.Height -= 26;
            }
            else
            {
                mytimer.Stop();
                mypanel.Visible = false; //節省效能 把它關了 其實沒這行也沒差
                mybutton.Enabled = true;
            }
        }


    }
}

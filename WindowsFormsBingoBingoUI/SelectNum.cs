using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsBingoBingoUI
{
    internal class SelectNum
    {
        List<RoundButton> myroundbuttons = new List<RoundButton>();
        List<int> TargetNum = new List<int>();

        public SelectNum()
        {

        }

        public void Target(List<RoundButton> list, Panel panelname) //功能:將某個Panel內的RoundButton存進List中
        {
            myroundbuttons = list;

            //抓這個panel內的Object屬於RoundButton的存進list中
            foreach (Object roundButton in panelname.Controls)
            {
                if (roundButton is RoundButton)
                {
                    myroundbuttons.Add((RoundButton)roundButton);//將找到的RoundButton存進list中
                }
            }
        }



        //判斷RoundButton有沒有被按下
        public void TargetClick(List<RoundButton> list)
        {
            foreach (RoundButton roundButton in list)
            {
                if (roundButton is RoundButton)
                {
                    roundButton.Click += ShowButton;
                }
            }
        }


        //按下的RoundButton會被染成255,192,128(橘色)
        int counts = 0;//號碼選了幾個
        int Buttonnum = 0;//用來算mytargetroundButton裡重覆的button的次數 重覆1次正常
        public List<RoundButton> mytargetroundButton = new List<RoundButton>();
        RoundButton roundButton = new RoundButton();


        private void ShowButton(object sender, EventArgs e)
        {
            roundButton = (RoundButton)sender;
            roundButton.BackColor = Color.FromArgb(255, 192, 128);
            mytargetroundButton.Add(roundButton);
            counts++;
           
            for (int i = 0; i < mytargetroundButton.Count; i++)
            {
                if (roundButton.Name == mytargetroundButton[i].Name)
                {
                    Buttonnum++;
                    //Console.WriteLine("Buttonnum"+Buttonnum);
                    
                }
                if (Buttonnum == 2)
                {
                    //Console.WriteLine("刪了新增的和舊的");
                    mytargetroundButton.Remove(roundButton);
                    mytargetroundButton.Remove(roundButton);
                    counts -=2;//刪掉新的和舊的 所以是-2
                    roundButton.BackColor = Color.FromArgb(224, 224, 224);
                    //Console.WriteLine("counts:"+counts);
                }                
                
            }
            Buttonnum = 0;//初始化

            if (mytargetroundButton.Count > 10)
            {                
                mytargetroundButton.RemoveAt(10);
                roundButton.BackColor = Color.FromArgb(224, 224, 224);
                MessageBox.Show("不能選超過10顆");
            }

            //用來檢查mytargetroundButton裡的東西數字正不正常
            /*
            for (int i = 0; i < mytargetroundButton.Count; i++)
            {
                Console.WriteLine(mytargetroundButton[i] + "    i" + i);
            }
            */
        }
        



        public List<int> autoTarget(int n, int m)
        { //隨機創一個1~n中 m個不重覆數字 m不能大於n

            TargetNum.Clear();//如果重覆按要刪掉這個list裡的東西
            n = n + 1;
            Random myRnd = new Random();
            //List<string> TargetNum = new List<string>();
            int Target1 = myRnd.Next(1, n);
            TargetNum.Add(Target1);

            for (int i = 1; i <= (m-1); i++)
            {
                int Target = myRnd.Next(1, n);

                for (int j = 0; j < TargetNum.Count; j++)
                {
                    if (Target == TargetNum[j])
                    {
                        i--;
                        break;
                    }
                    else
                    {
                        if (j == (TargetNum.Count - 1))
                        {
                            TargetNum.Add(Target);
                            break;
                        }
                    }


                }
            }

            return TargetNum;

        }
    }
}
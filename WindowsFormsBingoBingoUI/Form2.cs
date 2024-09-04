using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsBingoBingoUI
{
    public partial class Form2 : Form    
    {
        Form1 _form1 = new Form1();

        public Form2()
        {
            InitializeComponent();
        }       


        private void Form2_Load(object sender, EventArgs e)
        {
            GlobalVar.GlobalListCbox = this.lboxCNum;
            GlobalVar.GlobalListYbox = this.lboxYNum;
            GlobalVar.GlobalListCbox.Items.Clear();
            GlobalVar.GlobalListYbox.Items.Clear();
            Form3 form3 = new Form3();
            form3.AddlboxCNum();
            form3.AddlboxYNum();
            AddWin();

            MessageBox.Show("我沒有做跳出這視窗就會重置所有號碼的功能,所以可以關掉後去選會中的號碼");
        }

        void AddWin()
        {
            #region 加開獎號碼和SuperNum部分
            int DrawSuperNumListIdx = -1;
            if (GlobalVar.ArrayListGlobalTargetNum.Count != 0)
            {
                for (int i = 0; i < GlobalVar.ArrayListGlobalTargetNum.Count; i += 1)
                {
                    string concatCTarget = String.Join(",", (List<string>)GlobalVar.ArrayListGlobalTargetNum[i]);
                    lblLotteryDraw.Text = (concatCTarget);
                    DrawSuperNumListIdx++;
                }
            }
            List<string> liststring = new List<string>();
            liststring = (List<string>)GlobalVar.ArrayListGlobalTargetNum[DrawSuperNumListIdx];
            lblSuperNum.Text = liststring[19];
            GlobalVar.DrawSuperNum = lblSuperNum.Text;
            DrawSuperNumListIdx = 0;
            #endregion


            int SmallCounts = 0;
            int BigCounts = 0;
            int EvenCounts = 0;
            int OddCounts = 0;

            #region 比大小
            if (GlobalVar.ArrayListGlobalTargetNum.Count != 0)
            {
                for (int i = 0; i < GlobalVar.ArrayListGlobalTargetNum.Count; i += 1)
                {
                    SmallCounts = 0;
                    BigCounts = 0;
                    foreach (string s in (List<string>)GlobalVar.ArrayListGlobalTargetNum[i])
                    {
                        if (Convert.ToInt32(s) <= 40)
                        {
                            SmallCounts += 1;
                            
                        }
                        else
                        {
                            BigCounts += 1;
                        }
                    }
                    
                }
            }

            if (SmallCounts >= 13)
            {
                lblBigSmall.Text = "小";
                GlobalVar.DrawBigSmall = "小";
            }
            else if (BigCounts >= 13)
            {
                lblBigSmall.Text = "大";
                GlobalVar.DrawBigSmall = "大";
            }
            else
            {
                lblBigSmall.Text = "中間值";
                GlobalVar.DrawBigSmall = "中間值";
            }
            #endregion

            #region 奇偶數
            if (GlobalVar.ArrayListGlobalTargetNum.Count != 0)
            {
                for (int i = 0; i < GlobalVar.ArrayListGlobalTargetNum.Count; i += 1)
                {
                    EvenCounts = 0;
                    OddCounts = 0;
                    foreach (string s in (List<string>)GlobalVar.ArrayListGlobalTargetNum[i])
                    {
                        if (Convert.ToInt32(s) % 2 == 0)
                        {
                            EvenCounts += 1;

                        }
                        else
                        {
                            OddCounts += 1;
                        }
                    }

                }
            }

            if (EvenCounts >= 13)
            {
                lblOddEven.Text = "雙";
                GlobalVar.DrawOddEven = "雙";
            }
            else if (OddCounts >= 13)
            {
                lblOddEven.Text = "單";
                GlobalVar.DrawOddEven = "單";
            }
            else
            {
                lblOddEven.Text = "中間值";
                GlobalVar.DrawOddEven = "中間值";
            }
            #endregion


        }


        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            //GPT教的 當Form2關閉時可以執行這個東西
            _form1.btnWin.Enabled = true;
        }

        private async void btnWin_Click(object sender, EventArgs e)
        {
            CheckYNum();
            CheckCNum();
            lbl_Money.Text = "請等待5秒...";
            await Task.Delay(5000);
            lbl_Money.Text = ($"{CWinMoney + YWinMoney}元");
        }






        int FinalMoney = 0;
        int CWinMoney = 0;//電腦下注得到的錢
        int YWinMoney = 0;//自選下注得到的錢

        #region 對獎看中幾個      
        public void CheckCNum()
        {
            if (GlobalVar.ArrayListGlobalCTargetNum.Count != 0 || GlobalVar.ALG_COddEven.Count != 0 || GlobalVar.ALG_CBigSmall.Count != 0 || GlobalVar.ALG_CSuperNum.Count != 0)
            {
                List<int> Counts = new List<int>();
                Counts.Add(GlobalVar.ArrayListGlobalCTargetNum.Count);
                Counts.Add(GlobalVar.ALG_COddEven.Count);
                Counts.Add(GlobalVar.ALG_CBigSmall.Count);
                Counts.Add(GlobalVar.ALG_CSuperNum.Count);
                int Max = Counts.Max();
                List<string> ALG_AllYum = new List<string>();
                List<string> ALG_Temp = new List<string>();
                int WinBall = 0;
                int WinBigSmall = 0;
                int WinOddEven = 0;
                int WinSuperNum = 0;
                CWinMoney = 0;
                for (int i = 0; i < Max; i++)
                {
                    WinBall = 0;
                    if (GlobalVar.ArrayListGlobalCTargetNum.Count > i)
                    {
                        ALG_Temp = ((List<string>)GlobalVar.ArrayListGlobalCTargetNum[i]);
                        List<string> StringList_Temp = new List<string>((List<string>)GlobalVar.ArrayListGlobalTargetNum[0]);//這是拿來存開獎序列的號碼
                        
                        foreach (string s in (List<string>)ALG_Temp)
                        {
                            if (StringList_Temp.Contains(s))
                            {
                                WinBall++;
                            }
                        }
                    }

                    WinOddEven = 0;
                    string COddEven = "";
                    if (GlobalVar.ALG_COddEven.Count > i)
                    {
                        COddEven = (string)GlobalVar.ALG_COddEven[i];

                        if (COddEven == (string)GlobalVar.DrawOddEven)
                        {
                            WinOddEven++;
                        }
;
                    }

                    WinBigSmall = 0;
                    string CBigSmall = "";
                    if (GlobalVar.ALG_CBigSmall.Count > i)
                    {
                        CBigSmall = (string)GlobalVar.ALG_CBigSmall[i];
                        if (CBigSmall == (string)GlobalVar.DrawBigSmall)
                        {
                            WinBigSmall++;
                        }
                    }

                    WinSuperNum = 0;
                    string CSuperNum = "";
                    if (GlobalVar.ALG_CSuperNum.Count > i)
                    {
                        CSuperNum = (string)GlobalVar.ALG_CSuperNum[i];
                        if (CSuperNum == (string)GlobalVar.DrawSuperNum)
                        {
                            WinSuperNum++;
                        }
                    }


                    if (WinBall == 0 && WinSuperNum == 0 && WinBigSmall == 0 && WinOddEven == 0)
                    {

                    }
                    else
                    {
                        lboxWin.Items.Add($"電腦選號第{i + 1}組:{ALG_Temp.Count}中{WinBall}, 超級獎號:{WinSuperNum}, 比大小:{WinBigSmall}, 猜單雙:{WinOddEven},");
                    }


                    #region 把下注多少顆中多少丟進方法中計算獎金出來
                    if (ALG_Temp.Count == 10)
                    {
                        CWinMoney += Money_Ten(WinBall);
                    }
                    else if (ALG_Temp.Count == 9)
                    {
                        CWinMoney += Money_Nine(WinBall);
                    }
                    else if (ALG_Temp.Count == 8)
                    {
                        CWinMoney += Money_Eight(WinBall);
                    }
                    else if (ALG_Temp.Count == 7)
                    {
                        CWinMoney += Money_Seven(WinBall);
                    }
                    else if (ALG_Temp.Count == 6)
                    {
                        CWinMoney += Money_Six(WinBall);
                    }
                    else if (ALG_Temp.Count == 5)
                    {
                        CWinMoney += Money_Five(WinBall);
                    }
                    else if (ALG_Temp.Count == 4)
                    {
                        CWinMoney += Money_Four(WinBall);
                    }
                    else if (ALG_Temp.Count == 3)
                    {
                        CWinMoney += Money_Three(WinBall);
                    }
                    else if (ALG_Temp.Count == 2)
                    {
                        CWinMoney += Money_Two(WinBall);
                    }
                    else if (ALG_Temp.Count == 1)
                    {
                        CWinMoney += Money_One(WinBall);
                    }
                    #endregion
                    #region 其他的中獎換錢
                    CWinMoney += OddEvenMoney(WinOddEven);
                    CWinMoney += BigSmallMoney(WinBigSmall);
                    CWinMoney += SuperNumMoney(WinSuperNum);
                    #endregion

                }

                if (WinBall == 0 && WinSuperNum == 0 && WinBigSmall == 0 && WinOddEven == 0)
                {
                    lboxWin.Items.Add("電腦選號都沒有中");
                }

            }
        }


        public void CheckYNum()  //原本名字AddAllYNum
        {

            if (GlobalVar.ArrayListGlobalYTargetNum.Count != 0 || GlobalVar.ALG_YOddEven.Count != 0 || GlobalVar.ALG_YBigSmall.Count != 0 || GlobalVar.ALG_YSuperNum.Count != 0)
            {
                List<int> Counts = new List<int>();
                Counts.Add(GlobalVar.ArrayListGlobalYTargetNum.Count);
                Counts.Add(GlobalVar.ALG_YOddEven.Count);
                Counts.Add(GlobalVar.ALG_YBigSmall.Count);
                Counts.Add(GlobalVar.ALG_YSuperNum.Count);
                int Max = Counts.Max();
                List<string> ALG_AllYum = new List<string>();
                List<string> ALG_Temp = new List<string>();
                int WinBall = 0;
                int WinBigSmall = 0;
                int WinOddEven = 0;
                int WinSuperNum = 0;
                YWinMoney = 0;

                for (int i = 0; i < Max; i++)
                {
                    WinBall = 0;
                    if (GlobalVar.ArrayListGlobalYTargetNum.Count > i)
                    {
                        ALG_Temp = ((List<string>)GlobalVar.ArrayListGlobalYTargetNum[i]);
                        List<string> StringList_Temp = new List<string>((List<string>)GlobalVar.ArrayListGlobalTargetNum[0]);//這是拿來存開獎序列的號碼
                        
                        foreach (string s in (List<string>)ALG_Temp)
                        {
                            if (StringList_Temp.Contains(s))
                            {
                                WinBall++;
                            }
                        }                          
                        
                    }                   


                    WinOddEven = 0;
                    string YOddEven = "";
                    if (GlobalVar.ALG_YOddEven.Count > i)
                    {
                        YOddEven = (string)GlobalVar.ALG_YOddEven[i];

                        if (YOddEven == (string)GlobalVar.DrawOddEven)
                        {
                            WinOddEven++;
                        }
;
                    }



                    WinBigSmall = 0;
                    string YBigSmall = "";
                    if (GlobalVar.ALG_YBigSmall.Count > i)
                    {
                        YBigSmall = (string)GlobalVar.ALG_YBigSmall[i];
                        if (YBigSmall == (string)GlobalVar.DrawBigSmall)
                        {
                            WinBigSmall++;
                        }
                    }


                    WinSuperNum = 0;
                    string YSuperNum = "";
                    if (GlobalVar.ALG_YSuperNum.Count > i)
                    {
                        YSuperNum = (string)GlobalVar.ALG_YSuperNum[i];
                        if (YSuperNum == (string)GlobalVar.DrawSuperNum)
                        {
                            WinSuperNum++;
                        }
                    }


                    if (WinBall == 0 && WinSuperNum == 0 && WinBigSmall == 0 && WinOddEven == 0)
                    {
                        
                    }
                    else
                    {
                        lboxWin.Items.Add($"自選號碼第{i + 1}組:{ALG_Temp.Count}中{WinBall}, 超級獎號:{WinSuperNum}, 比大小:{WinBigSmall}, 猜單雙:{WinOddEven},");
                    }



                    #region 把下注多少顆中多少丟進方法中計算獎金出來,建議不要打開,很長
                    if (ALG_Temp.Count == 10)
                    {
                        YWinMoney += Money_Ten(WinBall);
                    }
                    else if (ALG_Temp.Count == 9)
                    {
                        YWinMoney += Money_Nine(WinBall);
                    }
                    else if (ALG_Temp.Count == 8)
                    {
                        YWinMoney += Money_Eight(WinBall);
                    }
                    else if (ALG_Temp.Count == 7)
                    {
                        YWinMoney += Money_Seven(WinBall);
                    }
                    else if (ALG_Temp.Count == 6)
                    {
                        YWinMoney += Money_Six(WinBall);
                    }
                    else if (ALG_Temp.Count == 5)
                    {
                        YWinMoney += Money_Five(WinBall);
                    }
                    else if (ALG_Temp.Count == 4)
                    {
                        YWinMoney += Money_Four(WinBall);
                    }
                    else if (ALG_Temp.Count == 3)
                    {
                        YWinMoney += Money_Three(WinBall);
                    }
                    else if (ALG_Temp.Count == 2)
                    {
                        YWinMoney += Money_Two(WinBall);
                    }
                    else if (ALG_Temp.Count == 1)
                    {
                        YWinMoney += Money_One(WinBall);
                    }
                    #endregion

                    #region 其他的中獎換錢
                    YWinMoney += OddEvenMoney(WinOddEven);
                    YWinMoney += BigSmallMoney(WinBigSmall);
                    YWinMoney += SuperNumMoney(WinSuperNum);
                    #endregion


                }

                if (WinBall == 0 && WinSuperNum == 0 && WinBigSmall == 0 && WinOddEven == 0)
                {
                    lboxWin.Items.Add("自選號碼都沒有中");
                }

                
            }
        }
        #endregion


        #region 獎金換算

        #region 10~1星的獎金規則,不要打開,很長
        //根據台彩規則照抄的 應該沒抄錯
        private int Money_Ten(int ball)
        {
            int money = 0;

            switch (ball)
            {
                case 0:
                    money = 25;
                    break;
                case 1:
                    money = 0;
                    break;
                case 2:
                    money = 0;
                    break;
                case 3:
                    money = 0;
                    break;
                case 4:
                    money = 0;
                    break;
                case 5:
                    money = 25;
                    break;
                case 6:
                    money = 250;
                    break;
                case 7:
                    money = 2500;
                    break;
                case 8:
                    money = 25000;
                    break;
                case 9:
                    money = 250000;
                    break;
                case 10:
                    money = 5000000;
                    break;
            }
            return money;
        }

        private int Money_Nine(int ball)
        {
            int money = 0;

            switch (ball)
            {
                case 0:
                    money = 25;
                    break;
                case 1:
                    money = 0;
                    break;
                case 2:
                    money = 0;
                    break;
                case 3:
                    money = 0;
                    break;
                case 4:
                    money = 25;
                    break;
                case 5:
                    money = 100;
                    break;
                case 6:
                    money = 500;
                    break;
                case 7:
                    money = 3000;
                    break;
                case 8:
                    money = 100000;
                    break;
                case 9:
                    money = 1000000;
                    break;
                case 10:
                    MessageBox.Show("獎金有問題");
                    break;
            }
            return money;
        }

        private int Money_Eight(int ball)
        {
            int money = 0;

            switch (ball)
            {
                case 0:
                    money = 25;
                    break;
                case 1:
                    money = 0;
                    break;
                case 2:
                    money = 0;
                    break;
                case 3:
                    money = 0;
                    break;
                case 4:
                    money = 25;
                    break;
                case 5:
                    money = 200;
                    break;
                case 6:
                    money = 1000;
                    break;
                case 7:
                    money = 20000;
                    break;
                case 8:
                    money = 500000;
                    break;
                case 9:
                    MessageBox.Show("獎金有問題");
                    break;
                case 10:
                    MessageBox.Show("獎金有問題");
                    break;
            }
            return money;
        }

        private int Money_Seven(int ball)
        {
            int money = 0;

            switch (ball)
            {
                case 0:
                    money = 0;
                    break;
                case 1:
                    money = 0;
                    break;
                case 2:
                    money = 0;
                    break;
                case 3:
                    money = 25;
                    break;
                case 4:
                    money = 50;
                    break;
                case 5:
                    money = 300;
                    break;
                case 6:
                    money = 3000;
                    break;
                case 7:
                    money = 80000;
                    break;
                case 8:
                    MessageBox.Show("獎金有問題");
                    break;
                case 9:
                    MessageBox.Show("獎金有問題");
                    break;
                case 10:
                    MessageBox.Show("獎金有問題");
                    break;
            }
            return money;
        }

        private int Money_Six(int ball)
        {
            int money = 0;

            switch (ball)
            {
                case 0:
                    money = 0;
                    break;
                case 1:
                    money = 0;
                    break;
                case 2:
                    money = 0;
                    break;
                case 3:
                    money = 25;
                    break;
                case 4:
                    money = 200;
                    break;
                case 5:
                    money = 1000;
                    break;
                case 6:
                    money = 25000;
                    break;
                case 7:
                    MessageBox.Show("獎金有問題");
                    break;
                case 8:
                    MessageBox.Show("獎金有問題");
                    break;
                case 9:
                    MessageBox.Show("獎金有問題");
                    break;
                case 10:
                    MessageBox.Show("獎金有問題");
                    break;
            }
            return money;
        }

        private int Money_Five(int ball)
        {
            int money = 0;

            switch (ball)
            {
                case 0:
                    money = 0;
                    break;
                case 1:
                    money = 0;
                    break;
                case 2:
                    money = 0;
                    break;
                case 3:
                    money = 50;
                    break;
                case 4:
                    money = 500;
                    break;
                case 5:
                    money = 7500;
                    break;
                case 6:
                    MessageBox.Show("獎金有問題");
                    break;
                case 7:
                    MessageBox.Show("獎金有問題");
                    break;
                case 8:
                    MessageBox.Show("獎金有問題");
                    break;
                case 9:
                    MessageBox.Show("獎金有問題");
                    break;
                case 10:
                    MessageBox.Show("獎金有問題");
                    break;
            }
            return money;
        }


        private int Money_Four(int ball)
        {
            int money = 0;

            switch (ball)
            {
                case 0:
                    money = 0;
                    break;
                case 1:
                    money = 0;
                    break;
                case 2:
                    money = 25;
                    break;
                case 3:
                    money = 100;
                    break;
                case 4:
                    money = 1000;
                    break;
                case 5:
                    MessageBox.Show("獎金有問題");
                    break;
                case 6:
                    MessageBox.Show("獎金有問題");
                    break;
                case 7:
                    MessageBox.Show("獎金有問題");
                    break;
                case 8:
                    MessageBox.Show("獎金有問題");
                    break;
                case 9:
                    MessageBox.Show("獎金有問題");
                    break;
                case 10:
                    MessageBox.Show("獎金有問題");
                    break;
            }
            return money;
        }

        private int Money_Three(int ball)
        {
            int money = 0;

            switch (ball)
            {
                case 0:
                    money = 0;
                    break;
                case 1:
                    money = 0;
                    break;
                case 2:
                    money = 50;
                    break;
                case 3:
                    money = 500;
                    break;
                case 4:
                    MessageBox.Show("獎金有問題");
                    break;
                case 5:
                    MessageBox.Show("獎金有問題");
                    break;
                case 6:
                    MessageBox.Show("獎金有問題");
                    break;
                case 7:
                    MessageBox.Show("獎金有問題");
                    break;
                case 8:
                    MessageBox.Show("獎金有問題");
                    break;
                case 9:
                    MessageBox.Show("獎金有問題");
                    break;
                case 10:
                    MessageBox.Show("獎金有問題");
                    break;
            }
            return money;
        }

        private int Money_Two(int ball)
        {
            int money = 0;

            switch (ball)
            {
                case 0:
                    money = 0;
                    break;
                case 1:
                    money = 25;
                    break;
                case 2:
                    money = 75;
                    break;
                case 3:
                    MessageBox.Show("獎金有問題");
                    break;
                case 4:
                    MessageBox.Show("獎金有問題");
                    break;
                case 5:
                    MessageBox.Show("獎金有問題");
                    break;
                case 6:
                    MessageBox.Show("獎金有問題");
                    break;
                case 7:
                    MessageBox.Show("獎金有問題");
                    break;
                case 8:
                    MessageBox.Show("獎金有問題");
                    break;
                case 9:
                    MessageBox.Show("獎金有問題");
                    break;
                case 10:
                    MessageBox.Show("獎金有問題");
                    break;
            }
            return money;
        }


        private int Money_One(int ball)
        {
            int money = 0;

            switch (ball)
            {
                case 0:
                    money = 0;
                    break;
                case 1:
                    money = 50;
                    break;
                case 2:
                    MessageBox.Show("獎金有問題");
                    break;
                case 3:
                    MessageBox.Show("獎金有問題");
                    break;
                case 4:
                    MessageBox.Show("獎金有問題");
                    break;
                case 5:
                    MessageBox.Show("獎金有問題");
                    break;
                case 6:
                    MessageBox.Show("獎金有問題");
                    break;
                case 7:
                    MessageBox.Show("獎金有問題");
                    break;
                case 8:
                    MessageBox.Show("獎金有問題");
                    break;
                case 9:
                    MessageBox.Show("獎金有問題");
                    break;
                case 10:
                    MessageBox.Show("獎金有問題");
                    break;
            }
            return money;
        }
        #endregion

        #region 其他獎金規則
        private int SuperNumMoney(int WinSuperNum)
        {
            int money = 0;

            switch (WinSuperNum)
            {
                case 0:
                    money = 0;
                    break;
                case 1:
                    money = 1200;
                    break;
            }
            return money;
        }


        private int BigSmallMoney(int WinBigSmallNum)
        {
            int money = 0;
            switch (WinBigSmallNum)
            {
                case 0:
                    money = 0;
                    break;
                case 1:
                    money = 150;
                    break;  
            }
            return money;
        }

        private int OddEvenMoney(int WinOddEvenNum)
        {
            int money = 0;
            switch (WinOddEvenNum)
            {
                case 0:
                    money = 0;
                    break;
                case 1:
                    money = 150;
                    break;
            }
            return money;
        }
        #endregion

        #endregion






    }
}

/*
應該算是完成了啦 只是我沒有加入算你下注這張要多少錢的功能就是了
*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WindowsFormsBingoBingoUI
{
    public partial class Form1 : Form
    {
        public static List<Panel> panels = new List<Panel>();
        List<Panel> CollapsePanels = new List<Panel>();
        Menu mymenu = new Menu();
        SelectNum myselect = new SelectNum();
        List<RoundButton> Cbuttons = new List<RoundButton>(); //在panel中電腦號碼
        List<RoundButton> Ybuttons = new List<RoundButton>(); //在panel中你的號碼
        List<RoundButton> Tbuttons = new List<RoundButton>(); //在panel中開獎號碼
        List<string> WantNum = new List<string>();//生成cbox號碼用的
        

        public Form1()
        {
            InitializeComponent();
            Drawtimer.Interval = 1000; // 每秒触发一次
            Drawtimer.Tick += Time;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            panel_lottery_draw.Visible = false;
            panel_computer.Visible = false;
            panel_yourself.Visible = false;
            panel_ChoseNum.Visible = false;
            panels.Add(panel_lottery_draw);
            panels.Add(panel_computer);
            panels.Add(panel_yourself);
            panels.Add(panel_ChoseNum);
            panels.Add(panel_welcome);
            mymenu.Menupanels(panels);


            //cbox內容生成
            for (int i = 1; i <= 10; i++)
            {
                WantNum.Add(i.ToString());
            }
            foreach (string s in WantNum)
            {
                cboxWantNum.Items.Add(s);
            }
            cboxWantNum.SelectedIndex = 0;

            txtSuperNum.Text = "1";

        }

        #region Menu部分


        //開獎頁面
        private void btn_lottery_draw_Click(object sender, EventArgs e)
        {
            mymenu.BigMenu(panel_lottery_draw);
        }


        //選號摺疊選單
        private void btn_ChoseNum_Click(object sender, EventArgs e)
        {
            mymenu.ShowCollapseMenu(btn_ChoseNum,panel_ChoseNum);
        }        


        //摺疊選單中電腦選號選單
        private void btn_computer_Click(object sender, EventArgs e)
        {
            mymenu.ShowINCollapseMenu(panel_computer);//有IN喔 跟上面不同 別看錯
            //await Task.WhenAll();
        }

        //摺疊選單中自己選號選單
        private void btn_yourself_Click(object sender, EventArgs e)
        {
            mymenu.ShowINCollapseMenu(panel_yourself);//有IN喔 跟上面不同 別看錯
            myselect.Target(Ybuttons, panel_yourself);//Target方法:在panel_yourself取得的RoundButtonList會存到Ybuttons中
            myselect.TargetClick(Ybuttons);//偵測Ybutton有沒有按下

        }

        //號碼清單
        private void btnAllBallList_Click(object sender, EventArgs e)
        {
            GlobalVar.myform3.Show();
            //Form3 form3 = new Form3();
            //form3.Show();
            GlobalVar.btnAllBallList = btnAllBallList;
            GlobalVar.btnAllBallList.Enabled = false;           

        }

        //對獎頁面開啟按鈕
        private void btnWin_Click(object sender, EventArgs e)
        {
            if (GlobalVar.ArrayListGlobalTargetNum.Count > 0)
            {
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("沒有產生開獎號碼沒辦法對獎");
            }           

        }

        /*
        public void LabelUpdate()
        {
            btnAllBallList.Enabled = true;
        }
        */


        #endregion

        #region 電腦選號
        List<int> autoTarget = new List<int>(); //這個List拿來存autoTarget產生的20顆不重覆亂數數字
               
        private void btn_C_NUM_Click(object sender, EventArgs e) //按下去電腦選號
        {   
            btn_ChoseNum.Enabled = false;
            int WantNum = cboxWantNum.SelectedIndex + 1;

            //初始化
            for (int i = 0; i < (autoTarget.Count); i++)
            {//Cbuttons中的button儲存是反的 所以要倒過來設定                
                Cbuttons[80 - autoTarget[i]].BackColor = Color.FromArgb(224, 224, 224);
            }
            autoTarget.Clear();
            //初始化

            //使用myselect.autoTarget產生號碼
            autoTarget = new List<int>( myselect.autoTarget(80, WantNum)); //要用new不然會被覆寫掉
            myselect.Target(Cbuttons, panel_computer);//Target用法:在panel_computer取得的RoundButtonList會存到Cbuttons中
            for (int i = 0; i < (autoTarget.Count); i++)
            {//Cbuttons中的button儲存是反的 所以要倒過來設定                
                Cbuttons[80-autoTarget[i]].BackColor = Color.FromArgb(255, 192, 128);
                //GlobalVar.ListGlobalCargetNum.Add(Cbuttons[80 - autoTarget[i]]);
            }
            btn_ChoseNum.Enabled=true;


        }


        private void btnXCNum_Click(object sender, EventArgs e) //按下去取消電腦選號
        {
            for (int i = 0; i < (autoTarget.Count); i++)
            {//Cbuttons中的button儲存是反的 所以要倒過來設定                
                Cbuttons[80 - autoTarget[i]].BackColor = Color.FromArgb(224, 224, 224);
                //GlobalVar.ListGlobalCargetNum.Add(Cbuttons[80 - autoTarget[i]]);
            }
            autoTarget.Clear();
        }



        //List<int> autoSuperTarget = new List<int>();
        string autoSuperTarget = "";
        private void btnSuperNum_Click(object sender, EventArgs e)
        {
            lblSuperNum.Text = "?";
            //初始化
            autoSuperTarget = "";
            //rbtnSuperNum.BackColor = Color.FromArgb(244, 244, 244);
            //初始化
            List<int> templist = new List<int>(myselect.autoTarget(80, 1));
            autoSuperTarget = templist[0].ToString();
            lblSuperNum.Text = (string)autoSuperTarget;
            lblSuperNum.BackColor = Color.FromArgb(255, 192, 128);

        }

        private void btnNoSuperSum_Click(object sender, EventArgs e)
        {
            lblSuperNum.Text = "??";
            autoSuperTarget = "";
            lblSuperNum.BackColor = Color.FromArgb(224, 224, 224);
        }

        string COddEvenlist = "";
        private void btnOddEven_Click(object sender, EventArgs e)
        {
            COddEvenlist = "";
            Random myrand = new Random();
            List<String> OddEvenlist = new List<String>();
            OddEvenlist.Add("單");
            OddEvenlist.Add("雙");
            int rand = myrand.Next(0,2);            
            lblOddEven.Text = OddEvenlist[rand];
            lblOddEven.BackColor = Color.FromArgb(255, 192, 128);
            COddEvenlist = (OddEvenlist[rand]);

        }

        private void btnNoOddEven_Click(object sender, EventArgs e)
        {
            lblOddEven.BackColor = Color.FromArgb(224, 224, 224);
            lblOddEven.Text = "??";
            COddEvenlist = "";
        }

        string CBigSmalllist = "";
        private void btnBigSmall_Click(object sender, EventArgs e)
        {
            CBigSmalllist = "";
            Random myrand = new Random();
            List<String> btnBigSmalllist = new List<String>();
            btnBigSmalllist.Add("大");
            btnBigSmalllist.Add("小");
            int rand = myrand.Next(0, 2);
            lblBigSmall.Text = btnBigSmalllist[rand];
            lblBigSmall.BackColor = Color.FromArgb(255, 192, 128);
            CBigSmalllist = (btnBigSmalllist[rand]);
        }

        private void btnNoBigSmall_Click(object sender, EventArgs e)
        {
            lblBigSmall.BackColor = Color.FromArgb(224, 224, 224);
            lblBigSmall.Text = "??";
            CBigSmalllist = "";
        }
        #endregion

        #region YOddEven
        string YOddEvenlist = "";
        private void btnOdd_Click(object sender, EventArgs e)
        {
            lblYOddEven.Text = "單";
            lblYOddEven.BackColor = Color.FromArgb(255, 192, 128);
            YOddEvenlist = "單";
        }

        private void btnEven_Click(object sender, EventArgs e)
        {
            lblYOddEven.Text = "雙";
            lblYOddEven.BackColor = Color.FromArgb(255, 192, 128);
            YOddEvenlist = "雙";
        }

        private void btnXOddEven_Click(object sender, EventArgs e)
        {
            lblYOddEven.Text = "無";
            lblYOddEven.BackColor = Color.FromArgb(224, 224, 224);
            YOddEvenlist = "";
        }

        #endregion


        #region YBigSmall
        string YBigSmalllist = "";

        private void btnBig_Click(object sender, EventArgs e)
        {
            lblYBigSmall.Text = "大";
            lblYBigSmall.BackColor = Color.FromArgb(255, 192, 128);
            YBigSmalllist = "大";
        }

        private void btnSmall_Click(object sender, EventArgs e)
        {
            lblYBigSmall.Text = "小";
            lblYBigSmall.BackColor = Color.FromArgb(255, 192, 128);
            YBigSmalllist = "小";
        }

        private void btnXBigSmall_Click(object sender, EventArgs e)
        {
            lblYBigSmall.Text = "無";
            lblYBigSmall.BackColor = Color.FromArgb(224, 224, 224);
            YBigSmalllist = "";
        }
        #endregion


        #region YSuperNum

        string YSuperTarget = "";

        private void txtSuperNum_MouseClick(object sender, MouseEventArgs e)
        {
            txtSuperNum.Text = "";
        }
        

        int YSuperNum = 0;
        private void txtSuperNum_TextChanged(object sender, EventArgs e)
        {
            
            if (txtSuperNum.Text != "" && txtSuperNum.Text != "??")
            {
                bool isPass = Int32.TryParse(txtSuperNum.Text, out YSuperNum);
                if (isPass && (YSuperNum>0) && (YSuperNum <= 80))
                {
                    //輸入正確
                }
                else
                {
                    txtSuperNum.Text = "";
                    MessageBox.Show("請輸入1~80的整數");
                }
            
            }
            

        }

        private void btnONumEnter_Click(object sender, EventArgs e)
        {
            lblYSuperNum.Text = YSuperNum.ToString();
            YSuperTarget = txtSuperNum.Text;
            lblYSuperNum.BackColor = Color.FromArgb(255, 192, 128);
        }

        private void btnXSuperNum_Click(object sender, EventArgs e)
        {
            lblYSuperNum.Text = "??";
            YSuperTarget = "";
            lblYSuperNum.BackColor = Color.FromArgb(224, 224, 224);
        }

        #endregion



        List<int> DrawTarget = new List<int>();
        private void btnDraw_Click(object sender, EventArgs e)
        {
            //這裡要加入 如果我沒有選號是不能按開獎的功能

            btnDraw.Enabled = false;

            //初始化
            for (int i = 0; i < (DrawTarget.Count); i++)
            {//Cbuttons中的button儲存是反的 所以要倒過來設定                
                Tbuttons[80 - DrawTarget[i]].BackColor = Color.FromArgb(224, 224, 224);
            }
            DrawTarget.Clear();
            //初始化

            //使用myselect.autoTarget產生號碼
            DrawTarget = myselect.autoTarget(80, 20);
            myselect.Target(Tbuttons, panel_lottery_draw);//Target用法:在panel_computer取得的RoundButtonList會存到Cbuttons中

            List<string> vs = new List<string>();            
            for (int i = 0; i < (DrawTarget.Count); i++)
            {//Cbuttons中的button儲存是反的 所以要倒過來設定                
                Tbuttons[80 - DrawTarget[i]].BackColor = Color.FromArgb(255, 192, 128);                
                vs.Add(Tbuttons[80 - DrawTarget[i]].Text);
            }
            List<string> vs1 = new List<string>(vs);//要創 不然vs初始化就會被刪了
            GlobalVar.ArrayListGlobalTargetNum.Add(vs1);
            Tbuttons[80 - DrawTarget[19]].BackColor = Color.FromArgb(255, 133, 133); 

            btnDraw.Enabled = true;

            vs.Clear();
        }


        private void btnYJoin_Click(object sender, EventArgs e)
        {
            List<string> vs = new List<string>();
            if (myselect.mytargetroundButton.Count > 0 || YOddEvenlist != "" || YBigSmalllist != "" || YSuperTarget != "")
            {
                foreach (RoundButton roundButton in myselect.mytargetroundButton)
                {
                    vs.Add(roundButton.Text);                    
                }
                MessageBox.Show("已加入選號清單");
            }
            else
            {
                MessageBox.Show("請選擇號碼,猜單雙,猜大小,猜超級獎項其一");
                return;
            }
            
            List<string> vs1 = new List<string>(vs); //要創一個新的vs1來複製一份vs 不然vs清掉加入的那個vs也會被清掉
            
            GlobalVar.ArrayListGlobalYTargetNum.Add(vs1);
            GlobalVar.ALG_YOddEven.Add(YOddEvenlist);
            GlobalVar.ALG_YBigSmall.Add(YBigSmalllist);
            GlobalVar.ALG_YSuperNum.Add(YSuperTarget);
            
            //if (YOddEvenlist != "")
            //{
                
            //}
            //if (YBigSmalllist != "")
            //{
                
            //}
            //if (YSuperTarget != "")
            //{
                
            //}

            vs.Clear();//初始化 不然List裡會越加越多


            #region 加進From3的部分
            GlobalVar.myform3.AddlboxYNum();
            //Form3 form3 = new Form3();
            //form3.AddlboxYNum();
            #endregion

        }

        private void btnXallYNum_Click(object sender, EventArgs e)
        {
            foreach (RoundButton roundButton in myselect.mytargetroundButton)
            {
                roundButton.BackColor = Color.FromArgb(224, 224, 224);
            }

            myselect.mytargetroundButton.Clear();
        }


        private void buttonCJoin_Click(object sender, EventArgs e)
        {            
            List<string> vs = new List<string>();
            if (autoTarget.Count > 0 || COddEvenlist != "" || CBigSmalllist !="" || autoSuperTarget != "")
            {
                for (int i = 0; i < (autoTarget.Count); i++)
                {//Cbuttons中的button儲存是反的 所以要倒過來設定                
                    Cbuttons[80 - autoTarget[i]].BackColor = Color.FromArgb(255, 192, 128);                    
                    vs.Add(Cbuttons[80 - autoTarget[i]].Text);                    
                }
                MessageBox.Show("已加入選號清單");
            }
            else
            {
                MessageBox.Show("請選擇號碼,猜單雙,猜大小,猜超級獎項其一");
                return;
            }

            //號碼的部分
            List<string> vs1 = new List<string>(vs); //要創一個新的vs1來複製一份vs 不然vs清掉加入的那個vs也會被清掉
            GlobalVar.ArrayListGlobalCTargetNum.Add(vs1);
            GlobalVar.ALG_COddEven.Add(COddEvenlist);
            GlobalVar.ALG_CBigSmall.Add(CBigSmalllist);
            GlobalVar.ALG_CSuperNum.Add(autoSuperTarget);
            
            //if (COddEvenlist != "")
            //{
                
            //}
            //if (CBigSmalllist != "")
            //{
                
            //}
            //if (autoSuperTarget != "")
            //{
                
            //}

            

            vs.Clear();//初始化 不然List裡會越加越多

            //Console.WriteLine(GlobalVar.ALG_COddEven.Count);
            #region 加進From3的部分
            GlobalVar.myform3.AddlboxCNum();
            //Form3 form3 = new Form3();
            //form3.AddlboxCNum();
            #endregion

        }







        Timer Drawtimer = new Timer();
        int Drawseconds = 10; //幾秒開一次獎
        int initialDrawseconds = 10; //跟上面要設定一樣


        private void btn_TimerStart_Click(object sender, EventArgs e)
        {
            if (!Drawtimer.Enabled)
            {
                progressBarDraw.Maximum = initialDrawseconds;
                progressBarDraw.Value = initialDrawseconds - Drawseconds;
                Drawtimer.Start();
            }
        }

        private void btn_TimerStop_Click(object sender, EventArgs e)
        {
            Drawtimer.Stop();
        }

        private void btn_TimerReset_Click(object sender, EventArgs e)
        {
            Drawtimer.Stop();
            Drawseconds = initialDrawseconds;
            progressBarDraw.Value = 0;
            TimeSpan time = TimeSpan.FromSeconds(Drawseconds);
            string formattedTime = time.ToString(@"mm\:ss");
            lbl_DrawTime.Text = (formattedTime);
        } 

        void Time(object sender, EventArgs e)
        {            
            Drawseconds-= 1;
            progressBarDraw.Value = initialDrawseconds - Drawseconds;
            TimeSpan time = TimeSpan.FromSeconds(Drawseconds);
            string formattedTime = time.ToString(@"mm\:ss");
            lbl_DrawTime.Text = ("開獎倒數: "+formattedTime);
            if (Drawseconds == 0)
            {               
                btnDraw_Click(sender, e);
                btn_TimerReset_Click(sender,e);
            }


        }

    }
}

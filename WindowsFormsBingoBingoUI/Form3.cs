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
    public partial class Form3 : Form
    {
        Form1 _form1 = new Form1();


        public Form3()
        {
            InitializeComponent();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            GlobalVar.GlobalListCbox = this.lboxCNum; //同步Form1和Form3的lbox更新
            GlobalVar.GlobalListYbox = this.lboxYNum;
            GlobalVar.GlobalListCbox.Items.Clear();
            GlobalVar.GlobalListYbox.Items.Clear();
            AddlboxCNum();
            AddlboxYNum();
        }

        #region 廢棄,原本是只有加入號碼的功能
        /*
        public void AddlboxCNum()
        {
            GlobalVar.GlobalListCbox.Items.Clear();
            if (GlobalVar.ArrayListGlobalCTargetNum.Count != 0)
            {
                for (int i = 0; i < GlobalVar.ArrayListGlobalCTargetNum.Count; i += 1)
                {
                    string concatCTarget = String.Join(",", (List<string>)GlobalVar.ArrayListGlobalCTargetNum[i]);
                    GlobalVar.GlobalListCbox.Items.Add("第"+(i+1)+"組"+":"+concatCTarget);
                    Console.WriteLine(concatCTarget);
                }
            }            
        }
        */
        /*
        public void AddlboxYNum()
        {
            GlobalVar.GlobalListYbox.Items.Clear(); //要清除 不然會保留上一次加入的 然後又加了一組一樣的
            if (GlobalVar.ArrayListGlobalYTargetNum.Count != 0)
            {
                for (int i = 0; i < GlobalVar.ArrayListGlobalYTargetNum.Count; i += 1)
                {
                    string concatYTarget = String.Join(",", (List<string>)GlobalVar.ArrayListGlobalYTargetNum[i]);
                    GlobalVar.GlobalListYbox.Items.Add(concatYTarget);
                }
            }
        }
        */
        #endregion

        #region 加選的組合進去
        public void AddlboxCNum()  //原本名字AddAllCNum
        {
            GlobalVar.GlobalListCbox.Items.Clear();
            if (GlobalVar.ArrayListGlobalCTargetNum.Count != 0 || GlobalVar.ALG_COddEven.Count != 0 || GlobalVar.ALG_CBigSmall.Count != 0 || GlobalVar.ALG_CSuperNum.Count != 0 )
            {
                List<int> Counts = new List<int>();
                Counts.Add(GlobalVar.ArrayListGlobalCTargetNum.Count);
                Counts.Add(GlobalVar.ALG_COddEven.Count);
                Counts.Add(GlobalVar.ALG_CBigSmall.Count);
                Counts.Add(GlobalVar.ALG_CSuperNum.Count);
                int Max = Counts.Max();
                ArrayList ALG_AllCum = new ArrayList();
                List<String> ALG_Temp = new List<String>();
                string concatCTarget = "";
                string concatCBigSmall = "";
                string concatCOddEven = "";
                string concatCSuperNum = "";

                for (int i = 0; i < Max; i++)
                {
                    if (GlobalVar.ArrayListGlobalCTargetNum.Count > i)
                    {
                        concatCTarget = "";
                        ALG_Temp = ((List<String>)GlobalVar.ArrayListGlobalCTargetNum[i]);
                        concatCTarget = "";
                        concatCTarget = String.Join(",", ALG_Temp);

                    }

                    if (GlobalVar.ALG_COddEven.Count > i)
                    {
                        concatCOddEven = "";
                        concatCOddEven = String.Join(",", (string)GlobalVar.ALG_COddEven[i]);
                    }
                    if (GlobalVar.ALG_CBigSmall.Count > i)
                    {
                        concatCBigSmall = "";
                        concatCBigSmall = String.Join(",", (string)GlobalVar.ALG_CBigSmall[i]);
                    }
                    if (GlobalVar.ALG_CSuperNum.Count > i)
                    {
                        concatCSuperNum = "";
                        concatCSuperNum = String.Join(",", (string)GlobalVar.ALG_CSuperNum[i]);
                    }


                    if (concatCTarget == ""  && concatCSuperNum == "" && concatCBigSmall == "" && concatCOddEven =="")
                    {

                    }
                    else
                    {
                        string concatALL = ("第" + (i + 1) + "組" + "號碼:" + concatCTarget + ", 超級獎號:" + concatCSuperNum + ", 比大小:" + concatCBigSmall + ", 猜單雙:" + concatCOddEven);
                        GlobalVar.GlobalListCbox.Items.Add(concatALL);
                        ALG_AllCum.Add(concatALL);//儲存跟lboxCNum一樣的資料
                    }
                    
                }
            }
        }


        public void AddlboxYNum()  //原本名字AddAllYNum
        {
            GlobalVar.GlobalListYbox.Items.Clear();
            if (GlobalVar.ArrayListGlobalYTargetNum.Count != 0 || GlobalVar.ALG_YOddEven.Count != 0 || GlobalVar.ALG_YBigSmall.Count != 0 || GlobalVar.ALG_YSuperNum.Count != 0)
            {
                List<int> Counts = new List<int>();
                Counts.Add(GlobalVar.ArrayListGlobalYTargetNum.Count);
                Counts.Add(GlobalVar.ALG_YOddEven.Count);
                Counts.Add(GlobalVar.ALG_YBigSmall.Count);
                Counts.Add(GlobalVar.ALG_YSuperNum.Count);
                int Max = Counts.Max();
                ArrayList ALG_AllYum = new ArrayList();
                List<string> ALG_Temp = new List<string>();
                string concatYTarget = "";
                string concatYBigSmall = "";
                string concatYOddEven = "";
                string concatYSuperNum = "";

                for (int i = 0; i < Max; i++)
                {
                    if (GlobalVar.ArrayListGlobalYTargetNum.Count > i)
                    {
                        concatYTarget = "";
                        ALG_Temp = (List<string>)GlobalVar.ArrayListGlobalYTargetNum[i];

                        for (int j = 0; j < ALG_Temp.Count; j += 1)
                        {
                            concatYTarget = "";
                            concatYTarget = String.Join(",", ALG_Temp);
                        }
                    }


                    if (GlobalVar.ALG_YOddEven.Count > i)
                    {
                        concatYOddEven = "";
                        concatYOddEven = String.Join(",", (string)GlobalVar.ALG_YOddEven[i]);
                    }
                    if (GlobalVar.ALG_YBigSmall.Count > i)
                    {
                        concatYBigSmall = "";
                        concatYBigSmall = String.Join(",", (string)GlobalVar.ALG_YBigSmall[i]);
                    }
                    if (GlobalVar.ALG_YSuperNum.Count > i)
                    {
                        concatYSuperNum = "";
                        concatYSuperNum = String.Join(",", (string)GlobalVar.ALG_YSuperNum[i]);
                    }

                    if (concatYTarget == "" && concatYSuperNum == "" && concatYBigSmall == "" && concatYOddEven == "" )
                    {
                        
                    }
                    else
                    {
                        string concatALL = ("第" + (i + 1) + "組" + "號碼:" + concatYTarget + ", 超級獎號:" + concatYSuperNum + ", 比大小:" + concatYBigSmall + ", 猜單雙:" + concatYOddEven);
                        GlobalVar.GlobalListYbox.Items.Add(concatALL);
                        ALG_AllYum.Add(concatALL);//儲存跟lboxCNum一樣的資料
                    }
                        
                    
                }

            }
        }






        #endregion




        







        private void lboxYNum_DoubleClick(object sender, EventArgs e)
        {
            int selectIdx = lboxYNum.SelectedIndex;

            if (selectIdx >= 0)
            {
                var result = MessageBox.Show("確定要移除嗎?", "確定要移除嗎????", buttons: MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    //GlobalVar.GlobalListYbox.Items.Clear();
                    GlobalVar.GlobalListYbox.Items.RemoveAt(selectIdx);
                    GlobalVar.ArrayListGlobalYTargetNum.RemoveAt(selectIdx);
                    GlobalVar.ALG_YOddEven.RemoveAt(selectIdx);
                    GlobalVar.ALG_YBigSmall.RemoveAt(selectIdx);
                    GlobalVar.ALG_YSuperNum.RemoveAt(selectIdx);
                    AddlboxYNum();
                    MessageBox.Show("成功移除");

                }
            }
            else
            {
                MessageBox.Show("尚未選取任何號碼");
            }


        }

        private void lboxCNum_DoubleClick(object sender, EventArgs e)
        {
            int selectIdx = lboxCNum.SelectedIndex;

            if (selectIdx >= 0)
            {
                var result = MessageBox.Show("確定要移除嗎?", "確定要移除嗎????", buttons: MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    
                    GlobalVar.GlobalListCbox.Items.RemoveAt(selectIdx);                    
                    GlobalVar.ArrayListGlobalCTargetNum.RemoveAt(selectIdx);
                    GlobalVar.ALG_COddEven.RemoveAt(selectIdx);
                    GlobalVar.ALG_CBigSmall.RemoveAt(selectIdx);
                    GlobalVar.ALG_CSuperNum.RemoveAt(selectIdx);
                    AddlboxCNum();
                }

            }
            else
            {
                MessageBox.Show("尚未選取任何號碼");
            }

            
            
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalVar.btnAllBallList.Enabled = true;
        }

        private void btnWin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("這功能我沒有做! 所以免費!");
        }
    }
}

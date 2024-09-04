using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace WindowsFormsBingoBingoUI
{
    internal class GlobalVar
    {

        public static ArrayList ArrayListGlobalTargetNum = new ArrayList();//開獎的歷史表單
        public static ArrayList ArrayListGlobalYTargetNum = new ArrayList();//你選的號碼的歷史表單
        public static ArrayList ArrayListGlobalCTargetNum = new ArrayList();//電腦選的號碼的歷史表單
        
        
        public static ArrayList ALG_YOddEven = new ArrayList();
        public static ArrayList ALG_COddEven = new ArrayList();

        public static ArrayList ALG_YBigSmall = new ArrayList();
        public static ArrayList ALG_CBigSmall = new ArrayList();


        public static ArrayList ALG_YSuperNum = new ArrayList();
        public static ArrayList ALG_CSuperNum = new ArrayList();


        public static ListBox GlobalListCbox = new ListBox();
        public static ListBox GlobalListYbox = new ListBox();

        
        public static Form3 myform3 = new Form3();


        public static Button btnAllBallList = new Button();


        //Draw

        public static string DrawSuperNum = "";
        public static string DrawOddEven = "";
        public static string DrawBigSmall = "";




    }
}

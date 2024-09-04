using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsBingoBingoUI
{
    public class Menu
    {   
        Animation myanimation = new Animation();
        List<Panel> panels = new List<Panel>();

        public void Menupanels(List<Panel> _panels)
        {
            this.panels = _panels;
        }


        public void BigMenu(Panel panelname)
        {           
            for (int i = 0; i < (panels.Count - 1); i++)
            {
                if (panelname == panels[i])
                {
                    panelname.Visible = true;
                    panelname.BringToFront();
                }
                else
                {
                    panels[i].Visible = false;
                }

            }
        }


        public void ShowCollapseMenu(Button buttonname,Panel panelname)
        {
            if (panelname.Visible == false)
            {
                myanimation.MenuAnimation(buttonname,panelname, true);

            }
            else if (panelname.Visible == true)
            {
                myanimation.MenuAnimation(buttonname,panelname, false);                
            }
        }


        public void ShowINCollapseMenu(Panel Collapsepanelname)
        {
            Collapsepanelname.Visible = true;
            Collapsepanelname.BringToFront();
        }




    }
}

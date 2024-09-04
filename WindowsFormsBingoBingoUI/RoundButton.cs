using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundButton : Button
{
    protected override void OnPaint(PaintEventArgs pevent)
    {
        GraphicsPath graphicsPath = new GraphicsPath();
        graphicsPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
        this.Region = new Region(graphicsPath);        
        base.OnPaint(pevent);
    }    


    protected override void OnPaintBackground(PaintEventArgs pevent)
    {
        base.OnPaintBackground(pevent);

        Graphics g = pevent.Graphics;
        g.SmoothingMode = SmoothingMode.HighQuality;
        g.Clear(this.Parent.BackColor);

        using (Brush brush = new SolidBrush(this.BackColor))
        {
            g.FillEllipse(brush, 0, 0, this.ClientSize.Width, this.ClientSize.Height);
        }
    }

}
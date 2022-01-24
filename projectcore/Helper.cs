using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projectcore
{
    static class Helper
    {
        public static void SwtichToBoldRegular(this Button c)
        {
            if (c.Font.Style != FontStyle.Bold)
                c.Font = new Font(c.Font, FontStyle.Bold);
            else
                c.Font = new Font(c.Font, FontStyle.Regular);
        }
        public static void SwtichColor(this Button c)
        {
            Color main = Color.FromArgb(15,154,238);
            if(c.ForeColor == main)
            {
                c.ForeColor = Color.Black;
            }
            else
            {
                c.ForeColor = main;

            }
        }
        public static void SwichBG(this Button c)
        {
            Color main = Color.FromArgb(248, 248, 248);
            if (c.BackColor == main)
            {
                c.BackColor = Color.White;
            }
            else
            {
                c.BackColor = main;

            }
        }
        public static void DeActiveButton(Button[] c)
        {
            Color main = Color.FromArgb(248, 248, 248);
            Color sw = Color.FromArgb(15, 154, 238);

            foreach (var b in c)
            {
                if (b.BackColor == main)
                {
                    b.BackColor = Color.White;
                }
                if (b.ForeColor == sw)
                {
                    b.ForeColor = Color.Black;
                }
                if (b.Font.Style == FontStyle.Bold)
                {
                    b.Font = new Font(b.Font, FontStyle.Regular);
                }
                    
            }
        }

       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warZone
{
    public class wz
    {
        public Random rnd = new Random();
        public int lastSpriteSelected = -1;
        
        public wz() { }
        
        public List<sprite> sprites = new List<sprite>(100);
        public void addSprite() { sprites.Add(new sprite()); }
        public void removeSprite(int a) { sprites.RemoveAt(a); }
        public void addSprite(sprite sprite) { sprites.Add(sprite); }
        public void addToForm(Form f, int a) { f.Controls.Add(sprites[a]); sprites[a].indexul = a; sprites[a].writeIndexOf(a.ToString()); }
        public void removeFromForm(Form f, int a) { f.Controls.Remove(sprites[a]); }
        public void setPositionOfSprite(int a, Form f, int pleft, int ptop) { f.Controls[a].Left = pleft; f.Controls[a].Top = ptop; }
        public void setVisibility(int a, Form f, bool ptf) { f.Controls[a].Visible = ptf; }
        public void setDimension(int a, Form f, int w, int h) { f.Controls[a].Width = w; f.Controls[a].Height = h; }
        public void setBackColor(int a, Form f, Color c) { f.Controls[a].BackColor = c; }
        public void selectedSprite(int vi)
        {
            lastSpriteSelected =  vi ;
        }
    }
}

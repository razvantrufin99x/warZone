using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace warZone
{
    public partial class sprite : UserControl
    {
        public sprite()
        {
            InitializeComponent();
        }
        public int ismd = 0;
        public bool isSelected = false;
        public int indexul = -1;
        public Form1 f = null;

        public void writeIndexOf(string s) { this.label1.Text = s; }
        public void setSelectedControl()
        {

            ismd = 1;
            isSelected = true;
            f.setSelectedItem(indexul);


        }
        public void setLabelForeColor(Color c)
        {
            this.label1.ForeColor = c;
        }
        private void sprite_MouseDown(object sender, MouseEventArgs e)
        {
            setSelectedControl();
        }

        private void sprite_MouseUp(object sender, MouseEventArgs e)
        {
            ismd = 0;
        }

        private void sprite_MouseMove(object sender, MouseEventArgs e)
        {
            if(ismd == 1)
            {

                this.Left += e.X;
                this.Top += e.Y;
                this.BringToFront();
            }
        }

        public void schangeIsSelectedValue() {
            if (isSelected == false) { isSelected = true; }
            else { isSelected = false; }
        }
        private void sprite_MouseClick(object sender, MouseEventArgs e)
        {
            setSelectedControl();
        }

        private void sprite_MouseLeave(object sender, EventArgs e)
        {
            isSelected = false;
        }

        private void sprite_Load(object sender, EventArgs e)
        {
            try
            {
                f = (Form1)ParentForm;
            }
            catch { }

            
            
        }

        private void sprite_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}

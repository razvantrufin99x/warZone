namespace warZone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        public wz vwz = new wz();

        public void addnew(int i) {
            int numa = vwz.rnd.Next(800);
            int numb = vwz.rnd.Next(600);
            vwz.addSprite();
            vwz.addToForm(this, i);
            vwz.setPositionOfSprite(i, this, numa, numb);
            vwz.setVisibility(i, this, true);
            vwz.setDimension(i, this, 20, 20);
            if (i % 2 == 0)
            {
                vwz.setBackColor(i, this, Color.Red);
            }
            else 
            {
                vwz.setBackColor(i, this, Color.Blue);
            }
           vwz.sprites[i]. setLabelForeColor(Color.White);
        }
        public void addN(int n) {
            for (int a = 0; a < n; a++)
            { 
                addnew(a);
            }
          }
        public void randomizePositions(int i) {
            int numa = vwz.rnd.Next(800);
            int numb = vwz.rnd.Next(600); 
            vwz.setPositionOfSprite(i, this, numa, numb);
        }

        public void setSelectedItem(int i) { vwz.selectedSprite(i); }

        public void randAllPozitions(int start, int finish)
        {

            for (int i = start; i < finish; i++)
            {

                randomizePositions(i);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
           
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            
            addN(10*2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //randAllPozitions(0, 9);
            
            
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (vwz.lastSpriteSelected != -1)
            {
                if (e.X < vwz.sprites[vwz.lastSpriteSelected].Left) { vwz.setPositionOfSprite(vwz.lastSpriteSelected, this, vwz.sprites[vwz.lastSpriteSelected].Left--, vwz.sprites[vwz.lastSpriteSelected].Top); }
                else if (e.X > vwz.sprites[vwz.lastSpriteSelected].Left) { vwz.setPositionOfSprite(vwz.lastSpriteSelected, this, vwz.sprites[vwz.lastSpriteSelected].Left++, vwz.sprites[vwz.lastSpriteSelected].Top); }
                else if (e.Y < vwz.sprites[vwz.lastSpriteSelected].Top) { vwz.setPositionOfSprite(vwz.lastSpriteSelected, this, vwz.sprites[vwz.lastSpriteSelected].Left, vwz.sprites[vwz.lastSpriteSelected].Top++); }
                else if (e.Y > vwz.sprites[vwz.lastSpriteSelected].Top) { vwz.setPositionOfSprite(vwz.lastSpriteSelected, this, vwz.sprites[vwz.lastSpriteSelected].Left, vwz.sprites[vwz.lastSpriteSelected].Top--); }
                else { }

            }
            Text = e.X.ToString() + " : " + e.Y.ToString();
            
            Refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (vwz.lastSpriteSelected != -1){
                if (e.KeyCode == Keys.Left) { vwz.setPositionOfSprite(vwz.lastSpriteSelected, this, vwz.sprites[vwz.lastSpriteSelected].Left--, vwz.sprites[vwz.lastSpriteSelected].Top); }
                else if (e.KeyCode == Keys.Right) { vwz.setPositionOfSprite(vwz.lastSpriteSelected, this, vwz.sprites[vwz.lastSpriteSelected].Left--, vwz.sprites[vwz.lastSpriteSelected].Top); }
                else if (e.KeyCode == Keys.Up) { vwz.setPositionOfSprite(vwz.lastSpriteSelected, this, vwz.sprites[vwz.lastSpriteSelected].Left, vwz.sprites[vwz.lastSpriteSelected].Top++); }
                else if (e.KeyCode == Keys.Down) { vwz.setPositionOfSprite(vwz.lastSpriteSelected, this, vwz.sprites[vwz.lastSpriteSelected].Left, vwz.sprites[vwz.lastSpriteSelected].Top--); }
                else { }
            
            }
           
            Text = e.KeyValue.ToString();
            Refresh();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
          
            
        }

        
    }
}

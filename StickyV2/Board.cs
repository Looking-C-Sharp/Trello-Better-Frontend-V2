using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StickyV2
{
    public partial class Board : Form
    {
        public Board()
        {
            
            InitializeMyScrollBar();
            displayGroupLabels();
            InitializeComponent();
        }
        private void InitializeMyScrollBar()
        {
            // Create and initialize a VScrollBar.
            VScrollBar vScrollBar1 = new VScrollBar();

            // Dock the scroll bar to the right side of the form.
            vScrollBar1.Dock = DockStyle.Right;

            // Add the scroll bar to the form.
            Controls.Add(vScrollBar1);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
public void displayGroupLabels()
{
   //string[] groups = getGroupLabels();
   List<Panel> panels = new List<Panel>();
   List<Button> buttons= new List<Button>();
  for (int i = 0; i < 20; i++)
   {
       
       Panel p = new Panel();
       Button b = new Button();
       p.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
       b.Text = i + "";
       //label.MultiLine= true;
      // label.Multiline = true;
       //label.ScrollBars = ScrollBars.Both;
      // label.Text = i+"";
       p.Location = new System.Drawing.Point(200*i, 50);

       panels.Add(p);
       buttons.Add(b);
       this.Controls.Add(p);
       this.Controls.Add(b);
   }
}
/*
public string[] getGroupLabels()
{
   string[] groups = new string[5];
   groups[0] = "First Group";
   groups[1] = "Trello Board";
   groups[2] = "This is a really long group name becasue we should test these kinds of things :) :) :) :) :) :)";
   groups[3] = "Hello World";
   groups[4] = "Last Group";
   return groups;
}*/
    }
}

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
    public partial class Groups : Form
    {
        public Groups()
        {
            displayGroupLabels();
            InitializeComponent();
            
        }

        public void displayGroupLabels()
        {
            string[] groups = getGroupLabels();
            List<LinkLabel> labels = new List<LinkLabel>();
            for (int i = 0; i < 5; i++)
            {
                LinkLabel label = new LinkLabel();
                label.Text = groups[i];
                label.Location = new System.Drawing.Point(70, 60 + 25 * i);
                label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.openGroup);
                labels.Add(label);
                this.Controls.Add(label);
            }
        }

        public string[] getGroupLabels()
        {
            string[] groups = new string[5];
            groups[0] = "First Group";
            groups[1] = "Trello Board";
            groups[2] = "This is a really long group name becasue we should test these kinds of things :) :) :) :) :) :)";
            groups[3] = "Hello World";
            groups[4] = "Last Group";
            return groups;
        }

        private void openGroup(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Projects p = new Projects();
            p.Show();
            this.Hide();
        }
    }
}

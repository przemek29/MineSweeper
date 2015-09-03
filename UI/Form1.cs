using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;

namespace UI
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private Button createButton(int x, int y, int gridX, int gridY)
        {
            Button btn = new Button();

            btn.Text = "";
            btn.Name = gridX.ToString() + " " + gridY.ToString();
            btn.Size = new System.Drawing.Size(24, 24);
            btn.Location = new System.Drawing.Point(x, y);
            Controls.AddRange(new System.Windows.Forms.Control[] { btn, });
            //bttn.Click += new System.EventHandler(bttnOnclick);
            //bttn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bttnOnRightClick);

            return btn;
        }

        private Label createLables(int x, int y)
        {
            Label lbl = new Label();
            lbl.Name = x.ToString() + " " + y.ToString();
            lbl.Text = "0";
            lbl.Size = new System.Drawing.Size(24, 24);
            lbl.Font = new Font("Microsoft Sans Serif", 15.75f, lbl.Font.Style, lbl.Font.Unit);
            lbl.Location = new System.Drawing.Point(x, y);
            Controls.AddRange(new System.Windows.Forms.Control[] { lbl, });
            return lbl;
        }
    }
}

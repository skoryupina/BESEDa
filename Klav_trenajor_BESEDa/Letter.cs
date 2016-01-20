using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace BESEDa
{
    public partial class Letter : UserControl
    {
        public volatile string Letterl = "C";
        private int fontSize;
        public Letter()
        {
            InitializeComponent();
            DoubleBuffered = true;
            fontSize = 30;
        }

        public Letter(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }
        public int UserFontSize
        {
            get { return fontSize; }
            set { fontSize = value; }
        }
        private void Letter_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath myGraphicsPath = new GraphicsPath();
            //string stringText = Letterl;
            FontFamily family = new FontFamily("Arial");
            int fontStyle = (int)FontStyle.Bold;
            int emSize = fontSize;
            PointF origin = new PointF(0, 0);
            StringFormat format = new StringFormat(StringFormat.GenericDefault);
            myGraphicsPath.AddString(Letterl, family, fontStyle, emSize, origin, format);
            this.Region = new Region(myGraphicsPath);
          
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath myGraphicsPath = new GraphicsPath();
            //string stringText = Letterl;
            FontFamily family = new FontFamily("Arial");
            int fontStyle = (int)FontStyle.Bold;
            int emSize = fontSize*2;
            PointF origin = new PointF(0, 0);
            StringFormat format = new StringFormat(StringFormat.GenericDefault);
            myGraphicsPath.AddString(Letterl, family, fontStyle, emSize, origin, format);
            this.Region = new Region(myGraphicsPath);
           
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP4_to_MP3_Converter
{
    public partial class SeLeCtRa : Form
    {
        public SeLeCtRa()
        {
            InitializeComponent();

            // Start the timer for close the form
            timer1.Start();
        }

        // Fire the event when timer finished
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}

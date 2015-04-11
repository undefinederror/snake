using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
            new Settings();
            
        }

        Form _frmSnake = new frmSnake();
       
        //private void trackBar1_Scroll(object sender, EventArgs e)
        //{
        //    // Calculate the volume that's being set. BTW: this is a trackbar!
        //    int NewVolume = ((ushort.MaxValue / 10) * trackBar1.Value);
        //    // Set the same volume for both the left and the right channels
        //    uint NewVolumeAllChannels = (((uint)NewVolume & 0x0000ffff) | ((uint)NewVolume << 16));
        //    // Set the volume
        //    VolumeControl.PlayerVolume.waveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels);

        //}

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            _frmSnake.ShowDialog();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
                //Dictionary<string, string> x = new Dictionary<string, Dictionary<string,string> >();
            
                
         
           
            
        }
       


       
    }
}

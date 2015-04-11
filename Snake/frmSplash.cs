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
   
    public partial class frmSplash : Form
    {

        public Form _frmSnake = new frmSnake();
        public frmSplash()
        {
            InitializeComponent();
            new Settings();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            _frmSnake.ShowDialog();
            Settings.states =  states
            

        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
        
        }
    }
}

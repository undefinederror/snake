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

        
        public frmSplash()
        {
            InitializeComponent();
            
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            Program._frmSnake = new frmSnake();
            Program._frmSnake.Show();
        }
        private void frmSplash_Shown(object sender, EventArgs e)
        {
            if (Program._frmSnake != null) 
            { 
            Program._frmSnake.Hide();
            }

        }
               
    }
}

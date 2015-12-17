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
            //new Settings();
            
            Form _frmSnake = new frmSnake();
            _frmSnake.Show();
            _frmSnake.Activate();
            
            

            
            

        }
        private void frmSplash_Load(object sender, EventArgs e)
        { 
        }
               
    }
}

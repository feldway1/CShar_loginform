using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CShar_loginform
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            lbxkq.Items.Clear();
            int so;
            so = Convert.ToInt32(txtso.Text);
            for (int i = 1; i <= so; i++)
            {
                if (so % i == 0)
                {
                    lbxkq.Items.Add(i.ToString());
                }
            }

        }

        private void txtso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtso_MouseClick(object sender, MouseEventArgs e)
        {

        }

       /* private void btnboi_Click(object sender, EventArgs e)
        {
           
            int so, boi;
            so = Convert.ToInt32(txtso.Text);
            boi = Convert.ToInt32(txtgioihan.Text);
            for (int i = 0; i <= boi; i++)
            {


                so * i = boi;
                

            }
        }*/
    }
}

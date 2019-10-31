using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace posmsLite
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            if(LoginManager.isAuthUser)
            {
                switch (LoginManager.CurrentUser.Role) {
                    case User.Roles.Admin:
                        quartermasterBox.Visible = false;
                        adminBox.Visible = true;
                        break;
                    case User.Roles.Quartemaster:
                        quartermasterBox.Visible = true;
                        adminBox.Visible = false;
                        break;
                    default:
                        quartermasterBox.Visible = false;
                        adminBox.Visible = false;
                        break;

                }

            }
        }

        private void Back_to_login_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}

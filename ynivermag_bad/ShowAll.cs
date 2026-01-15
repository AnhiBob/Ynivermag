using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ynivermag_bad
{
    public partial class ShowAll : Form
    {
        private int _roleID;
        private string _FIO;
        public ShowAll(string FIO, int roleId)
        {
            InitializeComponent();
            _roleID= roleId;
            _FIO = FIO;
        }

        private void InMenuClient_Click(object sender, EventArgs e)
        {
            if (_roleID==1)
            {
                MenuAdminForm admin = new MenuAdminForm(_FIO);
                admin.Show();
                this.Hide();
            }else if(_roleID == 2)
            {
                MenuSellerForm seller = new MenuSellerForm(_FIO);
                seller.Show();
                this.Hide();
            }else if (_roleID == 3)
            {
                MenuTovarovedForm menu = new MenuTovarovedForm(_FIO);
                menu.Show();
                this.Hide();
            }
        }
    }
}

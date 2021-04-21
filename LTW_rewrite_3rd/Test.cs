using LTW_rewrite_3rd.Access;
using LTW_rewrite_3rd.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTW_rewrite_3rd
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            MyDataContext myda = new MyDataContext();
            myda.openConection();
            MyLogin mylog = new MyLogin();
            DataTable dt = mylog.getUser();
            dataGridView1.DataSource = mylog.getUser();
        }
    }
}

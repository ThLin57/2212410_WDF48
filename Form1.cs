using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212410_WDF48
{
    public partial class frmDemoComboBox : Form
    {
        public frmDemoComboBox()
        {
            InitializeComponent();
        }
        private void frmDemoComboBox_Load(object sender, EventArgs e)
        {
            string[] datas = { "Tiếng Anh","Tiếng Pháp", "Tiếng Việt", "Tiếng Nhật" };
            this.comboBox_NgoaiNgu.DataSource = datas;
         }
        private void comboBox_NgoaiNgu_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(this.comboBox_NgoaiNgu.SelectedItem.ToString());
        }

       
    }
}

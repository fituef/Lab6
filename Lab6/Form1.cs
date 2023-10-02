using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Form> lst = new List<Form>();
        public void DisposeAllButThis(Form form)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() == form.GetType() && frm != form)
                {
                    frm.Dispose();
                    frm.Hide();
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
            frmAdd frm = new frmAdd();
            frm.MdiParent = this;

            //DisposeAllButThis(frm);
            int total = lst.Count;
            for(int i=0; i<total; i++)
            {
                if(frm.Text == lst[i].Text)
                {
                    lst[i].Show();
                    lst[i].Activate();
                    return;
                }
            }
            lst.Add(frm);
            frm.Show();
        }

        private void userInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfo frm = new frmUserInfo();
            frm.MdiParent = this;
            DisposeAllButThis(frm);
            frm.Show();
        }
    }
}

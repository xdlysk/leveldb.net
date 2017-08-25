using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LevelDB.Viewer
{
    public partial class Form1 : Form
    {
        private DB _db;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            LbList.Items.Clear();
            var filter = TxtSearch.Text;
            using (var iterator = _db.CreateIterator(new ReadOptions()))
            {
                iterator.SeekToFirst();
                while (iterator.Valid())
                {
                    var key = iterator.StringKey();
                    if (string.IsNullOrWhiteSpace(filter))
                    {
                        LbList.Items.Add(key);
                    }
                    else if(key.IndexOf(filter,StringComparison.OrdinalIgnoreCase)>=0)
                    {
                        LbList.Items.Add(key);
                    }
                    iterator.Next();
                }
            }
        }

        private void BtnBrowser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            var result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                TxtDbPath.Text = fbd.SelectedPath;
                _db = new DB(TxtDbPath.Text);
            }
        }

        private void LbList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var item = LbList.SelectedItem;
            if (item != null)
            {
                TxtContent.Text = _db.Get(item.ToString());
            }
        }
    }
}

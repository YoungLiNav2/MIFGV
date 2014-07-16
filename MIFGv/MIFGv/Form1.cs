using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.IO;
using System.Drawing.Drawing2D;

namespace MIFGv
{
    public partial class MIFGv : Form
    {
        public MIFGv()
        {
            InitializeComponent();
        }

        private void MIFGv_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“connectDatabaseDataSet.people”中。您可以根据需要移动或删除它。      
        }        
        
        private void oPENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog MapOpen = new OpenFileDialog();
            MapOpen.InitialDirectory = @"D:\";
            MapOpen.DefaultExt = "mif";
            MapOpen.Filter = "MIF files (*.mif)|*.mif|All files (*.*)|*.*";
            MapOpen.RestoreDirectory = false;
            MapOpen.Multiselect = true;
            MapOpen.ShowDialog();
            //Drawingpet pet1 = new Drawingpet();
            //pet1.Show();

        }     

    }

    public class FileReader
    {
        public string oriPath;
        public FileReader(string path)
        {
            oriPath = path;
        }
        public string OpenFile(string filePath)
        {
            StreamReader sFileReaer = new StreamReader(filePath,Encoding.Default);
            string sBuilder = sFileReaer.ReadToEnd();
            return sBuilder;
        }

    }
}

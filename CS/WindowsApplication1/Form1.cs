using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ViewInfo;
using System.Reflection;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnScroll(object sender, ScrollEventArgs e)
        {
            int topIndex = (sender as ListBoxControl).TopIndex;
            listBoxControl1.TopIndex = topIndex;
            listBoxControl2.TopIndex = topIndex;
        }

     
    }
}
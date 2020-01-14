using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA200114
{
    public partial class FrmDiakLista : Form
    {
        OleDbConnection conn;
        public FrmDiakLista(OleDbConnection conn)
        {
            this.conn = conn;
            InitializeComponent();

            Icon = Properties.Resources.student;
        }
    }
}

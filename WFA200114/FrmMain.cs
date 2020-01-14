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
    public partial class FrmMain : Form
    {
        OleDbConnection conn;
        public FrmMain()
        {
            conn = new OleDbConnection(
                "Provider = Microsoft.ACE.OLEDB.12.0;" +
                @"Data Source = ..\..\Resources\pontverseny.accdb");
            InitializeComponent();

            Icon = Properties.Resources.math;
        }

        private void SzerkesztesTSMI_Click(object sender, EventArgs e)
        {
            var frm = new FrmDiak(conn);
            frm.ShowDialog();
        }

        private void KeresesTSMI_Click(object sender, EventArgs e)
        {
            var frm = new FrmDiakLista(conn);
            frm.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            conn.Open();
            var cmd = new OleDbCommand(
                "SELECT diak.nev, SUM(eredmeny.pont), diak.evfolyam, iskola.iskola_neve " +
                "FROM ((diak " +
                "INNER JOIN eredmeny ON diak.diakID = eredmeny.diakID) " +
                "INNER JOIN iskola ON diak.iskID = iskola.iskID) " +
                "GROUP BY diak.nev, diak.evfolyam, iskola.iskola_neve " +
                "ORDER BY SUM(eredmeny.pont) DESC", conn);
            int hely = 1;
            var r = cmd.ExecuteReader();
            while (r.Read())
            {
                dgvEredmenyek.Rows.Add(hely + ".", r[0], r[1], r[2], r[3]);
                hely++;
            }
            conn.Close();
        }
    }
}

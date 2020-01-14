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
    public partial class FrmDiak : Form
    {
        OleDbConnection conn;
        public FrmDiak(OleDbConnection conn)
        {
            this.conn = conn;
            InitializeComponent();

            Icon = Properties.Resources.student;
        }

        private void FrmDiak_Load(object sender, EventArgs e)
        {
            conn.Open();
            var cmd = new OleDbCommand(
                "SELECT iskola_neve FROM iskola " +
                "ORDER BY iskola_neve", conn);
            var r = cmd.ExecuteReader();
            while (r.Read())
            {
                cbIsk.Items.Add(r[0]);
            }
            conn.Close();
        }

        private void KeresesTSMI_Click(object sender, EventArgs e)
        {
            var frm = new FrmDiakLista(conn);
            frm.ShowDialog();
        }

        private void MentesTSMI_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbAzon.Text))
            {
                int iskID = GetIskId(cbIsk.SelectedItem.ToString());

                //INSERT
                conn.Open();
                var adp = new OleDbDataAdapter()
                {
                    InsertCommand = new OleDbCommand(
                        "INSERT INTO diak (nev, evfolyam, iskID) VALUES " +
                        $"('{tbNev.Text}', {nudEvf.Value}, {iskID});", conn),
                };
                adp.InsertCommand.ExecuteNonQuery();
                conn.Close();
                SetAzonosito();
                MessageBox.Show("Új Diák adatai rögzítve!");
            }
            else
            {
                //UPDATE
                conn.Open();
                var adp = new OleDbDataAdapter()
                {
                    UpdateCommand = new OleDbCommand(
                        "UPDATE diak SET " +
                        $"nev = '{tbNev.Text}', " +
                        $"evfolyam = {nudEvf.Value}, " +
                        $"iskID = {GetIskId(cbIsk.SelectedItem.ToString())} " +
                        $"WHERE diakID = {tbAzon.Text}", conn),
                };
                adp.UpdateCommand.ExecuteNonQuery();
                conn.Close();

            }
        }

        private int GetIskId(string iskolaNeve)
        {
            conn.Open();
            var cmd = new OleDbCommand(
                "SELECT iskID FROM iskola " +
                $"WHERE iskola_neve LIKE '{iskolaNeve}';", conn);
            var r = cmd.ExecuteReader();
            r.Read();
            int id = r.GetInt32(0);
            conn.Close();
            return id;
        }

        private void SetAzonosito()
        {
            conn.Open();
            var cmd = new OleDbCommand(
                "SELECT TOP 1 diakID FROM diak " +
                "ORDER BY diakID DESC;", conn);
            var r = cmd.ExecuteReader();
            r.Read();
            tbAzon.Text = r.GetInt32(0).ToString();
            conn.Close();
        }
    }
}

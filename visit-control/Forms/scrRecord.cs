using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using visit_control.Connection;
using visit_control.PDF;

namespace visit_control.Forms
{
    public partial class scrRecord : MaterialForm

    {
        public scrRecord()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Red900, //Color dialog 
                Primary.Red900, //Color control buttons
                Primary.Blue400,
                Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        #region FUNCIONES

        private void fill_dgv(string searchValue, DateTime date1, DateTime date2)
        {
            dgvVisit.Rows.Clear();
            var db = new ConnectionDB();

            var data = db.Visitors.Join(db.Visitors_Department, x => x.id, y => y.id_visitor, (x, y) => new
            {
                x.id,
                x.name,
                x.last_name,
                x.m_last_name,
                x.status,
                y.department,
                y.entry
            });

            if (!string.IsNullOrEmpty(searchValue))
            {
                data = data.Where(x => x.name.Contains(searchValue) ||
                                       x.last_name.Contains(searchValue) ||
                                       x.m_last_name.Contains(searchValue) ||
                                       x.department.Contains(searchValue)
                ).Where(x => x.status == 1 && DbFunctions.TruncateTime(x.entry) >= DbFunctions.TruncateTime(date1) && DbFunctions.TruncateTime(x.entry) <= DbFunctions.TruncateTime(date2));
            }

            foreach (var item in data.ToList())
            {
                dgvVisit.Rows.Add(item.name,
                    item.last_name,
                    item.m_last_name,
                    item.department,
                    item.entry);
            }
        }

        private void print_visitor_info(string name, string department, DateTime entry)
        {
            dsVisitorInfo ds = new dsVisitorInfo();
            crVisitor cr = new crVisitor();

            ds.dtData.AdddtDataRow(name.ToUpper(), department.ToUpper(), entry.ToString("dd-MMMM-yyyy hh:mm:ss"));

            cr.SetDataSource(ds);
            scrReport scr = new scrReport { crvReport = { ReportSource = cr } };
            scr.ShowDialog();
            ds.Clear();
            cr.Close();
        }
        #endregion

        private void scrRecord_Load(object sender, EventArgs e)
        {
            fill_dgv(tbSearchValue.Text,dtpF1.Value,dtpF2.Value);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            fill_dgv(tbSearchValue.Text, dtpF1.Value, dtpF2.Value);
        }

        private void printTicket_Click(object sender, EventArgs e)
        {
            var index = dgvVisit.CurrentRow.Index;
            string name = dgvVisit.Rows[index].Cells[0].Value.ToString() + " " +
                          dgvVisit.Rows[index].Cells[1].Value.ToString() + " " +
                          dgvVisit.Rows[index].Cells[2].Value.ToString();

            string department = dgvVisit.Rows[index].Cells[3].Value.ToString();

            DateTime entry = Convert.ToDateTime(dgvVisit.Rows[index].Cells[4].Value);

            print_visitor_info(name,department,entry);
        }
    }
}

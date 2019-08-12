using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using visit_control.Connection;

namespace visit_control.Models
{
    public partial class scrDashBoard : MaterialForm
    {
        private int id_visitor;

        public scrDashBoard()
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

        private void scrDashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
        }

        #region FUNCIONES

        private void enable_disable_visitor(Boolean option)
        {
            pbImage.Enabled = option;
            tbName.Enabled = option;
            tbLastName.Enabled = option;
            tbMLastName.Enabled = option;
            tbAlias.Enabled = option;
            tbEmail.Enabled = option;
            tbPhone.Enabled = option;
            tbAddress.Enabled = option;
        }

        private void enable_disable_visit(Boolean option)
        {
            tbDepartment.Enabled = option;
            tbReason.Enabled = option;
            rtbObservation.Enabled = option;
        }

        private void clean_fields_visitor()
        {
            pbImage.BackgroundImage = null;
            tbName.Text = string.Empty;
            tbLastName.Text = string.Empty;
            tbMLastName.Text = string.Empty;
            tbAlias.Text = string.Empty;
            tbEmail.Text = string.Empty;
            tbPhone.Text = string.Empty;
            tbAddress.Text = string.Empty;
        }

        private bool check_fields_visitor()
        {
            if (string.IsNullOrEmpty(tbName.Text))
            {
                MessageBox.Show("Campo obligatorio", "Operador", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(tbAlias.Text))
            {
                MessageBox.Show("Campo obligatorio", "Operador", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(tbPhone.Text))
            {
                MessageBox.Show("Campo obligatorio", "Operador", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbPhone.Focus();
                return false;
            }

            return true;
        }

        private bool check_fields_visit()
        {
            if (string.IsNullOrEmpty(tbDepartment.Text))
            {
                MessageBox.Show("Campo obligatorio", "Operador", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbDepartment.Focus();
                return false;
            }

            return true;
        }

        private void fill_dgv(string searchValue)
        {
            dgvVistors.Rows.Clear();
            var db = new ConnectionDB();
            var data = db.Visitors.Where(x => x.status == 1);
            if (!string.IsNullOrEmpty(searchValue))
            {
                data = data.Where(x=>   x.name.Contains(searchValue) ||
                                        x.last_name.Contains(searchValue) ||
                                        x.m_last_name.Contains(searchValue) ||
                                        x.alias.Contains(searchValue) ||
                                        x.email.Contains(searchValue) ||
                                        x.phone.Contains(searchValue));
            }

            foreach (var item in data.ToList())
            {
                dgvVistors.Rows.Add(item.id,
                                                item.name,
                                                item.last_name,
                                                item.m_last_name,
                                                item.alias,
                                                item.email,
                                                item.phone);
            }
        }

        private string ConvertImageToBase64(Image image)
        {
            using (var m = new MemoryStream())
            {
                if (image != null)
                {
                    image.Save(m, image.RawFormat);
                    var imageBytes = m.ToArray();
                    
                    var base64String = Convert.ToBase64String(imageBytes);
                    return base64String;
                }

                return "";
            }
        }

        public Image ConvertBase64ToImage(string base64String)
        {
            // Convert base 64 string to byte[]
            var imageBytes = Convert.FromBase64String(base64String);
            // Convert byte[] to Image
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                try
                {
                    var image = Image.FromStream(ms, true);
                    return image;
                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }
        #endregion

        #region BOTONES
        private void btnNewVisitor_Click(object sender, EventArgs e)
        {
            enable_disable_visitor(true);

            btnCancel.Visible = true;
            btnSaveVisitor.Visible = true;
            btnNewVisitor.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clean_fields_visitor();
            enable_disable_visitor(false);
            btnCancel.Visible = false;
            btnSaveVisitor.Visible = false;
            btnNewVisitor.Visible = true;
        }

        private void btnSaveVisitor_Click(object sender, EventArgs e)
        {
            if (!check_fields_visitor())
            {
                return;
            }

            var db = new ConnectionDB();
            var visitor = new Visitors
            {
                name = tbName.Text,
                last_name = tbLastName.Text,
                m_last_name = tbMLastName.Text,
                alias = tbAlias.Text,
                email = tbEmail.Text,
                phone = tbPhone.Text,
                address = tbAddress.Text,
                status = 1,
                image = ConvertImageToBase64(pbImage.BackgroundImage)
            };

            db.Visitors.Add(visitor);
            db.SaveChanges();

            MessageBox.Show("Registro realizado con éxito", "Operador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clean_fields_visitor();
            enable_disable_visitor(false);
            fill_dgv("");
        }

        private void pbImage_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                Filter = "Archivos de Imagen JPG|*.jpg|Todos los archivos|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var image_name = ofd.FileName;
                pbImage.BackgroundImage = Image.FromFile(image_name);
            }
            else
            {
                pbImage.BackgroundImage = null;
            }
        }

        private void stbtSearch_Click(object sender, EventArgs e)
        {
            fill_dgv(tbSearch.Text);
        }

        private void dgvVistors_DoubleClick(object sender, EventArgs e)
        {
            var db = new ConnectionDB();
            if (dgvVistors.CurrentRow == null) return;

            var index = dgvVistors.CurrentRow.Index;
            id_visitor = Convert.ToInt16(dgvVistors.Rows[index].Cells[0].Value);

            var visitor = db.Visitors.FirstOrDefault(x => x.id == id_visitor);

            if (visitor == null) return;

            pbImage.BackgroundImage = ConvertBase64ToImage(visitor.image);
            tbName.Text = visitor.name;
            tbLastName.Text = visitor.last_name;
            tbMLastName.Text = visitor.m_last_name;
            tbAlias.Text = visitor.alias;
            tbEmail.Text = visitor.email;
            tbPhone.Text = visitor.phone;
            tbAddress.Text = visitor.address;

            btnNewVisitor.Visible = false;
            btnNewVisit.Visible = false;
        }

        private void btnNewVisit_Click(object sender, EventArgs e)
        {
            enable_disable_visit(true);
            btnNewVisit.Visible = false;
            btnSaveVisit.Visible = true;
        }

        private void btnSaveVisit_Click(object sender, EventArgs e)
        {
            if(!check_fields_visit()) return;
            var db = new ConnectionDB();
            var visitorDepartment = new Visitors_Department
            {
                department = tbDepartment.Text,
                reason =  tbReason.Text,
                observation = rtbObservation.Text,
                entry = DateTime.Now,
                id_visitor = id_visitor
            };

            db.Visitors_Department.Add(visitorDepartment);
            db.SaveChanges();

            MessageBox.Show("Visita registrada con éxito", "Operador", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}

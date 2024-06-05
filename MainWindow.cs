using OfficeOpenXml;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelarz
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Font = new Font("Open Sans", this.Font.Size);
            openHome();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            closeForms();

            openHome();

        }

        private void buttonKatalog_Click(object sender, EventArgs e)
        {
            closeForms();

            openKatalog();

        }
        //d

        private void buttonExport_Click(object sender, EventArgs e)
        {

            string connectionString = "User Id=msbd4;Password=haslo2024;Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=155.158.112.45)(PORT=1521)))(CONNECT_DATA=(SID=oltpstud)))";

            string sqlQuery = "select p.pacjent_id, p.imie, p.nazwisko, p.pesel, p.data_urodzenia, m.nr_modelu, m.data_wykonania from pacjenci p join modeleortodontyczne m on p.pacjent_id = m.pacjent_id";

            DataTable dataTable = GetDataFromDatabase(connectionString, sqlQuery);

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Save as Excel File";
            saveFileDialog.FileName = "plik.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                ExportToExcel(dataTable, filePath);

                MessageBox.Show("Eksport danych zakończony sukcesem!");
            }
        }


        void closeForms()
        {
            List<Form> formsToClose = new List<Form>();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Home || frm is Katalog)
                {
                    formsToClose.Add(frm);
                }
            }

            foreach (Form frm in formsToClose)
            {
                frm.Close();
            }
        }

        void openHome()
        {
            Home frm = new Home()
            {
                TopLevel = false,
                Dock = DockStyle.Fill
            };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.panelMain.Controls.Add(frm);
            frm.Show();
        }

        void openKatalog()
        {
            Katalog frm = new Katalog()
            {
                TopLevel = false,
                Dock = DockStyle.Fill
            };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.panelMain.Controls.Add(frm);
            frm.Show();
        }


        public DataTable GetDataFromDatabase(string connectionString, string query)
        {
            DataTable dataTable = new DataTable();

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }

        public void ExportToExcel(DataTable dataTable, string filePath)
        {
            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Sheet1");

                worksheet.Cells["A1"].LoadFromDataTable(dataTable, true);

                package.SaveAs(new FileInfo(filePath));
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            buttonKatalog_Click(sender, e);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            buttonExport_Click(sender, e);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            btnExit_Click(sender, e);
        }

        private void guna2Button2_MouseEnter(object sender, EventArgs e)
        {
            guna2Button2.Cursor = Cursors.Hand;
        }

        private void guna2Button1_MouseEnter(object sender, EventArgs e)
        {
            guna2Button1.Cursor = Cursors.Hand;
        }

        private void guna2Button3_MouseEnter(object sender, EventArgs e)
        {
            guna2Button3.Cursor = Cursors.Hand;
        }

        private void guna2Button4_MouseEnter(object sender, EventArgs e)
        {
            guna2Button4.Cursor = Cursors.Hand;
        }

    }
}
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Modelarz
{
    public partial class Katalog : Form
    {
        private DataTable dataTable;
        private bool changeBtn = false;
        private int rowCountBefore;

        public Katalog()
        {
            InitializeComponent();
            LoadData();
            CustomDataGrid();
            this.Font = new Font("Open Sans", this.Font.Size);
        }


        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("imie LIKE '%{0}%' OR nazwisko LIKE '%{0}%' OR pesel LIKE '%{0}%' OR nr_modelu LIKE '%{0}%'", guna2TextBox1.Text);

        }

        private void Katalog_Load()
        {
            string connectionString = "User Id=msbd4;Password=haslo2024;Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=155.158.112.45)(PORT=1521)))(CONNECT_DATA=(SID=oltpstud)))";
            using (OracleConnection con = new OracleConnection(connectionString))
            {
                con.Open();
                Console.WriteLine("Connected to Oracle Database");

                string sqlQuery = "select p.pacjent_id, p.imie, p.nazwisko, p.pesel, p.data_urodzenia, m.nr_modelu, m.data_wykonania from pacjenci p join modeleortodontyczne m on p.pacjent_id = m.pacjent_id";

                using (OracleCommand command = new OracleCommand(sqlQuery, con))
                {
                    using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                    {
                        dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
                con.Close();
            }
        }

        private void CustomDataGrid()
        {
            dataGridView1.Columns["pacjent_id"].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Imię";
            dataGridView1.Columns[2].HeaderText = "Nazwisko";
            dataGridView1.Columns[3].HeaderText = "PESEL";
            dataGridView1.Columns[4].HeaderText = "Data urodzenia";
            dataGridView1.Columns[5].HeaderText = "Nr modelu";
            dataGridView1.Columns[6].HeaderText = "Data wykonania";

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.HeaderCell.Style.Font = new Font("Microsoft Sans Serif", 9F);
            }

            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(227, 227, 227);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (changeBtn)
            {
                guna2Button1.FillColor = Color.LightGray;
                changeBtn = false;
                dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            }
            else
            {
                guna2Button1.FillColor = Color.FromArgb(247, 247, 247);
                changeBtn = true;
                dataGridView1.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                rowCountBefore = dataGridView1.Rows.Count - 2;
            }
        }

        // Save data to the database
        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "User Id=msbd4;Password=haslo2024;Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=155.158.112.45)(PORT=1521)))(CONNECT_DATA=(SID=oltpstud)))";

            using (OracleConnection con = new OracleConnection(connectionString))
            {
                con.Open();
                OracleTransaction transaction = con.BeginTransaction();

                try
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        if (row.RowState == DataRowState.Modified)
                        {
                            string updatePacjenciQuery = "UPDATE pacjenci SET imie = :imie, nazwisko = :nazwisko, pesel = :pesel, data_urodzenia = :data_urodzenia WHERE pacjent_id = :pacjent_id";
                            using (OracleCommand cmdPacjenci = new OracleCommand(updatePacjenciQuery, con))
                            {
                                cmdPacjenci.Parameters.Add("imie", OracleDbType.Varchar2).Value = row["imie"];
                                cmdPacjenci.Parameters.Add("nazwisko", OracleDbType.Varchar2).Value = row["nazwisko"];
                                cmdPacjenci.Parameters.Add("pesel", OracleDbType.Varchar2).Value = row["pesel"];
                                cmdPacjenci.Parameters.Add("data_urodzenia", OracleDbType.Date).Value = row["data_urodzenia"];
                                cmdPacjenci.Parameters.Add("pacjent_id", OracleDbType.Int32).Value = row["pacjent_id"];
                                cmdPacjenci.ExecuteNonQuery();
                            }

                            string updateModeleQuery = "UPDATE modeleortodontyczne SET nr_modelu = :nr_modelu, data_wykonania = :data_wykonania WHERE pacjent_id = :pacjent_id";
                            using (OracleCommand cmdModele = new OracleCommand(updateModeleQuery, con))
                            {
                                cmdModele.Parameters.Add("nr_modelu", OracleDbType.Varchar2).Value = row["nr_modelu"];
                                cmdModele.Parameters.Add("data_wykonania", OracleDbType.Date).Value = row["data_wykonania"];
                                cmdModele.Parameters.Add("pacjent_id", OracleDbType.Int32).Value = row["pacjent_id"];
                                cmdModele.ExecuteNonQuery();
                            }
                        }
                        else if (row.RowState == DataRowState.Added)
                        {
                            string insertPacjenciQuery = "INSERT INTO pacjenci (imie, nazwisko, pesel, data_urodzenia) VALUES (:imie, :nazwisko, :pesel, :data_urodzenia) RETURNING pacjent_id INTO :pacjent_id";
                            using (OracleCommand cmdPacjenci = new OracleCommand(insertPacjenciQuery, con))
                            {
                                cmdPacjenci.Parameters.Add("imie", OracleDbType.Varchar2).Value = row["imie"];
                                cmdPacjenci.Parameters.Add("nazwisko", OracleDbType.Varchar2).Value = row["nazwisko"];
                                cmdPacjenci.Parameters.Add("pesel", OracleDbType.Varchar2).Value = row["pesel"];
                                cmdPacjenci.Parameters.Add("data_urodzenia", OracleDbType.Date).Value = row["data_urodzenia"];

                                OracleParameter outParameter = new OracleParameter("pacjent_id", OracleDbType.Int32, ParameterDirection.Output);
                                cmdPacjenci.Parameters.Add(outParameter);
                                cmdPacjenci.ExecuteNonQuery();

                                int pacjentId = Convert.ToInt32(outParameter.Value.ToString());
                                row["pacjent_id"] = pacjentId;
                            }

                            string insertModeleQuery = "INSERT INTO modeleortodontyczne (pacjent_id, nr_modelu, data_wykonania) VALUES (:pacjent_id, :nr_modelu, :data_wykonania)";
                            using (OracleCommand cmdModele = new OracleCommand(insertModeleQuery, con))
                            {
                                cmdModele.Parameters.Add("pacjent_id", OracleDbType.Int32).Value = row["pacjent_id"];
                                cmdModele.Parameters.Add("nr_modelu", OracleDbType.Varchar2).Value = row["nr_modelu"];
                                cmdModele.Parameters.Add("data_wykonania", OracleDbType.Date).Value = row["data_wykonania"];
                                cmdModele.ExecuteNonQuery();
                            }
                        }
                    }

                    transaction.Commit();
                    MessageBox.Show("Zmiany zostały zapisane.");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Błąd podczas zapisywania zmian: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string connectionString = "User Id=msbd4;Password=haslo2024;Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=155.158.112.45)(PORT=1521)))(CONNECT_DATA=(SID=oltpstud)))";
            using (OracleConnection con = new OracleConnection(connectionString))
            {
                con.Open();
                string sqlQuery = "SELECT p.pacjent_id, p.imie, p.nazwisko, p.pesel, p.data_urodzenia, m.nr_modelu, m.data_wykonania FROM pacjenci p JOIN modeleortodontyczne m ON p.pacjent_id = m.pacjent_id";

                using (OracleCommand command = new OracleCommand(sqlQuery, con))
                {
                    using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                    {
                        dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
                con.Close();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e); 
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            button3_Click(sender, e);
        }

        private void guna2Button1_MouseEnter(object sender, EventArgs e)
        {
            guna2Button1.Cursor = Cursors.Hand;
        }

        private void guna2Button2_MouseEnter(object sender, EventArgs e)
        {
            guna2Button2.Cursor = Cursors.Hand;
        }

        private void guna2Button3_MouseEnter(object sender, EventArgs e)
        {
            guna2Button3.Cursor = Cursors.Hand;
        }
    }
}

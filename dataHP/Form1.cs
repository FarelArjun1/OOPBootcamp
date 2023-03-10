using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace dataHP
{
    public partial class Form1 : Form
    {
        MySqlConnection koneksi = connection.getConnection();
        DataTable dataTable = new DataTable();

        public DataTable getDataTable()
        {
            dataTable.Reset();
            dataTable = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM hp", koneksi))
            {
                koneksi.Open();

                MySqlDataReader reader = cmd.ExecuteReader();
                dataTable.Load(reader);
            }
            return dataTable;

        }

        // mengurutkan id
        public void resetIncrement()
        {
            MySqlScript script = new MySqlScript(koneksi, "SET @id :=0; Update hp SET id = @id := (@id+1); " + "ALTER TABLE hp AUTO_INCREMENT = 1;");
            script.Execute();
        }

        // fungsi mencari data
        public void searchData(string ValueToFind)
        {
            string searchQuery = "SELECT * FROM hp WHERE CONCAT (id, nama, jenis, stock) LIKE '%" + ValueToFind + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, koneksi);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView2.DataSource = table;
        }

        public void filldataTable()
        {
            dataGridView2.DataSource = getDataTable();

            DataGridViewButtonColumn colEditSarana = new DataGridViewButtonColumn();
            colEditSarana.UseColumnTextForButtonValue = true;
            colEditSarana.Text = "Edit";
            colEditSarana.Name = "";
            dataGridView2.Columns.Add(colEditSarana);   

            DataGridViewButtonColumn colDeleteSarana = new DataGridViewButtonColumn();
            colDeleteSarana.UseColumnTextForButtonValue = true;
            colDeleteSarana.Text = "Delete";
            colDeleteSarana.Name = "";
            dataGridView2.Columns.Add(colDeleteSarana);

            koneksi.Close();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filldataTable();
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;

            try
            {
                koneksi.Open();
                resetIncrement();
                cmd = koneksi.CreateCommand();
                cmd.CommandText = "INSERT INTO hp (nama, jenis, stock) VALUE(@nama, @jenis, @stock)";
                cmd.Parameters.AddWithValue("@nama", nama.Text);
                cmd.Parameters.AddWithValue("@jenis", jenis.Text);
                cmd.Parameters.AddWithValue("@stock", stock.Text);
                cmd.ExecuteNonQuery();
                koneksi.Close();
                dataGridView2.Columns.Clear();
                dataTable.Clear();
                filldataTable();
            }
            catch (Exception ex)
            {

            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                int id = Convert.ToInt32(dataGridView2.CurrentCell.RowIndex.ToString());
                id_hp.Text = dataGridView2.Rows[id].Cells[0].Value.ToString();
                nama.Text = dataGridView2.Rows[id].Cells[1].Value.ToString();
                jenis.Text = dataGridView2.Rows[id].Cells[2].Value.ToString();
                stock.Text = dataGridView2.Rows[id].Cells[3].Value.ToString();

                dataGridView2.Enabled = true;
            }

            if (e.ColumnIndex == 5)
            {
                int id = Convert.ToInt32(dataGridView2.CurrentCell.RowIndex.ToString());

                MySqlCommand cmd;
                koneksi.Open();

                try
                {
                    cmd = koneksi.CreateCommand();
                    cmd.CommandText = "DELETE FROM hp WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", dataGridView2.Rows[id].Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    resetIncrement();
                    koneksi.Close();
                    dataGridView2.Columns.Clear();
                    dataTable.Clear();
                    filldataTable(); 
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            koneksi.Open();

            try
            {
                cmd = koneksi.CreateCommand();
                cmd.CommandText = "UPDATE hp SET nama=@nama, jenis=@jenis, stock=@stock where id=@id";
                cmd.Parameters.AddWithValue("@id", id_hp.Text);
                cmd.Parameters.AddWithValue("@nama", nama.Text);
                cmd.Parameters.AddWithValue("@jenis", jenis.Text);
                cmd.Parameters.AddWithValue("@stock", stock.Text);
                cmd.ExecuteNonQuery();
                koneksi.Close();
                dataGridView2.Columns.Clear();
                dataTable.Clear();
                filldataTable();
            }
            catch (Exception ex)
            {

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
             
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchData(textBox1.Text);
        }
    }
}
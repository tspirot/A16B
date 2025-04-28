using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A16B
{
    public partial class Form1 : Form
    {
        SqlConnection konekcija=
            new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\A16.mdf;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopuniComboPasa();
            PopuniComboIzlozbe();
            PopuniComboKategorije();
        }

        private void PopuniComboKategorije()
        {
            string upit = "SELECT KategorijaID,CONCAT(KategorijaID,' - ',Naziv) AS Naziv " +
               "FROM Kategorija " +
               "ORDER BY KategorijaID ASC";
            SqlCommand cmd = new SqlCommand(upit, konekcija);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                adapter.Fill(dt);
                comboBoxKategorija.DataSource = dt;
                comboBoxKategorija.DisplayMember = "Naziv";
                comboBoxKategorija.ValueMember = "KategorijaID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska: " + ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
        }

        private void PopuniComboIzlozbe()
        {
            string upit= "SELECT IzlozbaID,CONCAT(IzlozbaID,' - ',Mesto,' - ',Datum) AS Izl " +
                "FROM Izlozba " +
                "ORDER BY IzlozbaID ASC";
            SqlCommand cmd = new SqlCommand(upit, konekcija);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                adapter.Fill(dt);
                comboBoxIzlozba.DataSource = dt;
                comboBoxIzlozba.DisplayMember = "Izl";
                comboBoxIzlozba.ValueMember = "IzlozbaID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska: " + ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
        }

        private void PopuniComboPasa()
        {
            string upit = "SELECT PasID,CONCAT(PasID,' - ',Ime) AS Naziv " +
                "FROM Pas " +
                "ORDER BY PasID ASC";
            SqlCommand cmd = new SqlCommand(upit, konekcija);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                adapter.Fill(dt);
                comboBoxPas.DataSource = dt;
                comboBoxPas.DisplayMember = "Naziv";
                comboBoxPas.ValueMember = "PasID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska: " + ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
        }
    }
}

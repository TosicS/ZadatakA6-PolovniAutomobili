using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ZadatakA6_PolovniAutomobili
{
    public partial class Form1 : Form
    {
        SqlConnection konekcija = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Skola\MATURA\Programiranje\ZadatakA6-PolovniAutomobili\ZadatakA6-PolovniAutomobili\A6 (1).mdf"";Integrated Security=True");
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        public void PrikaziLB()
        {
            string sqlUpit = "SELECT m.ModelID,m.Naziv,p.Naziv FROM Model AS m, Proizvodjac AS p WHERE p.ProizvodjacID=m.ProizvodjacID";

            SqlCommand cmd = new SqlCommand(sqlUpit,konekcija);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            dt.Clear();
            
            try
            {
                adapter.Fill(dt);
                listBoxModeliAutomobila.Items.Clear();

                foreach (DataRow dr in dt.Rows)
                {
                    listBoxModeliAutomobila.Items.Add(String.Format("{0,-6}", dr[0]) + dr[1] +", " + dr[2]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void PopuniComboB()
        {
            string sqlUpit = "SELECT ProizvodjacID, Naziv from Proizvodjac";

            SqlCommand cmd = new SqlCommand(sqlUpit, konekcija);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable tabela = new DataTable();

            try
            {
                adapter.Fill(tabela);

                comboBoxPrizovdjac.DataSource = tabela;
                comboBoxPrizovdjac.ValueMember = "ProizvodjacID";
                comboBoxPrizovdjac.DisplayMember = "Naziv";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            comboBoxPrizovdjac.SelectedIndex = -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PrikaziLB();
            PopuniComboB();
        }

        private void buttonPrikazi_Click(object sender, EventArgs e)
        {
            int id, i;
            if (int.TryParse(textBoxSifra.Text, out id))
            {
                for (i = 0; i < dt.Rows.Count && (int)dt.Rows[i][0] != id; i++) ;
                if (i < dt.Rows.Count)
                {
                    listBoxModeliAutomobila.SelectedIndex = i;
                    textBoxSifra.Text = dt.Rows[i][0].ToString();
                    textBoxNaziv.Text = dt.Rows[i][1].ToString();
                    comboBoxPrizovdjac.Text = dt.Rows[i][2].ToString();
                }
                else
                {
                    listBoxModeliAutomobila.SelectedIndex = -1;
                    textBoxNaziv.Text = "";
                    comboBoxPrizovdjac.Text = "";
                    textBoxSifra.Focus();
                    textBoxSifra.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("Greska u sifri!");
                textBoxSifra.Focus();
                textBoxSifra.SelectAll();
            }
        }

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBoxSifra.Text) != 0 && textBoxNaziv.Text != "" && comboBoxPrizovdjac.Text != "")
            {
                string sqlUpit = "Update Model set Naziv = @parNaziv, ProizvodjacID = @parID where ModelID = @parModel";
                SqlCommand cmd = new SqlCommand(sqlUpit, konekcija);
                cmd.Parameters.AddWithValue("@parModel", int.Parse(textBoxSifra.Text));
                cmd.Parameters.AddWithValue("@parID", (int)comboBoxPrizovdjac.SelectedValue);
                cmd.Parameters.AddWithValue("@parNaziv", textBoxNaziv.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                try
                {
                    konekcija.Open();
                    int index = listBoxModeliAutomobila.SelectedIndex;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Uspesno izmenjeni podaci");
                    PrikaziLB();
                    listBoxModeliAutomobila.SelectedIndex = index;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    konekcija.Close();
                }
            }
            
        }

        private void buttonIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //drugi tab
        private void buttonPrikaziF2_Click(object sender, EventArgs e)
        {
            if (textBoxKilometraza.Text != "" && int.Parse(textBoxKilometraza.Text) != 0)
            {
                string sqlUpit = "Select Proizvodjac.Naziv as Proizvodjac, count(Vozilo.VoziloID) as Broj " +
                "from Proizvodjac inner join Model on Proizvodjac.ProizvodjacID = Model.ProizvodjacID " +
                "inner join Vozilo on Vozilo.ModelID = Model.ModelID " +
                "where Vozilo.GodinaProizvodnje >= @od and Vozilo.GodinaProizvodnje <= @do and Vozilo.PredjenoKM <= @km " +
                "group by Proizvodjac.Naziv";

                SqlCommand cmd = new SqlCommand(sqlUpit, konekcija);

                cmd.Parameters.AddWithValue("@od", (int)numericUpDownOd.Value);
                cmd.Parameters.AddWithValue("@do", (int)numericUpDownDo.Value);
                cmd.Parameters.AddWithValue("@km", int.Parse(textBoxKilometraza.Text));

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                try
                {
                    adapter.Fill(tabela);
                    listView1.Items.Clear();

                    foreach (DataRow dr in tabela.Rows)
                    {
                        ListViewItem item = new ListViewItem(dr[0].ToString());
                        item.SubItems.Add(dr[1].ToString());
                        listView1.Items.Add(item);
                    }
                    chart1.DataSource = tabela;
                    chart1.Series[0].XValueMember = "Proizvodjac";
                    chart1.Series[0].YValueMembers = "Broj";
                    chart1.Series[0].IsValueShownAsLabel = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Unesite pređenu kilometražu !");
                textBoxKilometraza.Focus();
                return;
            }
        }

        //ne treba al neka ga ima
        private void listBoxModeliAutomobila_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxModeliAutomobila.SelectedItems.Count > 0)
            {
                textBoxSifra.Text = dt.Rows[listBoxModeliAutomobila.SelectedIndex][0].ToString();
                textBoxNaziv.Text = dt.Rows[listBoxModeliAutomobila.SelectedIndex][1].ToString();
                comboBoxPrizovdjac.Text = dt.Rows[listBoxModeliAutomobila.SelectedIndex][2].ToString();
            }
        }
    }
}

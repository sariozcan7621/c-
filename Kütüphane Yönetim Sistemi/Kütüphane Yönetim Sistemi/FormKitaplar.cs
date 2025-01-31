using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Yönetim_Sistemi
{
    public partial class FormKitaplar : Form
    {
        SqlConnection bağlanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=DbYTKütüphane;Integrated Security=True;Encrypt=False");

        public FormKitaplar()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void buttonKitapEkle_Click(object sender, EventArgs e)
        {



            try
            {

                bağlanti.Open();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO TableKitaplar (KitapAdi,YazarAdi,YazarSoyadi,ISBN,Durum,KitapTurKodu)VALUES(@P1,@P2,@P3,@P4,@P5,@P6)", bağlanti);
                sqlCommand.Parameters.AddWithValue("@P1", textKitapAdı.Text);
                sqlCommand.Parameters.AddWithValue("@P2", textYazarAdı.Text);
                sqlCommand.Parameters.AddWithValue("@P3", textYazarSoyadı.Text);
                sqlCommand.Parameters.AddWithValue("@P4", textISBN.Text);
                sqlCommand.Parameters.AddWithValue("@P5", true);
                sqlCommand.Parameters.AddWithValue("@P6", textKitapTürKodu.Text);

                sqlCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("kitap eklenince hata oluştu" + ex.Message);

            }
            finally
            {
                bağlanti.Close();
            }
            verileriGöster();
        }
        private void verileriGöster()
        {
            String q = "SELECT*FROM TableKitaplar";
            SqlDataAdapter da = new SqlDataAdapter(q, bağlanti);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dataGridViewKitaplar.DataSource = dt;

            }

        }
        private void FormKitaplar_Load(object sender, EventArgs e)
        {
            verileriGöster();

        }

        private void dataGridViewKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelGecikmeÜcreti.Text = "0";
            int secilenSatir = dataGridViewKitaplar.SelectedCells[0].RowIndex;

            ; labelIdD.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[0].Value.ToString();
            textKitapAdı.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[1].Value.ToString();
            textYazarAdı.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[2].Value.ToString();
            textYazarSoyadı.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[3].Value.ToString();
            textISBN.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[4].Value.ToString();
            textKitapTürKodu.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[8].Value.ToString();
            textBoxÖdünçAlan.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[6].Value.ToString();
            if (dataGridViewKitaplar.Rows[secilenSatir].Cells[7].Value != System.DBNull.Value)

                dateTimePickerÖdünçAlmaTarihi.Value = (System.DateTime)dataGridViewKitaplar.Rows[secilenSatir].Cells[7].Value;

        }

        private void buttonGüncelle_Click(object sender, EventArgs e)
        {
            bağlanti.Open();
            SqlCommand sqlCommand = new SqlCommand("UPDATE TableKitaplar SET KitapAdi=@P1,YazarAdi=@P2,YazarSoyadi=@P3,ISBN=@P4,KitapTurKodu=@P5 WHERE ID=@P6", bağlanti);
            try
            {
                sqlCommand.Parameters.AddWithValue("@P1", textKitapAdı.Text);
                sqlCommand.Parameters.AddWithValue("@P2", textYazarAdı.Text);
                sqlCommand.Parameters.AddWithValue("@P3", textYazarSoyadı.Text);
                sqlCommand.Parameters.AddWithValue("@P4", textISBN.Text);
                sqlCommand.Parameters.AddWithValue("@P5", textKitapTürKodu.Text);
                sqlCommand.Parameters.AddWithValue("@P6", labelIdD.Text);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("kitap güncellerken hata oluştu" + ex.Message);
            }
            finally
            {
                bağlanti.Close();
            }
            verileriGöster();


        }

        private void buttonKitapÖdünçVer_Click(object sender, EventArgs e)
        {
            if (labelIdD.Text != "--")
            {

                bağlanti.Open();
                SqlCommand sqlCommand = new SqlCommand("UPDATE TableKitaplar SET OduncAlan=@P1,OduncAlmaTarihi=@P2,Durum=@P3 WHERE ID=@P4", bağlanti);
                try
                {
                    sqlCommand.Parameters.AddWithValue("@P1", textBoxÖdünçAlan.Text);
                    sqlCommand.Parameters.Add("@P2", SqlDbType.Date).Value = dateTimePickerÖdünçAlmaTarihi.Value.Date;
                    sqlCommand.Parameters.AddWithValue("@P3", false);
                    sqlCommand.Parameters.AddWithValue("@P4", labelIdD.Text);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("kitap  ödünç işlemi sırasında hata oluştu" + ex.Message);
                }
                finally
                {
                    bağlanti.Close();
                }
                verileriGöster();


            }
            else
            {
                MessageBox.Show("Bir kitap seçiniz ");
            }
        }

        private void buttonGecikmeBedeliHesapla_Click(object sender, EventArgs e)
        {
            if (labelIdD.Text != "---")
            {
                DateTime bugününTarihi = DateTime.Now;
                int günFarkı = (int)(bugününTarihi - dateTimePickerÖdünçAlmaTarihi.Value.Date).TotalDays;
                if (günFarkı > 10)
                {
                    int gecikmeÜcreti = (günFarkı - 10) * 1;
                    labelGecikmeÜcreti.Text = gecikmeÜcreti.ToString();
                }

            }
        }

        private void buttonKitabıİadeEt_Click(object sender, EventArgs e)
        {

            if (labelIdD.Text != "---")
            {

                bağlanti.Open();
                SqlCommand sqlCommand = new SqlCommand("UPDATE TableKitaplar SET OduncAlan=@P1,OduncAlmaTarihi=@P2,Durum=@P3 WHERE ID=@P4", bağlanti);
                try
                {
                    sqlCommand.Parameters.AddWithValue("@P1", "");
                    sqlCommand.Parameters.Add("@P2", SqlDbType.Date).Value = System.DBNull.Value;
                    sqlCommand.Parameters.AddWithValue("@P3", false);
                    sqlCommand.Parameters.AddWithValue("@P4", labelIdD.Text);
                    sqlCommand.ExecuteNonQuery();
                    textBoxÖdünçAlan.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("kitap  iade işlemi sırasında hata oluştu" + ex.Message);
                }
                finally
                {
                    bağlanti.Close();
                }
                verileriGöster();



            }
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            metinKutularınıTemizle();
        }
        public void metinKutularınıTemizle()
        {
            labelIdD.Text = "";
            textKitapAdı.Text = "";
            textYazarAdı.Text = "";
            textYazarSoyadı.Text = "";
            textISBN.Text = "";
            textKitapTürKodu.Text = "";
            textBoxÖdünçAlan.Text = "";

        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            AramaSonuclarınıGöster();
        }
        private void AramaSonuclarınıGöster()
        {
            try
            {

                String q = "SELECT*FROM TableKitaplar WHERE KitapAdi LIKE '" + textKitapAdı.Text
                    + "%' And YazarAdi LIKE'" + textYazarAdı.Text + "%' "
                    + " And YazarSoyadi LIKE'" + textYazarSoyadı.Text + "%' "
                    + " And ISBN LIKE'" + textISBN.Text + "%' "
                    + " And KitapTurKodu LIKE'" + textKitapTürKodu.Text + "%' "
                    + " And OduncAlan LIKE'" + textBoxÖdünçAlan.Text + "%' ";
                SqlDataAdapter da = new SqlDataAdapter(q, bağlanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridViewKitaplar.DataSource = dt;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }

        private void buttonKitaplarıGöster_Click(object sender, EventArgs e)
        {
            verileriGöster();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (labelIdD.Text == "-" || labelIdD.Text == "")
            {
                MessageBox.Show("lütfen listeden silinecek kitabı sil");
            }
            else
            {



                try
                {
                    bağlanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("DELETE FROM TableKitaplar WHERE ID=@P1", bağlanti);
                    sqlCommand.Parameters.AddWithValue("@P1", labelIdD.Text);

                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("kitap  silinirken hata oluştu" + ex.Message);
                }
                finally
                {
                    bağlanti.Close();
                }
                verileriGöster();
                metinKutularınıTemizle();
            }
        }
    }
}
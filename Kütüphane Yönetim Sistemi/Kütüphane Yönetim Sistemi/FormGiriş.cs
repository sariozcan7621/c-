using Microsoft.Data.SqlClient;

namespace Kütüphane_Yönetim_Sistemi
{
    public partial class FormGiriş : Form
    {
        FormKitaplar formKitaplar;
        public FormGiriş()
        {
            InitializeComponent();
        }
        SqlConnection bağlanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=DbYTKütüphane;Integrated Security=True;Encrypt=False");
        private void buttonGiris_Click(object sender, EventArgs e)
        {

            String Şifre = "";
            try
            {
                bağlanti.Open();
                SqlCommand sqlKomut = new SqlCommand("SELECT Şifre FROM TableKütüphaneYöneticileri WHERE KullanıcıAdı=@p1 ", bağlanti);
                sqlKomut.Parameters.AddWithValue("@p1", textBoxKullaniciAdi.Text);
                SqlDataReader sqlDataReader = sqlKomut.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Şifre = sqlDataReader[0].ToString();
                }
                // label3.Text = Şifre;
                if (Şifre == textBoxSifre.Text)
                {

                    formKitaplar = new FormKitaplar();
                    formKitaplar.Show();
                }
                else
                {

                    MessageBox.Show("bağlantı hatası!");
                    textBoxKullaniciAdi.Text = " ";
                    textBoxSifre.Text = " ";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı Hatası" + ex.Message);
            }
            finally
            {
                bağlanti.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
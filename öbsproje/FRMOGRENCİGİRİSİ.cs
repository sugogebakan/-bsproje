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

namespace öbsproje
{
    public partial class FRMOGRENCİGİRİSİ : Form
    {

        SqlConnection baglanti=new SqlConnection("Data Source=sucomputer\\SQLEXPRESS;Initial Catalog=UNİNOTSİSTEMİVT;Integrated Security=True");
        public FRMOGRENCİGİRİSİ()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void TxtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (TxtSifre.UseSystemPasswordChar==true)
            {
                TxtSifre.UseSystemPasswordChar = false;
            }
            else if (TxtSifre.UseSystemPasswordChar==false)
            {
                TxtSifre.UseSystemPasswordChar=true;
            }
        }

        private void FRMOGRENCİGİRİSİ_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            if(baglanti.State==ConnectionState.Open)
            {
                MessageBox.Show("Bağlantı başarılı!");
            }
            else
            {
                MessageBox.Show("Hata!!!");
            }
            baglanti.Close();
            
            GuvenliKoduOlustur();
        }

        void GuvenliKoduOlustur()
        {
            Random rastgele=new Random();
            
            string karakterler = "0123456789qwertyuıopğüasdfghjklşizxcvbnmöçQWERTYUIOPĞÜASDFGHJKLŞİZXCVBNMÖÇ";
            string olustur = "";

            for (int i=0;i<4;i++)
            {
                olustur += karakterler[rastgele.Next(karakterler.Length)];
            }
            LblGuvenlikKodu.Text=olustur.ToString();
            TxtGuvenlik.Text=olustur.ToString();
        }

        private void PbDegistir_Click(object sender, EventArgs e)
        {
            GuvenliKoduOlustur();
        }

        private void TxtOgrNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            if(TxtOgrNo.Text!=""&&TxtSifre.Text!=""&&TxtGuvenlik.Text!="")
            {
                if(TxtOgrNo.TextLength<10)
                {
                    MessageBox.Show("Öğrenci Numarası 10 Haneli Olmalıdır");
                }
               

                else 
                {
                    if(TxtGuvenlik.Text==LblGuvenlikKodu.Text)
                    {
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Ogrenciler WHERE OGRNO=@P1 AND OGRSIFRE=@P2", baglanti);
                        komut.Parameters.AddWithValue("@P1", TxtOgrNo.Text);
                        komut.Parameters.AddWithValue("@P2",TxtSifre.Text);
                        SqlDataReader oku = komut.ExecuteReader();

                        if(oku.Read())
                        {
                            //MessageBox.Show(oku[3].ToString()+" " + oku[4].ToString());

                            string ogrenciAdi = oku["OGRAD"].ToString();
                            string ogrenciSoyadi = oku["OGRSOYAD"].ToString() ;
                            string ogrenciNumarası = oku["OGRNO"].ToString();



                            FRMOGRENCİANAFORM frm= new FRMOGRENCİANAFORM();
                            frm.ogrencininAdi=ogrenciAdi;
                            frm.ogrencininSoyadi=ogrenciSoyadi;
                            frm.ogrencininNumarasi=ogrenciNumarası;
                            frm.Show();
                            this.Hide();
                            //this.Close();
                           // Application.Exit();
                        }


                        else
                        {
                            MessageBox.Show("Kullanıcı Bulunamadı!!");
                        }
                        baglanti.Close();
                    }
                    else
                    {
                        MessageBox.Show("Güvenlik kodunu doğru giriniz!");
                    }
                }

            }
            else
            {
                MessageBox.Show("Lütfen Tüm Alanları doldurunuz!");
            }
        }

        private void BtnGirisYap_MouseMove(object sender, MouseEventArgs e)
        {
            BtnGirisYap.BackColor = Color.Red;
        }

        private void BtnGirisYap_MouseLeave(object sender, EventArgs e)
        {
            BtnGirisYap.BackColor = Color.FromArgb(38, 167, 73);
        }
    }
}

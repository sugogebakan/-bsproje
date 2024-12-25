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
    public partial class FRMOGRENCİANAFORM : Form
    {
        public FRMOGRENCİANAFORM()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=sucomputer\\SQLEXPRESS;Initial Catalog=UNİNOTSİSTEMİVT;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LBL_GenelOrt_Click(object sender, EventArgs e)
        {

        }

        private void LBL_OgrenciBolum_Click(object sender, EventArgs e)
        {

        }
        public string ogrencininNumarasi, ogrencininAdi, ogrencininSoyadi;

        private void FRMOGRENCİANAFORM_Load(object sender, EventArgs e)
        {
            Lbl_OgrenciAdiSoyadi.Text = ogrencininAdi + " " + ogrencininSoyadi;
            LBL_OgrenciNo.Text = ogrencininNumarasi;

            ogrenciBilgiGetir();

            Panel_Genel.Visible = false;
            ortalamaKontrol();
        }

        void ogrenciBilgiGetir()
        {
           baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Tbl_OgrenciDetay where OGRNO=@p1",baglanti);
            komut.Parameters.AddWithValue("@p1",ogrencininNumarasi);
            SqlDataReader dr=komut.ExecuteReader();
            if (dr.Read())
            {
                LBL_OgrenciFakulte.Text = dr["OGRFAKULTE"].ToString();
                LBL_OgrenciBolum.Text = dr["OGRBOLUM"].ToString();
                LBL_DonemOrt.Text = dr["OGRDONEM"].ToString();
                LBL_GenelOrt.Text = dr["OGRGENEL"].ToString();
                LBL_OgrenciSinifi.Text = dr["OGRSINIF"].ToString();
                
            }
           baglanti.Close();
        }
        void ortalamaKontrol()
        {
            double donemort= Convert.ToDouble(LBL_DonemOrt.Text);
         

            if (donemort < 2.00)
            {
                LBL_DonemOrt.ForeColor = Color.Red;
            }
            else
            {
                LBL_DonemOrt.ForeColor = Color.Green;
            }

            
        }

        private void PB_Ogrenci_Bilgi_Ekrani_Click(object sender, EventArgs e)
        {
            if(Panel_Genel.Visible==false)
            {
                Panel_Genel.Visible=true;
            }
            else
            {
                Panel_Genel.Visible = false;
            }

        }

        private void BTN_BilgiGuncelle_Click(object sender, EventArgs e)
        {
            FRMOGRENCİBİLGİGUNCELLE frm= new FRMOGRENCİBİLGİGUNCELLE();
            frm.ShowDialog();
            Panel_Genel.Visible = false;
        }

        private void BTN_BilgiGuncelle_MouseMove(object sender, MouseEventArgs e)
        {
            BTN_BilgiGuncelle.BackColor = Color.Orange;
        }

        private void BTN_BilgiGuncelle_MouseLeave(object sender, EventArgs e)
        {
            BTN_BilgiGuncelle.BackColor = Color.FromArgb(17, 28, 43);
        }

        private void PB_Ogrenci_Bilgi_Ekrani_MouseMove(object sender, MouseEventArgs e)
        {
            PB_Ogrenci_Bilgi_Ekrani.Image = Properties.Resources.multiple_users_silhouette;
        }

        private void PB_Ogrenci_Bilgi_Ekrani_MouseLeave(object sender, EventArgs e)
        {
           // PB_Ogrenci_Bilgi_Ekrani.Image = Properties.Resources.user;
           if (Panel_Genel.Visible==false)
            {
                PB_Ogrenci_Bilgi_Ekrani.Image = Properties.Resources.multiple_users_silhouette;
            }
            else
            {
                PB_Ogrenci_Bilgi_Ekrani.Image = Properties.Resources.user;
            }
        }
    }
}

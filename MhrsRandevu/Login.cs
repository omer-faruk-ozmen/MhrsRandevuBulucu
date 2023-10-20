using System;
using Newtonsoft.Json;
using System.Linq;
using System.Windows.Forms;
using MhrsRandevu.Entities.SignIn;

namespace MhrsRandevu
{
    public partial class Login : Form
    {
        [System.Runtime.InteropServices.DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);
        public Login()
        {
            if (!CheckNet())
            {
                MessageBox.Show("Lütfen internet bağlantısını yaptıktan sonra tekrar deneyin.", "İnternet bağlantısı tespit edilemedi...");
                this.Close();
            }

            InitializeComponent();
        }

        public static bool CheckNet()
        {
            int desc;
            return InternetGetConnectedState(out desc, 0);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Entities.Login body = new Entities.Login()
            {
                captchaKey = null,
                girisTipi = "PAROLA",
                islemKanali = "VATANDAS_WEB",
                kullaniciAdi = Convert.ToInt64(maskedTb_Identity.Text),
                parola = tb_Password.Text,
            };

            var result = LoginRequest(body, "https://prd.mhrs.gov.tr/api/vatandas/login");

            LoginReturned login = JsonConvert.DeserializeObject<LoginReturned>(result);

            if (login.success)
            {
                MessageBox.Show("Giriş başarılı randevu sayfasına yönlendiriliyorsunuz...", "Başarılı");
                AppointmentPage appPage = new AppointmentPage();
                appPage.LoginUser = login.data;
                appPage.ShowDialog();
         
            }
            else if (login.success == false)
            {
                MessageBox.Show("mesaj : " + login.errors.First().mesaj, "Beklenmedik bir sorun ile karşılaşıldı!!");
                return;
            }

        }

        private string LoginRequest(object body, string url)
        {
            Request newRequest = new Request();

            var result = newRequest.Post(body, url);

            return result;
        }
    }
}

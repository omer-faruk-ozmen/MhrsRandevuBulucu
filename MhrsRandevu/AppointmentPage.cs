using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using MhrsRandevu.Entities.Appointment;
using MhrsRandevu.Entities.Cities;
using MhrsRandevu.Entities.Clinics;
using MhrsRandevu.Entities.Hospitals;
using Newtonsoft.Json;

namespace MhrsRandevu
{
    public partial class AppointmentPage : Form
    {
        public Entities.SignIn.Data LoginUser = null;

        [System.Runtime.InteropServices.DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);

        public AppointmentPage()
        {
            InitializeComponent();

            var isConnectionActive = CheckNet();
            if (!isConnectionActive)
            {
                cbCities.Enabled = false;
                cbDistricts.Enabled = false;
                cbClinics.Enabled = false;
                cbHospitals.Enabled = false;
                btnStart.Enabled = false;
                btnStart.BackColor = Color.Gray;
                trackBarMinute.Enabled = false;
                lblNetStatus.Text = "Bağlantı yok";
                btnStop.Hide();
                MessageBox.Show("İnternet Bağlantısı tespit edilemedi", "Bir Sorunla Karşılaşıldı!");
                return;
            }

            lblNetStatus.Text = "Bağlı";
            lblAppointmentCycle.Text = "Pasif";

        }

        private void trackBarMinute_Scroll(object sender, EventArgs e)
        {
            lblCycle.Text = $"Çalışma Sıklığı {trackBarMinute.Value} Dakikada Bir...";
        }

        public static bool CheckNet()
        {
            int desc;
            return InternetGetConnectedState(out desc, 0);
        }



        private void GetCities()
        {
            string url = "https://prd.mhrs.gov.tr/api/yonetim/genel/il/selectinput-tree";

            Request request = new Request();

            var result = request.Get(url, new Dictionary<string, string>()
            {
                {"Authorization","Bearer " + LoginUser.jwt}
            });

            List<City> cities = JsonConvert.DeserializeObject<List<City>>(result);

            cbCities.Items.Clear();

            foreach (var city in cities)
            {
                cbCities.Items.Add(new ComboBoxData { Id = city.value, Display = city.text });

                if (city.children.Count > 0)
                {
                    foreach (var cityChild in city.children)
                    {
                        cbCities.Items.Add(new ComboBoxData { Id = cityChild.value, Display = cityChild.text });
                    }
                }
            }
        }

        private void GetDistricts(int cityId)
        {
            string url = $"https://prd.mhrs.gov.tr/api/yonetim/genel/ilce/selectinput/{cityId}";
            Request request = new Request();


            var result = request.Get(url, new Dictionary<string, string>()
            {
                {"Authorization","Bearer " + LoginUser.jwt}
            });

            List<District> districts = JsonConvert.DeserializeObject<List<District>>(result);

            cbDistricts.Items.Clear();

            foreach (var district in districts)
            {
                cbDistricts.Items.Add(new ComboBoxData { Id = Int16.Parse(district.value), Display = district.text });
            }
        }


        private void GetClinics(int cityId, int districtId = -1)
        {
            string url = $"https://prd.mhrs.gov.tr/api/kurum/kurum/kurum-klinik/il/{cityId}/ilce/{districtId}/kurum/-1/aksiyon/200/select-input";

            Request request = new Request();


            var result = request.Get(url, new Dictionary<string, string>()
            {
                {"Authorization","Bearer " + LoginUser.jwt}
            });

            Result clinics = JsonConvert.DeserializeObject<Result>(result);

            cbClinics.Items.Clear();
            foreach (var clinic in clinics.data)
            {
                cbClinics.Items.Add(new ComboBoxData() { Id = clinic.value, Display = clinic.text });
            }

        }

        private void GetHospitals(int cityId, int clinicId, int districtId = -1)
        {
            string url = $"https://prd.mhrs.gov.tr/api/kurum/kurum/kurum-klinik/il/{cityId}/ilce/{districtId}/kurum/-1/klinik/{clinicId}/ana-kurum/select-input";

            Request request = new Request();

            var result = request.Get(url, new Dictionary<string, string>()
            {
                {"Authorization","Bearer " + LoginUser.jwt}
            });

            ReturnHospital hospitals = JsonConvert.DeserializeObject<ReturnHospital>(result);

            cbHospitals.Items.Clear();
            foreach (var hospital in hospitals.data)
            {
                cbHospitals.Items.Add(new ComboBoxData() { Id = hospital.value, Display = hospital.text });
            }
        }

        private class ComboBoxData
        {
            public int Id { get; set; }
            public string Display { get; set; }
        }

        private void cbCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxData selectedItem = cbCities.Items[cbCities.SelectedIndex] as ComboBoxData;

            GetDistricts(selectedItem.Id);
            GetClinics(selectedItem.Id);
            if (cbCities.SelectedIndex < 0 || cbCities.Text == "")
            {
                cbDistricts.Enabled = false;
                cbClinics.Enabled = false;
                cbHospitals.Enabled = false;
                btnStart.Enabled = false;
                btnStart.BackColor = Color.Gray;
                trackBarMinute.Enabled = false;
                return;
            }
            cbDistricts.Enabled = true;
            cbClinics.Enabled = true;
        }

        private void cbDistricts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxData selectedCity = cbCities.Items[cbCities.SelectedIndex] as ComboBoxData;

            if (cbDistricts.SelectedIndex < 0 || cbDistricts.Text == "")
            {
                GetClinics(selectedCity.Id);
                cbHospitals.Enabled = true;
                btnStart.Enabled = true;
                btnStart.BackColor = Color.LimeGreen;
                trackBarMinute.Enabled = true;
                return;
            }
            ComboBoxData selectedDistrict = cbDistricts.Items[cbDistricts.SelectedIndex] as ComboBoxData;
            cbClinics.Text = "";
            cbHospitals.Text = "";
            GetClinics(selectedCity.Id, selectedDistrict.Id);
            cbHospitals.Enabled = true;
            btnStart.Enabled = true;
            btnStart.BackColor = Color.LimeGreen;
            trackBarMinute.Enabled = true;
        }

        private void cbClinics_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxData selectedCity = cbCities.Items[cbCities.SelectedIndex] as ComboBoxData;
            ComboBoxData selectedClinic = cbClinics.Items[cbClinics.SelectedIndex] as ComboBoxData;

            if (cbDistricts.SelectedIndex < 0 || cbDistricts.Text == "")
            {
                cbHospitals.Text = "";
                GetHospitals(selectedCity.Id, selectedClinic.Id);
                cbHospitals.Enabled = true;
                btnStart.Enabled = true;
                btnStart.BackColor = Color.LimeGreen;
                trackBarMinute.Enabled = true;
                return;
            }

            cbHospitals.Text = "";
            ComboBoxData selectedDistrict = cbDistricts.Items[cbDistricts.SelectedIndex] as ComboBoxData;
            GetHospitals(selectedCity.Id, selectedClinic.Id, selectedDistrict.Id);
            cbHospitals.Enabled = true;
            btnStart.Enabled = true;
            btnStart.BackColor = Color.LimeGreen;
            trackBarMinute.Enabled = true;
        }

        private ReturnAppointment GetAppointment(int cityId, int clinicId, int districtId, int hospitalId)
        {
            var body = new GetAppointment()
            {
                mhrsIlId = cityId,
                mhrsIlceId = districtId,
                mhrsKlinikId = clinicId,
                mhrsKurumId = hospitalId
            };

            var jsonBody = JsonConvert.SerializeObject(body);
            var data = new StringContent(jsonBody, Encoding.UTF8, "application/json");

            string url = "https://prd.mhrs.gov.tr/api/kurum-rss/randevu/slot-sorgulama/arama";

            Request request = new Request();
            var result = request.Post(body, url, new Dictionary<string, string>()
            {
                { "Authorization", "Bearer " + LoginUser.jwt }
            });

            ReturnAppointment appointment = JsonConvert.DeserializeObject<ReturnAppointment>(result);
            return appointment;
        }


        private int GetByObjectId(object obj)
        {
            var property = obj.GetType().GetProperty("Id").GetValue(obj, null);
            return Convert.ToInt32(property);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cbCities.SelectedIndex == -1 || cbClinics.SelectedIndex == -1)
            {
                MessageBox.Show("Şehir veya Klinik adı boş olamaz", "Hata!");
                return;
            }

            appointmentCycle.Interval = trackBarMinute.Value * 1000 * 60;
            appointmentCycle.Start();
            btnStart.Enabled = false;
            btnStart.Hide();
            btnStop.Show();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStop.Hide();
            appointmentCycle.Stop();
            lblAppointmentCheck.Text = "Pasif";
            btnStart.Show();
        }

        private void appointmentCycle_Tick(object sender, EventArgs e)
        {
            var selectedCityId = cbCities.SelectedIndex == -1 ? -1 : GetByObjectId(cbCities.Items[cbCities.SelectedIndex]);
            var selectedDistrictId = cbDistricts.SelectedIndex == -1 ? -1
                : GetByObjectId(cbDistricts.Items[cbDistricts.SelectedIndex]);
            var selectedClinicId = cbClinics.SelectedIndex == -1 ? -1 : GetByObjectId(cbClinics.Items[cbClinics.SelectedIndex]);
            var selectedHospitalId = cbHospitals.SelectedIndex == -1 ? -1 : GetByObjectId(cbHospitals.Items[cbHospitals.SelectedIndex]);

            if (!CheckNet())
            {
                lblNetStatus.Text = "Başarısız";
                lblAppointmentCycle.Text = "Pasif";
                return;
            }

            lblAppointmentCycle.Text = "Aktif";
            lblNetStatus.Text = "Bağlı";
            ReturnAppointment appointment =
                GetAppointment(selectedCityId, selectedClinicId, selectedDistrictId, selectedHospitalId);

            if (appointment != null && appointment.success)
            {
                foreach (var hastane in appointment.data.hastane)
                {
                    lb_Information.Items.Add($"------------ Randevu Bulundu ------------");
                    lb_Information.Items.Add($"Hastane : {hastane.kurum.kurumAdi}");
                    lb_Information.Items.Add(
                        $"Klinik : {hastane.muayeneYeri.adi}");
                    lb_Information.Items.Add($"Adres : {hastane.kurum.ilIlce.ilceAdi} / {hastane.kurum.ilIlce.ilAdi}");
                }
                cbCities.Enabled = true;
                cbDistricts.Enabled = false;
                cbClinics.Enabled = false;
                cbHospitals.Enabled = false;
                btnStart.Enabled = false;
                btnStart.BackColor = Color.Gray;
                trackBarMinute.Enabled = false;
                btnStop.Hide();
                btnStart.Show();
                SoundPlayer audio = new SoundPlayer(Properties.Resources.notificationSound);
                audio.Play();
                appointmentCycle.Stop();
                lblAppointmentCycle.Text = "Pasif";
            }

            if (appointment.success == false)
            {
                foreach (var error in appointment.errors)
                {
                    lb_Information.Items.Add($"{error.kodu} Aradığınız kriterlere uygun randevu bulunamamıştır.");
                }
            }
        }

        private void AppointmentPage_Load(object sender, EventArgs e)
        {
            GetCities();
            lblAuthName.Text = LoginUser.kullaniciAdi + " " + LoginUser.kullaniciSoyadi;

            TokenHelper tokenHelper = new TokenHelper();
            lblAuthExpiry.Text = tokenHelper.GetExpiryTimestamp(LoginUser.jwt).ToString();

            cbCities.Enabled = true;
            cbDistricts.Enabled = false;
            cbClinics.Enabled = false;
            cbHospitals.Enabled = false;
            btnStart.Enabled = false;
            btnStart.BackColor = Color.Gray;
            trackBarMinute.Enabled = false;
            btnStop.Hide();
            trackBarMinute.Scroll += new EventHandler(trackBarMinute_Scroll);
        }
    }
}

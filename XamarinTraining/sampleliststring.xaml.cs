using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinTraining
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class sampleliststring : ContentPage
    {
        public sampleliststring()
        {
            InitializeComponent();

            List<string> listkota = new List<string>
            {
                "Jakarta","Bandung","Yogyakarta","Surabaya"
            };

            lvkota.ItemsSource = listkota;
        }

        private async void lvkota_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //tambah async karena data yang di hasilkan / display alert adalah taskpage, 
            //sehingga metode yang diminta ada jenis async (await=async)
            var selectedcity = (string)e.Item;
            await DisplayAlert("Informasi", $"Data yang dipilih: {selectedcity}", "OK");
            
        }
    }
}
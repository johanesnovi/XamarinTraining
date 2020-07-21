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
    public partial class samplegridlayout : ContentPage
    {
        public samplegridlayout()
        {
            InitializeComponent();

            List<string> listkota = new List<string>();
            listkota.Add("Jakarta");
            listkota.Add("Bandung");
            listkota.Add("Surabaya");
            pickercity.ItemsSource = listkota;
        }

        private void btntambah_Clicked(object sender, EventArgs e)
        {
            var bil1 = Convert.ToDouble(entrybil1.Text);
            var bil2 = Convert.ToDouble(entrybil2.Text);
            var hasil = bil1 + bil2;
            entryhasil.Text = hasil.ToString();
        }

        private void btnproses_Clicked(object sender, EventArgs e)
        {
            var bil1 = Convert.ToDouble(entrybil1.Text);
            var bil2 = Convert.ToDouble(entrybil2.Text);
            double hasil = 0 ;

            var btn = (Button)sender;

            switch (btn.Text)
            {
                case "+":
                    hasil = bil1 + bil2;
                    break;
                case "-":
                    hasil = bil1 - bil2;
                    break;
                case "/":
                    hasil = bil1 / bil2;
                    break;
                case "x":
                    hasil = bil1 * bil2;
                    break;
            }
            entryhasil.Text = hasil.ToString();
        }

        private void btnreset_Clicked(object sender, EventArgs e)
        {
            entrybil1.Text = null;
            entrybil2.Text = null;
            entryhasil.Text = null;
        }
    }
}
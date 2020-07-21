using XamarinTraining.Models;
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
    public partial class samplelistbinding : ContentPage
    {
        public samplelistbinding()
        {
            InitializeComponent();

            List<ListItem> lstitems = new List<ListItem>();
            lstitems.Add(new ListItem
            {
                title = "satu",
                description ="satu-satu"
            }) ;
            lstitems.Add(new ListItem
            {
                title = "dua",
                description = "dua-satu"
            });
            lvdata.ItemsSource = lstitems;
        }
    }
}
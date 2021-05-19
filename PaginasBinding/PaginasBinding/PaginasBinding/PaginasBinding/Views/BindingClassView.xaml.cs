using PaginasBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PaginasBinding.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BindingClassView : ContentPage
    {
        public BindingClassView()
        {
            InitializeComponent();
            Coche car = new Coche();
            car.Marca = "VW";
            car.Modelo = "Golf";
            car.Velocidad = 280;
            car.Imagen = "https://images1.autocasion.com/unsafe/1200x800/actualidad/wp-content/uploads/2020/10/volkswagen-golf-gti-clubsport-1.jpg";
            this.BindingContext = car;
        }
    }
}
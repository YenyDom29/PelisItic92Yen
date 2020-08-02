using PelisItic92Yen.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PelisItic92Yen
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private IList<Pelicula> peliculas = new ObservableCollection<Pelicula>();
        private PeliculaDirector director = new PeliculaDirector();
        public MainPage()
        {
            BindingContext = peliculas;
            InitializeComponent();
            Refresh();
        }

        async public void Refrescar(object sender, EventArgs e)
        {
            Refresh();
        }

        async private void Refresh()
        { 

            var peliculasCollection = await director.GetAll();
            foreach (Pelicula pelicula in peliculasCollection)
            {
                if(peliculas.All(t => t.Id != pelicula.Id))
                {
                    peliculas.Add(pelicula);
                }
                
            }
        }

        async public void OnAddPelicula(object sender, EventArgs e) 
        {
            await Navigation.PushAsync(new AddPelicula(director));
        }

    }
}


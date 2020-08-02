using PelisItic92Yen.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PelisItic92Yen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddPelicula : ContentPage
    {

        private PeliculaDirector director;
        private Pelicula pelicula;
        public AddPelicula(PeliculaDirector director, Pelicula pelicula = null)

          
        {
            InitializeComponent();
            this.pelicula = pelicula;
            this.director = director;
           
        }

        async public void OnSavePelicula(object sender, EventArgs e)
        {
            await director.Add(txtTitulo.Text, txtGenero.Text, txtDirector.Text, txtAnio.Text);
        }
    }
}
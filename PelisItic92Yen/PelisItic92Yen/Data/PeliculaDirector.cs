using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PelisItic92Yen.Data
{
    public class PeliculaDirector
    {
        const string url = "http://192.168.1.69:3000/peliculas/";
        public async Task<IEnumerable<Pelicula>> GetAll()
        {
            HttpClient client = new HttpClient();
            string result = await client.GetStringAsync(url);
            return JsonConvert.DeserializeObject<IEnumerable<Pelicula>>(result);
        }
        public async Task<Pelicula> Add(string titulo, string genero, string director, string anio )
        {
            Pelicula pelicula = new Pelicula()
            {
                Titulo = titulo,
                Genero = genero,
                Director = director,
                Anio = anio

            };

            HttpClient client = new HttpClient();
            var response = await client.PostAsync(url, 
                new StringContent(JsonConvert.SerializeObject(pelicula), Encoding.UTF8,
                "application/json"));

            return JsonConvert.DeserializeObject<Pelicula>(
                await response.Content.ReadAsStringAsync());
            }
        }

    }

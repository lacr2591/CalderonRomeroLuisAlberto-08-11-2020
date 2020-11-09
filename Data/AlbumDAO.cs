using System;
using System.Collections.Generic;
using System.Text;
using Entity.Entidades;
using Entity.Contratos;
using Newtonsoft.Json;

namespace Data
{
    public class AlbumDAO : IAlbumDAO
    {
        JsonContext jsonContext = new JsonContext();
        public List<Album> GetAlbums()
        {
            var urlAPI = jsonContext.ObtenerJson("https://jsonplaceholder.typicode.com/albums");
            List<Album> albumes = JsonConvert.DeserializeObject<List<Album>>(urlAPI);

            return albumes;
        }
    }
}

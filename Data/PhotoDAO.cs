using System;
using System.Collections.Generic;
using System.Text;
using Entity.Entidades;
using Entity.Contratos;
using System.Linq;
using Newtonsoft.Json;

namespace Data
{
    public class PhotoDAO : IPhotoDAO
    {
        JsonContext jsonContext = new JsonContext();
        public List<Photo> GetPhotoByIdAlbum(int idAlbum)
        {
            List<Photo> photos;
            photos = GetPhotos().Where(photo => photo.AlbumId == idAlbum).ToList();

            return photos;
        }

        public List<Photo> GetPhotos()
        {
            var json = jsonContext.ObtenerJson("https://jsonplaceholder.typicode.com/photos");
            List<Photo> photos = JsonConvert.DeserializeObject<List<Photo>>(json);
            return photos;
        }
    }
}

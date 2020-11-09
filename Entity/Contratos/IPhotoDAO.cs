using System;
using System.Collections.Generic;
using Entity.Entidades;

namespace Entity.Contratos
{
    public interface IPhotoDAO
    {
        List<Photo> GetPhotos();
        List<Photo> GetPhotoByIdAlbum(int idAlbum);
    }
}

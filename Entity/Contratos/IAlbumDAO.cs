using System;
using System.Collections.Generic;
using Entity.Entidades;

namespace Entity.Contratos
{
    public interface IAlbumDAO
    {
        List<Album> GetAlbums();
    }
}

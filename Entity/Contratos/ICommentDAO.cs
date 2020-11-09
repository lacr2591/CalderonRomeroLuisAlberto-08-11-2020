using System;
using System.Collections.Generic;
using Entity.Entidades;

namespace Entity.Contratos
{
    public interface ICommentDAO
    {
        List<Comment> getCommentsByIdPhoto(int idPhoto);
    }
}

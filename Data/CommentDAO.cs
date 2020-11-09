using System;
using System.Collections.Generic;
using System.Text;
using Entity.Entidades;
using Entity.Contratos;
using Newtonsoft.Json;

namespace Data
{
    public class CommentDAO : ICommentDAO
    {
        JsonContext jsonContext = new JsonContext();
        public List<Comment> getCommentsByIdPhoto(int idPhoto)
        {
            var json = jsonContext.ObtenerJson("https://jsonplaceholder.typicode.com/comments?postId="+idPhoto);

            List<Comment> comentarios = new List<Comment>();
            comentarios= JsonConvert.DeserializeObject<List<Comment>>(json);

            return comentarios;
        }
    }
}

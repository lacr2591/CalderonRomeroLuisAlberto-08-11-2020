using System;

namespace Entity.Entidades
{
    public class Comment
    {
        private int postId;
        private int id;
        private string name;
        private string email;
        private string body;

        public int PostId { get => postId; set => postId = value; }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Body { get => body; set => body = value; }
    }
}

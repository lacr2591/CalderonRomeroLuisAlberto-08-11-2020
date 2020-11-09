using System;

namespace Entity.Entidades
{
    public class Album
    {
        private int userId;
        private int id;
        private string title;

        public int UserId { get => userId; set => userId = value; }
        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
    }
}

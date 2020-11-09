using System;

namespace Entity.Entidades
{
    public class Photo
    {
        private int albumId;
        private int id;
        private string title;
        private string url;
        private string thumbnailUrl;

        public int AlbumId { get => albumId; set => albumId = value; }
        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Url { get => url; set => url = value; }
        public string ThumbnailUrl { get => thumbnailUrl; set => thumbnailUrl = value; }
    }
}

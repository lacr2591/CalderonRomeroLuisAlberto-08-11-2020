using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Entity.Entidades;
using Data;

namespace MyProyect.Controllers
{
    public class PhotosController : Controller
    {
        PhotoDAO photoDAO = new PhotoDAO();

        [HttpGet]
        public IActionResult Index(int albumId)
        {
            List<Photo> photos = new List<Photo>();
            photos = photoDAO.GetPhotoByIdAlbum(albumId);
            ViewBag.IdAlbum = albumId;
            return View(photos);
        }
    }
}
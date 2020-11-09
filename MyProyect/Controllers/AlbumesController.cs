using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Data;
using Entity.Entidades;


namespace MyProyect.Controllers
{
    public class AlbumesController : Controller
    {
        Album album = new Album();
        AlbumDAO albumDAO = new AlbumDAO();
        public IActionResult Index()
        {

            return View(albumDAO.GetAlbums());
        }
    }
}
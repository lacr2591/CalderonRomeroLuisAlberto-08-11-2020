﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Entity.Entidades;
using Data;

namespace MyProyect.Controllers
{
    public class CommentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult ObtenerComentarios(int idPhoto)
        {
            CommentDAO commentDAO = new CommentDAO();
            List<Comment> comentarios = commentDAO.getCommentsByIdPhoto(idPhoto);


            return PartialView("Comentarios",comentarios);
        }
    }
}
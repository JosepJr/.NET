﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContatoWeb.Models;


namespace ContatoWeb.Controllers
{
    public class ContatoController : Controller{
        public ActionResult Index(){
            using (ContatoModel model = new ContatoModel()) {
                List<Contato> Lista = model.Read;
                return View(Lista);
            }            
        }

        [HttpGet]
        public ActionResult Create(FormCollection form){
            Contato contato = new Contato();
            contato.Nome = form["Nome"];
            contato.Email = form["Email"];

            using (ContatoModel model = new ContatoModel()){
                model.Create(contato);
                return RedirectToAction("Index");
            }
        }
    }
}
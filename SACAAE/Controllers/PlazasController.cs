﻿using SACAAE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace SACAAE.Controllers
{
    public class PlazasController : Controller
    {
        //
        // GET: /Plazas/

        private const string TempDataMessageKey = "Message";
        private RepositorioPlazas repositorio = new RepositorioPlazas();

        [Authorize]
        public ActionResult Index()
        {
            var model = repositorio.ObtenerTodasPlazas();
            return View(model);
        }

        //
        // GET: /Plazas/Details/5
        [Authorize]
        public ActionResult Detalles(int id)
        {
            var model = repositorio.ObtenerPlaza(id);
            return View(model);
        }

        //
        // GET: /Plazas/Create
        [Authorize]
        public ActionResult Crear()
        {
            var model = new Plaza();
            return View(model);
        }

        //
        // POST: /Plazas/Create
        [Authorize]
        [HttpPost]
        public ActionResult Crear(Plaza nuevaPlaza)
        {
            repositorio.CrearPlaza(nuevaPlaza.Codigo_Plaza, nuevaPlaza.Tipo_de_plaza, nuevaPlaza.Tipo_segun_tiempo, nuevaPlaza.Horas_Totales, nuevaPlaza.Tiempo_de_vigencia);
            TempData[TempDataMessageKey] = "Plaza creada correctamente.";
            return RedirectToAction("Index");
        }

        //
        // GET: /Plazas/Edit/5
        [Authorize]
        public ActionResult Editar(int id)
        {
            var model = repositorio.ObtenerPlaza(id);
            return View(model);
        }

        //
        // POST: /Plazas/Edit/5
        [Authorize]
        [HttpPost]
        public ActionResult Editar(Plaza plaza)
        {
            if (ModelState.IsValid)
            {
                repositorio.Actualizar(plaza);
                TempData[TempDataMessageKey] = "Plaza editada correctamente";
            }
            return RedirectToAction("Index");
        }

        //
        // GET: /Plazas/Delete/5
        [Authorize]
        public ActionResult Eliminar(int id)
        {
            var model = repositorio.ObtenerPlaza(id);
            return View(model);
        }

        //
        // POST: /Plazas/Delete/5
        [Authorize]
        [HttpPost]
        public ActionResult Eliminar(Plaza plaza)
        {
            repositorio.BorrarPlaza(plaza);
            TempData[TempDataMessageKey] = "Plaza eliminada correctamente";
            return RedirectToAction("Index");
        }
    }
}
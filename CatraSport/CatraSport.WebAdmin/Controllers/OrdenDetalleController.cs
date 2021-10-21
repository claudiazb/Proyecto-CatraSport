using CatraSport.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CatraSport.WebAdmin.Controllers
{
    public class OrdenDetalleController : Controller
    {
        OrdenesBL _ordenBL;

        public OrdenDetalleController()
        {
            _ordenBL = new OrdenesBL();
           
        }

        // GET: OrdenesDetalles
        public ActionResult Index(int id)
        {
            var orden = _ordenBL.ObtenerOrden(id);
            
            return View(orden);
        }
    }
}
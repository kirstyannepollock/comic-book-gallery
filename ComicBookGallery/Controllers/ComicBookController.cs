using ComicBookGallery.Data;
using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers 
{
    public class ComicBookController : Controller
    {
        public ActionResult Detail(int? iD)
        {
            if (iD == null)
            {
                return HttpNotFound();
            };

            ComicBook comic = ComicBookRepository.GetComicBook((int)iD);

            if (comic == default(ComicBook))
            {
                return HttpNotFound();
            };

            return View(comic);
        }

      
    }
}
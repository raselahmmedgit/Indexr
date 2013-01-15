using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Indexr.Domain;
using Indexr.DomainView;
using Indexr.Service;

namespace Indexr.Web.Controllers
{
    //[System.Web.Mvc.OutputCache(NoStore = true, Duration = 0, VaryByParam = "*")]
    public class IndexrController : Controller
    {
        #region Global Variable Declaration

        private readonly IContactInfoService _iContactInfoService;

        #endregion

        #region Constructor

        public IndexrController(IContactInfoService iContactInfoService)
        {
            this._iContactInfoService = iContactInfoService;
        }

        #endregion

        #region Action Methods

        public ActionResult Details(int id)
        {
            //return View();
            return PartialView("_Details");
        }

        public ActionResult Add()
        {
            //return View();
            //return PartialView("_Add");
            return View("_Add");
        }

        [HttpPost]
        public ActionResult Add(ContactInfoViewModel viewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (_iContactInfoService.Create(viewModel) > 0)
                    {
                        return Json(new { msg = "Data saved successfully.", status = MessageType.success.ToString() }, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        return Json(new { msg = "Data could not saved.", status = MessageType.notice.ToString() }, JsonRequestBehavior.AllowGet);
                    }

                }

                return Json(new { msg = ExceptionHelper.ModelStateErrorFormat(ModelState), status = MessageType.notice.ToString() }, JsonRequestBehavior.AllowGet);

            }
            catch (Exception ex)
            {
                return Json(new { msg = ExceptionHelper.ExceptionMessageFormat(ex, log: true), status = MessageType.error.ToString() }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult Edit(int id)
        {
            //var model=
            //return View();
            return PartialView("_Edit");
        }

        [HttpPost]
        public ActionResult Edit(int id, ContactInfoViewModel viewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ContactInfoViewModel editViewModel = _iContactInfoService.GetContactInfo(id);
                    if (editViewModel != null)
                    {
                        if (_iContactInfoService.Create(editViewModel) > 0)
                        {
                            return Json(new { msg = "Data updated successfully.", status = MessageType.success.ToString() }, JsonRequestBehavior.AllowGet);
                        }
                        else
                        {
                            return Json(new { msg = "Data could not updated.", status = MessageType.notice.ToString() }, JsonRequestBehavior.AllowGet);
                        }

                    }

                    return Json(new { msg = "This data are missing.", status = MessageType.notice.ToString() }, JsonRequestBehavior.AllowGet);
                }

                return Json(new { msg = ExceptionHelper.ModelStateErrorFormat(ModelState), status = MessageType.notice.ToString() }, JsonRequestBehavior.AllowGet);

            }
            catch (Exception ex)
            {
                return Json(new { msg = ExceptionHelper.ExceptionMessageFormat(ex, log: true), status = MessageType.error.ToString() }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult Delete(int id)
        {
            //return View();
            return PartialView("_Delete");
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                ContactInfoViewModel deleteViewModel = _iContactInfoService.GetContactInfo(id);
                if (deleteViewModel != null)
                {
                    if (_iContactInfoService.Delete(deleteViewModel) > 0)
                    {
                        return Json(new { msg = "Data deleted successfully.", status = MessageType.success.ToString() }, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        return Json(new { msg = "Data could not deleted.", status = MessageType.notice.ToString() }, JsonRequestBehavior.AllowGet);
                    }

                }

                return Json(new { msg = "This data are missing.", status = MessageType.notice.ToString() }, JsonRequestBehavior.AllowGet);

            }
            catch (Exception ex)
            {
                return Json(new { msg = ExceptionHelper.ExceptionMessageFormat(ex, log: true), status = MessageType.error.ToString() }, JsonRequestBehavior.AllowGet);
            }
        }

        #endregion

        #region Utility Methods

        private IQueryable<ContactInfoViewModel> GetData()
        {
            return _iContactInfoService.GetAll();
        }

        #endregion
    }
}

﻿using Hotel.Admin.App_Start;
using Hotel.Bll;
using Hotel.Model;
using Newtonsoft.Json;
using NIU.Common.BLL;
using NIU.Core;
using NIU.Core.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel.Admin.Controllers
{
    public class ChangeRoomController : AdminBaseController
    {
        public ActionResult Index()
        {
            ViewBag.HotelId = UserContext.CurrentUser.HotelId;
            return View();
        }

        

        public ActionResult GetPage(int page, int rows, string  StartDate, string  EndDate, string RoomNO, bool isEnd = false)
        { 
            var data = RoomChangeRecordBll.GetPager(page,rows,isEnd, StartDate, EndDate, RoomNO, UserContext.CurrentUser.HotelId);
            return Json(data);
        }
 
    }
}
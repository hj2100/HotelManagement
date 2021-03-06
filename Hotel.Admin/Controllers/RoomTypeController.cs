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
    public class RoomTypeController : AdminBaseController
    {
        // GET: RoomType
        public ActionResult Index()
        {
            return View();
        }

        public string GetList()
        {
            var data = RoomTypeBll.GetList(UserContext.CurrentUser.HotelId);
            return JsonConvert.SerializeObject(data);
        }

        /// <summary>
        /// 编辑
        /// </summary>
        [HttpGet]
        public ActionResult Edit(long id = 0)
        {
            if (id == 0)
                return View(new RoomType());
            var info = RoomTypeBll.GetById(id);
            return View(info);
        }

        /// <summary>
        /// 保存
        /// </summary>
        [HttpPost, ValidateAntiForgeryToken]
        [OprtLogFilter(IsRecordLog = true, Method = "", IsFormPost = true, Entitys = new Type[] { typeof(RoomType) }, LogWay = OprtLogType.新增和修改)]
        public JsonResult Edit(RoomType model)
        {
            var apiResult = new APIResult();
            try
            {
                RoomTypeBll.AddOrUpdate(model, UserContext.CurrentUser.HotelId);
            }
            catch (Exception ex)
            {
                apiResult.Ret = -1;
                apiResult.Msg = ex.Message;
                if (!(ex is OperationExceptionFacade))
                    LogFactory.GetLogger().Log(LogLevel.Error, ex);
            }

            return Json(apiResult);
        }

        public JsonResult GetById(long id)
        {
            var model = RoomTypeBll.GetById(id);
            return Json(model, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 删除
        /// </summary>
        [OprtLogFilter(IsRecordLog = true, Method = "删除", IsFormPost = false, LogWay = OprtLogType.删除, IsFromCache = true)]
        public ActionResult Delete(long id)
        {
            var apiResult = new APIResult();
            try
            {
                RoomTypeBll.DeleteById(id);
            }
            catch (Exception ex)
            {
                apiResult.Ret = -1;
                apiResult.Msg = ex.Message;
                if (!(ex is OperationExceptionFacade))
                    LogFactory.GetLogger().Log(LogLevel.Error, ex);
            }
            return Json(apiResult);
        }

        public JsonResult GetHourRoomList(long id)
        {
            var data = RoomTypeBll.GetHourRoomList(id, UserContext.CurrentUser.HotelId);
            return Json(data,JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetPeriodRoomList(long id)
        {
            var data = RoomTypeBll.GetPeriodRoomList(id, UserContext.CurrentUser.HotelId);
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}
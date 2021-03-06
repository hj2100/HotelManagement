﻿using MC.ORM;
using Newtonsoft.Json;
using NIU.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Model
{
    /// <summary>
    /// 会员续卡记录
    /// </summary>
    [TableName("mem_expire_card_record"), PrimaryKey("Id")]
    public class MemExpireCardRecord : BaseModel
    {
        #region 属性

        /// <summary>
        /// Id
        /// </summary>
        [JsonConverter(typeof(LongToStringConverter))]
        public long Id { set; get; }

        /// <summary>
        /// 会员id
        /// </summary>
        [JsonConverter(typeof(LongToStringConverter))]
        public long MemberId { set; get; }

        /// <summary>
        /// 会员姓名
        /// </summary>
        [Display(Name = "会员姓名")]
        public string MemberName { set; get; }

        /// <summary>
        /// 续卡天数
        /// </summary>
        [Display(Name = "原卡号")]
        public int Days { set; get; }

        /// <summary>
        /// 到期时间
        /// </summary>
        [Display(Name = "到期时间")]
        public DateTime ExpireDate { set; get; }

        /// <summary>
        /// 支付方式
        /// </summary>
        [JsonConverter(typeof(LongToStringConverter))]
        public long PayTypeId { set; get; }

        /// <summary>
        /// 支付方式
        /// </summary>
        [Display(Name = "支付方式")]
        public string PayTypeName { set; get; }

        /// <summary>
        /// 金额
        /// </summary>
        [Display(Name = "金额")]
        public decimal Money { set; get; }

        /// <summary>
        /// 操作人
        /// </summary>
        [JsonConverter(typeof(LongToStringConverter))]
        public long HandlerId { set; get; }

        /// <summary>
        /// 操作人
        /// </summary>
        [Display(Name = "操作人")]
        public string HandlerName { set; get; }

        /// <summary>
        /// 酒店Id
        /// </summary>
        [JsonConverter(typeof(LongToStringConverter))]
        public long HotelId { set; get; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public int CDate { set; get; }

        #endregion

        #region 扩展属性



        #endregion

        #region 方法


        #endregion
    }
}

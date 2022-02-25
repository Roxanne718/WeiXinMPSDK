﻿/*----------------------------------------------------------------
    Copyright (C) 2022 Senparc
    
    文件名：BaseController.cs
    文件功能描述：Controller基类
    
    
    创建标识：Senparc - 20150312
----------------------------------------------------------------*/

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Senparc.Weixin.Entities;

namespace Senparc.Weixin.Sample.MP.Controllers
{
    public class BaseController : Controller
    {
        protected string AppId
        {
            get
            {
                return Config.SenparcWeixinSetting.WeixinAppId;//与微信公众账号后台的AppId设置保持一致，区分大小写。
            }
        }

        protected static ISenparcWeixinSettingForMP MpSetting
        {
            get
            {
                return Config.SenparcWeixinSetting.MpSetting;
            }
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            //给模板页 footer 输出使用，根据实际需要配置
            ViewData["CacheType"] = CO2NET.Cache.CacheStrategyFactory.GetObjectCacheStrategyInstance().GetType().Name;
            base.OnActionExecuting(context);
        }
    }
}

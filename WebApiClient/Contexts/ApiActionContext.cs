﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WebApiClient.Attributes;

namespace WebApiClient.Contexts
{
    /// <summary>
    /// 表示请求Api的上下文
    /// </summary>
    public class ApiActionContext
    {
        /// <summary>
        /// 获取关联的HttpApiConfig
        /// </summary>
        public HttpApiConfig HttpApiConfig { get; internal set; }

        /// <summary>
        /// 获取关联的ApiActionDescriptor
        /// </summary>
        public ApiActionDescriptor ApiActionDescriptor { get; internal set; }

        /// <summary>
        /// 获取关联的HttpRequestMessage
        /// </summary>
        public HttpRequestMessage RequestMessage { get; internal set; }

        /// <summary>
        /// 获取关联的HttpResponseMessage
        /// </summary>
        public HttpResponseMessage ResponseMessage { get; internal set; }

        /// <summary>
        /// 转换为字符串
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.ApiActionDescriptor.ToString();
        }
    }
}

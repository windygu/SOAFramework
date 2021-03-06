﻿using SOAFramework.Service.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOAFramework.Service.Core.Model
{
    /// <summary>
    /// 带分页的服务器回应实体
    /// </summary>
    public class PagingServerResponse : ServerResponse
    {
        /// <summary>
        /// 总数据量
        /// </summary>
        public int TotalRecordCount { get; set; }
    }
}

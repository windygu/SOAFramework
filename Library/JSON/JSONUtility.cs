﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Newtonsoft.Json;

namespace SOAFramework.Library
{
    public class JSONUtility
    {
        /// <summary>
        /// 把对象序列化成JSON格式字符串
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string Serialize(object obj, bool useDefaultFormat = true)
        {
            return JsonConvert.SerializeObject(obj, useDefaultFormat);
        }

        /// <summary>
        /// 把JSON格式字符串反序列化成对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="JSON"></param>
        /// <returns></returns>
        public static T Deserialize<T>(string JSON)
        {
            return JsonConvert.DeserializeObject<T>(JSON);
        }
    }
}

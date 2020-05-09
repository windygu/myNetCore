﻿using System;
using System.Collections.Generic;
using System.Text;

namespace KAJ.Model
{
   public class PageModel<T>
    {
        /// <summary>
        /// 当前页
        /// </summary>
        public int Page { get; set; } = 1;
        /// <summary>
        /// 总页数
        /// </summary>
        public int PageCount { get; set; } = 10;
        /// <summary>
        /// 每页大小
        /// </summary>
        public int PageSize { set; get; }
        /// <summary>
        /// 数据总数
        /// </summary>
        public int DataCount { get; set; } = 0;
        
        /// <summary>
        /// 返回数据
        /// </summary>
        public List<T> Data { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;
using Magicodes.ExporterAndImporter.Core;
using OfficeOpenXml.Table;

namespace Magicodes.ExporterAndImporter.Excel
{
    /// <summary>
    /// Excel导出设计
    /// </summary>
    public class ExcelExporterAttribute : ExporterAttribute
    {
        /// <summary>
        /// 表格样式风格
        /// </summary>
        public TableStyles? TableStyle { get; set; } = TableStyles.Medium10;
    }
}

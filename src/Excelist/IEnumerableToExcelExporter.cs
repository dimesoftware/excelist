﻿using System.IO;

namespace System.Collections.Generic
{
    public interface IEnumerableToExcelExporter<in T>
    {
        MemoryStream ToExcel(IEnumerable<T> collection);
    }
}
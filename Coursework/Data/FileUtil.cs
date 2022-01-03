﻿using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace Coursework.Data
{
    public static class FileUtil
    {
        public static ValueTask<object> SaveAs(this IJSRuntime js, string filename, byte[] data)
    => js.InvokeAsync<object>(
        "saveAsFile",
        filename,
        Convert.ToBase64String(data));
    }
}
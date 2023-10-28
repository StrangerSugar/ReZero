﻿using Microsoft.AspNetCore.Http; 
using ReZero.Enties.Const;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ReZero
{
    public class ReZeroApi : IReZeroApi
    {
        public bool IsApi(string url)
        {
            return url.ToString()?.StartsWith(NamingConventionsConst.ApiReZeroRoute) == true;
        }

        public Task WriteAsync(HttpContext context)
        {
            throw new NotImplementedException();
        }
    }
}

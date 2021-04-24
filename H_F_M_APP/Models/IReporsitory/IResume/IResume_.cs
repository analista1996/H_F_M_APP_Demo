using H_F_M_APPDATA.Context;
using H_F_M_APPMODEL.Models.Resume;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace H_F_M_APP.Models.IReporsitory.IResume
{
    public interface IResume_
    {
        public Resume GetResume(HttpContext context);
    }
}

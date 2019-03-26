using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NETCoreTest.Enties.wmw;

namespace NETCoreTest.Controllers
{
    /// <summary>
    /// 国家控制器
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        /// <summary>
        /// 单表的常用操作
        /// </summary>
        public readonly countryManager _countrydb;

        /// <summary>
        /// 构造函数
        /// </summary>
        public CountryController()
        {
            _countrydb = new countryManager();
        }

        /// <summary>
        /// 按名称获取城市信息
        /// </summary>
        /// <param name="_inputName">国家名称</param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<country>> GetCityByName(string _inputName)
        {
            var lst = _countrydb.GetList().Where(p => p.Name == _inputName)
                .ToList();
            return lst;
        }

    }
}
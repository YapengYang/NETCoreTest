using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NETCore.DB;

namespace NETCoreTest.Controllers
{
    /// <summary>
    /// 基础测试类
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        /// <summary>
        /// 数据库上下文
        /// </summary>
        public readonly NETCoreDBContext _db;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="db"></param>
        public ValuesController(NETCoreDBContext db)
        {
            _db = db;
        }

        // GET api/values
        /// <summary>
        /// 测试API
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        /// <summary>
        /// 单条数据查询
        /// </summary>
        /// <param name="id">主键ID</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="id">主键ID</param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        /// <summary>
        /// 获取所有产品
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<product>> GetAllProduct()
        {
            var lst = _db.product.ToList();
            return lst;
        }

    }
}

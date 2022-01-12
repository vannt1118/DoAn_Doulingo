using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Data;
using webapiqltruyen.Repository;
using System.Web.Http;

namespace webapiqltruyen.Controllers
{
    public class ServiceController : ApiController
    {
        [Route("api/ServiceController/LayDsTruyen")]
        [HttpGet]
        public IHttpActionResult LayDsTruyen()
        {
            DataTable tb = Database.Read_Table("LayDsTruyen");
            if (tb != null && tb.Rows.Count > 0)
                return Ok(tb);
            else
                return NotFound();
        }

        [Route("api/ServiceController/LayTruyenTheoMa")]
        [HttpGet]
        public IHttpActionResult LayTruyenTheoMa (int matruyen)
        {
            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("matruyen", matruyen);
            DataTable tb = Database.Read_Table("LayTruyenTheoMa", param);
            if (tb != null && tb.Rows.Count > 0)
                return Ok(tb);
            else
                return NotFound();
        }

    }
}

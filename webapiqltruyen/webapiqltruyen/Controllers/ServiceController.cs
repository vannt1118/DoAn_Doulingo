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
        public IHttpActionResult LayTruyenTheoMa(int matruyen)
        {
            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("matruyen", matruyen);
            DataTable tb = Database.Read_Table("LayTruyenTheoMa", param);
            if (tb != null && tb.Rows.Count > 0)
                return Ok(tb);
            else
                return NotFound();
        }

        [Route("api/ServiceController/LayDsTuTheoTruyen")]
        [HttpGet]

        public IHttpActionResult LayDsTuTheoTruyen(int matruyen)
        {
            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("matruyen", matruyen);
            DataTable tb = Database.Read_Table("LayDsTuTheoTruyen", param);
            if (tb != null && tb.Rows.Count > 0)
                return Ok(tb);
            else
                return NotFound();
        }

        [Route("api/ServiceController/LayTuTheoMa")]
        [HttpGet]

        public IHttpActionResult LayTuTheoMa(int matu)
        {
            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("matu", matu);
            DataTable tb = Database.Read_Table("LayDsTuTheoMa", param);
            if (tb != null && tb.Rows.Count > 0)
                return Ok(tb);
            else
                return NotFound();
        }

        [Route("api/ServiceController/LayDsTuDongNghia")]
        [HttpGet]

        public IHttpActionResult LayDsTuDongNghia(int matu)
        {
            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("matu", matu);
            DataTable tb = Database.Read_Table("LayDsTuDongNghia", param);
            if (tb != null && tb.Rows.Count > 0)
                return Ok(tb);
            else
                return NotFound();
        }

        [Route("api/ServiceController/LayDsTuTraiNghia")]
        [HttpGet]

        public IHttpActionResult LayDsTuTraiNghia(int matu)
        {
            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("matu", matu);
            DataTable tb = Database.Read_Table("LayDsTuTraiNghia", param);
            if (tb != null && tb.Rows.Count > 0)
                return Ok(tb);
            else
                return NotFound();
        }
    }
}

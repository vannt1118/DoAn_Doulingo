using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DoAnapi.Database;

namespace DoAnapi.Controllers
{
    public class ServiceController : ApiController
    {
        // Lấy danh sách truyện
        [Route("api/ServiceController/LayDsTruyen")]
        [HttpGet]

        public IHttpActionResult LayDsTruyen()
        {
            try 
            {
                DataTable result = Database.Database.ReadTable("LayDsTruyen");
                return Ok(result);
            }
            catch
            {
                return NotFound();
            }
        }

        //Lấy 1 truyện
        [Route("api/ServiceController/LayTruyenTheoMa")]
        [HttpGet]

        public IHttpActionResult LayTruyenTheoMa(int matruyen)
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("matruyen", matruyen);

                DataTable result = Database.Database.ReadTable("LayTruyenTheoMa", param);
                return Ok(result);
            }
            catch
            {
                return NotFound();
            }
        }

        [Route("api/ServiceController/LayDsTuTheoTruyen")]
        [HttpGet]

        public IHttpActionResult LayDsTuTheoTruyen(int matruyen)
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("matruyen", matruyen);

                DataTable result = Database.Database.ReadTable("LayDsTuTheoTruyen", param);
                return Ok(result);
            }
            catch
            {
                return NotFound();
            }
        }

        [Route("api/ServiceController/LayTuTheoMa")]
        [HttpGet]

        public IHttpActionResult LayTuTheoMa(int matu)
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("matu", matu);

                DataTable result = Database.Database.ReadTable("LayTuTheoMa", param);
                return Ok(result);
            }
            catch
            {
                return NotFound();
            }
        }

        [Route("api/ServiceController/LayDsTuDongNghia")]
        [HttpGet]

        public IHttpActionResult LayDsTuDongNghia(int matu)
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("matu", matu);

                DataTable result = Database.Database.ReadTable("LayDsTuDongNghia", param);
                return Ok(result);
            }
            catch
            {
                return NotFound();
            }
        }

        [Route("api/ServiceController/LayDsTuTraiNghia")]
        [HttpGet]

        public IHttpActionResult LayDsTuTraiNghia(int matu)
        {
            try
            {
                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("matu", matu);

                DataTable result = Database.Database.ReadTable("LayDsTuTraiNghia", param);
                return Ok(result);
            }
            catch
            {
                return NotFound();
            }
        }

    }
}

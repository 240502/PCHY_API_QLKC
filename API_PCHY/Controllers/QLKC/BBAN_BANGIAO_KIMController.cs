using API_PCHY.Models.QLKC.BBAN_BANGIAO_KIM;
using APIPCHY_PhanQuyen.Models.QLKC.DM_PHONGBAN;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Asn1.Tsp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http.Routing;

namespace API_PCHY.Controllers.QLKC
{
    [Route("api/[controller]")]
    [ApiController]
    public class BBAN_BANGIAO_KIMController : ControllerBase
    {
            
        BBAN_BANGIAO_KIMManager manager = new BBAN_BANGIAO_KIMManager();

        [Route("search_BBAN_BANGIAO_KIM")]
        [HttpPost]
        public IActionResult search_BBAN_BANGIAO_KIM([FromBody] Dictionary<string, object> formData)
        {
            try
            {
                int? pageIndex = 0;
                int? pageSize = 0;
                string don_vi_nhan = null;
                string don_vi_giao = null;
                int? trang_thai = null;
                if (formData.Keys.Contains("pageIndex") && !string.IsNullOrEmpty(formData["pageIndex"].ToString()))
                {
                    pageIndex = int.Parse(formData["pageIndex"].ToString());
                }
                if (formData.Keys.Contains("pageSize") && !string.IsNullOrEmpty(formData["pageSize"].ToString()))
                {
                    pageSize = int.Parse(formData["pageSize"].ToString());
                }
                if (formData.Keys.Contains("don_vi_nhan") && !string.IsNullOrEmpty(formData["don_vi_nhan"].ToString()))
                {
                    don_vi_nhan = formData["don_vi_nhan"].ToString();
                }
                if (formData.Keys.Contains("don_vi_giao") && !string.IsNullOrEmpty(formData["don_vi_giao"].ToString()))
                {
                    don_vi_giao = formData["don_vi_giao"].ToString();
                }
                if (formData.Keys.Contains("trang_thai") && !string.IsNullOrEmpty(formData["trang_thai"].ToString()))
                {
                    trang_thai = int.Parse(formData["trang_thai"].ToString());
                }

                int totalItems = 0;
                List<BBAN_BANGIAO_KIMModel> result = manager.search_BBAN_BANGIAO_KIM(pageIndex, pageSize, don_vi_giao, don_vi_nhan, trang_thai, out totalItems);
                return result != null ? Ok(new
                {
                    page = pageIndex,
                    pageSize = pageSize,
                    totalItems = totalItems,
                    data = result,
                    don_vi_nhan = don_vi_nhan,
                    don_vi_giao = don_vi_giao,
                    trang_thai = trang_thai
                }) : NotFound();
              
              

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("get_BBAN_BANGIAO_KIMByIdBBan")]
        [HttpGet]
        public IActionResult get_BBAN_BANGIAO_KIMByIdBBan(int id_bban)
        {
            try
            {
                BBAN_BANGIAO_KIMModel result = manager.get_BBAN_BANGIAO_KIMByIdBBan(id_bban);
                return result != null ? Ok(result) : NotFound();

            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [Route("insert_BBAN_BANGIAO_KIM")]
        [HttpPost]
        public IActionResult insert_BBAN_BANGIAO_KIM([FromBody] BBAN_BANGIAO_KIMModel bBAN_BANGIAO_KIMModel)
        {
            try
            {
                string result = manager.insert_BBAN_BANGIAO_KIM(bBAN_BANGIAO_KIMModel);
                return String.IsNullOrEmpty(result) ? Ok("Thêm thành công") : BadRequest(result);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
                
        }
        [Route("update_QLKC_BBAN_BANGIAO_KIMChoDuyet")]
        [HttpPut]
        public IActionResult update_QLKC_BBAN_BANGIAO_KIMChoDuyet([FromBody] BBAN_BANGIAO_KIMModel bBAN_BANGIAO_KIMModel)
        {
          
            try
            {
                string result = manager.update_QLKC_BBAN_BANGIAO_KIMChoDuyet(bBAN_BANGIAO_KIMModel);
                return String.IsNullOrEmpty(result) ? Ok("Sửa thành công") : BadRequest(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [Route("delete_QLKC_BBAN_BANGIAO_KIM")]
        [HttpDelete]
        public IActionResult delete_QLKC_BBAN_BANGIAO_KIM(int id_bban)
        {
            try
            {
                string result = manager.delete_QLKC_BBAN_BANGIAO_KIM(id_bban);
                return String.IsNullOrEmpty(result) ? Ok("Xóa thành công") : BadRequest(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("update_QLKC_BBAN_BANGIAO_KIMKyC1")]
        [HttpPut]
        public IActionResult update_QLKC_BBAN_BANGIAO_KIMKyC1(int id_bban)
        {
            try
            {
                string result = manager.update_QLKC_BBAN_BANGIAO_KIMKyC1(id_bban);
                return String.IsNullOrEmpty(result) ? Ok("Ký thành công") : BadRequest(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("update_QLKC_BBAN_BANGIAO_KIMTraLai")]
        [HttpPut]
        public IActionResult update_QLKC_BBAN_BANGIAO_KIMTraLai(int id_bban)
        {
            try
            {
                string result = manager.update_QLKC_BBAN_BANGIAO_KIMTraLai(id_bban);
                return String.IsNullOrEmpty(result) ? Ok("Trả thành công") : BadRequest(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [Route("update_QLKC_BBAN_BANGIAO_KIMKyC2")]
        [HttpPut]
        public IActionResult update_QLKC_BBAN_BANGIAO_KIMKyC2(int id_bban)
        {
            try
            {
                    string strrError = manager.update_QLKC_BBAN_BANGIAO_KIMKyC2(id_bban);
                    return String.IsNullOrEmpty(strrError) ? Ok("Ký thành công") : BadRequest(strrError);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

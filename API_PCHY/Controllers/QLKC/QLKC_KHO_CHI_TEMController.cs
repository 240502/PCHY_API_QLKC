using API_PCHY.Models.QLKC;
using API_PCHY.Models.QUAN_TRI.QLKC_KHO_CHI_TEM;
using APIPCHY_PhanQuyen.Models.QLKC.DM_DONVI;
using APIPCHY_PhanQuyen.Models.QLKC.DM_PHONGBAN;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace API_PCHY.Controllers.QUAN_TRI.QLKC_KHO_CHI_TEM
{
    [Route("APIPCHY/[controller]")]
    [ApiController]
    public class QLKC_KHO_CHI_TEMController : ControllerBase
    {
        QLKC_KHO_CHI_TEM_Manager db = new QLKC_KHO_CHI_TEM_Manager();

        [Route("update_QLKC_KHO_CHI_TEM")]
        [HttpPut]
        public IActionResult update_QLKC_KHO_CHI_TEM([FromBody] QLKC_KHO_CHI_TEM_Model qLKC_KHO_CHI_TEM)
        {
            string result = db.update_QLKC_KHO_CHI_TEM(qLKC_KHO_CHI_TEM);
            return string.IsNullOrEmpty(result) ? Ok() : BadRequest(result);
        }

        [Route("delete_QLKC_KHO_CHI_TEM")]
        [HttpDelete]
        public IActionResult delete_QLKC_KHO_CHI_TEM(Guid ID_KHO)
        {
            string result = db.delete_QLKC_KHO_CHI_TEM(ID_KHO.ToString());
            return string.IsNullOrEmpty(result) ? Ok() : BadRequest(result);
        }

        [Route("get_All_QLKC_KHO_CHI_TEM")]
        [HttpGet]
        public IActionResult get_All_QLKC_KHO_CHI_TEM()
        {
            List<QLKC_KHO_CHI_TEM_Model> result = db.get_All_QLKC_KHO_CHI_TEM();
            return result != null ? Ok(result) : NotFound();
        }

        [Route("get_QLKC_KHO_CHI_TEMByID_KHO")]
        [HttpGet]
        public IActionResult get_QLKC_KHO_CHI_TEMByID_KHO(int ID_KHO)
        {
            QLKC_KHO_CHI_TEM_Model result = db.get_QLKC_KHO_CHI_TEMByID_KHO(ID_KHO.ToString());
            return result != null ? Ok(result) : NotFound();
        }

        

        
    }
}

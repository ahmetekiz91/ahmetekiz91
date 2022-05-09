using DBModel;
using FINANS.Infrastruct;
using DBModel.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FINANS;

namespace MNERPAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CARIFISController : ControllerBase
    {

        //cari hareket apisi işlemleri front end kodlarını ve gelen istekleri bekliyor

        private readonly ICARIFISService _cariFisServices;
      
        public CARIFISController(ICARIFISService _cariFisServices)
        {
            this._cariFisServices = _cariFisServices;
        }


        [HttpPost]
        public async Task<IActionResult> Create(CARIFISDTO model)
        {
            try
            {

                bool res = await _cariFisServices.CreateCARIFISLARAsync(model);
                string mesaj = "";
                if (res) mesaj = "OK";
                else mesaj = "FAIL";
                var serializestr = JsonConvert.SerializeObject(mesaj);
                return Ok(serializestr);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        
        [HttpGet]
        public async Task<IActionResult> getAll()
        {
            try
            {
                List<CARIFISDTO> list = await _cariFisServices.GetCARIFISLAR();
                var serializestr = JsonConvert.SerializeObject(list);
                return Ok(serializestr);
            }
            catch (Exception ex)
            {

                throw;
            }

        }
       
        [HttpPut]
        public async Task<IActionResult> getByID(int ID)
        {
            try
            {
                List<CARIFISDTO> list = await _cariFisServices.GetCARIFISLARById(ID);
                var serializestr = JsonConvert.SerializeObject(list);
                return Ok(serializestr);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpPatch]
        public async Task<IActionResult> Update(CARIFISDTO model)
        {
            try
            {

                bool res = await _cariFisServices.UpdateCARIFISLARAsync(model);
                string mesaj = "";
                if (res) mesaj = "OK";
                else mesaj = "FAIL";
                var serializestr = JsonConvert.SerializeObject(mesaj);
                return Ok(serializestr);
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        [HttpDelete]
        public async Task<IActionResult> Delete(int ID)
        {
            try
            {
                bool res = await _cariFisServices.DeleteCARIFISLARAsync(ID);
                string mesaj = "";
                if (res) mesaj = "OK";
                else mesaj = "FAIL";
                var serializestr = JsonConvert.SerializeObject(mesaj);
                return Ok(serializestr);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}

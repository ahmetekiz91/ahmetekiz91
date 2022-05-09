using DBModel.Infrastruce;
using DBModel.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MNERPAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class CARIGRUPLARController : ControllerBase
    {

        private readonly ICARIGRUPLARServices cariGruplarServices;
        public CARIGRUPLARController(ICARIGRUPLARServices cariGruplarServices)
        {
            this.cariGruplarServices = cariGruplarServices;
        }


        [HttpGet]
        public async Task<IActionResult> getAll()
        {
            try
            {
                List<CARIGRUPLAR> list = await cariGruplarServices.GetCARIGRUPLAR();
                return Ok(list);
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
                CARIGRUPLAR list = await cariGruplarServices.GetCARIGRUPLARById(ID);
                return Ok(list);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(CARIGRUPLAR model)
        {
            try
            {

                bool res = await cariGruplarServices.CreateCARIGRUPLARAsync(model);
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

        [HttpPatch]
        public async Task<IActionResult> Update(CARIGRUPLAR model)
        {
            try
            {
                bool res = await cariGruplarServices.UpdateCARIGRUPLARAsync(model);
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
                bool res = await cariGruplarServices.DeleteCARIGRUPLARAsync(ID);
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

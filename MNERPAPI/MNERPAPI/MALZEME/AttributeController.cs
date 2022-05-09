using DBModel.Infrastruce;
using DBModel.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MNERPAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttributeController : ControllerBase
    {

        private readonly  IATTRIBUTESServices attributeServices;
        public AttributeController(IATTRIBUTESServices attributeServices)
        {
            this.attributeServices = attributeServices;
        }


        [HttpGet]
        public async Task<IActionResult> getAll()
        {
            try
            {
                List<ATTRIBUTES> list = await attributeServices.GetATTRIBUTES();
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
                ATTRIBUTES list = await attributeServices.GetATTRIBUTESById(ID);
                var serializestr = JsonConvert.SerializeObject(list);
                return Ok(serializestr);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(ATTRIBUTES model)
        {
            try
            {

                bool res = await attributeServices.CreateATTRIBUTESAsync(model);
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
        public async Task<IActionResult> Update(ATTRIBUTES model)
        {
            try
            {
                bool res = await attributeServices.UpdateATTRIBUTESAsync(model);
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
                bool res = await attributeServices.DeleteATTRIBUTESAsync(ID);
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

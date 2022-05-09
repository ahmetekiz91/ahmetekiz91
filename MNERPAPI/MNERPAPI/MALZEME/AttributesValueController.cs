using DBModel;
using DBModel.DTO;
using DBModel.Infrastruce;
using DBModel.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MNERPAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttributesValueController : ControllerBase
    {

        private readonly IATTRIBUTESVALUEServices attributevalueServices;
        //public AttributesValueController(IATTRIBUTESVALUEServices attributevalueServices)
        //{
        //    this.attributevalueServices = attributevalueServices;
        //}
        private readonly IHelper IHelper;
        public AttributesValueController(IATTRIBUTESVALUEServices attributevalueServices, IHelper IHelper)
        {
            this.attributevalueServices = attributevalueServices;
            this.IHelper = IHelper;
        }
        [HttpGet("ddl_Attributes")]
        public async Task<IActionResult> ddl_Attributes()
        {
            try
            {
                List<ATTRIBUTES> list = await attributevalueServices.ddl_Attribute();
                var serializestr = JsonConvert.SerializeObject(list);
                return Ok(serializestr);
            }
            catch (Exception ex)
            {

                throw;
            }

        }
        [HttpGet("ddl_Birimler")]
        public async Task<IActionResult> ddl_Birimler()
        {
            try
            {
                var list =  new DBModel.Content(this.IHelper).Birimler();
                var jslist = JsonConvert.SerializeObject(list);
                return Ok(jslist);
            }
            catch (Exception ex)
            {
            }
            return null;

        }
        [HttpGet]
        public async Task<IActionResult> getAll()
        {
            try
            {
                List<AttributeValuesDTO> list = await attributevalueServices.GetATTRIBUTESVALUE();
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
                AttributeValuesDTO list = await attributevalueServices.GetATTRIBUTESVALUEById(ID);
                var serializestr = JsonConvert.SerializeObject(list);
                return Ok(serializestr);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(AttributeValuesDTO model)
        {
            try
            {

                bool res = await attributevalueServices.CreateATTRIBUTESVALUEAsync(model);
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
        public async Task<IActionResult> Update(AttributeValuesDTO model)
        {
            try
            {
                bool res = await attributevalueServices.UpdateATTRIBUTESVALUEAsync(model);
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
                bool res = await attributevalueServices.DeleteATTRIBUTESVALUEAsync(ID);
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

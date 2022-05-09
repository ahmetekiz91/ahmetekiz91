using DBModel.Infrastruce;
using DBModel.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MNERPAPI.MALZEME
{
    [Route("api/[controller]")]
    [ApiController]
    public class MalzemeController : ControllerBase
    {


        private readonly IMalzemeServices Malzemeservices;
        public MalzemeController(IMalzemeServices Malzemeservices)
        {
            this.Malzemeservices = Malzemeservices;
        }


        [HttpGet]
        public async Task<IActionResult> getAll()
        {
            try
            {
                List<Malzeme> list = await Malzemeservices.GetMalzeme();
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
                Malzeme list = await Malzemeservices.GetMalzemeById(ID);
                var serializestr = JsonConvert.SerializeObject(list);
                return Ok(serializestr);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(Malzeme model)
        {
            try
            {

                bool res = await Malzemeservices.CreateMalzemeAsync(model);
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
        public async Task<IActionResult> Update(Malzeme model)
        {
            try
            {
                bool res = await Malzemeservices.UpdateMalzemeAsync(model);
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
                bool res = await Malzemeservices.DeleteMalzemeAsync(ID);
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

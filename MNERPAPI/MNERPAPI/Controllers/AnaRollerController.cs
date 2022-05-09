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
    public class AnaRollerAPIController : ControllerBase
    {

        private readonly IANAROLLERServices _anarollerService;
        public AnaRollerAPIController(IANAROLLERServices _anarollerService)
        {
            this._anarollerService = _anarollerService;
        }
     

        [HttpGet]
        public  async Task<IActionResult> getAll()
        {
            try
            {
                List<ANAROLLER> list = await _anarollerService.GetANAROLLER();
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
                ANAROLLER list = await _anarollerService.GetANAROLLERById(ID);
                var serializestr = JsonConvert.SerializeObject(list);
                return Ok(serializestr);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(ANAROLLER model)
        {
            try
            {

                bool res = await _anarollerService.CreateANAROLLERAsync(model);
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
        public async Task<IActionResult> Update(ANAROLLER model)
        {
            try
            {
                bool res = await _anarollerService.UpdateANAROLLERAsync(model);
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
                bool res = await _anarollerService.DeleteANAROLLERAsync(ID);
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

using DBModel;
using DBModel.DTO;
using DBModel.Infrastruce;
using DBModel.Model;
using DBModel.Services;
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
    public class CARIKARTController : ControllerBase
    {
        private readonly ICARIKARTServices carikartServices;
        private readonly IHelper IHelper;

        public CARIKARTController(ICARIKARTServices CARIKARTServices, IHelper IHelper)
        {
            this.carikartServices = CARIKARTServices;
            this.IHelper = IHelper;
        }

        [HttpGet]
        public async Task<IActionResult> getAll()
        {
            try
            {
                List<CARIKARTDTO> list = await carikartServices.GetCARIKART();
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
                CARIKARTDTO list = await carikartServices.GetCARIKARTById(ID);
                return Ok(list);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(CARIKARTDTO model)
        {
            try
            {
                bool res = await carikartServices.CreateCARIKARTAsync(model);
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
        public async Task<IActionResult> Update(CARIKARTDTO model)
        {
            try
            {
                bool res = await carikartServices.UpdateCARIKARTAsync(model);
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
                bool res = await carikartServices.DeleteCARIKARTAsync(ID);
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

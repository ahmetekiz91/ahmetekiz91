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
    public class BankalarController : ControllerBase
    {

        private readonly IBANKALARServices bankalarServices;

        public BankalarController(IBANKALARServices bankalarServices)
        {
            this.bankalarServices = bankalarServices;
        }


        [HttpGet]
        public async Task<IActionResult> getAll()
        {
            try
            {
                List<BANKALAR> list = await bankalarServices.GetBANKALAR();
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
                BANKALAR list = await bankalarServices.GetBANKALARById(ID);
                return Ok(list);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(BANKALAR model)
        {
            try
            {

                bool res = await bankalarServices.CreateBANKALARAsync(model);
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
        public async Task<IActionResult> Update(BANKALAR model)
        {
            try
            {
                bool res = await bankalarServices.UpdateBANKALARAsync(model);
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
                bool res = await bankalarServices.DeleteBANKALARAsync(ID);
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

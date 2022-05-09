using DBModel.Infrastruce;
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
    public class USERSController : ControllerBase
    {

        private readonly IUSERSServices usersServices;
        public USERSController(IUSERSServices CARIKARTServices)
        {
            this.usersServices = CARIKARTServices;
        }

        [HttpGet]
        public async Task<IActionResult> getAll()
        {
            try
            {
                List<DBModel.Model.USERS> list = await usersServices.GetUSERS();
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
                DBModel.Model.USERS list = await usersServices.GetUSERSById(ID);
                return Ok(list);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(DBModel.Model.USERS model)
        {  
            string mesaj = "";
            try
            {

                bool res = await usersServices.CreateUSERSAsync(model);
              
                if (res) mesaj = "OK";else mesaj = "FAIL";
            }
            catch (Exception ex)
            {
                throw;
            }
            var serializestr = JsonConvert.SerializeObject(mesaj);
            return Ok(serializestr);
        }

        [HttpPatch]
        public async Task<IActionResult> Update(DBModel.Model.USERS model)
        {
            string mesaj = "";
            try
            {
                bool res = await usersServices.UpdateUSERSAsync(model);       
                if (res) mesaj = "OK";else mesaj = "FAIL";
            }
            catch (Exception ex)
            {
                throw;
            }
            var serializestr = JsonConvert.SerializeObject(mesaj);
            return Ok(serializestr);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int ID)
        {
            string mesaj = "";
            try
            {
                bool res = await usersServices.DeleteUSERSAsync(ID);
                if (res) mesaj = "OK"; else mesaj = "FAIL";
            }
            catch (Exception ex)
            {
                throw;
            }
            var serializestr = JsonConvert.SerializeObject(mesaj);
            return Ok(serializestr);
        }

    }
}

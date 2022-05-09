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
    public class PlasiyerlerController : ControllerBase
    {
        private readonly IPlasiyerlerServices PlasiyerlerServices;
        private readonly IHelper IHelper;

        public PlasiyerlerController(IPlasiyerlerServices PlasiyerlerServices, IHelper IHelper)
        {
            this.PlasiyerlerServices = PlasiyerlerServices;
            this.IHelper = IHelper;
        }

        [HttpGet]
        public async Task<IActionResult> getAll()
        {
            try
            {
                List<Plasiyerler> list = await PlasiyerlerServices.GetPlasiyerler();
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
                Plasiyerler list = await PlasiyerlerServices.GetPlasiyerlerById(ID);
                return Ok(list);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(Plasiyerler model)
        {
            try
            {
                bool res = await PlasiyerlerServices.CreatePlasiyerlerAsync(model);
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
        public async Task<IActionResult> Update(Plasiyerler model)
        {
            try
            {
                bool res = await PlasiyerlerServices.UpdatePlasiyerlerAsync(model);
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
                bool res = await PlasiyerlerServices.DeletePlasiyerlerAsync(ID);
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

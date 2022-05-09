using DBModel;
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
    public class ContentController : ControllerBase
    {
 

        private readonly IHelper IHelper;
        public ContentController( IHelper IHelper)
        {
            this.IHelper = IHelper;
        }

        [HttpGet("ddl_Birimler")]
        public async Task<IActionResult> ddl_Birimler()
        {
            try
            {
                var list = new Content(this.IHelper).Birimler();
                var jslist = JsonConvert.SerializeObject(list);
                return Ok(jslist);
            }
            catch (Exception ex)
            {
            }
            return null;

        }

        [HttpGet("ddl_Ulkeler")]
        public async Task<IActionResult> ddl_Ulkeler()
        {
            try
            {
                var list = new Content(this.IHelper).Ulkeler();
                var jslist = JsonConvert.SerializeObject(list);
                return Ok(jslist);
            }
            catch (Exception ex)
            {
            }
            return null;
        }
        [HttpGet("ddl_Plasiyerler")]
        public async Task<IActionResult> ddl_Plasiyerler()
        {
            try
            {
                var list = new Content(this.IHelper).Plasiyerler();
                var jslist = JsonConvert.SerializeObject(list);
                return Ok(jslist);
            }
            catch (Exception ex)
            {
            }
            return null;
        }

        [HttpGet("ddl_CARIGRUPLAR")]
        public async Task<IActionResult> ddl_CARIGRUPLAR()
        {
            try
            {
                var list = new Content(this.IHelper).CARIGRUPLAR();
                var jslist = JsonConvert.SerializeObject(list);
                return Ok(jslist);
            }
            catch (Exception ex)
            {
            }
            return null;
        }
    }
}

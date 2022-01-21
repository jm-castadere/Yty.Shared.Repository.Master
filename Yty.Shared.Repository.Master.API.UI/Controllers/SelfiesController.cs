using MediatR;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;
using Yty.Shared.Repository.Master.API.Application.Commands;
using Yty.Shared.Repository.Master.API.Application.DTOs;
using Yty.Shared.Repository.Master.API.Application.Queries;
using Yty.Shared.Repository.Master.Domain.Interfaces;

namespace Yty.Shared.Repository.Master.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    //[EnableCors(SecurityMethods.DEFAULT_POLICY_2)]
    public class SelfiesController : ControllerBase
    {
        #region Fields
        private readonly ISelfieRepository _repository = null;
        private readonly IWebHostEnvironment _webHostEnvironment = null;
       
        private readonly IMediator _mediator = null;
        #endregion

        public SelfiesController(IMediator mediator, ISelfieRepository repository, IWebHostEnvironment webHostEnvironment)
        {
            this._repository = repository;
            this._webHostEnvironment = webHostEnvironment;
            this._mediator = mediator;
        }


        [HttpGet]
        [DisableCors()]
        //[EnableCors(SecurityMethods.DEFAULT_POLICY_3)]
        public IActionResult GetAll([FromQuery] int wookieId = 0)
        {
            if (this.Request != null)
            {
                var param = this.Request.Query["wookieId"];
            }

            var model = this._mediator.Send(new SelectAllSelfiesQuery() { WookieId = wookieId });

            return this.Ok(model);
        }

       
        //[Route("photos")]
        //[HttpPost]
        //public async Task<IActionResult> AddPicture(IFormFile picture)
        //{
        //    string filePath = Path.Combine(this._webHostEnvironment.ContentRootPath, @"images\selfies");

        //    if (!Directory.Exists(filePath))
        //    {
        //        Directory.CreateDirectory(filePath);
        //    }
        //    filePath = Path.Combine(filePath, picture.FileName);


        //    using var stream = new FileStream(filePath, FileMode.OpenOrCreate);
        //    await picture.CopyToAsync(stream);

        //    var itemFile = this._repository.AddOnePicture(filePath);

        //    try
        //    {
        //        this._repository.UnitOfWork.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {

        //        throw;
        //    }


        //    return this.Ok(itemFile);
        //}

        [HttpPost]
        public async Task<IActionResult> AddOne(SelfieDto dto)
        {
            IActionResult result = this.BadRequest();

            var item = await this._mediator.Send(new AddSelfieCommand() { Item = dto });
            if (item != null)
            {
                result = this.Ok(item);
            }

            return result;
        }
    }
}

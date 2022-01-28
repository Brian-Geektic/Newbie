using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Newbie.Web.ViewModels;
using Newbie.Services.Services;
using Newbie.Services.Interfaces;
using Microsoft.Extensions.Logging;
using Newbie.Services.Dto;

namespace Newbie.Web.Controllers
{
    public class MemberController : Controller
    {

        protected readonly IMapper _mapper;
        protected readonly IMembersPublicService _membersPublicService;

        public MemberController(IMembersPublicService membersPublicService, IMapper mapper)
        {
            _mapper = mapper;
            _membersPublicService = membersPublicService;

        }

        public IActionResult Index()
        {
            var listmemberDto = _mapper.Map<List<MemberPublicDetailsVM>>(_membersPublicService.GetAll());
            return View(listmemberDto);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(MemberPublicDetailsVM member)
        {
            if (ModelState.IsValid)
            {
                await _membersPublicService.CreateAsync(_mapper.Map<MemberPublicDto>(member));
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var memberdetail = _membersPublicService.GetById(id);
            try
            {
                if (memberdetail == null)
                    return Content("查無此帳號");
                else
                    return View(_mapper.Map<MemberPublicDetailsVM>(memberdetail));
            }
            catch (Exception ex)
            {
                return Content(ex.ToString() + ": 出現未知錯誤,請洽系統管理者");
            }
        }
        [HttpPost]
        public async Task<IActionResult> Edit(MemberPublicDetailsVM memberupdate)
        {
            try
            {
                if (memberupdate == null)
                    return Content("查無此帳號");
                else
                {
                    await _membersPublicService.UpdateAsync(_mapper.Map<MemberPublicDto>(memberupdate));
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                return Content(ex.Message + "出現未知錯誤,請洽系統管理者");
            }
        }

    }
}

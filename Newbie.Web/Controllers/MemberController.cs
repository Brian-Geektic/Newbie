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
            var listmemberDto = _membersPublicService.GetAll();
            _mapper.Map<MemberPublicDetailsVM>(listmemberDto);
            return View();
        }
    }
}

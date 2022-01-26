using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Newbie.Repositories.Models;
using Newbie.Services.Dto;
using Newbie.Web.ViewModels;

namespace Newbie.Web
{
    public class MyMappingProfile : Profile
    {
        public MyMappingProfile()
        {
            CreateMap<ArticleDto, Article>().ReverseMap();
            CreateMap<AuthorizationDto, Authorization>().ReverseMap();
            CreateMap<MemberPrivateDto, MembersPrivate>().ReverseMap();
            CreateMap<MemberPublicDto, MembersPublic>().ReverseMap();
            CreateMap<RoleArticleDto, RoleArticle>().ReverseMap();
            CreateMap<RoleDto, Role>().ReverseMap();

            CreateMap<ArticleDetailsVM, ArticleDto>().ReverseMap();
            CreateMap<AuthorizationDetailsVM, AuthorizationDto>().ReverseMap();
            CreateMap<MemberPrivateDetailsVM, MemberPrivateDto>().ReverseMap();
            CreateMap<MemberPublicDetailsVM, MemberPublicDto>().ReverseMap();
            CreateMap<RoleArticleDetailsVM, RoleArticleDto>().ReverseMap();
            CreateMap<RoleDetailsVM, RoleDto>().ReverseMap();


        }
    }
}
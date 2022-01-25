using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newbie.Services.Interfaces;
using Newbie.Repositories.Data;
using Newbie.Repositories.Models;
using Newbie.Repositories.Interfaces;
using AutoMapper;
using Newbie.Repositories.Repositories;
using System.Linq.Expressions;

namespace Newbie.Services.Services
{
    public class NewbieServices : INewbieServices
    {
        private readonly INewbieRepository<Project> newbieRepository = new NewbieRepositories<Project>();
        public void Create(Project entity)
        {

        }

        public void Delete(Project entity)
        {
            throw new NotImplementedException();
        }
        public void Update(Project entity)
        {
            throw new NotImplementedException();
        }
        public bool IsExists(int id)
        {
            return newbieRepository.GetAll().Any(x => x.Id == id);
        }

        public IEnumerable<Project> GetAll()
        {
            throw new NotImplementedException();
        }

        public Project GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

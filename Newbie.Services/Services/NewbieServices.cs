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

namespace Newbie.Services.Services
{
    public class NewbieServices<T> : INewbieServices<T> where T : class
    {
        private NewbieRepositories _newbieRepositories;
        public NewbieServices(NewbieRepositories newbieRepositories)
        {
            this._newbieRepositories = newbieRepositories;
        }
        public void Create(T entity)
        {

        }
    }
}

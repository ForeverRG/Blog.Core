﻿using Blog.Core.IRepository.Base;
using Blog.Core.IServices;
using Blog.Core.Model.Models;
using Blog.Core.Services.BASE;

namespace Blog.Core.Services
{
    public partial class AccessTrendLogServices : BaseServices<AccessTrendLog>, IAccessTrendLogServices
    {
        IBaseRepository<AccessTrendLog> _dal;
        public AccessTrendLogServices(IBaseRepository<AccessTrendLog> dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }

    }
}

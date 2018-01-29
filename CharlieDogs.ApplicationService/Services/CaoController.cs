﻿using CharlieDogs.BusinessLogic;
using CharlieDogs.Domain.ViewModel;
using System.Collections.Generic;
using System.Web.Http;

namespace CharlieDogs.ApplicationService.Services
{
    public class CaoController : ApiController
    {
        private ICaesBll _caesBll;

        public CaoController(ICaesBll caesBll)
        {
            _caesBll = caesBll;
        }

        public IEnumerable<CaesVM> Get()
        {
            return _caesBll.Listar();
        }
    }
}
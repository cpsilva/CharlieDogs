using CharlieDogs.BusinessLogic;
using CharlieDogs.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CharlieDogs.ApplicationService.Grid
{
    public class CaoGridController : ApiController
    {
        private ICaesBll _caesBll;

        public CaoGridController(ICaesBll caesBll)
        {
            _caesBll = caesBll;
        }

        public IEnumerable<CaesVM> Get()
        {
            return _caesBll.Listar();
        }

    }
}
using CharlieDogs.BusinessLogic;
using CharlieDogs.Domain.ViewModel;
using System.Collections.Generic;
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
            var lista = _caesBll.Listar();
            return lista;
        }

    }
}
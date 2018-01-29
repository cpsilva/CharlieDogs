using CharlieDogs.DataAccess;
using CharlieDogs.Domain.ViewModel;
using System.Collections.Generic;

namespace CharlieDogs.BusinessLogic
{
    public class CaesBll : ICaesBll
    {
        private readonly IUnitOfWork _uow;


        public CaesBll(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public IEnumerable<CaesVM> Listar()
        {
            var lista = _uow.QueryStack.Cachorros.Listar();

            return AutoMapper.Mapper.Map<IEnumerable<CaesVM>>(lista);
        }
    }
}

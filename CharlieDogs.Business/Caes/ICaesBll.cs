using CharlieDogs.Domain.ViewModel;
using System.Collections.Generic;

namespace CharlieDogs.BusinessLogic
{
    public interface ICaesBll
    {
        IEnumerable<CaesVM> Listar();

        CaesVM Selecionar(CaesVM cao);
    }
}

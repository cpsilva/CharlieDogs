using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharlieDogs.DataAccess.Tests
{
    /// <summary>
    /// Summary description for IntegracaoTest
    /// </summary>
    [TestClass]
    public class IntegracaoTest
    {
        private IUnitOfWork _uow;

        public IntegracaoTest()
        {
            Mapping.Initialize.Init();
            DependenceInjection.Initialize.InitSingleton();
            _uow = DependenceInjection.Initialize.Instance<UnitOfWork>(typeof(UnitOfWork));
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [TestMethod]
        public void Connection()
        {
            var lista = _uow.QueryStack.Raca.Listar();
        }

        //[TestMethod]
        //public void Insert()
        //{
        //    var raca = new RacaEntity()
        //    {
        //        RCA_DESCRICAO = "Husky"
        //    };

        //    _uow.CommandStack.Raca.Salvar(raca);
        //    _uow.CommandStack.Save();
        //}
    }
}
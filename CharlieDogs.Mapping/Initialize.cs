using AutoMapper;
using AutoMapper.Configuration;
using System;
using System.Linq;

namespace CharlieDogs.Mapping
{
    public static class Initialize
    {
        public static void Init()
        {
            var asm = AppDomain.CurrentDomain.GetAssemblies();
            var config = new MapperConfigurationExpression();

            foreach (var item in asm.Where(o => o.FullName.StartsWith("CharlieDogs.")))
            {
                config.AddProfiles(item);
            }

            Mapper.Initialize(config);
        }
    }
}
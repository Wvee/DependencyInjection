using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.Models;

namespace DependencyInjection.Infrastructure
{
    public class TypeBroker
    {
        private static Type s_repoType = typeof(MemoryRepository);
        private static IRepository s_testRepo;
        public static IRepository Repository =>
            s_testRepo ?? Activator.CreateInstance(s_repoType) as IRepository;
        public static void SetRepositoryType<T>() where T : IRepository => s_repoType = typeof(T);
        public static void SetTestObject(IRepository repo)
        {
            s_testRepo = repo;
        }
    }
}

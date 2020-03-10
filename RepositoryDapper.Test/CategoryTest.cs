using ConexaoDapper;
using ExpressionBuilder.Generics;
using ExpressionBuilder.Operations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepositoryDapper.Entities;
using RepositoryDapper.Test.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryDapper.Test
{
    [TestClass]
    public class CategoryTest
    {
        [TestInitialize]
        public void Initialize()
        {
            var start = new Startup();
            start.Run();
        }

        [TestMethod]
        public void Get()
        {
            Category myCategory;

            using (var repository = new CategoryRepository())
            {
                var myCondition = new Filter<Category>();
                myCondition.By("Id", Operation.EqualTo, 1);
                myCategory = repository.Get(myCondition);
            }

            Assert.AreNotEqual(null, myCategory, "Category is null!");
            Assert.IsTrue(myCategory.Id == 1, "Incorrect category!");
        }

        [TestMethod]
        public void GetAll()
        {
            IEnumerable<Category> categories;

            using (var repository = new CategoryRepository())
                categories = repository.GetAll();

            Assert.AreNotEqual(null, categories, "Categories is null!");
            Assert.IsTrue(categories.ToList().Count > 1, "Incorrect category!");
        }

        [TestMethod]
        public void Insert()
        {
            using (var repository = new CategoryRepository())
            {
                var cat = new Category { Id = 3, Name = "xpto" };
                repository.Insert(cat);
            }

        }

        [TestMethod]
        public void Update()
        {
            using (var repository = new CategoryRepository())
            {
                var myCategoryXpto = repository.Get(x => x.Id == 3);
                myCategoryXpto.Name = "Xpto Updated!";
                var result = repository.Update(myCategoryXpto);
                
                Assert.IsTrue(result, "Fail to update entitie.");
            }
        }

        [TestMethod]
        public void Delete()
        {
            using (var repository = new CategoryRepository())
            {
                var entitie = CreateIfNotExists(5, "acme");
                var result = repository.Delete(entitie);

                Assert.IsTrue(result, "Fail to delete entitie.");
            }
        }

        public Category CreateIfNotExists(int id, string name)
        {
            using (var repository = new CategoryRepository())
            {
                var entitie = repository.Get(x => x.Id == id);

                if (entitie != null)
                    return entitie;

                repository.Insert(new Category { Id = id, Name = name });

                return CreateIfNotExists(id, name);
            }
        }
    }
}

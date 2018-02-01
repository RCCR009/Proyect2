using System;
using System.Collections.Generic;
using Entities_POJO;
using DataAcess.Mapper;

namespace DataAcess.Crud
{
    public class CustomerCrudFactory : CrudFactory
    {
        public CustomerCrudFactory() : base()
        {
            EntityMapper = new CustomerMapper();
        }

        public override void Create(BaseEntity entity)
        {
            
            throw new NotImplementedException();
        }

        public override void Delete(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public override T Retrieve<T>(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public override List<T> RetrieveAll<T>()
        {
            throw new NotImplementedException();
        }

        public override void Update(BaseEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}

﻿using EasyCashIdentityProject.BusinessLayer.Abstract;
using EasyCashIdentityProject.DataAccessLayer.Abstract;
using EasyCashIdentityProject.Entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.Concrete
{
    public class CustomerAccountProcessManager : ICustomerAccountProcessService
    {
        private readonly ICustomerAccountProcessDal _customerAccountProcessDal;

        public CustomerAccountProcessManager(ICustomerAccountProcessDal customerAccountProcessDal)
        {
            _customerAccountProcessDal=customerAccountProcessDal;
        }

        public void TDelete(CustomerAccountProcess entity)
        {
            _customerAccountProcessDal.Delete(entity);
        }

        public CustomerAccountProcess TGetById(int id)
        {
           return _customerAccountProcessDal.GetById(id);
        }

        public List<CustomerAccountProcess> TGetList()
        {
           return _customerAccountProcessDal.GetList();
        }

        public void TInsert(CustomerAccountProcess entity)
        {
            _customerAccountProcessDal.Insert(entity);
        }

        public void TUpdate(CustomerAccountProcess entity)
        {
          _customerAccountProcessDal.Update(entity);
        }
    }
}

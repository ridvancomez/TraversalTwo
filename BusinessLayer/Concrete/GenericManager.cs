using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class GenericManager<T> : IGenericService<T> where T : class
    {
        protected readonly IGenericDal<T> _dal;

        public GenericManager(IGenericDal<T> dal) => _dal = dal;
        

        public void TAdd(T t) => _dal.Insert(t);

        public void TDelete(T t) => _dal.Delete(t);

        public T TGetById(int id) => _dal.GetById(id);

        public List<T> TGetList() => _dal.GetAll();

        public void TUpdate(T t) => _dal.Update(t);
    }
}

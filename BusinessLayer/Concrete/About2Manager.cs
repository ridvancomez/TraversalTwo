using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class About2Manager : GenericManager<About2>, IAbout2Service
    {
        public About2Manager(IGenericDal<About2> dal) : base(dal)
        {
        }
    }
}

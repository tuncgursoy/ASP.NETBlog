using Core.DataAccess;
using Entity.Entities;
using DataAccess.Abstract;
namespace DataAccess.Concrete
{
  public class EftblresimDal : EfEntityRepositoryBase<tblresim, dbBlogWebContext>, ItblresimDal
  {
  }
}

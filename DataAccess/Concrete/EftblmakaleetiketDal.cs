using Core.DataAccess;
using Entity.Entities;
using DataAccess.Abstract;
namespace DataAccess.Concrete
{
  public class EftblmakaleetiketDal : EfEntityRepositoryBase<tblmakaleetiket, dbBlogWebContext>, ItblmakaleetiketDal
  {
  }
}

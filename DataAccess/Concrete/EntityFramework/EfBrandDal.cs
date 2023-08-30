using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework;

public class EfBrandDal : IBrandDal
{
    public List<Brand> GetAll(Expression<Func<Brand, bool>>? filter = null)
    {
        using (CarRentalContext context = new CarRentalContext())
        {
            return filter == null ? context.Set<Brand>().ToList() : context.Set<Brand>().Where(filter).ToList();
        }
    }

    public Brand Get(Expression<Func<Brand, bool>> filter)
    {
        using (CarRentalContext context = new CarRentalContext())
        {
            return context.Set<Brand>().SingleOrDefault(filter) ?? throw new Exception("NULL");
        }
    }

    public void Add(Brand entity)
    {
        using (CarRentalContext context = new CarRentalContext())
        {
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }
    }

    public void Update(Brand entity)
    {
        using (CarRentalContext context = new CarRentalContext())
        {
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }

    public void Delete(Brand entity)
    {
        using (CarRentalContext context = new CarRentalContext())
        {
            var deletedEntity = context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }
    }
}
using Hitmans.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hitmans
{
    public class WaluigiTime : IWaluigiTime
    {
        public void CreateSome(Hitmany created)
        {
            method(context =>
            {
                hitman alpha = new hitman();
                alpha.hitmansId = created.ID;
                alpha.name = created.Name;
                alpha.picture = created.PicLink;
                alpha.price = created.Price;
                context.hitmans.Add(alpha);
                context.Entry(alpha).State = EntityState.Added;
                context.SaveChanges();
            });

            int id = GetSomeMore().FirstOrDefault(p => p.Name == created.Name && p.Price == created.Price).ID;
            foreach (var detail in created.Description)
            {
                CreateSomeInfo(id, detail);
            }

        }

        public void CreateSomeInfo(int id, string details)
        {
            method(context =>
            {
                detail info = new detail();
                info.hitmansId = id;
                info.detailText = details;
                context.details.Add(info);
                context.Entry(info).State = EntityState.Added;
                context.SaveChanges();

            });
        }

        public void DeleteSome(int id)
        {
            method(context =>
            {
                foreach (var item in context.details.Where(p => p.hitmansId == id))
                {
                    DeleteSomeInfo(id, item.detailId);
                }

                context.Entry(context.hitmans.Remove(context.hitmans.SingleOrDefault(p => p.hitmansId == id))).State = EntityState.Deleted;
                context.SaveChanges();
            });
        }

        public void DeleteSomeInfo(int id, int infoId)
        {
            method(context =>
            {
                 context.Entry(context.details.Remove(context.details.SingleOrDefault(p => p.hitmansId == id && p.detailId == infoId))).State = EntityState.Deleted;
                context.SaveChanges();
            });

        }

        public Hitmany GetSome(int id)
        {
            throw new NotImplementedException();
        }

        public List<detail> GetSomeInfo(int id)
        {
            throw new NotImplementedException();
        }

        public List<Hitmany> GetSomeMore()
        {
            List<Hitmany> assassins = new List<Hitmany>();

            method(context =>
            {
                var thing = context.hitmans.ToList();
                List<string> descriptions = new List<string>();
                foreach (var item in thing)
                {
                    Hitmany person = new Hitmany()
                    {
                        ID = item.hitmansId,
                        Name = item.name,
                        Price = item.price,
                        PicLink = item.picture

                    };

                    var deets = item.details.Where(d => d.hitmansId == person.ID);
                       
                    
                    person.Description = descriptions;
                    assassins.Add(person);
                }
            });

            return assassins;
        }

        public void UpdateSome(Hitmany updates)
        {
            throw new NotImplementedException();
        }

        public void UpdateSomeInfo(detail updates)
        {
            throw new NotImplementedException();
        }

        private void method(Action<HitmenEntities> action)
        {
            using (HitmenEntities context = new HitmenEntities())
            {
                action(context);
            }
        }
    }
}

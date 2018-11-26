using Hitmans.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hitmans
{
    public interface IWaluigiTime
    {
        Hitmany GetSome(int id);
        List<Hitmany> GetSomeMore();
        List<detail> GetSomeInfo(int id);

        void DeleteSome(int id);
        void DeleteSomeInfo(int id, int infoId);

        void UpdateSome(Hitmany updates);
        void UpdateSomeInfo(detail updates);

        void CreateSome(Hitmany created);
        void CreateSomeInfo(int id, string getSomeCheese);

    }
}

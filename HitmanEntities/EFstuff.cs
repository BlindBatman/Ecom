using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitmanEntities
{
    public interface IHitmen
    {
        void CreateHitman();
        void HitmanBYid();
        void DeleteHitman();
        HitmenModels GetAllHitman();

    }
}

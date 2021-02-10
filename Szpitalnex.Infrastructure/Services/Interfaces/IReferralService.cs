using System;
using System.Collections.Generic;
using System.Text;
using Szpitalnex.Core.Dto;

namespace Szpitalnex.Infrastructure.Interfaces
{
    public interface IReferralService
    {
        //ReferralDto Get(int id);
        //IEnumerable<ReferralDto> GetAll();
        bool Add(ReferralDto entity);
        //bool Update(ReferralDto entity);
        //bool Delete(ReferralDto entity);
    }
}

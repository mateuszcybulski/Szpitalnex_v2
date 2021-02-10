using System;
using System.Collections.Generic;
using System.Text;
using Szpitalnex.Core.Dto;

namespace Szpitalnex.Infrastructure.Interfaces
{
    public interface IVisitsService
    {
        VisitDto Get(int id);
        IEnumerable<VisitDto> GetAll();
        bool Add(VisitDto entity);
        bool Add(VisitDto visit, int IdDoctor);
        bool Update(VisitDto entity);
        bool Delete(VisitDto entity);
    }
}

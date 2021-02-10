using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Szpitalnex.Core.Dto;
using Szpitalnex.Database.Repositories.Base.Interfaces;
using Szpitalnex.Infrastructure.Interfaces;

namespace Szpitalnex.Infrastructure.Models
{
    public class VisitsService : IVisitsService
    {

        private readonly IMapper mMapper;    
        private readonly IVisitRepository mVisitRepository;


        public VisitsService(   IMapper mapper,
                                IVisitRepository visitRepository)
        {
            mMapper = mapper;
            mVisitRepository = visitRepository;
        }


        public VisitDto Get(int id)
        {
            var visit = mVisitRepository.Get(id);

            return mMapper.Map<VisitDto>(visit);
        }

        public IEnumerable<VisitDto> GetAll()
        {
            var visit = mVisitRepository.GetAllVisits();

            return mMapper.Map<IEnumerable<VisitDto>>(visit);
        }

        public bool Add(VisitDto entity)
        {
            throw new NotImplementedException();
        }

        public bool Add(VisitDto visit, int IdDoctor)
        {
            throw new NotImplementedException();
        }

        public bool AddNewVisit(VisitDto visit)
        {
            throw new NotImplementedException();
        }

        public bool Delete(VisitDto entity)
        {
            throw new NotImplementedException();
        }


        public bool Update(VisitDto entity)
        {
            throw new NotImplementedException();
        }
    }
}

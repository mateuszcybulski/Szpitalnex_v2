using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Szpitalnex.Core.Dto;
using Szpitalnex.Database.Repositories.Base.Interfaces;
using Szpitalnex.Infrastructure.Interfaces;

namespace Szpitalnex.Infrastructure.Models
{
    public class ReferralService : IReferralService
    {

        private readonly IMapper mMapper;
        private readonly IReferralRepository mReferralRepository;

        public ReferralService(IMapper mapper,
                                IReferralRepository referralRepository)
        {
            mMapper = mapper;
            mReferralRepository = referralRepository;
        }

        public bool Add(ReferralDto entity)
        {
            throw new NotImplementedException();
        }


        //AddNewReferralForVisit
    }
}

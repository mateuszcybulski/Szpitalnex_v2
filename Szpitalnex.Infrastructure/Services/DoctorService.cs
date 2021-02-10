using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Szpitalnex.Core.Dto;
using Szpitalnex.Database.Repositories.Base.Interfaces;
using Szpitalnex.Infrastructure.Interfaces;

namespace Szpitalnex.Infrastructure.Models
{
    public class DoctorService : IDoctorService
    {
        private readonly IMapper mMapper;
        private readonly IDoctorRepository mDoctorRepository;

        public DoctorService(IMapper mapper,
                                IDoctorRepository doctorRepository)
        {
            mMapper = mapper;
            mDoctorRepository = doctorRepository;
        }
        public DoctorDto Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}

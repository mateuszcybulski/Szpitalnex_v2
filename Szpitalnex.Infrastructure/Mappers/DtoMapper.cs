using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Szpitalnex.Core.Dto;
using Szpitalnex.Database.Entities;

namespace Szpitalnex.Infrastructure.Mappers
{
    public static class DtoMapper
    {
        public static IMapper Initialize()
            => new MapperConfiguration(config =>
            {
                config.CreateMap<Doctor, DoctorDto>()
                       .ReverseMap();
                config.CreateMap<Specialization, SpecializationDto>()
                      .ReverseMap();
                config.CreateMap<Visit, VisitDto>()
                      .ReverseMap();
                config.CreateMap<Address, AddressDto>()
                      .ReverseMap();
                config.CreateMap<DiagnosedDisease, DiagnosedDiseaseDto>()
                      .ReverseMap();
                config.CreateMap<Disease, DiseaseDto>()
                      .ReverseMap();
                config.CreateMap<Medicine, MedicineDto>()
                      .ReverseMap();
                config.CreateMap<Patient, PatientDto>()
                      .ReverseMap();
                config.CreateMap<Person, PersonDto>()
                      .ReverseMap();
                config.CreateMap<PrescribedMedicine, PrescribedMedicineDto>()
                      .ReverseMap();
                config.CreateMap<Referral, ReferralDto>()
                      .ReverseMap();
                config.CreateMap<DoctorAvailability, DoctorAvailabilityDto>()
                      .ReverseMap();
            }).CreateMapper();
    }
}

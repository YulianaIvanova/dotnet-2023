﻿using AdmissionCommittee.Server.Dto;
using AutoMapper;

namespace AdmissionCommittee.Server;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Entrant, EntrantGetDto>();
        CreateMap<Entrant, EntrantPostDto>();
        CreateMap<EntrantPostDto, Entrant>();

        CreateMap<List<Result>, List<ResultPostDto>>();

        CreateMap<Speciality, SpecialityPostDto>();
        CreateMap<SpecialityPostDto, Speciality>();
    }
}
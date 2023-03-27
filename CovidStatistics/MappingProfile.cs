using AutoMapper;
using Entities.Models;
using Shared.Dtos;

namespace CovidStatistics;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Case, CaseDto>();
    }
}
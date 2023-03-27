using CsvHelper.Configuration;
using Entities.Models;

namespace Service;

public sealed class MsCaseMap : ClassMap<Case>
{
    public MsCaseMap()
    {
        Map(m => m.Date).Name("date");
        Map(m => m.NumberOfActiveCases).Name("region.ms.cases.active");
        Map(m => m.NumberOfVacinatedFirst).Name("region.ms.vaccinated.1st.todate");
        Map(m => m.NumberOfVacinatedSecond).Name("region.ms.vaccinated.2nd.todate");
        Map(m => m.DeceasedToDate).Name("region.ms.deceased.todate");
    }
}
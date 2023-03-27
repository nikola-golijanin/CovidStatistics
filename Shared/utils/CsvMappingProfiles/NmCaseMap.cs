using CsvHelper.Configuration;
using Entities.Models;

namespace Service;

public sealed class NmCaseMap : ClassMap<Case>
{
    public NmCaseMap()
    {
        Map(m => m.Date).Name("date");
        Map(m => m.NumberOfActiveCases).Name("region.nm.cases.active");
        Map(m => m.NumberOfVacinatedFirst).Name("region.nm.vaccinated.1st.todate");
        Map(m => m.NumberOfVacinatedSecond).Name("region.nm.vaccinated.2nd.todate");
        Map(m => m.DeceasedToDate).Name("region.nm.deceased.todate");
    }
}
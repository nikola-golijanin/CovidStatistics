using CsvHelper.Configuration;
using Entities.Models;

namespace Service;

public sealed class KkCaseMap : ClassMap<Case>
{
    public KkCaseMap()
    {
        Map(m => m.Date).Name("date");
        Map(m => m.NumberOfActiveCases).Name("region.kk.cases.active");
        Map(m => m.NumberOfVacinatedFirst).Name("region.kk.vaccinated.1st.todate");
        Map(m => m.NumberOfVacinatedSecond).Name("region.kk.vaccinated.2nd.todate");
        Map(m => m.DeceasedToDate).Name("region.kk.deceased.todate");
    }
}
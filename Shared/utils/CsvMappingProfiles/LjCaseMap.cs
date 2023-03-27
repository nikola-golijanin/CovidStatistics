using CsvHelper.Configuration;
using Entities.Models;

namespace Service;

public sealed class LjCaseMap : ClassMap<Case>
{
    public LjCaseMap()
    {
        Map(m => m.Date).Name("date");
        Map(m => m.NumberOfActiveCases).Name("region.lj.cases.active");
        Map(m => m.NumberOfVacinatedFirst).Name("region.lj.vaccinated.1st.todate");
        Map(m => m.NumberOfVacinatedSecond).Name("region.lj.vaccinated.2nd.todate");
        Map(m => m.DeceasedToDate).Name("region.lj.deceased.todate");
    }
}
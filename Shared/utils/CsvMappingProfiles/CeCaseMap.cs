using CsvHelper.Configuration;
using Entities.Models;

namespace Service;

public sealed class CeCaseMap : ClassMap<Case>
{
    public CeCaseMap()
    {
        Map(m => m.Date).Name("date");
        Map(m => m.NumberOfActiveCases).Name("region.ce.cases.active");
        Map(m => m.NumberOfVacinatedFirst).Name("region.ce.vaccinated.1st.todate");
        Map(m => m.NumberOfVacinatedSecond).Name("region.ce.vaccinated.2nd.todate");
        Map(m => m.DeceasedToDate).Name("region.ce.deceased.todate");
    }
}
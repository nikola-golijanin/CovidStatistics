using CsvHelper.Configuration;
using Entities.Models;

namespace Service;

public sealed class PoCaseMap : ClassMap<Case>
{
    public PoCaseMap()
    {
        Map(m => m.Date).Name("date");
        Map(m => m.NumberOfActiveCases).Name("region.po.cases.active");
        Map(m => m.NumberOfVacinatedFirst).Name("region.po.vaccinated.1st.todate");
        Map(m => m.NumberOfVacinatedSecond).Name("region.po.vaccinated.2nd.todate");
        Map(m => m.DeceasedToDate).Name("region.po.deceased.todate");
    }
}
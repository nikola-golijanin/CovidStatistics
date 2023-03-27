using CsvHelper.Configuration;
using Entities.Models;

namespace Service;

public sealed class MbCaseMap : ClassMap<Case>
{
    public MbCaseMap()
    {
        Map(m => m.Date).Name("date");
        Map(m => m.NumberOfActiveCases).Name("region.mb.cases.active");
        Map(m => m.NumberOfVacinatedFirst).Name("region.mb.vaccinated.1st.todate");
        Map(m => m.NumberOfVacinatedSecond).Name("region.mb.vaccinated.2nd.todate");
        Map(m => m.DeceasedToDate).Name("region.mb.deceased.todate");
    }
}
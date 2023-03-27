using CsvHelper.Configuration;
using Entities.Models;

namespace Service;

public sealed class SgCaseMap : ClassMap<Case>
{
    public SgCaseMap()
    {
        Map(m => m.Date).Name("date");
        Map(m => m.NumberOfActiveCases).Name("region.sg.cases.active");
        Map(m => m.NumberOfVacinatedFirst).Name("region.sg.vaccinated.1st.todate");
        Map(m => m.NumberOfVacinatedSecond).Name("region.sg.vaccinated.2nd.todate");
        Map(m => m.DeceasedToDate).Name("region.sg.deceased.todate");
    }
}
using CsvHelper.Configuration;
using Entities.Models;

namespace Service;

public sealed class NgCaseMap : ClassMap<Case>
{
    public NgCaseMap()
    {
        Map(m => m.Date).Name("date");
        Map(m => m.NumberOfActiveCases).Name("region.ng.cases.active");
        Map(m => m.NumberOfVacinatedFirst).Name("region.ng.vaccinated.1st.todate");
        Map(m => m.NumberOfVacinatedSecond).Name("region.ng.vaccinated.2nd.todate");
        Map(m => m.DeceasedToDate).Name("region.ng.deceased.todate");
    }
}
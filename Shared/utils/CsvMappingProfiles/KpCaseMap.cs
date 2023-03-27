using CsvHelper.Configuration;
using Entities.Models;

namespace Service;

public sealed class KpCaseMap : ClassMap<Case>
{
    public KpCaseMap()
    {
        Map(m => m.Date).Name("date");
        Map(m => m.NumberOfActiveCases).Name("region.kp.cases.active");
        Map(m => m.NumberOfVacinatedFirst).Name("region.kp.vaccinated.1st.todate");
        Map(m => m.NumberOfVacinatedSecond).Name("region.kp.vaccinated.2nd.todate");
        Map(m => m.DeceasedToDate).Name("region.kp.deceased.todate");
    }
}
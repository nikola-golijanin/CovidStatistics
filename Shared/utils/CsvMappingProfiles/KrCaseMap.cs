using CsvHelper.Configuration;
using Entities.Models;

namespace Service;

public sealed class KrCaseMap : ClassMap<Case>
{
    public KrCaseMap()
    {
        Map(m => m.Date).Name("date");
        Map(m => m.NumberOfActiveCases).Name("region.kr.cases.active");
        Map(m => m.NumberOfVacinatedFirst).Name("region.kr.vaccinated.1st.todate");
        Map(m => m.NumberOfVacinatedSecond).Name("region.kr.vaccinated.2nd.todate");
        Map(m => m.DeceasedToDate).Name("region.kr.deceased.todate");
    }
}
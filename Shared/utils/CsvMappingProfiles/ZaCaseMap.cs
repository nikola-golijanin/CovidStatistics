using CsvHelper.Configuration;
using Entities.Models;

namespace Service;

public sealed class ZaCaseMap : ClassMap<Case>
{
    public ZaCaseMap()
    {
        Map(m => m.Date).Name("date");
        Map(m => m.NumberOfActiveCases).Name("region.za.cases.active");
        Map(m => m.NumberOfVacinatedFirst).Name("region.za.vaccinated.1st.todate");
        Map(m => m.NumberOfVacinatedSecond).Name("region.za.vaccinated.2nd.todate");
        Map(m => m.DeceasedToDate).Name("region.za.deceased.todate");
    }
}
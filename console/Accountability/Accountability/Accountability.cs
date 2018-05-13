using System;
using AnalysisPatterns.ObservationsAndMeasurements;

namespace AnalysisPatterns.Accountability
{
    public class Accountability {
        public PartyId Commissioner {get;}
        public PartyId Responsible {get;}

        public AccountabilityType AccountabilityType {get;}
        public TimePeriod TimePeriod {get;}
    }
}
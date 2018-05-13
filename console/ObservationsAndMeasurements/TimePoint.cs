using System;

namespace AnalysisPatterns.ObservationsAndMeasurements
{
    public class TimePoint {
        public DateTime Value {get;}
        public TimePoint(DateTime value){
            this.Value = value;
        }
    }
}
using System;

namespace AnalysisPatterns.ObservationsAndMeasurements
{
    public class Money : Quantity<decimal>{
        public Currency Currency {
            get{
                return new Currency(this.Units.Name);
            }
        }
    }
}
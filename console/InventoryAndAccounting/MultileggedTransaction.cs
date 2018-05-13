using System.Collections.Generic;
using System.Linq;
using AnalysisPatterns.ObservationsAndMeasurements;

namespace AnalysisPatterns.InventoryAndAccounting
{
    public class MultileggedTransaction{
        public List<Entry> Entries {get;}

        public MultileggedTransaction(List<Entry> entries){
            if(this.Entries == null) throw new AnalysisPatternsException("Multilegged transaction entries are required");
            
            var sum = this.Entries.Sum((entry) => entry.Amount.Amount);
            if(sum != 0) throw new AnalysisPatternsException("Multilegged transactions sum of entries must equal two zero");            
        }
    }
}
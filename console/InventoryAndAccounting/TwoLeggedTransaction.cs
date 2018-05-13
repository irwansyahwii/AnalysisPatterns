using System.Collections.Generic;
using System.Linq;
using AnalysisPatterns.ObservationsAndMeasurements;

namespace AnalysisPatterns.InventoryAndAccounting
{

    public class TwoLeggedTransaction{
        public List<Entry> Entries {get;}

        public TwoLeggedTransaction(List<Entry> entries){
            this.Entries = entries;

            ValidateProperties();
        }

        private void ValidateProperties()
        {
            if(this.Entries == null) throw new AnalysisPatternsException("Two legged transaction entries are required");
            if(this.Entries.Count < 2) throw new AnalysisPatternsException("Two legged transaction must have two entries");
            
            var sum = this.Entries.Sum((entry) => entry.Amount.Amount);
            if(sum != 0) throw new AnalysisPatternsException("Two legged transactions sum of entries must equal two zero");
        }
    }
}
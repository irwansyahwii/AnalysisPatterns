using System.Collections.Generic;

namespace AnalysisPatterns.ObservationsAndMeasurements
{
    public class CompoundUnit : Unit {
        public HashSet<AtomicUnit> Direct {get;}
        public HashSet<AtomicUnit> Inverse {get;}

        public CompoundUnit(string name, HashSet<AtomicUnit> direct, HashSet<AtomicUnit> inverse):base(name){
            this.Direct = direct;
            this.Inverse = inverse;

            ValidateProperties();
        }

        private void ValidateProperties()
        {
            if(this.Direct == null) throw new AnalysisPatternsException("Compound unit's Direct is required");
            if(this.Inverse == null) throw new AnalysisPatternsException("Compound unit's Inverse is required");

            if(this.Direct.Count < 1 && this.Inverse.Count < 2){
                throw new AnalysisPatternsException("Compound unit must have at least one inverse or at least two direct units");
            }
        }
    }
}
using System;

namespace AnalysisPatterns.ObservationsAndMeasurements
{
    public class Range<T>{
        public bool IsUpperInclusive {get;}
        public bool IsLowerInclusive {get;}

        public T Upper {get;}
        public T Lower {get;}

        public virtual bool IsIncludes(T upper, T lower){
            throw new NotImplementedException();
        }
        public virtual bool IsOverlaps(Range<T> otherRange){
            throw new NotImplementedException();
        }
        public virtual bool IsAbuts(Range<T> range){
            throw new NotImplementedException();
        }
    }
}
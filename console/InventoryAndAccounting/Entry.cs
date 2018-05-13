using AnalysisPatterns.ObservationsAndMeasurements;

namespace AnalysisPatterns.InventoryAndAccounting
{
    public class Entry {
        public AccountId AccountId {get;}
        public Money Amount {get;}

        public TimePoint WhenCharged {get;}
        public TimePoint WhenBooked {get;}
    }
}
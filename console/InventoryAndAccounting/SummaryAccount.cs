using System.Collections.Generic;

namespace AnalysisPatterns.InventoryAndAccounting
{
    public class SummaryAccount: Account {
        public HashSet<Account> Components {get;}
    }
}
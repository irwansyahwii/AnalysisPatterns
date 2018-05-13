using System;
using System.Runtime.Serialization;

namespace AnalysisPatterns.ObservationsAndMeasurements
{
    [Serializable]
    internal class AnalysisPatternsException : Exception
    {
        public AnalysisPatternsException()
        {
        }

        public AnalysisPatternsException(string message) : base(message)
        {
        }

        public AnalysisPatternsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AnalysisPatternsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
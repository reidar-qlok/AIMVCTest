using Microsoft.ML.Data;

namespace AIMVCTest
{
    public class FaqPrediction
    {
        [ColumnName("PredictedLabel")]
        public string Answer { get; set; }
    }
}

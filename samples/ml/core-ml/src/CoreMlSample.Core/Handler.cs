namespace CoreMlSample.Core;

public class Handler { public string Process() => "Core ML ready"; }

public class MLPredictor
{
    public class Prediction
    {
        public string Label { get; set; } = string.Empty;
        public float Confidence { get; set; }
    }

    public Prediction Predict(float[] features)
    {
        if (features.Length == 0)
            return new Prediction { Label = "unknown", Confidence = 0 };

        var sum = features.Sum();
        var label = sum > features.Length / 2 ? "positive" : "negative";
        return new Prediction { Label = label, Confidence = Math.Min(sum / features.Length, 1f) };
    }
}
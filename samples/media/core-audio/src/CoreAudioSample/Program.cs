using CoreAudioSample.Core;

Console.WriteLine("[Core Audio DSP Sample]");

var sample = 0.5f;
var gainedSample = AudioDSP.ApplyGain(sample, 2.0f);
Console.WriteLine($"Gain applied: {sample} * 2.0 = {gainedSample}");

var lpFiltered = AudioDSP.SimpleLowPass(0.5f, 0.3f, 0.5f);
Console.WriteLine($"Low-pass filtered: {lpFiltered}");

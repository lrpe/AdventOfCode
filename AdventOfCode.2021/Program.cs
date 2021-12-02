using AdventOfCode._2021;

// Day 1: Sonar Sweep
var sonarSweep = new SonarSweep();
Console.WriteLine("Day 1: Sonar Sweep");

// Part 1
int result = sonarSweep.CountMeasurementsLargerThanPrevious();
Console.WriteLine($"There are {result} measurements that are larger than the previous.");

// Part 2
List<int> batchMeasurements = sonarSweep.BatchMeasurements();
int batchResult = sonarSweep.CountMeasurementsLargerThanPrevious(batchMeasurements);
Console.WriteLine($"There are {batchResult} batch measurements that are larger than the previous.");

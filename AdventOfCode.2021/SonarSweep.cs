using System.Runtime.InteropServices;

namespace AdventOfCode._2021;

public class SonarSweep
{
    public SonarSweep()
    {
        Measurements = File.ReadLines("SonarSweep.txt").Select(int.Parse);
    }

    public IEnumerable<int> Measurements { get; private set; }

    public int CountMeasurementsLargerThanPrevious([Optional] IEnumerable<int> measurements)
    {
        measurements ??= Measurements;

        int measurementsLargerThanPrevious = 0;

        // Start at index 1, since first item has no previous measurement.
        for (int index = 1; index < measurements.Count(); index++)
        {
            if (measurements.ElementAt(index) > measurements.ElementAt(index - 1))
            {
                measurementsLargerThanPrevious++;
            }
        }

        return measurementsLargerThanPrevious;
    }

    public List<int> BatchMeasurements([Optional] IEnumerable<int> measurements, int batchSize = 3)
    {
        measurements ??= Measurements;

        IEnumerable<int> batchMeasurements = measurements
            .SkipLast(batchSize - 1)
            .Select((measurement, index) => measurement + measurements.Skip(index + 1).Take(batchSize - 1).Sum());

        return batchMeasurements.ToList();
    }
}

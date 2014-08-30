using System;
using System.Collections.Generic;
using System.Linq;

public static class AverageAgeCalculator
{
    public static double CalculateAverageAge(List<Animal> animals)
    {
        return animals.Average(animal => animal.Age);
    }
}
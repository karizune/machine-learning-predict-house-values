// This file was auto-generated by ML.NET Model Builder. 

using System;
using Prever_valor_de_casasML.Model;

namespace Prever_valor_de_casasML.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            ModelInput sampleData = new ModelInput()
            {
                Bedrooms = 3F,
                Bathrooms = 1F,
                Sqft_lot = 5650F,
                Floors = 1F,
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = ConsumeModel.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Price with predicted Price from sample data...\n\n");
            Console.WriteLine($"Bedrooms: {sampleData.Bedrooms}");
            Console.WriteLine($"Bathrooms: {sampleData.Bathrooms}");
            Console.WriteLine($"Sqft_lot: {sampleData.Sqft_lot}");
            Console.WriteLine($"Floors: {sampleData.Floors}");
            Console.WriteLine($"\n\nPredicted Price: {predictionResult.Score}\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}

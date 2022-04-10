using System;
using System.Collections.Generic;
using Prever_valor_de_casasML.Model;

namespace Prever_valor_de_casas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add input data

            List<ModelInput> samples = new List<ModelInput>()
            {
                new ModelInput()
                {
                    Bedrooms = 3F,
                    Bathrooms = 1F,
                    Sqft_lot = 5650F,
                    Floors = 1F,
                },
                new ModelInput()
                {
                    Bedrooms = 1F,
                    Bathrooms = 2F,
                    Sqft_lot = 1000F,
                    Floors = 1F,
                },
                new ModelInput()
                {
                    Bedrooms = 5F,
                    Bathrooms = 3F,
                    Sqft_lot = 8420F,
                    Floors = 2F,
                },
            };

            var results = ConsumeModel.PredictAll(samples);
            MostrarResultados(results);
            Console.ReadKey();
        }

        static void MostrarResultados(List<ModelOutput> outputs)
        {
            foreach (var output in outputs)
            {
                Console.WriteLine($"Valor sugerido: {output.Score}");
            }
        }
    }
}

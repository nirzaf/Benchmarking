using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmarking
{
    [MemoryDiagnoser]
    public class DynamicConcatenations
    {
        [Params(1, 2, 3, 4, 5)]
        public int Count { get; set; }

        [Benchmark]
        public string PlusEquals()
        {
            var result = "";

            for (int i = 0; i < Count; i++)
            {
                result += i + " ";
            }

            return result;
        }

        [Benchmark(Baseline = true)]
        public string Builder()
        {
            var result = new StringBuilder();

            for (int i = 0; i < Count; i++)
            {
                result.Append(i).Append(" ");
            }

            return result.ToString();
        }
    }
}

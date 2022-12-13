using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmarking
{
    //[ShortRunJob]
    [MemoryDiagnoser]
    public class FixedConcatenations
    {
        public int X { get; set; } = 1;
        public int Y { get; set; } = 2;
        public int Z { get; set; } = 3;

        [Benchmark]
        public string UsingPlus()
        {
            return "X = " + X + ". Y = " + Y + ". Z = " + Z + ".";
        }

        [Benchmark]
        public string UsingPlusEquals()
        {
            var str = "X = ";
            str += X;
            str += ". Y = ";
            str += Y;
            str += ". Z = ";
            str += Z;
            str += ".";

            return str;
        }

        [Benchmark(Baseline = true)]
        public string UsingInterpolation()
        {
            return $"X = {X}. Y = {Y}. Z = {Z}.";
        }

        [Benchmark]
        public string UsingFormat()
        {
            return string.Format("X = {0}. Y = {1}. Z = {2}.", X, Y, Z);
        }

        [Benchmark]
        public string UsingBuilder()
        {
            var builder = new StringBuilder();

            builder.Append("X = ");
            builder.Append(X);
            builder.Append(". Y = ");
            builder.Append(Y);
            builder.Append(". Z = ");
            builder.Append(Z);
            builder.Append(".");

            return builder.ToString();
        }
    }
}

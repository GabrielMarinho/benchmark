// See https://aka.ms/new-console-template for more information

using Benchmark;
using Benchmark.Tests;
using BenchmarkDotNet.Running;

var summary = BenchmarkRunner.Run<SubstringTest>();
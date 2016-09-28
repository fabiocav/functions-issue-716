#r "TestDependency.dll"

using System;
using TestDependency;

public static void Run(string input, TraceWriter log)
{
    var testType = new TestType();
    var testResult = testType.Test();

    log.Info($"Test function triggered with result: {testResult}");
}
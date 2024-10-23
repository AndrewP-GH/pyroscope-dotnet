// <copyright file="IRunSummary.cs" company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>
#nullable enable
using Datadog.Trace.DuckTyping;

namespace Datadog.Trace.ClrProfiler.AutoInstrumentation.Testing.XUnit;

internal interface IRunSummary
{
    [DuckField]
    public int Total { get; set; }

    [DuckField]
    public int Failed { get; set; }

    [DuckField]
    public int Skipped { get; set; }

    [DuckField]
    public decimal Time { get; set; }

    void Aggregate(IRunSummary other);
}

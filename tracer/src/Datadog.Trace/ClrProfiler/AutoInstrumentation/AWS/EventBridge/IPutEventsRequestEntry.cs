// <copyright file="IPutEventsRequestEntry.cs" company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>

#nullable enable

namespace Datadog.Trace.ClrProfiler.AutoInstrumentation.AWS.EventBridge
{
    /// <summary>
    /// PutEventsRequestEntry interface for ducktyping.
    /// Mirrors Amazon.EventBridge.Model.PutEventsRequestEntry, with unused properties removed.
    /// </summary>
    internal interface IPutEventsRequestEntry
    {
        string? Detail { get; set; }

        string? EventBusName { get; }
    }
}

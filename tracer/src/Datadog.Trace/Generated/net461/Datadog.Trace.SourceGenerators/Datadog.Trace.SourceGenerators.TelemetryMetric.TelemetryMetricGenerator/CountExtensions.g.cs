﻿// <auto-generated/>
#nullable enable

namespace Datadog.Trace.Telemetry.Metrics;
internal static partial class CountExtensions
{
    /// <summary>
    /// The number of separate metrics in the <see cref="Datadog.Trace.Telemetry.Metrics.Count" /> metric.
    /// </summary>
    public const int Length = 34;

    /// <summary>
    /// Gets the metric name for the provided metric
    /// </summary>
    /// <param name="metric">The metric to get the name for</param>
    /// <returns>The datadog metric name</returns>
    public static string GetName(this Datadog.Trace.Telemetry.Metrics.Count metric)
        => metric switch
        {
            Datadog.Trace.Telemetry.Metrics.Count.LogCreated => "logs_created",
            Datadog.Trace.Telemetry.Metrics.Count.IntegrationsError => "integration_errors",
            Datadog.Trace.Telemetry.Metrics.Count.SpanCreated => "spans_created",
            Datadog.Trace.Telemetry.Metrics.Count.SpanFinished => "spans_finished",
            Datadog.Trace.Telemetry.Metrics.Count.SpanEnqueuedForSerialization => "spans_enqueued_for_serialization",
            Datadog.Trace.Telemetry.Metrics.Count.SpanDropped => "spans_dropped",
            Datadog.Trace.Telemetry.Metrics.Count.TraceSegmentCreated => "trace_segments_created",
            Datadog.Trace.Telemetry.Metrics.Count.TraceChunkEnqueued => "trace_chunks_enqueued_for_serialization",
            Datadog.Trace.Telemetry.Metrics.Count.TraceChunkDropped => "trace_chunks_dropped",
            Datadog.Trace.Telemetry.Metrics.Count.TraceChunkSent => "trace_chunks_sent",
            Datadog.Trace.Telemetry.Metrics.Count.TraceSegmentsClosed => "trace_segments_closed",
            Datadog.Trace.Telemetry.Metrics.Count.TraceApiRequests => "trace_api.requests",
            Datadog.Trace.Telemetry.Metrics.Count.TraceApiResponses => "trace_api.responses",
            Datadog.Trace.Telemetry.Metrics.Count.TraceApiErrors => "trace_api.errors",
            Datadog.Trace.Telemetry.Metrics.Count.TracePartialFlush => "trace_partial_flush.count",
            Datadog.Trace.Telemetry.Metrics.Count.ContextHeaderStyleInjected => "context_header_style.injected",
            Datadog.Trace.Telemetry.Metrics.Count.ContextHeaderStyleExtracted => "context_header_style.extracted",
            Datadog.Trace.Telemetry.Metrics.Count.StatsApiRequests => "stats_api.requests",
            Datadog.Trace.Telemetry.Metrics.Count.StatsApiResponses => "stats_api.responses",
            Datadog.Trace.Telemetry.Metrics.Count.StatsApiErrors => "stats_api.errors",
            Datadog.Trace.Telemetry.Metrics.Count.TelemetryApiRequests => "telemetry_api.requests",
            Datadog.Trace.Telemetry.Metrics.Count.TelemetryApiResponses => "telemetry_api.responses",
            Datadog.Trace.Telemetry.Metrics.Count.TelemetryApiErrors => "telemetry_api.errors",
            Datadog.Trace.Telemetry.Metrics.Count.VersionConflictTracerCreated => "version_conflict_tracers_created",
            Datadog.Trace.Telemetry.Metrics.Count.DirectLogLogs => "direct_log_logs",
            Datadog.Trace.Telemetry.Metrics.Count.DirectLogApiRequests => "direct_log_api.requests",
            Datadog.Trace.Telemetry.Metrics.Count.DirectLogApiResponses => "direct_log_api.responses",
            Datadog.Trace.Telemetry.Metrics.Count.DirectLogApiErrors => "direct_log_api.errors",
            Datadog.Trace.Telemetry.Metrics.Count.WafInit => "waf.init",
            Datadog.Trace.Telemetry.Metrics.Count.WafUpdates => "waf.updates",
            Datadog.Trace.Telemetry.Metrics.Count.WafRequests => "waf.requests",
            Datadog.Trace.Telemetry.Metrics.Count.IastExecutedSources => "executed.source",
            Datadog.Trace.Telemetry.Metrics.Count.IastExecutedPropagations => "executed.propagation",
            Datadog.Trace.Telemetry.Metrics.Count.IastExecutedSinks => "executed.sink",
            _ => null!,
        };

    /// <summary>
    /// Gets whether the metric is a "common" metric, used by all tracers
    /// </summary>
    /// <param name="metric">The metric to check</param>
    /// <returns>True if the metric is a "common" metric, used by all languages</returns>
    public static bool IsCommon(this Datadog.Trace.Telemetry.Metrics.Count metric)
        => metric switch
        {
            Datadog.Trace.Telemetry.Metrics.Count.VersionConflictTracerCreated => false,
            Datadog.Trace.Telemetry.Metrics.Count.DirectLogLogs => false,
            Datadog.Trace.Telemetry.Metrics.Count.DirectLogApiRequests => false,
            Datadog.Trace.Telemetry.Metrics.Count.DirectLogApiResponses => false,
            Datadog.Trace.Telemetry.Metrics.Count.DirectLogApiErrors => false,
            _ => true,
        };

    /// <summary>
    /// Gets the custom namespace for the provided metric
    /// </summary>
    /// <param name="metric">The metric to get the name for</param>
    /// <returns>The datadog metric name</returns>
    public static string? GetNamespace(this Datadog.Trace.Telemetry.Metrics.Count metric)
        => metric switch
        {
            Datadog.Trace.Telemetry.Metrics.Count.LogCreated => "general",
            Datadog.Trace.Telemetry.Metrics.Count.TelemetryApiRequests => "telemetry",
            Datadog.Trace.Telemetry.Metrics.Count.TelemetryApiResponses => "telemetry",
            Datadog.Trace.Telemetry.Metrics.Count.TelemetryApiErrors => "telemetry",
            Datadog.Trace.Telemetry.Metrics.Count.WafInit => "appsec",
            Datadog.Trace.Telemetry.Metrics.Count.WafUpdates => "appsec",
            Datadog.Trace.Telemetry.Metrics.Count.WafRequests => "appsec",
            Datadog.Trace.Telemetry.Metrics.Count.IastExecutedSources => "iast",
            Datadog.Trace.Telemetry.Metrics.Count.IastExecutedPropagations => "iast",
            Datadog.Trace.Telemetry.Metrics.Count.IastExecutedSinks => "iast",
            _ => null,
        };
}
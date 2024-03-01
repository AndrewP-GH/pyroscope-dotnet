﻿// <copyright company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>
// <auto-generated/>

#nullable enable

using System.Threading;

namespace Datadog.Trace.Telemetry;
internal partial class MetricsTelemetryCollector
{
    private const int CountLength = 345;

    /// <summary>
    /// Creates the buffer for the <see cref="Datadog.Trace.Telemetry.Metrics.Count" /> values.
    /// </summary>
    private static AggregatedMetric[] GetCountBuffer()
        => new AggregatedMetric[]
        {
            // logs_created, index = 0
            new(new[] { "level:debug" }),
            new(new[] { "level:info" }),
            new(new[] { "level:warn" }),
            new(new[] { "level:error" }),
            // spans_created, index = 4
            new(new[] { "integration_name:datadog" }),
            new(new[] { "integration_name:opentracing" }),
            new(new[] { "integration_name:ciapp" }),
            new(new[] { "integration_name:debugger_span_probe" }),
            new(new[] { "integration_name:aws_lambda" }),
            new(new[] { "integration_name:msbuild" }),
            new(new[] { "integration_name:httpmessagehandler" }),
            new(new[] { "integration_name:httpsocketshandler" }),
            new(new[] { "integration_name:winhttphandler" }),
            new(new[] { "integration_name:curlhandler" }),
            new(new[] { "integration_name:aspnetcore" }),
            new(new[] { "integration_name:adonet" }),
            new(new[] { "integration_name:aspnet" }),
            new(new[] { "integration_name:aspnetmvc" }),
            new(new[] { "integration_name:aspnetwebapi2" }),
            new(new[] { "integration_name:graphql" }),
            new(new[] { "integration_name:hotchocolate" }),
            new(new[] { "integration_name:mongodb" }),
            new(new[] { "integration_name:xunit" }),
            new(new[] { "integration_name:nunit" }),
            new(new[] { "integration_name:mstestv2" }),
            new(new[] { "integration_name:wcf" }),
            new(new[] { "integration_name:webrequest" }),
            new(new[] { "integration_name:elasticsearchnet" }),
            new(new[] { "integration_name:servicestackredis" }),
            new(new[] { "integration_name:stackexchangeredis" }),
            new(new[] { "integration_name:serviceremoting" }),
            new(new[] { "integration_name:rabbitmq" }),
            new(new[] { "integration_name:msmq" }),
            new(new[] { "integration_name:kafka" }),
            new(new[] { "integration_name:cosmosdb" }),
            new(new[] { "integration_name:awssdk" }),
            new(new[] { "integration_name:awssqs" }),
            new(new[] { "integration_name:awssns" }),
            new(new[] { "integration_name:ilogger" }),
            new(new[] { "integration_name:aerospike" }),
            new(new[] { "integration_name:azurefunctions" }),
            new(new[] { "integration_name:couchbase" }),
            new(new[] { "integration_name:mysql" }),
            new(new[] { "integration_name:npgsql" }),
            new(new[] { "integration_name:oracle" }),
            new(new[] { "integration_name:sqlclient" }),
            new(new[] { "integration_name:sqlite" }),
            new(new[] { "integration_name:serilog" }),
            new(new[] { "integration_name:log4net" }),
            new(new[] { "integration_name:nlog" }),
            new(new[] { "integration_name:traceannotations" }),
            new(new[] { "integration_name:grpc" }),
            new(new[] { "integration_name:process" }),
            new(new[] { "integration_name:hashalgorithm" }),
            new(new[] { "integration_name:symmetricalgorithm" }),
            new(new[] { "integration_name:opentelemetry" }),
            new(new[] { "integration_name:pathtraversal" }),
            new(new[] { "integration_name:ssrf" }),
            new(new[] { "integration_name:ldap" }),
            new(new[] { "integration_name:hardcodedsecret" }),
            new(new[] { "integration_name:awskinesis" }),
            new(new[] { "integration_name:azureservicebus" }),
            new(new[] { "integration_name:systemrandom" }),
            new(new[] { "integration_name:awsdynamodb" }),
            new(new[] { "integration_name:ibmmq" }),
            new(new[] { "integration_name:remoting" }),
            new(new[] { "integration_name:trustboundaryviolation" }),
            new(new[] { "integration_name:unvalidatedredirect" }),
            new(new[] { "integration_name:testplatformassemblyresolver" }),
            new(new[] { "integration_name:stacktraceleak" }),
            new(new[] { "integration_name:xpathinjection" }),
            new(new[] { "integration_name:reflectioninjection" }),
            // spans_finished, index = 72
            new(null),
            // spans_enqueued_for_serialization, index = 73
            new(new[] { "reason:p0_keep" }),
            new(new[] { "reason:single_span_sampling" }),
            new(new[] { "reason:default" }),
            // spans_dropped, index = 76
            new(new[] { "reason:p0_drop" }),
            new(new[] { "reason:overfull_buffer" }),
            new(new[] { "reason:serialization_error" }),
            new(new[] { "reason:api_error" }),
            // trace_segments_created, index = 80
            new(new[] { "new_continued:new" }),
            new(new[] { "new_continued:continued" }),
            // trace_chunks_enqueued_for_serialization, index = 82
            new(new[] { "reason:p0_keep" }),
            new(new[] { "reason:default" }),
            // trace_chunks_dropped, index = 84
            new(new[] { "reason:p0_drop" }),
            new(new[] { "reason:overfull_buffer" }),
            new(new[] { "reason:serialization_error" }),
            new(new[] { "reason:api_error" }),
            // trace_chunks_sent, index = 88
            new(null),
            // trace_segments_closed, index = 89
            new(null),
            // trace_api.requests, index = 90
            new(null),
            // trace_api.responses, index = 91
            new(new[] { "status_code:200" }),
            new(new[] { "status_code:201" }),
            new(new[] { "status_code:202" }),
            new(new[] { "status_code:204" }),
            new(new[] { "status_code:2xx" }),
            new(new[] { "status_code:301" }),
            new(new[] { "status_code:302" }),
            new(new[] { "status_code:307" }),
            new(new[] { "status_code:308" }),
            new(new[] { "status_code:3xx" }),
            new(new[] { "status_code:400" }),
            new(new[] { "status_code:401" }),
            new(new[] { "status_code:403" }),
            new(new[] { "status_code:404" }),
            new(new[] { "status_code:405" }),
            new(new[] { "status_code:4xx" }),
            new(new[] { "status_code:500" }),
            new(new[] { "status_code:501" }),
            new(new[] { "status_code:502" }),
            new(new[] { "status_code:503" }),
            new(new[] { "status_code:504" }),
            new(new[] { "status_code:5xx" }),
            // trace_api.errors, index = 113
            new(new[] { "type:timeout" }),
            new(new[] { "type:network" }),
            new(new[] { "type:status_code" }),
            // trace_partial_flush.count, index = 116
            new(new[] { "reason:large_trace" }),
            new(new[] { "reason:single_span_ingestion" }),
            // context_header_style.injected, index = 118
            new(new[] { "header_style:tracecontext" }),
            new(new[] { "header_style:datadog" }),
            new(new[] { "header_style:b3multi" }),
            new(new[] { "header_style:b3single" }),
            // context_header_style.extracted, index = 122
            new(new[] { "header_style:tracecontext" }),
            new(new[] { "header_style:datadog" }),
            new(new[] { "header_style:b3multi" }),
            new(new[] { "header_style:b3single" }),
            // stats_api.requests, index = 126
            new(null),
            // stats_api.responses, index = 127
            new(new[] { "status_code:200" }),
            new(new[] { "status_code:201" }),
            new(new[] { "status_code:202" }),
            new(new[] { "status_code:204" }),
            new(new[] { "status_code:2xx" }),
            new(new[] { "status_code:301" }),
            new(new[] { "status_code:302" }),
            new(new[] { "status_code:307" }),
            new(new[] { "status_code:308" }),
            new(new[] { "status_code:3xx" }),
            new(new[] { "status_code:400" }),
            new(new[] { "status_code:401" }),
            new(new[] { "status_code:403" }),
            new(new[] { "status_code:404" }),
            new(new[] { "status_code:405" }),
            new(new[] { "status_code:4xx" }),
            new(new[] { "status_code:500" }),
            new(new[] { "status_code:501" }),
            new(new[] { "status_code:502" }),
            new(new[] { "status_code:503" }),
            new(new[] { "status_code:504" }),
            new(new[] { "status_code:5xx" }),
            // stats_api.errors, index = 149
            new(new[] { "type:timeout" }),
            new(new[] { "type:network" }),
            new(new[] { "type:status_code" }),
            // telemetry_api.requests, index = 152
            new(new[] { "endpoint:agent" }),
            new(new[] { "endpoint:agentless" }),
            // telemetry_api.responses, index = 154
            new(new[] { "endpoint:agent", "status_code:200" }),
            new(new[] { "endpoint:agent", "status_code:201" }),
            new(new[] { "endpoint:agent", "status_code:202" }),
            new(new[] { "endpoint:agent", "status_code:204" }),
            new(new[] { "endpoint:agent", "status_code:2xx" }),
            new(new[] { "endpoint:agent", "status_code:301" }),
            new(new[] { "endpoint:agent", "status_code:302" }),
            new(new[] { "endpoint:agent", "status_code:307" }),
            new(new[] { "endpoint:agent", "status_code:308" }),
            new(new[] { "endpoint:agent", "status_code:3xx" }),
            new(new[] { "endpoint:agent", "status_code:400" }),
            new(new[] { "endpoint:agent", "status_code:401" }),
            new(new[] { "endpoint:agent", "status_code:403" }),
            new(new[] { "endpoint:agent", "status_code:404" }),
            new(new[] { "endpoint:agent", "status_code:405" }),
            new(new[] { "endpoint:agent", "status_code:4xx" }),
            new(new[] { "endpoint:agent", "status_code:500" }),
            new(new[] { "endpoint:agent", "status_code:501" }),
            new(new[] { "endpoint:agent", "status_code:502" }),
            new(new[] { "endpoint:agent", "status_code:503" }),
            new(new[] { "endpoint:agent", "status_code:504" }),
            new(new[] { "endpoint:agent", "status_code:5xx" }),
            new(new[] { "endpoint:agentless", "status_code:200" }),
            new(new[] { "endpoint:agentless", "status_code:201" }),
            new(new[] { "endpoint:agentless", "status_code:202" }),
            new(new[] { "endpoint:agentless", "status_code:204" }),
            new(new[] { "endpoint:agentless", "status_code:2xx" }),
            new(new[] { "endpoint:agentless", "status_code:301" }),
            new(new[] { "endpoint:agentless", "status_code:302" }),
            new(new[] { "endpoint:agentless", "status_code:307" }),
            new(new[] { "endpoint:agentless", "status_code:308" }),
            new(new[] { "endpoint:agentless", "status_code:3xx" }),
            new(new[] { "endpoint:agentless", "status_code:400" }),
            new(new[] { "endpoint:agentless", "status_code:401" }),
            new(new[] { "endpoint:agentless", "status_code:403" }),
            new(new[] { "endpoint:agentless", "status_code:404" }),
            new(new[] { "endpoint:agentless", "status_code:405" }),
            new(new[] { "endpoint:agentless", "status_code:4xx" }),
            new(new[] { "endpoint:agentless", "status_code:500" }),
            new(new[] { "endpoint:agentless", "status_code:501" }),
            new(new[] { "endpoint:agentless", "status_code:502" }),
            new(new[] { "endpoint:agentless", "status_code:503" }),
            new(new[] { "endpoint:agentless", "status_code:504" }),
            new(new[] { "endpoint:agentless", "status_code:5xx" }),
            // telemetry_api.errors, index = 198
            new(new[] { "endpoint:agent", "type:timeout" }),
            new(new[] { "endpoint:agent", "type:network" }),
            new(new[] { "endpoint:agent", "type:status_code" }),
            new(new[] { "endpoint:agentless", "type:timeout" }),
            new(new[] { "endpoint:agentless", "type:network" }),
            new(new[] { "endpoint:agentless", "type:status_code" }),
            // version_conflict_tracers_created, index = 204
            new(null),
            // direct_log_logs, index = 205
            new(new[] { "integration_name:datadog" }),
            new(new[] { "integration_name:opentracing" }),
            new(new[] { "integration_name:ciapp" }),
            new(new[] { "integration_name:debugger_span_probe" }),
            new(new[] { "integration_name:aws_lambda" }),
            new(new[] { "integration_name:msbuild" }),
            new(new[] { "integration_name:httpmessagehandler" }),
            new(new[] { "integration_name:httpsocketshandler" }),
            new(new[] { "integration_name:winhttphandler" }),
            new(new[] { "integration_name:curlhandler" }),
            new(new[] { "integration_name:aspnetcore" }),
            new(new[] { "integration_name:adonet" }),
            new(new[] { "integration_name:aspnet" }),
            new(new[] { "integration_name:aspnetmvc" }),
            new(new[] { "integration_name:aspnetwebapi2" }),
            new(new[] { "integration_name:graphql" }),
            new(new[] { "integration_name:hotchocolate" }),
            new(new[] { "integration_name:mongodb" }),
            new(new[] { "integration_name:xunit" }),
            new(new[] { "integration_name:nunit" }),
            new(new[] { "integration_name:mstestv2" }),
            new(new[] { "integration_name:wcf" }),
            new(new[] { "integration_name:webrequest" }),
            new(new[] { "integration_name:elasticsearchnet" }),
            new(new[] { "integration_name:servicestackredis" }),
            new(new[] { "integration_name:stackexchangeredis" }),
            new(new[] { "integration_name:serviceremoting" }),
            new(new[] { "integration_name:rabbitmq" }),
            new(new[] { "integration_name:msmq" }),
            new(new[] { "integration_name:kafka" }),
            new(new[] { "integration_name:cosmosdb" }),
            new(new[] { "integration_name:awssdk" }),
            new(new[] { "integration_name:awssqs" }),
            new(new[] { "integration_name:awssns" }),
            new(new[] { "integration_name:ilogger" }),
            new(new[] { "integration_name:aerospike" }),
            new(new[] { "integration_name:azurefunctions" }),
            new(new[] { "integration_name:couchbase" }),
            new(new[] { "integration_name:mysql" }),
            new(new[] { "integration_name:npgsql" }),
            new(new[] { "integration_name:oracle" }),
            new(new[] { "integration_name:sqlclient" }),
            new(new[] { "integration_name:sqlite" }),
            new(new[] { "integration_name:serilog" }),
            new(new[] { "integration_name:log4net" }),
            new(new[] { "integration_name:nlog" }),
            new(new[] { "integration_name:traceannotations" }),
            new(new[] { "integration_name:grpc" }),
            new(new[] { "integration_name:process" }),
            new(new[] { "integration_name:hashalgorithm" }),
            new(new[] { "integration_name:symmetricalgorithm" }),
            new(new[] { "integration_name:opentelemetry" }),
            new(new[] { "integration_name:pathtraversal" }),
            new(new[] { "integration_name:ssrf" }),
            new(new[] { "integration_name:ldap" }),
            new(new[] { "integration_name:hardcodedsecret" }),
            new(new[] { "integration_name:awskinesis" }),
            new(new[] { "integration_name:azureservicebus" }),
            new(new[] { "integration_name:systemrandom" }),
            new(new[] { "integration_name:awsdynamodb" }),
            new(new[] { "integration_name:ibmmq" }),
            new(new[] { "integration_name:remoting" }),
            new(new[] { "integration_name:trustboundaryviolation" }),
            new(new[] { "integration_name:unvalidatedredirect" }),
            new(new[] { "integration_name:testplatformassemblyresolver" }),
            new(new[] { "integration_name:stacktraceleak" }),
            new(new[] { "integration_name:xpathinjection" }),
            new(new[] { "integration_name:reflectioninjection" }),
            // direct_log_api.requests, index = 273
            new(null),
            // direct_log_api.responses, index = 274
            new(new[] { "status_code:200" }),
            new(new[] { "status_code:201" }),
            new(new[] { "status_code:202" }),
            new(new[] { "status_code:204" }),
            new(new[] { "status_code:2xx" }),
            new(new[] { "status_code:301" }),
            new(new[] { "status_code:302" }),
            new(new[] { "status_code:307" }),
            new(new[] { "status_code:308" }),
            new(new[] { "status_code:3xx" }),
            new(new[] { "status_code:400" }),
            new(new[] { "status_code:401" }),
            new(new[] { "status_code:403" }),
            new(new[] { "status_code:404" }),
            new(new[] { "status_code:405" }),
            new(new[] { "status_code:4xx" }),
            new(new[] { "status_code:500" }),
            new(new[] { "status_code:501" }),
            new(new[] { "status_code:502" }),
            new(new[] { "status_code:503" }),
            new(new[] { "status_code:504" }),
            new(new[] { "status_code:5xx" }),
            // direct_log_api.errors, index = 296
            new(new[] { "type:timeout" }),
            new(new[] { "type:network" }),
            new(new[] { "type:status_code" }),
            // waf.init, index = 299
            new(null),
            // waf.updates, index = 300
            new(null),
            // waf.requests, index = 301
            new(new[] { "waf_version", "rule_triggered:false", "request_blocked:false", "waf_timeout:false", "request_excluded:false" }),
            new(new[] { "waf_version", "rule_triggered:true", "request_blocked:false", "waf_timeout:false", "request_excluded:false" }),
            new(new[] { "waf_version", "rule_triggered:true", "request_blocked:true", "waf_timeout:false", "request_excluded:false" }),
            new(new[] { "waf_version", "rule_triggered:false", "request_blocked:false", "waf_timeout:true", "request_excluded:false" }),
            new(new[] { "waf_version", "rule_triggered:false", "request_blocked:false", "waf_timeout:false", "request_excluded:true" }),
            // waf.input_truncated, index = 306
            new(new[] { "truncation_reason:string_too_long" }),
            new(new[] { "truncation_reason:list_or_map_too_large" }),
            new(new[] { "truncation_reason:object_too_deep" }),
            // executed.source, index = 309
            new(new[] { "source_type:http.request.body" }),
            new(new[] { "source_type:http.request.path" }),
            new(new[] { "source_type:http.request.parameter.name" }),
            new(new[] { "source_type:http.request.parameter" }),
            new(new[] { "source_type:http.request.path.parameter" }),
            new(new[] { "source_type:http.request.header" }),
            new(new[] { "source_type:http.request.header.name" }),
            new(new[] { "source_type:http.request.query" }),
            new(new[] { "source_type:http.request.cookie.name" }),
            new(new[] { "source_type:http.request.cookie.value" }),
            new(new[] { "source_type:http.request.matrix.parameter" }),
            new(new[] { "source_type:http.request.uri" }),
            // executed.propagation, index = 321
            new(null),
            // executed.sink, index = 322
            new(new[] { "vulnerability_type:none" }),
            new(new[] { "vulnerability_type:weak_cipher" }),
            new(new[] { "vulnerability_type:weak_hash" }),
            new(new[] { "vulnerability_type:sql_injection" }),
            new(new[] { "vulnerability_type:command_injection" }),
            new(new[] { "vulnerability_type:path_traversal" }),
            new(new[] { "vulnerability_type:ldap_injection" }),
            new(new[] { "vulnerability_type:ssrf" }),
            new(new[] { "vulnerability_type:unvalidated_redirect" }),
            new(new[] { "vulnerability_type:insecure_cookie" }),
            new(new[] { "vulnerability_type:no_httponly_cookie" }),
            new(new[] { "vulnerability_type:no_samesite_cookie" }),
            new(new[] { "vulnerability_type:weak_randomness" }),
            new(new[] { "vulnerability_type:hardcoded_secret" }),
            new(new[] { "vulnerability_type:xcontenttype_header_missing" }),
            new(new[] { "vulnerability_type:trust_boundary_violation" }),
            new(new[] { "vulnerability_type:hsts_header_missing" }),
            new(new[] { "vulnerability_type:header_injection" }),
            new(new[] { "vulnerability_type:stacktrace_leak" }),
            new(new[] { "vulnerability_type:nosql_mongodb_injection" }),
            new(new[] { "vulnerability_type:xpath_injection" }),
            new(new[] { "vulnerability_type:reflection_injection" }),
            // request.tainted, index = 344
            new(null),
        };

    /// <summary>
    /// Gets an array of metric counts, indexed by integer value of the <see cref="Datadog.Trace.Telemetry.Metrics.Count" />.
    /// Each value represents the number of unique entries in the buffer returned by <see cref="GetCountBuffer()" />
    /// It is equal to the cardinality of the tag combinations (or 1 if there are no tags)
    /// </summary>
    private static int[] CountEntryCounts { get; }
        = new int[]{ 4, 68, 1, 3, 4, 2, 2, 4, 1, 1, 1, 22, 3, 2, 4, 4, 1, 22, 3, 2, 44, 6, 1, 68, 1, 22, 3, 1, 1, 5, 3, 12, 1, 22, 1, };

    public void RecordCountLogCreated(Datadog.Trace.Telemetry.Metrics.MetricTags.LogLevel tag, int increment = 1)
    {
        var index = 0 + (int)tag;
        Interlocked.Add(ref _buffer.Count[index], increment);
    }

    public void RecordCountSpanCreated(Datadog.Trace.Telemetry.Metrics.MetricTags.IntegrationName tag, int increment = 1)
    {
        var index = 4 + (int)tag;
        Interlocked.Add(ref _buffer.Count[index], increment);
    }

    public void RecordCountSpanFinished(int increment = 1)
    {
        Interlocked.Add(ref _buffer.Count[72], increment);
    }

    public void RecordCountSpanEnqueuedForSerialization(Datadog.Trace.Telemetry.Metrics.MetricTags.SpanEnqueueReason tag, int increment = 1)
    {
        var index = 73 + (int)tag;
        Interlocked.Add(ref _buffer.Count[index], increment);
    }

    public void RecordCountSpanDropped(Datadog.Trace.Telemetry.Metrics.MetricTags.DropReason tag, int increment = 1)
    {
        var index = 76 + (int)tag;
        Interlocked.Add(ref _buffer.Count[index], increment);
    }

    public void RecordCountTraceSegmentCreated(Datadog.Trace.Telemetry.Metrics.MetricTags.TraceContinuation tag, int increment = 1)
    {
        var index = 80 + (int)tag;
        Interlocked.Add(ref _buffer.Count[index], increment);
    }

    public void RecordCountTraceChunkEnqueued(Datadog.Trace.Telemetry.Metrics.MetricTags.TraceChunkEnqueueReason tag, int increment = 1)
    {
        var index = 82 + (int)tag;
        Interlocked.Add(ref _buffer.Count[index], increment);
    }

    public void RecordCountTraceChunkDropped(Datadog.Trace.Telemetry.Metrics.MetricTags.DropReason tag, int increment = 1)
    {
        var index = 84 + (int)tag;
        Interlocked.Add(ref _buffer.Count[index], increment);
    }

    public void RecordCountTraceChunkSent(int increment = 1)
    {
        Interlocked.Add(ref _buffer.Count[88], increment);
    }

    public void RecordCountTraceSegmentsClosed(int increment = 1)
    {
        Interlocked.Add(ref _buffer.Count[89], increment);
    }

    public void RecordCountTraceApiRequests(int increment = 1)
    {
        Interlocked.Add(ref _buffer.Count[90], increment);
    }

    public void RecordCountTraceApiResponses(Datadog.Trace.Telemetry.Metrics.MetricTags.StatusCode tag, int increment = 1)
    {
        var index = 91 + (int)tag;
        Interlocked.Add(ref _buffer.Count[index], increment);
    }

    public void RecordCountTraceApiErrors(Datadog.Trace.Telemetry.Metrics.MetricTags.ApiError tag, int increment = 1)
    {
        var index = 113 + (int)tag;
        Interlocked.Add(ref _buffer.Count[index], increment);
    }

    public void RecordCountTracePartialFlush(Datadog.Trace.Telemetry.Metrics.MetricTags.PartialFlushReason tag, int increment = 1)
    {
        var index = 116 + (int)tag;
        Interlocked.Add(ref _buffer.Count[index], increment);
    }

    public void RecordCountContextHeaderStyleInjected(Datadog.Trace.Telemetry.Metrics.MetricTags.ContextHeaderStyle tag, int increment = 1)
    {
        var index = 118 + (int)tag;
        Interlocked.Add(ref _buffer.Count[index], increment);
    }

    public void RecordCountContextHeaderStyleExtracted(Datadog.Trace.Telemetry.Metrics.MetricTags.ContextHeaderStyle tag, int increment = 1)
    {
        var index = 122 + (int)tag;
        Interlocked.Add(ref _buffer.Count[index], increment);
    }

    public void RecordCountStatsApiRequests(int increment = 1)
    {
        Interlocked.Add(ref _buffer.Count[126], increment);
    }

    public void RecordCountStatsApiResponses(Datadog.Trace.Telemetry.Metrics.MetricTags.StatusCode tag, int increment = 1)
    {
        var index = 127 + (int)tag;
        Interlocked.Add(ref _buffer.Count[index], increment);
    }

    public void RecordCountStatsApiErrors(Datadog.Trace.Telemetry.Metrics.MetricTags.ApiError tag, int increment = 1)
    {
        var index = 149 + (int)tag;
        Interlocked.Add(ref _buffer.Count[index], increment);
    }

    public void RecordCountTelemetryApiRequests(Datadog.Trace.Telemetry.Metrics.MetricTags.TelemetryEndpoint tag, int increment = 1)
    {
        var index = 152 + (int)tag;
        Interlocked.Add(ref _buffer.Count[index], increment);
    }

    public void RecordCountTelemetryApiResponses(Datadog.Trace.Telemetry.Metrics.MetricTags.TelemetryEndpoint tag1, Datadog.Trace.Telemetry.Metrics.MetricTags.StatusCode tag2, int increment = 1)
    {
        var index = 154 + ((int)tag1 * 22) + (int)tag2;
        Interlocked.Add(ref _buffer.Count[index], increment);
    }

    public void RecordCountTelemetryApiErrors(Datadog.Trace.Telemetry.Metrics.MetricTags.TelemetryEndpoint tag1, Datadog.Trace.Telemetry.Metrics.MetricTags.ApiError tag2, int increment = 1)
    {
        var index = 198 + ((int)tag1 * 3) + (int)tag2;
        Interlocked.Add(ref _buffer.Count[index], increment);
    }

    public void RecordCountVersionConflictTracerCreated(int increment = 1)
    {
        Interlocked.Add(ref _buffer.Count[204], increment);
    }

    public void RecordCountDirectLogLogs(Datadog.Trace.Telemetry.Metrics.MetricTags.IntegrationName tag, int increment = 1)
    {
        var index = 205 + (int)tag;
        Interlocked.Add(ref _buffer.Count[index], increment);
    }

    public void RecordCountDirectLogApiRequests(int increment = 1)
    {
        Interlocked.Add(ref _buffer.Count[273], increment);
    }

    public void RecordCountDirectLogApiResponses(Datadog.Trace.Telemetry.Metrics.MetricTags.StatusCode tag, int increment = 1)
    {
        var index = 274 + (int)tag;
        Interlocked.Add(ref _buffer.Count[index], increment);
    }

    public void RecordCountDirectLogApiErrors(Datadog.Trace.Telemetry.Metrics.MetricTags.ApiError tag, int increment = 1)
    {
        var index = 296 + (int)tag;
        Interlocked.Add(ref _buffer.Count[index], increment);
    }

    public void RecordCountWafInit(int increment = 1)
    {
        Interlocked.Add(ref _buffer.Count[299], increment);
    }

    public void RecordCountWafUpdates(int increment = 1)
    {
        Interlocked.Add(ref _buffer.Count[300], increment);
    }

    public void RecordCountWafRequests(Datadog.Trace.Telemetry.Metrics.MetricTags.WafAnalysis tag, int increment = 1)
    {
        var index = 301 + (int)tag;
        Interlocked.Add(ref _buffer.Count[index], increment);
    }

    public void RecordCountInputTruncated(Datadog.Trace.Telemetry.Metrics.MetricTags.TruncationReason tag, int increment = 1)
    {
        var index = 306 + (int)tag;
        Interlocked.Add(ref _buffer.Count[index], increment);
    }

    public void RecordCountIastExecutedSources(Datadog.Trace.Telemetry.Metrics.MetricTags.IastInstrumentedSources tag, int increment = 1)
    {
        var index = 309 + (int)tag;
        Interlocked.Add(ref _buffer.Count[index], increment);
    }

    public void RecordCountIastExecutedPropagations(int increment = 1)
    {
        Interlocked.Add(ref _buffer.Count[321], increment);
    }

    public void RecordCountIastExecutedSinks(Datadog.Trace.Telemetry.Metrics.MetricTags.IastInstrumentedSinks tag, int increment = 1)
    {
        var index = 322 + (int)tag;
        Interlocked.Add(ref _buffer.Count[index], increment);
    }

    public void RecordCountIastRequestTainted(int increment = 1)
    {
        Interlocked.Add(ref _buffer.Count[344], increment);
    }
}
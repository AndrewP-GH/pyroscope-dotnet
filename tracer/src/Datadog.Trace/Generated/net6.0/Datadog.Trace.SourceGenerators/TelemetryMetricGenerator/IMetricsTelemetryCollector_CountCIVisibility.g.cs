﻿// <copyright company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>
// <auto-generated/>

#nullable enable

namespace Datadog.Trace.Telemetry;
internal partial interface IMetricsTelemetryCollector
{
    public void RecordCountCIVisibilityEventCreated(Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityTestFramework tag1, Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityTestingEventTypeWithCodeOwnerAndSupportedCiAndBenchmark tag2, int increment = 1);

    public void RecordCountCIVisibilityEventFinished(Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityTestFramework tag1, Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityTestingEventTypeWithCodeOwnerAndSupportedCiAndBenchmarkAndEarlyFlakeDetectionAndRum tag2, int increment = 1);

    public void RecordCountCIVisibilityCodeCoverageStarted(Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityTestFramework tag1, Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityCoverageLibrary tag2, int increment = 1);

    public void RecordCountCIVisibilityCodeCoverageFinished(Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityTestFramework tag1, Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityCoverageLibrary tag2, int increment = 1);

    public void RecordCountCIVisibilityManualApiEvent(Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityTestingEventType tag, int increment = 1);

    public void RecordCountCIVisibilityEventsEnqueueForSerialization(int increment = 1);

    public void RecordCountCIVisibilityEndpointPayloadRequests(Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityEndpointAndCompression tag, int increment = 1);

    public void RecordCountCIVisibilityEndpointPayloadRequestsErrors(Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityEndpoints tag1, Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityErrorType tag2, int increment = 1);

    public void RecordCountCIVisibilityEndpointPayloadDropped(Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityEndpoints tag, int increment = 1);

    public void RecordCountCIVisibilityGitCommand(Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityCommands tag, int increment = 1);

    public void RecordCountCIVisibilityGitCommandErrors(Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityCommands tag1, Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityExitCodes tag2, int increment = 1);

    public void RecordCountCIVisibilityGitRequestsSearchCommits(Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityRequestCompressed tag, int increment = 1);

    public void RecordCountCIVisibilityGitRequestsSearchCommitsErrors(Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityErrorType tag, int increment = 1);

    public void RecordCountCIVisibilityGitRequestsObjectsPack(Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityRequestCompressed tag, int increment = 1);

    public void RecordCountCIVisibilityGitRequestsObjectsPackErrors(Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityErrorType tag, int increment = 1);

    public void RecordCountCIVisibilityGitRequestsSettings(Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityRequestCompressed tag, int increment = 1);

    public void RecordCountCIVisibilityGitRequestsSettingsErrors(Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityErrorType tag, int increment = 1);

    public void RecordCountCIVisibilityGitRequestsSettingsResponse(Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityITRSettingsResponse tag, int increment = 1);

    public void RecordCountCIVisibilityITRSkippableTestsRequest(Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityRequestCompressed tag, int increment = 1);

    public void RecordCountCIVisibilityITRSkippableTestsRequestErrors(Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityErrorType tag, int increment = 1);

    public void RecordCountCIVisibilityITRSkippableTestsResponseTests(int increment = 1);

    public void RecordCountCIVisibilityITRSkippableTestsResponseSuites(int increment = 1);

    public void RecordCountCIVisibilityITRSkipped(Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityTestingEventType tag, int increment = 1);

    public void RecordCountCIVisibilityITRUnskippable(Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityTestingEventType tag, int increment = 1);

    public void RecordCountCIVisibilityITRForcedRun(Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityTestingEventType tag, int increment = 1);

    public void RecordCountCIVisibilityCodeCoverageIsEmpty(int increment = 1);

    public void RecordCountCIVisibilityCodeCoverageErrors(int increment = 1);

    public void RecordCountCIVisibilityEarlyFlakeDetectionRequest(Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityRequestCompressed tag, int increment = 1);

    public void RecordCountCIVisibilityEarlyFlakeDetectionRequestErrors(Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityErrorType tag, int increment = 1);
}
// <copyright file="DuckTypeAttribute.cs" company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>

namespace Datadog.Trace.DuckTyping;

/// <summary>
/// Indicates the type is used as a ducktype.
/// This attribute is only used to drive tests.
/// </summary>
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = true)]
internal sealed class DuckTypeAttribute(string targetType, string targetAssembly) : Attribute
{
    public string? TargetType { get; set; } = targetType;

    public string? TargetAssembly { get; set; } = targetAssembly;
}

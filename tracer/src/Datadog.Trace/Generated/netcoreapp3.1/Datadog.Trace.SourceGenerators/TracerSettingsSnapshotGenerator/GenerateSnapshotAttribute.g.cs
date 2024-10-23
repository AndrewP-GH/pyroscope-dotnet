﻿// <copyright company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>
// <auto-generated/>

#nullable enable

namespace Datadog.Trace.SourceGenerators;

/// <summary>
/// Used to indicate the configuration key that this settable property corresponds to.
/// Used for automatically generating a snapshot of the properties to track changes
/// </summary>
[System.AttributeUsage(System.AttributeTargets.Property, AllowMultiple = false)]
internal class ConfigKeyAttribute : System.Attribute
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ConfigKeyAttribute"/> class.
    /// </summary>
    /// <param name="configurationKey">The configuration key to record in config</param>
    public ConfigKeyAttribute(string configurationKey)
    {
        ConfigurationKey = configurationKey;
    }

    /// <summary>
    /// Gets the configuration key to record in config
    /// </summary>
    public string ConfigurationKey { get; }
}

/// <summary>
/// Used to generate the snapshot class for the type
/// </summary>
[System.AttributeUsage(System.AttributeTargets.Class, AllowMultiple = false)]
internal class GenerateSnapshotAttribute : System.Attribute
{
}

/// <summary>
/// Used to ignore an otherwise eligible property from snapshotting
/// </summary>
[System.AttributeUsage(System.AttributeTargets.Property, AllowMultiple = false)]
internal class IgnoreForSnapshotAttribute : System.Attribute
{
}
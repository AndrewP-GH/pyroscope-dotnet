// <copyright file="IChannelWriter.cs" company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>
#nullable enable

using System;

namespace Datadog.Trace.Ci.Ipc;

internal interface IChannelWriter : IDisposable
{
    int GetMessageSize(in ArraySegment<byte> data);

    bool TryWrite(in ArraySegment<byte> data);
}

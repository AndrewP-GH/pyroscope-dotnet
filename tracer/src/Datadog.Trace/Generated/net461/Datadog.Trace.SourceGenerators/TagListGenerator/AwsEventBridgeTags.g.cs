﻿// <copyright company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>
// <auto-generated/>

#nullable enable

using Datadog.Trace.Processors;
using Datadog.Trace.Tagging;
using System;

namespace Datadog.Trace.Tagging
{
    partial class AwsEventBridgeTags
    {
        // RuleNameBytes = MessagePack.Serialize("rulename");
        private static ReadOnlySpan<byte> RuleNameBytes => new byte[] { 168, 114, 117, 108, 101, 110, 97, 109, 101 };
        // SpanKindBytes = MessagePack.Serialize("span.kind");
        private static ReadOnlySpan<byte> SpanKindBytes => new byte[] { 169, 115, 112, 97, 110, 46, 107, 105, 110, 100 };

        public override string? GetTag(string key)
        {
            return key switch
            {
                "rulename" => RuleName,
                "span.kind" => SpanKind,
                _ => base.GetTag(key),
            };
        }

        public override void SetTag(string key, string value)
        {
            switch(key)
            {
                case "rulename": 
                    RuleName = value;
                    break;
                case "span.kind": 
                    Logger.Value.Warning("Attempted to set readonly tag {TagName} on {TagType}. Ignoring.", key, nameof(AwsEventBridgeTags));
                    break;
                default: 
                    base.SetTag(key, value);
                    break;
            }
        }

        public override void EnumerateTags<TProcessor>(ref TProcessor processor)
        {
            if (RuleName is not null)
            {
                processor.Process(new TagItem<string>("rulename", RuleName, RuleNameBytes));
            }

            if (SpanKind is not null)
            {
                processor.Process(new TagItem<string>("span.kind", SpanKind, SpanKindBytes));
            }

            base.EnumerateTags(ref processor);
        }

        protected override void WriteAdditionalTags(System.Text.StringBuilder sb)
        {
            if (RuleName is not null)
            {
                sb.Append("rulename (tag):")
                  .Append(RuleName)
                  .Append(',');
            }

            if (SpanKind is not null)
            {
                sb.Append("span.kind (tag):")
                  .Append(SpanKind)
                  .Append(',');
            }

            base.WriteAdditionalTags(sb);
        }
    }
}

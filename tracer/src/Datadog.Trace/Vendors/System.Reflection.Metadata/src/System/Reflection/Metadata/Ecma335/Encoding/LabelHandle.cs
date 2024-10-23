//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
#pragma warning disable CS8600, CS8601, CS8602, CS8603, CS8604, CS8618, CS8620, CS8714, CS8762, CS8765, CS8766, CS8767, CS8768, CS8769, CS8612, CS8629, CS8774
// Decompiled with JetBrains decompiler
// Type: System.Reflection.Metadata.Ecma335.LabelHandle
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72

using System;
using System.Diagnostics.CodeAnalysis;


#nullable enable
namespace Datadog.Trace.VendoredMicrosoftCode.System.Reflection.Metadata.Ecma335
{
  internal readonly struct LabelHandle : IEquatable<LabelHandle>
  {
    /// <summary>
    /// 1-based id identifying the label within the context of a <see cref="T:System.Reflection.Metadata.Ecma335.ControlFlowBuilder" />.
    /// </summary>
    public int Id { get; }

    internal LabelHandle(int id) => this.Id = id;

    public bool IsNil => this.Id == 0;

    public bool Equals(LabelHandle other) => this.Id == other.Id;

    public override bool Equals([NotNullWhen(true)] object? obj) => obj is LabelHandle other && this.Equals(other);

    public override int GetHashCode() => this.Id.GetHashCode();

    public static bool operator ==(LabelHandle left, LabelHandle right) => left.Equals(right);

    public static bool operator !=(LabelHandle left, LabelHandle right) => !left.Equals(right);
  }
}

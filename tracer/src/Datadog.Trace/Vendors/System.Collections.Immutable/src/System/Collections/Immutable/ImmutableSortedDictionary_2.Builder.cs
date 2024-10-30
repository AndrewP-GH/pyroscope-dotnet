//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
#pragma warning disable CS8600, CS8601, CS8602, CS8603, CS8604, CS8618, CS8620, CS8714, CS8762, CS8765, CS8766, CS8767, CS8768, CS8769, CS8612, CS8629, CS8774
// Decompiled with JetBrains decompiler
// Type: System.Collections.Immutable.ImmutableSortedDictionaryBuilderDebuggerProxy`2
// Assembly: System.Collections.Immutable, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 5F9FF90F-0D16-4469-A104-76829D3705E2

using System.Collections.Generic;
using Datadog.Trace.VendoredMicrosoftCode.System.Collections.Generic;
using System.Diagnostics;


#nullable enable
namespace Datadog.Trace.VendoredMicrosoftCode.System.Collections.Immutable
{
    internal sealed class ImmutableSortedDictionaryBuilderDebuggerProxy<TKey, TValue> where TKey : notnull
  {

    #nullable disable
    private readonly ImmutableSortedDictionary<TKey, TValue>.Builder _map;
    private KeyValuePair<TKey, TValue>[] _contents;


    #nullable enable
    public ImmutableSortedDictionaryBuilderDebuggerProxy(
      ImmutableSortedDictionary<TKey, TValue>.Builder map)
    {
      Requires.NotNull<ImmutableSortedDictionary<TKey, TValue>.Builder>(map, nameof (map));
      this._map = map;
    }

    [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
    public KeyValuePair<TKey, TValue>[] Contents => this._contents ?? (this._contents = this._map.ToArray<KeyValuePair<TKey, TValue>>(this._map.Count));
  }
}

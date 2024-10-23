//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
#pragma warning disable CS8600, CS8601, CS8602, CS8603, CS8604, CS8618, CS8620, CS8714, CS8762, CS8765, CS8766, CS8767, CS8768, CS8769, CS8612, CS8629, CS8774
#nullable enable
// Decompiled with JetBrains decompiler
// Type: System.Reflection.Metadata.ReservedBlob`1
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72

namespace Datadog.Trace.VendoredMicrosoftCode.System.Reflection.Metadata
{
  /// <summary>
  /// Represents a handle and a corresponding blob on a metadata heap that was reserved for future content update.
  /// </summary>
  internal readonly struct ReservedBlob<THandle> where THandle : struct
  {
    public THandle Handle { get; }

    public Blob Content { get; }

    internal ReservedBlob(THandle handle, Blob content)
    {
      this.Handle = handle;
      this.Content = content;
    }

    /// <summary>
    /// Returns a <see cref="T:System.Reflection.Metadata.BlobWriter" /> to be used to update the content.
    /// </summary>
    public BlobWriter CreateWriter() => new BlobWriter(this.Content);
  }
}

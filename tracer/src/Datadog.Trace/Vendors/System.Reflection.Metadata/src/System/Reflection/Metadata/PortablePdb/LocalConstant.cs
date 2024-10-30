//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
#pragma warning disable CS8600, CS8601, CS8602, CS8603, CS8604, CS8618, CS8620, CS8714, CS8762, CS8765, CS8766, CS8767, CS8768, CS8769, CS8612, CS8629, CS8774
// Decompiled with JetBrains decompiler
// Type: System.Reflection.Metadata.LocalConstant
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72


#nullable enable
namespace Datadog.Trace.VendoredMicrosoftCode.System.Reflection.Metadata
{
  /// <summary>Local constant. Stored in debug metadata.</summary>
  /// <remarks>
  /// See https://github.com/dotnet/runtime/blob/main/src/libraries/System.Reflection.Metadata/specs/PortablePdb-Metadata.md#localconstant-table-0x34.
  /// </remarks>
  internal readonly struct LocalConstant
  {

    #nullable disable
    private readonly MetadataReader _reader;
    private readonly int _rowId;


    #nullable enable
    internal LocalConstant(MetadataReader reader, LocalConstantHandle handle)
    {
      this._reader = reader;
      this._rowId = handle.RowId;
    }

    private LocalConstantHandle Handle => LocalConstantHandle.FromRowId(this._rowId);

    public StringHandle Name => this._reader.LocalConstantTable.GetName(this.Handle);

    /// <summary>The constant signature.</summary>
    public BlobHandle Signature => this._reader.LocalConstantTable.GetSignature(this.Handle);
  }
}

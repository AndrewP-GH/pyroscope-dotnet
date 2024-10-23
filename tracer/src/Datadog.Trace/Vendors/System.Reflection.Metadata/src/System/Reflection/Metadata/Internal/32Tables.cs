//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
#pragma warning disable CS8600, CS8601, CS8602, CS8603, CS8604, CS8618, CS8620, CS8714, CS8762, CS8765, CS8766, CS8767, CS8768, CS8769, CS8612, CS8629, CS8774
// Decompiled with JetBrains decompiler
// Type: System.Reflection.Metadata.Ecma335.AssemblyTableReader
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72

using System;
using System.Reflection;
using Datadog.Trace.VendoredMicrosoftCode.System.Reflection.Internal;


#nullable enable
namespace Datadog.Trace.VendoredMicrosoftCode.System.Reflection.Metadata.Ecma335
{
  internal readonly struct AssemblyTableReader
  {
    internal readonly int NumberOfRows;
    private readonly bool _IsStringHeapRefSizeSmall;
    private readonly bool _IsBlobHeapRefSizeSmall;
    private readonly int _HashAlgIdOffset;
    private readonly int _MajorVersionOffset;
    private readonly int _MinorVersionOffset;
    private readonly int _BuildNumberOffset;
    private readonly int _RevisionNumberOffset;
    private readonly int _FlagsOffset;
    private readonly int _PublicKeyOffset;
    private readonly int _NameOffset;
    private readonly int _CultureOffset;
    internal readonly int RowSize;
    internal readonly MemoryBlock Block;

    internal AssemblyTableReader(
      int numberOfRows,
      int stringHeapRefSize,
      int blobHeapRefSize,
      MemoryBlock containingBlock,
      int containingBlockOffset)
    {
      this.NumberOfRows = numberOfRows > 1 ? 1 : numberOfRows;
      this._IsStringHeapRefSizeSmall = stringHeapRefSize == 2;
      this._IsBlobHeapRefSizeSmall = blobHeapRefSize == 2;
      this._HashAlgIdOffset = 0;
      this._MajorVersionOffset = this._HashAlgIdOffset + 4;
      this._MinorVersionOffset = this._MajorVersionOffset + 2;
      this._BuildNumberOffset = this._MinorVersionOffset + 2;
      this._RevisionNumberOffset = this._BuildNumberOffset + 2;
      this._FlagsOffset = this._RevisionNumberOffset + 2;
      this._PublicKeyOffset = this._FlagsOffset + 4;
      this._NameOffset = this._PublicKeyOffset + blobHeapRefSize;
      this._CultureOffset = this._NameOffset + stringHeapRefSize;
      this.RowSize = this._CultureOffset + stringHeapRefSize;
      this.Block = containingBlock.GetMemoryBlockAt(containingBlockOffset, this.RowSize * numberOfRows);
    }

    internal AssemblyHashAlgorithm GetHashAlgorithm() => (AssemblyHashAlgorithm) this.Block.PeekUInt32(this._HashAlgIdOffset);

    internal Version GetVersion() => new Version((int) this.Block.PeekUInt16(this._MajorVersionOffset), (int) this.Block.PeekUInt16(this._MinorVersionOffset), (int) this.Block.PeekUInt16(this._BuildNumberOffset), (int) this.Block.PeekUInt16(this._RevisionNumberOffset));

    internal AssemblyFlags GetFlags() => (AssemblyFlags) this.Block.PeekUInt32(this._FlagsOffset);

    internal BlobHandle GetPublicKey() => BlobHandle.FromOffset(this.Block.PeekHeapReference(this._PublicKeyOffset, this._IsBlobHeapRefSizeSmall));

    internal StringHandle GetName() => StringHandle.FromOffset(this.Block.PeekHeapReference(this._NameOffset, this._IsStringHeapRefSizeSmall));

    internal StringHandle GetCulture() => StringHandle.FromOffset(this.Block.PeekHeapReference(this._CultureOffset, this._IsStringHeapRefSizeSmall));
  }
}

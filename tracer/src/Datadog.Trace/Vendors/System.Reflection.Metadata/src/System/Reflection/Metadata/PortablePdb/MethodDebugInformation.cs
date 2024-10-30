//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
#pragma warning disable CS8600, CS8601, CS8602, CS8603, CS8604, CS8618, CS8620, CS8714, CS8762, CS8765, CS8766, CS8767, CS8768, CS8769, CS8612, CS8629, CS8774
// Decompiled with JetBrains decompiler
// Type: System.Reflection.Metadata.MethodDebugInformation
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72


#nullable enable
namespace Datadog.Trace.VendoredMicrosoftCode.System.Reflection.Metadata
{
  /// <summary>
  /// Debug information associated with a method definition. Stored in debug metadata.
  /// </summary>
  /// <remarks>
  /// See https://github.com/dotnet/runtime/blob/main/src/libraries/System.Reflection.Metadata/specs/PortablePdb-Metadata.md#methoddebuginformation-table-0x31.
  /// </remarks>
  internal readonly struct MethodDebugInformation
  {

    #nullable disable
    private readonly MetadataReader _reader;
    private readonly int _rowId;


    #nullable enable
    internal MethodDebugInformation(MetadataReader reader, MethodDebugInformationHandle handle)
    {
      this._reader = reader;
      this._rowId = handle.RowId;
    }

    private MethodDebugInformationHandle Handle => MethodDebugInformationHandle.FromRowId(this._rowId);

    /// <summary>
    /// Returns a blob encoding sequence points, or nil if the method doesn't have sequence points.
    /// Use <see cref="M:System.Reflection.Metadata.MethodDebugInformation.GetSequencePoints" /> to decode the blob.
    /// </summary>
    public BlobHandle SequencePointsBlob => this._reader.MethodDebugInformationTable.GetSequencePoints(this.Handle);

    /// <summary>
    /// Handle of the single document containing all sequence points of the method,
    /// or nil if the method doesn't have sequence points or spans multiple documents.
    /// </summary>
    public DocumentHandle Document => this._reader.MethodDebugInformationTable.GetDocument(this.Handle);

    /// <summary>
    /// Returns local signature handle, or nil if the method doesn't define any local variables.
    /// </summary>
    public StandaloneSignatureHandle LocalSignature => this.SequencePointsBlob.IsNil ? new StandaloneSignatureHandle() : StandaloneSignatureHandle.FromRowId(this._reader.GetBlobReader(this.SequencePointsBlob).ReadCompressedInteger());

    /// <summary>
    /// Returns a collection of sequence points decoded from <see cref="P:System.Reflection.Metadata.MethodDebugInformation.SequencePointsBlob" />.
    /// </summary>
    public SequencePointCollection GetSequencePoints() => new SequencePointCollection(this._reader.BlobHeap.GetMemoryBlock(this.SequencePointsBlob), this.Document);

    /// <summary>
    /// If the method is a MoveNext method of a state machine returns the kickoff method of the state machine, otherwise returns nil handle.
    /// </summary>
    public MethodDefinitionHandle GetStateMachineKickoffMethod() => this._reader.StateMachineMethodTable.FindKickoffMethod(this._rowId);
  }
}

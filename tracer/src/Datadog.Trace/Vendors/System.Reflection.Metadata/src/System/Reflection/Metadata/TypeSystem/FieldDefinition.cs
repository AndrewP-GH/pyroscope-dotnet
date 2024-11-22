//------------------------------------------------------------------------------
// <auto-generated />
// This file was automatically generated by the UpdateVendors tool.
//------------------------------------------------------------------------------
#pragma warning disable CS0618, CS0649, CS1574, CS1580, CS1581, CS1584, CS1591, CS1573, CS8018, SYSLIB0011, SYSLIB0032
#pragma warning disable CS8600, CS8601, CS8602, CS8603, CS8604, CS8618, CS8620, CS8714, CS8762, CS8765, CS8766, CS8767, CS8768, CS8769, CS8612, CS8629, CS8774
// Decompiled with JetBrains decompiler
// Type: System.Reflection.Metadata.FieldDefinition
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72

using System.Reflection;
using Datadog.Trace.VendoredMicrosoftCode.System.Reflection.Metadata.Ecma335;


#nullable enable
namespace Datadog.Trace.VendoredMicrosoftCode.System.Reflection.Metadata
{
  internal readonly struct FieldDefinition
  {

    #nullable disable
    private readonly MetadataReader _reader;
    private readonly uint _treatmentAndRowId;


    #nullable enable
    internal FieldDefinition(MetadataReader reader, uint treatmentAndRowId)
    {
      this._reader = reader;
      this._treatmentAndRowId = treatmentAndRowId;
    }

    private int RowId => (int) this._treatmentAndRowId & 16777215;

    private FieldDefTreatment Treatment => (FieldDefTreatment) (this._treatmentAndRowId >> 24);

    private FieldDefinitionHandle Handle => FieldDefinitionHandle.FromRowId(this.RowId);

    public StringHandle Name => this.Treatment == FieldDefTreatment.None ? this._reader.FieldTable.GetName(this.Handle) : this.GetProjectedName();

    public FieldAttributes Attributes => this.Treatment == FieldDefTreatment.None ? this._reader.FieldTable.GetFlags(this.Handle) : this.GetProjectedFlags();

    public BlobHandle Signature => this.Treatment == FieldDefTreatment.None ? this._reader.FieldTable.GetSignature(this.Handle) : this.GetProjectedSignature();

    public TType DecodeSignature<TType, TGenericContext>(
      ISignatureTypeProvider<TType, TGenericContext> provider,
      TGenericContext genericContext)
    {
      SignatureDecoder<TType, TGenericContext> signatureDecoder = new SignatureDecoder<TType, TGenericContext>(provider, this._reader, genericContext);
      BlobReader blobReader = this._reader.GetBlobReader(this.Signature);
      return signatureDecoder.DecodeFieldSignature(ref blobReader);
    }

    public TypeDefinitionHandle GetDeclaringType() => this._reader.GetDeclaringType(this.Handle);

    public ConstantHandle GetDefaultValue() => this._reader.ConstantTable.FindConstant((EntityHandle) this.Handle);

    public int GetRelativeVirtualAddress()
    {
      int fieldRvaRowId = this._reader.FieldRvaTable.FindFieldRvaRowId(this.Handle.RowId);
      return fieldRvaRowId == 0 ? 0 : this._reader.FieldRvaTable.GetRva(fieldRvaRowId);
    }

    /// <summary>Returns field layout offset, or -1 if not available.</summary>
    public int GetOffset()
    {
      int fieldLayoutRowId = this._reader.FieldLayoutTable.FindFieldLayoutRowId(this.Handle);
      if (fieldLayoutRowId == 0)
        return -1;
      uint offset = this._reader.FieldLayoutTable.GetOffset(fieldLayoutRowId);
      return offset > (uint) int.MaxValue ? -1 : (int) offset;
    }

    public BlobHandle GetMarshallingDescriptor()
    {
      int fieldMarshalRowId = this._reader.FieldMarshalTable.FindFieldMarshalRowId((EntityHandle) this.Handle);
      return fieldMarshalRowId == 0 ? new BlobHandle() : this._reader.FieldMarshalTable.GetNativeType(fieldMarshalRowId);
    }

    public CustomAttributeHandleCollection GetCustomAttributes() => new CustomAttributeHandleCollection(this._reader, (EntityHandle) this.Handle);

    private StringHandle GetProjectedName() => this._reader.FieldTable.GetName(this.Handle);

    private FieldAttributes GetProjectedFlags()
    {
      FieldAttributes flags = this._reader.FieldTable.GetFlags(this.Handle);
      return this.Treatment == FieldDefTreatment.EnumValue ? flags & ~FieldAttributes.FieldAccessMask | FieldAttributes.Public : flags;
    }

    private BlobHandle GetProjectedSignature() => this._reader.FieldTable.GetSignature(this.Handle);
  }
}
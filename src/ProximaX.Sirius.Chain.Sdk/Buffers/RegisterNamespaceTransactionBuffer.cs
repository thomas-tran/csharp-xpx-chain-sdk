// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace ProximaX.Sirius.Chain.Sdk.Buffers
{

using global::System;
using global::FlatBuffers;

public struct RegisterNamespaceTransactionBuffer : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static RegisterNamespaceTransactionBuffer GetRootAsRegisterNamespaceTransactionBuffer(ByteBuffer _bb) { return GetRootAsRegisterNamespaceTransactionBuffer(_bb, new RegisterNamespaceTransactionBuffer()); }
  public static RegisterNamespaceTransactionBuffer GetRootAsRegisterNamespaceTransactionBuffer(ByteBuffer _bb, RegisterNamespaceTransactionBuffer obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public RegisterNamespaceTransactionBuffer __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public uint Size { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public byte Signature(int j) { int o = __p.__offset(6); return o != 0 ? __p.bb.Get(__p.__vector(o) + j * 1) : (byte)0; }
  public int SignatureLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSignatureBytes() { return __p.__vector_as_span(6); }
#else
  public ArraySegment<byte>? GetSignatureBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetSignatureArray() { return __p.__vector_as_array<byte>(6); }
  public byte Signer(int j) { int o = __p.__offset(8); return o != 0 ? __p.bb.Get(__p.__vector(o) + j * 1) : (byte)0; }
  public int SignerLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSignerBytes() { return __p.__vector_as_span(8); }
#else
  public ArraySegment<byte>? GetSignerBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetSignerArray() { return __p.__vector_as_array<byte>(8); }
  public uint Version { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public ushort Type { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetUshort(o + __p.bb_pos) : (ushort)0; } }
  public uint MaxFee(int j) { int o = __p.__offset(14); return o != 0 ? __p.bb.GetUint(__p.__vector(o) + j * 4) : (uint)0; }
  public int MaxFeeLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<byte> GetMaxFeeBytes() { return __p.__vector_as_span(14); }
#else
  public ArraySegment<byte>? GetMaxFeeBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public uint[] GetMaxFeeArray() { return __p.__vector_as_array<uint>(14); }
  public uint Deadline(int j) { int o = __p.__offset(16); return o != 0 ? __p.bb.GetUint(__p.__vector(o) + j * 4) : (uint)0; }
  public int DeadlineLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDeadlineBytes() { return __p.__vector_as_span(16); }
#else
  public ArraySegment<byte>? GetDeadlineBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public uint[] GetDeadlineArray() { return __p.__vector_as_array<uint>(16); }
  public byte NamespaceType { get { int o = __p.__offset(18); return o != 0 ? __p.bb.Get(o + __p.bb_pos) : (byte)0; } }
  public uint DurationParentId(int j) { int o = __p.__offset(20); return o != 0 ? __p.bb.GetUint(__p.__vector(o) + j * 4) : (uint)0; }
  public int DurationParentIdLength { get { int o = __p.__offset(20); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDurationParentIdBytes() { return __p.__vector_as_span(20); }
#else
  public ArraySegment<byte>? GetDurationParentIdBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public uint[] GetDurationParentIdArray() { return __p.__vector_as_array<uint>(20); }
  public uint NamespaceId(int j) { int o = __p.__offset(22); return o != 0 ? __p.bb.GetUint(__p.__vector(o) + j * 4) : (uint)0; }
  public int NamespaceIdLength { get { int o = __p.__offset(22); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNamespaceIdBytes() { return __p.__vector_as_span(22); }
#else
  public ArraySegment<byte>? GetNamespaceIdBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public uint[] GetNamespaceIdArray() { return __p.__vector_as_array<uint>(22); }
  public byte NamespaceNameSize { get { int o = __p.__offset(24); return o != 0 ? __p.bb.Get(o + __p.bb_pos) : (byte)0; } }
  public string NamespaceName { get { int o = __p.__offset(26); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNamespaceNameBytes() { return __p.__vector_as_span(26); }
#else
  public ArraySegment<byte>? GetNamespaceNameBytes() { return __p.__vector_as_arraysegment(26); }
#endif
  public byte[] GetNamespaceNameArray() { return __p.__vector_as_array<byte>(26); }

  public static Offset<RegisterNamespaceTransactionBuffer> CreateRegisterNamespaceTransactionBuffer(FlatBufferBuilder builder,
      uint size = 0,
      VectorOffset signatureOffset = default(VectorOffset),
      VectorOffset signerOffset = default(VectorOffset),
      uint version = 0,
      ushort type = 0,
      VectorOffset maxFeeOffset = default(VectorOffset),
      VectorOffset deadlineOffset = default(VectorOffset),
      byte namespaceType = 0,
      VectorOffset durationParentIdOffset = default(VectorOffset),
      VectorOffset namespaceIdOffset = default(VectorOffset),
      byte namespaceNameSize = 0,
      StringOffset namespaceNameOffset = default(StringOffset)) {
    builder.StartObject(12);
    RegisterNamespaceTransactionBuffer.AddNamespaceName(builder, namespaceNameOffset);
    RegisterNamespaceTransactionBuffer.AddNamespaceId(builder, namespaceIdOffset);
    RegisterNamespaceTransactionBuffer.AddDurationParentId(builder, durationParentIdOffset);
    RegisterNamespaceTransactionBuffer.AddDeadline(builder, deadlineOffset);
    RegisterNamespaceTransactionBuffer.AddMaxFee(builder, maxFeeOffset);
    RegisterNamespaceTransactionBuffer.AddVersion(builder, version);
    RegisterNamespaceTransactionBuffer.AddSigner(builder, signerOffset);
    RegisterNamespaceTransactionBuffer.AddSignature(builder, signatureOffset);
    RegisterNamespaceTransactionBuffer.AddSize(builder, size);
    RegisterNamespaceTransactionBuffer.AddType(builder, type);
    RegisterNamespaceTransactionBuffer.AddNamespaceNameSize(builder, namespaceNameSize);
    RegisterNamespaceTransactionBuffer.AddNamespaceType(builder, namespaceType);
    return RegisterNamespaceTransactionBuffer.EndRegisterNamespaceTransactionBuffer(builder);
  }

  public static void StartRegisterNamespaceTransactionBuffer(FlatBufferBuilder builder) { builder.StartObject(12); }
  public static void AddSize(FlatBufferBuilder builder, uint size) { builder.AddUint(0, size, 0); }
  public static void AddSignature(FlatBufferBuilder builder, VectorOffset signatureOffset) { builder.AddOffset(1, signatureOffset.Value, 0); }
  public static VectorOffset CreateSignatureVector(FlatBufferBuilder builder, byte[] data) { builder.StartVector(1, data.Length, 1); for (int i = data.Length - 1; i >= 0; i--) builder.AddByte(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateSignatureVectorBlock(FlatBufferBuilder builder, byte[] data) { builder.StartVector(1, data.Length, 1); builder.Add(data); return builder.EndVector(); }
  public static void StartSignatureVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(1, numElems, 1); }
  public static void AddSigner(FlatBufferBuilder builder, VectorOffset signerOffset) { builder.AddOffset(2, signerOffset.Value, 0); }
  public static VectorOffset CreateSignerVector(FlatBufferBuilder builder, byte[] data) { builder.StartVector(1, data.Length, 1); for (int i = data.Length - 1; i >= 0; i--) builder.AddByte(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateSignerVectorBlock(FlatBufferBuilder builder, byte[] data) { builder.StartVector(1, data.Length, 1); builder.Add(data); return builder.EndVector(); }
  public static void StartSignerVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(1, numElems, 1); }
  public static void AddVersion(FlatBufferBuilder builder, uint version) { builder.AddUint(3, version, 0); }
  public static void AddType(FlatBufferBuilder builder, ushort type) { builder.AddUshort(4, type, 0); }
  public static void AddMaxFee(FlatBufferBuilder builder, VectorOffset maxFeeOffset) { builder.AddOffset(5, maxFeeOffset.Value, 0); }
  public static VectorOffset CreateMaxFeeVector(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddUint(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateMaxFeeVectorBlock(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartMaxFeeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDeadline(FlatBufferBuilder builder, VectorOffset deadlineOffset) { builder.AddOffset(6, deadlineOffset.Value, 0); }
  public static VectorOffset CreateDeadlineVector(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddUint(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateDeadlineVectorBlock(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartDeadlineVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddNamespaceType(FlatBufferBuilder builder, byte namespaceType) { builder.AddByte(7, namespaceType, 0); }
  public static void AddDurationParentId(FlatBufferBuilder builder, VectorOffset durationParentIdOffset) { builder.AddOffset(8, durationParentIdOffset.Value, 0); }
  public static VectorOffset CreateDurationParentIdVector(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddUint(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateDurationParentIdVectorBlock(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartDurationParentIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddNamespaceId(FlatBufferBuilder builder, VectorOffset namespaceIdOffset) { builder.AddOffset(9, namespaceIdOffset.Value, 0); }
  public static VectorOffset CreateNamespaceIdVector(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddUint(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateNamespaceIdVectorBlock(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartNamespaceIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddNamespaceNameSize(FlatBufferBuilder builder, byte namespaceNameSize) { builder.AddByte(10, namespaceNameSize, 0); }
  public static void AddNamespaceName(FlatBufferBuilder builder, StringOffset namespaceNameOffset) { builder.AddOffset(11, namespaceNameOffset.Value, 0); }
  public static Offset<RegisterNamespaceTransactionBuffer> EndRegisterNamespaceTransactionBuffer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<RegisterNamespaceTransactionBuffer>(o);
  }
  public static void FinishRegisterNamespaceTransactionBufferBuffer(FlatBufferBuilder builder, Offset<RegisterNamespaceTransactionBuffer> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedRegisterNamespaceTransactionBufferBuffer(FlatBufferBuilder builder, Offset<RegisterNamespaceTransactionBuffer> offset) { builder.FinishSizePrefixed(offset.Value); }
};


}

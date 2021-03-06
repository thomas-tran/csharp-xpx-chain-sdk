// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace ProximaX.Sirius.Chain.Sdk.Buffers
{

using global::System;
using global::FlatBuffers;

public struct ModifyContractTransactionBuffer : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static ModifyContractTransactionBuffer GetRootAsModifyContractTransactionBuffer(ByteBuffer _bb) { return GetRootAsModifyContractTransactionBuffer(_bb, new ModifyContractTransactionBuffer()); }
  public static ModifyContractTransactionBuffer GetRootAsModifyContractTransactionBuffer(ByteBuffer _bb, ModifyContractTransactionBuffer obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public ModifyContractTransactionBuffer __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

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
  public uint DurationDelta(int j) { int o = __p.__offset(18); return o != 0 ? __p.bb.GetUint(__p.__vector(o) + j * 4) : (uint)0; }
  public int DurationDeltaLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDurationDeltaBytes() { return __p.__vector_as_span(18); }
#else
  public ArraySegment<byte>? GetDurationDeltaBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public uint[] GetDurationDeltaArray() { return __p.__vector_as_array<uint>(18); }
  public byte Hash(int j) { int o = __p.__offset(20); return o != 0 ? __p.bb.Get(__p.__vector(o) + j * 1) : (byte)0; }
  public int HashLength { get { int o = __p.__offset(20); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<byte> GetHashBytes() { return __p.__vector_as_span(20); }
#else
  public ArraySegment<byte>? GetHashBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetHashArray() { return __p.__vector_as_array<byte>(20); }
  public byte NumCustomers { get { int o = __p.__offset(22); return o != 0 ? __p.bb.Get(o + __p.bb_pos) : (byte)0; } }
  public byte NumExecutors { get { int o = __p.__offset(24); return o != 0 ? __p.bb.Get(o + __p.bb_pos) : (byte)0; } }
  public byte NumVerifiers { get { int o = __p.__offset(26); return o != 0 ? __p.bb.Get(o + __p.bb_pos) : (byte)0; } }
  public CosignatoryModificationBuffer? Customers(int j) { int o = __p.__offset(28); return o != 0 ? (CosignatoryModificationBuffer?)(new CosignatoryModificationBuffer()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int CustomersLength { get { int o = __p.__offset(28); return o != 0 ? __p.__vector_len(o) : 0; } }
  public CosignatoryModificationBuffer? Executors(int j) { int o = __p.__offset(30); return o != 0 ? (CosignatoryModificationBuffer?)(new CosignatoryModificationBuffer()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int ExecutorsLength { get { int o = __p.__offset(30); return o != 0 ? __p.__vector_len(o) : 0; } }
  public CosignatoryModificationBuffer? Verifiers(int j) { int o = __p.__offset(32); return o != 0 ? (CosignatoryModificationBuffer?)(new CosignatoryModificationBuffer()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int VerifiersLength { get { int o = __p.__offset(32); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<ModifyContractTransactionBuffer> CreateModifyContractTransactionBuffer(FlatBufferBuilder builder,
      uint size = 0,
      VectorOffset signatureOffset = default(VectorOffset),
      VectorOffset signerOffset = default(VectorOffset),
      uint version = 0,
      ushort type = 0,
      VectorOffset maxFeeOffset = default(VectorOffset),
      VectorOffset deadlineOffset = default(VectorOffset),
      VectorOffset durationDeltaOffset = default(VectorOffset),
      VectorOffset hashOffset = default(VectorOffset),
      byte numCustomers = 0,
      byte numExecutors = 0,
      byte numVerifiers = 0,
      VectorOffset customersOffset = default(VectorOffset),
      VectorOffset executorsOffset = default(VectorOffset),
      VectorOffset verifiersOffset = default(VectorOffset)) {
    builder.StartObject(15);
    ModifyContractTransactionBuffer.AddVerifiers(builder, verifiersOffset);
    ModifyContractTransactionBuffer.AddExecutors(builder, executorsOffset);
    ModifyContractTransactionBuffer.AddCustomers(builder, customersOffset);
    ModifyContractTransactionBuffer.AddHash(builder, hashOffset);
    ModifyContractTransactionBuffer.AddDurationDelta(builder, durationDeltaOffset);
    ModifyContractTransactionBuffer.AddDeadline(builder, deadlineOffset);
    ModifyContractTransactionBuffer.AddMaxFee(builder, maxFeeOffset);
    ModifyContractTransactionBuffer.AddVersion(builder, version);
    ModifyContractTransactionBuffer.AddSigner(builder, signerOffset);
    ModifyContractTransactionBuffer.AddSignature(builder, signatureOffset);
    ModifyContractTransactionBuffer.AddSize(builder, size);
    ModifyContractTransactionBuffer.AddType(builder, type);
    ModifyContractTransactionBuffer.AddNumVerifiers(builder, numVerifiers);
    ModifyContractTransactionBuffer.AddNumExecutors(builder, numExecutors);
    ModifyContractTransactionBuffer.AddNumCustomers(builder, numCustomers);
    return ModifyContractTransactionBuffer.EndModifyContractTransactionBuffer(builder);
  }

  public static void StartModifyContractTransactionBuffer(FlatBufferBuilder builder) { builder.StartObject(15); }
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
  public static void AddDurationDelta(FlatBufferBuilder builder, VectorOffset durationDeltaOffset) { builder.AddOffset(7, durationDeltaOffset.Value, 0); }
  public static VectorOffset CreateDurationDeltaVector(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddUint(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateDurationDeltaVectorBlock(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartDurationDeltaVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddHash(FlatBufferBuilder builder, VectorOffset hashOffset) { builder.AddOffset(8, hashOffset.Value, 0); }
  public static VectorOffset CreateHashVector(FlatBufferBuilder builder, byte[] data) { builder.StartVector(1, data.Length, 1); for (int i = data.Length - 1; i >= 0; i--) builder.AddByte(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateHashVectorBlock(FlatBufferBuilder builder, byte[] data) { builder.StartVector(1, data.Length, 1); builder.Add(data); return builder.EndVector(); }
  public static void StartHashVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(1, numElems, 1); }
  public static void AddNumCustomers(FlatBufferBuilder builder, byte numCustomers) { builder.AddByte(9, numCustomers, 0); }
  public static void AddNumExecutors(FlatBufferBuilder builder, byte numExecutors) { builder.AddByte(10, numExecutors, 0); }
  public static void AddNumVerifiers(FlatBufferBuilder builder, byte numVerifiers) { builder.AddByte(11, numVerifiers, 0); }
  public static void AddCustomers(FlatBufferBuilder builder, VectorOffset customersOffset) { builder.AddOffset(12, customersOffset.Value, 0); }
  public static VectorOffset CreateCustomersVector(FlatBufferBuilder builder, Offset<CosignatoryModificationBuffer>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateCustomersVectorBlock(FlatBufferBuilder builder, Offset<CosignatoryModificationBuffer>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartCustomersVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddExecutors(FlatBufferBuilder builder, VectorOffset executorsOffset) { builder.AddOffset(13, executorsOffset.Value, 0); }
  public static VectorOffset CreateExecutorsVector(FlatBufferBuilder builder, Offset<CosignatoryModificationBuffer>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateExecutorsVectorBlock(FlatBufferBuilder builder, Offset<CosignatoryModificationBuffer>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartExecutorsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddVerifiers(FlatBufferBuilder builder, VectorOffset verifiersOffset) { builder.AddOffset(14, verifiersOffset.Value, 0); }
  public static VectorOffset CreateVerifiersVector(FlatBufferBuilder builder, Offset<CosignatoryModificationBuffer>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateVerifiersVectorBlock(FlatBufferBuilder builder, Offset<CosignatoryModificationBuffer>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartVerifiersVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<ModifyContractTransactionBuffer> EndModifyContractTransactionBuffer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<ModifyContractTransactionBuffer>(o);
  }
  public static void FinishModifyContractTransactionBufferBuffer(FlatBufferBuilder builder, Offset<ModifyContractTransactionBuffer> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedModifyContractTransactionBufferBuffer(FlatBufferBuilder builder, Offset<ModifyContractTransactionBuffer> offset) { builder.FinishSizePrefixed(offset.Value); }
};


}

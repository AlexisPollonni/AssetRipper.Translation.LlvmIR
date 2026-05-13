using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Enumerations;

[MangledName("_ZTSN19__llvm_libc_20_1_2_3cpp11MemoryOrderE")]
[DemangledName("__llvm_libc_20_1_2_::cpp::MemoryOrder")]
public enum MemoryOrder
{
	RELAXED,
	CONSUME,
	ACQUIRE,
	RELEASE,
	ACQ_REL,
	SEQ_CST
}

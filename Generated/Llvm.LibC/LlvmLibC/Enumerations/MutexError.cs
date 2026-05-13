using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Enumerations;

[MangledName("_ZTSN19__llvm_libc_20_1_2_10MutexErrorE")]
[DemangledName("__llvm_libc_20_1_2_::MutexError")]
public enum MutexError
{
	NONE,
	BUSY,
	TIMEOUT,
	UNLOCK_WITHOUT_LOCK,
	BAD_LOCK_STATE
}

using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE2EE8TypedIntImEC2Em")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::TypedInt<unsigned long>::TypedInt(unsigned long)")]
internal static partial class fputil_internal_FPStorage_fputil_FPType_2_TypedInt_unsigned_long_TypedInt_unsigned_long
{
	public unsafe static void Invoke(void* @this, long value)
	{
		unchecked((fputil_internal_FPStorage_v3nexn*)@this)->val = value;
	}
}

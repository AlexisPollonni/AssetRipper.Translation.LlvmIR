using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE2EEC2Ev")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::FPStorage()")]
internal static partial class fputil_internal_FPStorage_fputil_FPType_2_FPStorage
{
	public unsafe static void Invoke(void* @this)
	{
		unchecked((fputil_internal_FPStorage_v3nexn*)@this)->val = 0L;
	}
}

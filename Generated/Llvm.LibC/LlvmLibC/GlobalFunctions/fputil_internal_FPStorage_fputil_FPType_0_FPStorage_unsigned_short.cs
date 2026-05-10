using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE0EEC2Et")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::FPStorage(unsigned short)")]
internal static partial class fputil_internal_FPStorage_fputil_FPType_0_FPStorage_unsigned_short
{
	public unsafe static void Invoke(void* @this, short value)
	{
		unchecked((fputil_internal_FPStorage_za9n4f*)@this)->field_0 = value;
	}
}

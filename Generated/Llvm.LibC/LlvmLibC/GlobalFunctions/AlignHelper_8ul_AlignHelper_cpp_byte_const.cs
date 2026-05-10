using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11AlignHelperILm8EEC2EPKNS_3cpp4byteE")]
[DemangledName("__llvm_libc_20_1_2_::AlignHelper<8ul>::AlignHelper(__llvm_libc_20_1_2_::cpp::byte const*)")]
internal static partial class AlignHelper_8ul_AlignHelper_cpp_byte_const
{
	public unsafe static void Invoke(void* @this, void* ptr)
	{
		unchecked((fputil_internal_FPStorage_v3nexn*)@this)->val = unsigned_long_distance_to_next_aligned_8ul_void_const.Invoke(ptr);
	}
}

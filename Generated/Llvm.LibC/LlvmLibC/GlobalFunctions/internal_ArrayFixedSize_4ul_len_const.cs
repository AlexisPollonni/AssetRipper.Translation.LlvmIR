using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_8internal14ArrayFixedSizeILm4EE3lenEv")]
[DemangledName("__llvm_libc_20_1_2_::internal::ArrayFixedSize<4ul>::len() const")]
internal static partial class internal_ArrayFixedSize_4ul_len_const
{
	public unsafe static long Invoke(void* @this)
	{
		return unchecked((cpp_string_view*)@this)->span_size;
	}
}

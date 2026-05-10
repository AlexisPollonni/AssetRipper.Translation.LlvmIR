using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal14ArrayFixedSizeILm4EEC2EPvm")]
[DemangledName("__llvm_libc_20_1_2_::internal::ArrayFixedSize<4ul>::ArrayFixedSize(void*, unsigned long)")]
internal static partial class internal_ArrayFixedSize_4ul_ArrayFixedSize_void_unsigned_long
{
	public unsafe static void Invoke(void* @this, void* a, long s)
	{
		unchecked
		{
			((cpp_string_view*)@this)->span_data = a;
			((cpp_string_view*)@this)->span_size = s;
		}
	}
}

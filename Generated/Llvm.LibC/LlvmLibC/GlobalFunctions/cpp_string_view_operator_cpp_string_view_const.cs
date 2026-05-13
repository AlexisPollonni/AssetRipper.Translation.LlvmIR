using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp11string_vieweqES1_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::string_view::operator==(__llvm_libc_20_1_2_::cpp::string_view) const")]
internal static partial class cpp_string_view_operator_cpp_string_view_const
{
	public unsafe static bool Invoke(void* @this, [MangledName("Other.coerce0")] void* Other, [MangledName("Other.coerce1")] long Other_coerce1)
	{
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		cpp_string_view cpp_string_view3 = default(cpp_string_view);
		unchecked
		{
			*(void**)(&cpp_string_view2) = Other;
			((long*)(&cpp_string_view2))[1] = Other_coerce1;
			llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view3, &cpp_string_view2, 16L, isVolatile: false);
			return cpp_string_view_equals_cpp_string_view_const.Invoke(@this, *(void**)(&cpp_string_view3), ((long*)(&cpp_string_view3))[1]);
		}
	}
}

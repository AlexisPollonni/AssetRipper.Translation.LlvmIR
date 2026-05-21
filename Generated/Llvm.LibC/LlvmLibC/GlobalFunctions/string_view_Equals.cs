using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class string_view_Equals
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp11string_vieweqES1_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::string_view::operator==(__llvm_libc_20_1_2_::cpp::string_view) const")]
	public unsafe static bool Invoke(void* @this, [MangledName("Other.coerce0")] void* Other, [MangledName("Other.coerce1")] long Other_coerce1)
	{
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		cpp_string_view cpp_string_view3 = default(cpp_string_view);
		unchecked
		{
			*(void**)(&cpp_string_view2) = Other;
			((long*)(&cpp_string_view2))[1] = Other_coerce1;
			llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view3, &cpp_string_view2, 16L, isVolatile: false);
			return string_view_equals.Invoke(@this, *(void**)(&cpp_string_view3), ((long*)(&cpp_string_view3))[1]);
		}
	}
}
internal static partial class string_view_equals
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp11string_view6equalsES1_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::string_view::equals(__llvm_libc_20_1_2_::cpp::string_view) const")]
	public unsafe static bool Invoke(void* @this, [MangledName("Other.coerce0")] void* Other, [MangledName("Other.coerce1")] long Other_coerce1)
	{
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		unchecked
		{
			*(void**)(&cpp_string_view2) = Other;
			((long*)(&cpp_string_view2))[1] = Other_coerce1;
			return ((cpp_string_view*)@this)->span_size == cpp_string_view2.span_size && string_view_compareMemory.Invoke(((cpp_string_view*)@this)->span_data, cpp_string_view2.span_data, cpp_string_view2.span_size) == 0;
		}
	}
}

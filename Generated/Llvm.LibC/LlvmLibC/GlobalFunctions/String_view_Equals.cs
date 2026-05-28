using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class String_view_Equals
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp11string_vieweqES1_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::string_view::operator==(__llvm_libc_20_1_2_::cpp::string_view) const")]
	public unsafe static bool Invoke([MangledName("this")] void* This, [MangledName("Other.coerce0")] void* Other, [MangledName("Other.coerce1")] long Other_coerce1)
	{
		Cpp_string_view cpp_string_view = default(Cpp_string_view);
		Cpp_string_view cpp_string_view2 = default(Cpp_string_view);
		unchecked
		{
			*(void**)(&cpp_string_view) = Other;
			((long*)(&cpp_string_view))[1] = Other_coerce1;
			Llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view2, &cpp_string_view, 16L, isVolatile: false);
			return String_view_equals.Invoke(This, *(void**)(&cpp_string_view2), ((long*)(&cpp_string_view2))[1]);
		}
	}
}
internal static partial class String_view_equals
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp11string_view6equalsES1_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::string_view::equals(__llvm_libc_20_1_2_::cpp::string_view) const")]
	public unsafe static bool Invoke([MangledName("this")] void* This, [MangledName("Other.coerce0")] void* Other, [MangledName("Other.coerce1")] long Other_coerce1)
	{
		Cpp_string_view cpp_string_view = default(Cpp_string_view);
		unchecked
		{
			*(void**)(&cpp_string_view) = Other;
			((long*)(&cpp_string_view))[1] = Other_coerce1;
			return ((Cpp_string_view*)This)->Span_size == cpp_string_view.Span_size && String_view_compareMemory.Invoke(((Cpp_string_view*)This)->Span_data, cpp_string_view.Span_data, cpp_string_view.Span_size) == 0;
		}
	}
}

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
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view = default(Llvm_libc_20_1_2_cpp_string_view);
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view2 = default(Llvm_libc_20_1_2_cpp_string_view);
		unchecked
		{
			*(void**)(&llvm_libc_20_1_2_cpp_string_view) = Other;
			((long*)(&llvm_libc_20_1_2_cpp_string_view))[1] = Other_coerce1;
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_cpp_string_view2, &llvm_libc_20_1_2_cpp_string_view, 16L, isVolatile: false);
			return String_view_equals.Invoke(This, *(void**)(&llvm_libc_20_1_2_cpp_string_view2), ((long*)(&llvm_libc_20_1_2_cpp_string_view2))[1]);
		}
	}
}
internal static partial class String_view_equals
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp11string_view6equalsES1_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::string_view::equals(__llvm_libc_20_1_2_::cpp::string_view) const")]
	public unsafe static bool Invoke([MangledName("this")] void* This, [MangledName("Other.coerce0")] void* Other, [MangledName("Other.coerce1")] long Other_coerce1)
	{
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view = default(Llvm_libc_20_1_2_cpp_string_view);
		unchecked
		{
			*(void**)(&llvm_libc_20_1_2_cpp_string_view) = Other;
			((long*)(&llvm_libc_20_1_2_cpp_string_view))[1] = Other_coerce1;
			return ((Llvm_libc_20_1_2_cpp_string_view*)This)->Span_size == llvm_libc_20_1_2_cpp_string_view.Span_size && String_view_compareMemory.Invoke(((Llvm_libc_20_1_2_cpp_string_view*)This)->Span_data, llvm_libc_20_1_2_cpp_string_view.Span_data, llvm_libc_20_1_2_cpp_string_view.Span_size) == 0;
		}
	}
}

using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class String_view_substr
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp11string_view6substrEmm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::string_view::substr(unsigned long, unsigned long) const")]
	public unsafe static Struct_kqhe8i Invoke([MangledName("this")] void* This, [NativeType("unsigned long")] long Start, [NativeType("unsigned long")] long N)
	{
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view = default(Llvm_libc_20_1_2_cpp_string_view);
		long a = Start;
		unchecked
		{
			a = String_view_min.Invoke(a, ((Llvm_libc_20_1_2_cpp_string_view*)This)->Span_size);
			String_view_Constructor.Invoke(&llvm_libc_20_1_2_cpp_string_view, (byte*)((Llvm_libc_20_1_2_cpp_string_view*)This)->Span_data + a, String_view_min.Invoke(N, ((Llvm_libc_20_1_2_cpp_string_view*)This)->Span_size - a));
			return *(Struct_kqhe8i*)(&llvm_libc_20_1_2_cpp_string_view);
		}
	}
}

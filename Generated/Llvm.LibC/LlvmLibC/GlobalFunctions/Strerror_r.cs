using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Strerror_r
{
	[MangledName("strerror_r")]
	[DemangledName("strerror_r")]
	public unsafe static void* Invoke([MangledName("err_num")] int Err_num, [MangledName("buf")] void* Buf, [MangledName("buflen")] long Buflen)
	{
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view = default(Llvm_libc_20_1_2_cpp_string_view);
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view2 = default(Llvm_libc_20_1_2_cpp_string_view);
		Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_string_view);
		Span_char_Constructor.Invoke(&llvm_libc_20_1_2_cpp_string_view2, Buf, Buflen);
		unchecked
		{
			Struct_kqhe8i struct_kqhe8i = Llvm_libc_20_1_2_get_error_string.Invoke(Err_num, *(void**)(&llvm_libc_20_1_2_cpp_string_view2), ((long*)(&llvm_libc_20_1_2_cpp_string_view2))[1]);
			Llvm_libc_20_1_2_cpp_string_view* num = &llvm_libc_20_1_2_cpp_string_view;
			Struct_kqhe8i struct_kqhe8i2 = struct_kqhe8i;
			*(void**)num = struct_kqhe8i2.field_0;
			byte* num2 = (byte*)(&llvm_libc_20_1_2_cpp_string_view) + 8u;
			Struct_kqhe8i struct_kqhe8i3 = struct_kqhe8i;
			*(long*)num2 = struct_kqhe8i3.field_1;
			void* result = String_view_data.Invoke(&llvm_libc_20_1_2_cpp_string_view);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_string_view);
			return result;
		}
	}
}

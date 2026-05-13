using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Unimplemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_16get_error_stringEi")]
[DemangledName("__llvm_libc_20_1_2_::get_error_string(int)")]
internal static partial class Get_error_string_int
{
	public unsafe static Struct_kqhe8i Invoke(int err_num)
	{
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		cpp_string_view cpp_string_view3 = default(cpp_string_view);
		cpp_span_char_span_char_unsigned_long.Invoke(&cpp_string_view3, llvm_threadlocal_address_p0.Invoke(internal_error_buffer.Pointer), 26L);
		unchecked
		{
			Struct_kqhe8i struct_kqhe8i = Get_error_string_int_cpp_span_char.Invoke(err_num, *(void**)(&cpp_string_view3), ((long*)(&cpp_string_view3))[1]);
			cpp_string_view* num = &cpp_string_view2;
			Struct_kqhe8i struct_kqhe8i2 = struct_kqhe8i;
			*(void**)num = struct_kqhe8i2.field_0;
			byte* num2 = (byte*)(&cpp_string_view2) + 8u;
			Struct_kqhe8i struct_kqhe8i3 = struct_kqhe8i;
			*(long*)num2 = struct_kqhe8i3.field_1;
			return *(Struct_kqhe8i*)(&cpp_string_view2);
		}
	}
}

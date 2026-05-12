using System;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_16get_error_stringEiNS_3cpp4spanIcEE")]
[DemangledName("__llvm_libc_20_1_2_::get_error_string(int, __llvm_libc_20_1_2_::cpp::span<char>)")]
internal static partial class Get_error_string_int_cpp_span_char
{
	public unsafe static Struct_kqhe8i Invoke(int err_num, [MangledName("buffer.coerce0")] void* buffer, [MangledName("buffer.coerce1")] long opt_str)
	{
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		cpp_string_view cpp_string_view3 = default(cpp_string_view);
		cpp_optional_q73pcj cpp_optional_q73pcj2 = default(cpp_optional_q73pcj);
		cpp_string_view cpp_string_view4 = default(cpp_string_view);
		unchecked
		{
			*(void**)(&cpp_string_view3) = buffer;
			((long*)(&cpp_string_view3))[1] = opt_str;
			llvm_lifetime_start_p0.Invoke(24L, &cpp_optional_q73pcj2);
			sbyte* ptr = (sbyte*)(&cpp_optional_q73pcj2);
			sbyte* ptr2 = ptr;
			*(IntPtr*)ptr2 = unchecked((nint)(-6148914691236517206L));
			((long*)ptr2)[1] = -6148914691236517206L;
			ptr[16] = -86;
			sbyte* ptr3 = ptr + 17;
			*ptr3 = -86;
			ptr3[1] = -86;
			ptr3[2] = -86;
			ptr3[3] = -86;
			ptr3[4] = -86;
			ptr3[5] = -86;
			ptr3[6] = -86;
			MessageMapper_134ul_3113ul_get_str_int_const.Invoke(&cpp_optional_q73pcj2, (MessageMapper_76ei55*)internal_ERROR_MAPPER.Pointer, err_num);
			if (cpp_optional_cpp_string_view_operator_bool_const.Invoke(&cpp_optional_q73pcj2))
			{
				llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view2, cpp_optional_cpp_string_view_operator.Invoke(&cpp_optional_q73pcj2), 16L, isVolatile: false);
			}
			else
			{
				cpp_span_char_span_char_true_cpp_span_char.Invoke(&cpp_string_view4, &cpp_string_view3);
				Struct_kqhe8i struct_kqhe8i = internal_build_error_string_int_cpp_span_char.Invoke(err_num, *(void**)(&cpp_string_view4), ((long*)(&cpp_string_view4))[1]);
				cpp_string_view* num = &cpp_string_view2;
				Struct_kqhe8i struct_kqhe8i2 = struct_kqhe8i;
				*(void**)num = struct_kqhe8i2.field_0;
				byte* num2 = (byte*)(&cpp_string_view2) + 8u;
				Struct_kqhe8i struct_kqhe8i3 = struct_kqhe8i;
				*(long*)num2 = struct_kqhe8i3.field_1;
			}
			llvm_lifetime_end_p0.Invoke(24L, &cpp_optional_q73pcj2);
			return *(Struct_kqhe8i*)(&cpp_string_view2);
		}
	}
}

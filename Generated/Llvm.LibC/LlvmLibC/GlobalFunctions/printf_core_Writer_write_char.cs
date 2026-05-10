using System;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6Writer5writeEc")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::Writer::write(char)")]
internal static partial class printf_core_Writer_write_char
{
	public unsafe static int Invoke(void* @this, sbyte new_char)
	{
		sbyte b = 0;
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		cpp_string_view cpp_string_view3 = default(cpp_string_view);
		b = new_char;
		unchecked((printf_core_Writer*)@this)->chars_written++;
		unchecked
		{
			int result;
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((ulong)(((printf_core_WriteBuffer*)((printf_core_Writer*)@this)->wb)->buff_cur + 1L) <= (ulong)((printf_core_WriteBuffer*)((printf_core_Writer*)@this)->wb)->buff_len, expected: true))
			{
				sbyte b2 = b;
				((sbyte*)((printf_core_WriteBuffer*)((printf_core_Writer*)@this)->wb)->buff)[((printf_core_WriteBuffer*)((printf_core_Writer*)@this)->wb)->buff_cur] = b2;
				((printf_core_WriteBuffer*)((printf_core_Writer*)@this)->wb)->buff_cur++;
				result = 0;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(16L, &cpp_string_view2);
				*(IntPtr*)(&cpp_string_view2) = unchecked((nint)(-6148914691236517206L));
				((long*)(&cpp_string_view2))[1] = -6148914691236517206L;
				cpp_string_view_string_view_char_const_unsigned_long.Invoke(&cpp_string_view2, &b, 1L);
				void* wb = ((printf_core_Writer*)@this)->wb;
				llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view3, &cpp_string_view2, 16L, isVolatile: false);
				result = printf_core_WriteBuffer_overflow_write_cpp_string_view.Invoke(wb, *(void**)(&cpp_string_view3), ((long*)(&cpp_string_view3))[1]);
				llvm_lifetime_end_p0.Invoke(16L, &cpp_string_view2);
			}
			return result;
		}
	}
}

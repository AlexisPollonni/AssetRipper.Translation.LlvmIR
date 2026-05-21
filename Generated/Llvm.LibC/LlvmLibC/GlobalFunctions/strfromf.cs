using System;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class strfromf
{
	public unsafe static int Invoke(void* s, long n, void* format, float fp)
	{
		printf_core_FormatSection printf_core_FormatSection2 = default(printf_core_FormatSection);
		printf_core_WriteBuffer printf_core_WriteBuffer2 = default(printf_core_WriteBuffer);
		printf_core_Writer printf_core_Writer2 = default(printf_core_Writer);
		int num = 0;
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		llvm_lifetime_start_p0.Invoke(80L, &printf_core_FormatSection2);
		llvm_memset_p0_i64.Invoke(&printf_core_FormatSection2, -86, 80L, isVolatile: false);
		internal_parse_format_string_float.Invoke(&printf_core_FormatSection2, format, fp);
		llvm_lifetime_start_p0.Invoke(56L, &printf_core_WriteBuffer2);
		llvm_memset_p0_i64.Invoke(&printf_core_WriteBuffer2, -86, 56L, isVolatile: false);
		unchecked
		{
			WriteBuffer_Constructor.Invoke(&printf_core_WriteBuffer2, s, ((ulong)n <= 0uL) ? 0L : (n - 1L));
			llvm_lifetime_start_p0.Invoke(16L, &printf_core_Writer2);
			*(IntPtr*)(&printf_core_Writer2) = unchecked((nint)(-6148914691236517206L));
			((int*)(&printf_core_Writer2))[2] = -1431655766;
			sbyte* ptr = (sbyte*)(&printf_core_Writer2) + 12;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			ptr[3] = -86;
			Writer_Constructor.Invoke(&printf_core_Writer2, &printf_core_WriteBuffer2);
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = 0;
			if ((printf_core_FormatSection2.has_conv & 1) == 1)
			{
				num = internal_strfromfloat_convert_float.Invoke(&printf_core_Writer2, &printf_core_FormatSection2);
			}
			else
			{
				llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view2, &printf_core_FormatSection2.raw_string, 16L, isVolatile: false);
				num = Writer_write.Invoke(&printf_core_Writer2, *(void**)(&cpp_string_view2), ((long*)(&cpp_string_view2))[1]);
			}
			int result;
			if (num < 0)
			{
				result = num;
			}
			else
			{
				if ((ulong)n > 0uL)
				{
					((sbyte*)printf_core_WriteBuffer2.buff)[printf_core_WriteBuffer2.buff_cur] = 0;
				}
				result = Writer_get_chars_written.Invoke(&printf_core_Writer2);
			}
			llvm_lifetime_end_p0.Invoke(4L, &num);
			llvm_lifetime_end_p0.Invoke(16L, &printf_core_Writer2);
			llvm_lifetime_end_p0.Invoke(56L, &printf_core_WriteBuffer2);
			llvm_lifetime_end_p0.Invoke(80L, &printf_core_FormatSection2);
			return result;
		}
	}
}

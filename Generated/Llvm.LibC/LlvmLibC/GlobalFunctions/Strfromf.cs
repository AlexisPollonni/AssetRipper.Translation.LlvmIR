using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Strfromf
{
	[MangledName("strfromf")]
	[DemangledName("strfromf")]
	public unsafe static int Invoke([MangledName("s")] void* S, [MangledName("n")] long N, [MangledName("format")] void* Format, [MangledName("fp")] float Fp)
	{
		Llvm_libc_20_1_2_printf_core_FormatSection llvm_libc_20_1_2_printf_core_FormatSection = default(Llvm_libc_20_1_2_printf_core_FormatSection);
		Llvm_libc_20_1_2_printf_core_WriteBuffer llvm_libc_20_1_2_printf_core_WriteBuffer = default(Llvm_libc_20_1_2_printf_core_WriteBuffer);
		Llvm_libc_20_1_2_printf_core_Writer llvm_libc_20_1_2_printf_core_Writer = default(Llvm_libc_20_1_2_printf_core_Writer);
		int num = 0;
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view = default(Llvm_libc_20_1_2_cpp_string_view);
		Llvm_lifetime_start_p0.Invoke(80L, &llvm_libc_20_1_2_printf_core_FormatSection);
		Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_printf_core_FormatSection, -86, 80L, isVolatile: false);
		Internal_parse_format_string_float.Invoke(&llvm_libc_20_1_2_printf_core_FormatSection, Format, Fp);
		Llvm_lifetime_start_p0.Invoke(56L, &llvm_libc_20_1_2_printf_core_WriteBuffer);
		Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_printf_core_WriteBuffer, -86, 56L, isVolatile: false);
		unchecked
		{
			WriteBuffer_Constructor.Invoke(&llvm_libc_20_1_2_printf_core_WriteBuffer, S, ((ulong)N <= 0uL) ? 0L : (N - 1L));
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_printf_core_Writer);
			*(IntPtr*)(&llvm_libc_20_1_2_printf_core_Writer) = unchecked((nint)(-6148914691236517206L));
			((int*)(&llvm_libc_20_1_2_printf_core_Writer))[2] = -1431655766;
			sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_printf_core_Writer) + 12;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			ptr[3] = -86;
			Writer_Constructor.Invoke(&llvm_libc_20_1_2_printf_core_Writer, &llvm_libc_20_1_2_printf_core_WriteBuffer);
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = 0;
			if ((llvm_libc_20_1_2_printf_core_FormatSection.Has_conv & 1) == 1)
			{
				num = Internal_strfromfloat_convert_float.Invoke(&llvm_libc_20_1_2_printf_core_Writer, &llvm_libc_20_1_2_printf_core_FormatSection);
			}
			else
			{
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_cpp_string_view, &llvm_libc_20_1_2_printf_core_FormatSection.Raw_string, 16L, isVolatile: false);
				num = Writer_write.Invoke(&llvm_libc_20_1_2_printf_core_Writer, *(void**)(&llvm_libc_20_1_2_cpp_string_view), ((long*)(&llvm_libc_20_1_2_cpp_string_view))[1]);
			}
			int result;
			if (num < 0)
			{
				result = num;
			}
			else
			{
				if ((ulong)N > 0uL)
				{
					((sbyte*)llvm_libc_20_1_2_printf_core_WriteBuffer.Buff)[llvm_libc_20_1_2_printf_core_WriteBuffer.Buff_cur] = 0;
				}
				result = Writer_get_chars_written.Invoke(&llvm_libc_20_1_2_printf_core_Writer);
			}
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_printf_core_Writer);
			Llvm_lifetime_end_p0.Invoke(56L, &llvm_libc_20_1_2_printf_core_WriteBuffer);
			Llvm_lifetime_end_p0.Invoke(80L, &llvm_libc_20_1_2_printf_core_FormatSection);
			return result;
		}
	}
}

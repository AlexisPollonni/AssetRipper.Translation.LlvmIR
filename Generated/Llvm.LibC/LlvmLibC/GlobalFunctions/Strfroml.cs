using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Strfroml
{
	[MangledName("strfroml")]
	[DemangledName("strfroml")]
	public unsafe static int Invoke([MangledName("s")] void* S, [MangledName("n")] long N, [MangledName("format")] void* Format, [MangledName("fp")] double Fp)
	{
		Printf_core_FormatSection printf_core_FormatSection = default(Printf_core_FormatSection);
		Printf_core_WriteBuffer printf_core_WriteBuffer = default(Printf_core_WriteBuffer);
		Printf_core_Writer printf_core_Writer = default(Printf_core_Writer);
		int num = 0;
		Cpp_string_view cpp_string_view = default(Cpp_string_view);
		Llvm_lifetime_start_p0.Invoke(80L, &printf_core_FormatSection);
		Llvm_memset_p0_i64.Invoke(&printf_core_FormatSection, -86, 80L, isVolatile: false);
		Internal_parse_format_string_long_double.Invoke(&printf_core_FormatSection, Format, Fp);
		printf_core_FormatSection.Length_modifier = LengthModifier_mnvaa2.L;
		Llvm_lifetime_start_p0.Invoke(56L, &printf_core_WriteBuffer);
		Llvm_memset_p0_i64.Invoke(&printf_core_WriteBuffer, -86, 56L, isVolatile: false);
		unchecked
		{
			WriteBuffer_Constructor.Invoke(&printf_core_WriteBuffer, S, ((ulong)N <= 0uL) ? 0L : (N - 1L));
			Llvm_lifetime_start_p0.Invoke(16L, &printf_core_Writer);
			*(IntPtr*)(&printf_core_Writer) = unchecked((nint)(-6148914691236517206L));
			((int*)(&printf_core_Writer))[2] = -1431655766;
			sbyte* ptr = (sbyte*)(&printf_core_Writer) + 12;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			ptr[3] = -86;
			Writer_Constructor.Invoke(&printf_core_Writer, &printf_core_WriteBuffer);
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = 0;
			if ((printf_core_FormatSection.Has_conv & 1) == 1)
			{
				num = Internal_strfromfloat_convert_long_double.Invoke(&printf_core_Writer, &printf_core_FormatSection);
			}
			else
			{
				Llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view, &printf_core_FormatSection.Raw_string, 16L, isVolatile: false);
				num = Writer_write.Invoke(&printf_core_Writer, *(void**)(&cpp_string_view), ((long*)(&cpp_string_view))[1]);
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
					((sbyte*)printf_core_WriteBuffer.Buff)[printf_core_WriteBuffer.Buff_cur] = 0;
				}
				result = Writer_get_chars_written.Invoke(&printf_core_Writer);
			}
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			Llvm_lifetime_end_p0.Invoke(16L, &printf_core_Writer);
			Llvm_lifetime_end_p0.Invoke(56L, &printf_core_WriteBuffer);
			Llvm_lifetime_end_p0.Invoke(80L, &printf_core_FormatSection);
			return result;
		}
	}
}

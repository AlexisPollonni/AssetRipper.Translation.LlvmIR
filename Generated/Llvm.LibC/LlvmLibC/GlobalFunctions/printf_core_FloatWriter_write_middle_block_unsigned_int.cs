using System;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core11FloatWriter18write_middle_blockEj")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::FloatWriter::write_middle_block(unsigned int)")]
internal static partial class printf_core_FloatWriter_write_middle_block_unsigned_int
{
	public unsafe static int Invoke(void* @this, int block)
	{
		int result = 0;
		int num = 0;
		IntegerToString_uuwdyc integerToString_uuwdyc = default(IntegerToString_uuwdyc);
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		long num2 = 0L;
		unchecked
		{
			if (block == 999999999)
			{
				((printf_core_FloatWriter*)@this)->max_block_count++;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = printf_core_FloatWriter_flush_buffer_bool.Invoke(@this, round_up_max_blocks: false);
				int num3;
				if (num < 0)
				{
					result = num;
					num3 = 1;
				}
				else
				{
					num3 = 0;
				}
				llvm_lifetime_end_p0.Invoke(4L, &num);
				switch (num3)
				{
				case 0:
					break;
				case 1:
					goto IL_02aa;
				default:
					throw null;
				}
				llvm_lifetime_start_p0.Invoke(32L, &integerToString_uuwdyc);
				sbyte* ptr = (sbyte*)(&integerToString_uuwdyc);
				*ptr = -86;
				ptr[1] = -86;
				ptr[2] = -86;
				ptr[3] = -86;
				ptr[4] = -86;
				ptr[5] = -86;
				ptr[6] = -86;
				ptr[7] = -86;
				ptr[8] = -86;
				ptr[9] = -86;
				ptr[10] = -86;
				ptr[11] = -86;
				ptr[12] = -86;
				ptr[13] = -86;
				ptr[14] = -86;
				ptr[15] = -86;
				ptr[16] = -86;
				ptr[17] = -86;
				ptr[18] = -86;
				ptr[19] = -86;
				ptr[20] = -86;
				sbyte* ptr2 = (sbyte*)(&integerToString_uuwdyc) + 21;
				*ptr2 = -86;
				ptr2[1] = -86;
				ptr2[2] = -86;
				((long*)(&integerToString_uuwdyc))[3] = -6148914691236517206L;
				IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_IntegerToString_long.Invoke(&integerToString_uuwdyc, (uint)(block + 1000000000));
				llvm_lifetime_start_p0.Invoke(16L, &cpp_string_view2);
				*(IntPtr*)(&cpp_string_view2) = unchecked((nint)(-6148914691236517206L));
				((long*)(&cpp_string_view2))[1] = -6148914691236517206L;
				Struct_kqhe8i struct_kqhe8i = IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_view_const.Invoke(&integerToString_uuwdyc);
				cpp_string_view* num4 = &cpp_string_view2;
				Struct_kqhe8i struct_kqhe8i2 = struct_kqhe8i;
				*(void**)num4 = struct_kqhe8i2.field_0;
				byte* num5 = (byte*)(&cpp_string_view2) + 8u;
				Struct_kqhe8i struct_kqhe8i3 = struct_kqhe8i;
				*(long*)num5 = struct_kqhe8i3.field_1;
				llvm_lifetime_start_p0.Invoke(8L, &num2);
				for (num2 = 0L; (ulong)num2 < 9uL; num2++)
				{
					sbyte b = *(sbyte*)cpp_string_view_operator_unsigned_long_const.Invoke(&cpp_string_view2, num2 + 1L);
					((sbyte*)(&((printf_core_FloatWriter*)@this)->block_buffer))[num2] = b;
				}
				llvm_lifetime_end_p0.Invoke(8L, &num2);
				((printf_core_FloatWriter*)@this)->buffered_digits = 9L;
				llvm_lifetime_end_p0.Invoke(16L, &cpp_string_view2);
				llvm_lifetime_end_p0.Invoke(32L, &integerToString_uuwdyc);
			}
			result = 0;
			goto IL_02aa;
		}
		IL_02aa:
		return result;
	}
}

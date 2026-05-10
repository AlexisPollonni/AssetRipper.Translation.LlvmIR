using System;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core11FloatWriter17write_first_blockEjb")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::FloatWriter::write_first_block(unsigned int, bool)")]
internal static partial class printf_core_FloatWriter_write_first_block_unsigned_int_bool
{
	public unsafe static void Invoke(void* @this, int block, bool exp_format)
	{
		IntegerToString_uuwdyc integerToString_uuwdyc = default(IntegerToString_uuwdyc);
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		long num = 0L;
		long num2 = 0L;
		sbyte b = (exp_format ? ((sbyte)1) : ((sbyte)0));
		llvm_lifetime_start_p0.Invoke(32L, &integerToString_uuwdyc);
		unchecked
		{
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
			IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_IntegerToString_long.Invoke(&integerToString_uuwdyc, (uint)block);
			llvm_lifetime_start_p0.Invoke(16L, &cpp_string_view2);
			*(IntPtr*)(&cpp_string_view2) = unchecked((nint)(-6148914691236517206L));
			((long*)(&cpp_string_view2))[1] = -6148914691236517206L;
			Struct_kqhe8i struct_kqhe8i = IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_view_const.Invoke(&integerToString_uuwdyc);
			cpp_string_view* num3 = &cpp_string_view2;
			Struct_kqhe8i struct_kqhe8i2 = struct_kqhe8i;
			*(void**)num3 = struct_kqhe8i2.field_0;
			byte* num4 = (byte*)(&cpp_string_view2) + 8u;
			Struct_kqhe8i struct_kqhe8i3 = struct_kqhe8i;
			*(long*)num4 = struct_kqhe8i3.field_1;
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = cpp_string_view_size_const.Invoke(&cpp_string_view2);
			llvm_lifetime_start_p0.Invoke(8L, &num2);
			for (num2 = 0L; (ulong)num2 < (ulong)num; num2++)
			{
				sbyte b2 = *(sbyte*)cpp_string_view_operator_unsigned_long_const.Invoke(&cpp_string_view2, num2);
				((sbyte*)(&((printf_core_FloatWriter*)@this)->block_buffer))[num2] = b2;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			((printf_core_FloatWriter*)@this)->buffered_digits = num;
			if ((b & 1) != 1)
			{
				((printf_core_FloatWriter*)@this)->total_digits += num;
				((printf_core_FloatWriter*)@this)->digits_before_decimal += num;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			llvm_lifetime_end_p0.Invoke(16L, &cpp_string_view2);
			llvm_lifetime_end_p0.Invoke(32L, &integerToString_uuwdyc);
		}
	}
}

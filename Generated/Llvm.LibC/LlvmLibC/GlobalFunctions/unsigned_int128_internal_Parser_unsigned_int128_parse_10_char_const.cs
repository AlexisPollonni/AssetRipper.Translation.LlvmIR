using System;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal6ParserIoE5parseILi10EEEoPKc")]
[DemangledName("unsigned __int128 __llvm_libc_20_1_2_::internal::Parser<unsigned __int128>::parse<10>(char const*)")]
internal static partial class unsigned_int128_internal_Parser_unsigned_int128_parse_10_char_const
{
	public unsafe static Struct_fiz2nb Invoke(void* str)
	{
		internal_DigitBuffer_wha8ym internal_DigitBuffer_wha8ym2 = default(internal_DigitBuffer_wha8ym);
		Int128 @int = default(Int128);
		llvm_lifetime_start_p0.Invoke(56L, &internal_DigitBuffer_wha8ym2);
		llvm_memset_p0_i64.Invoke(&internal_DigitBuffer_wha8ym2, -86, 56L, isVolatile: false);
		internal_DigitBuffer_unsigned_int128_10_DigitBuffer_char_const.Invoke(&internal_DigitBuffer_wha8ym2, str);
		Struct_fiz2nb struct_fiz2nb = unsigned_int128_internal_accumulate_unsigned_int128_int_unsigned_char_const_unsigned_long.Invoke(10, &internal_DigitBuffer_wha8ym2.digits, internal_DigitBuffer_wha8ym2.size);
		Int128* num = &@int;
		Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
		unchecked
		{
			*(long*)num = struct_fiz2nb2.field_0;
			byte* num2 = (byte*)(&@int) + 8u;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			*(long*)num2 = struct_fiz2nb3.field_1;
			Int128 int2 = @int;
			llvm_lifetime_end_p0.Invoke(56L, &internal_DigitBuffer_wha8ym2);
			return *(Struct_fiz2nb*)(&int2);
		}
	}
}

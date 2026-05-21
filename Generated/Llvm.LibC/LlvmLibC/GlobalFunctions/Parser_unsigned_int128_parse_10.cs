using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Parser_unsigned_int128_parse_10
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal6ParserIoE5parseILi10EEEoPKc")]
	[DemangledName("unsigned __int128 __llvm_libc_20_1_2_::internal::Parser<unsigned __int128>::parse<10>(char const*)")]
	[return: NativeType("unsigned __int128")]
	public unsafe static Struct_fiz2nb Invoke([MangledName("str")][NativeType("char const*")] void* Str)
	{
		Llvm_libc_20_1_2_internal_DigitBuffer_wha8ym llvm_libc_20_1_2_internal_DigitBuffer_wha8ym = default(Llvm_libc_20_1_2_internal_DigitBuffer_wha8ym);
		Int128 @int = default(Int128);
		Llvm_lifetime_start_p0.Invoke(56L, &llvm_libc_20_1_2_internal_DigitBuffer_wha8ym);
		Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_internal_DigitBuffer_wha8ym, -86, 56L, isVolatile: false);
		DigitBuffer_unsigned_int128_10_Constructor.Invoke(&llvm_libc_20_1_2_internal_DigitBuffer_wha8ym, Str);
		Struct_fiz2nb struct_fiz2nb = Internal_accumulate_unsigned_int128.Invoke(10, &llvm_libc_20_1_2_internal_DigitBuffer_wha8ym.Digits, llvm_libc_20_1_2_internal_DigitBuffer_wha8ym.Size);
		Int128* num = &@int;
		Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
		unchecked
		{
			*(long*)num = struct_fiz2nb2.field_0;
			byte* num2 = (byte*)(&@int) + 8u;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			*(long*)num2 = struct_fiz2nb3.field_1;
			Int128 int2 = @int;
			Llvm_lifetime_end_p0.Invoke(56L, &llvm_libc_20_1_2_internal_DigitBuffer_wha8ym);
			return *(Struct_fiz2nb*)(&int2);
		}
	}
}

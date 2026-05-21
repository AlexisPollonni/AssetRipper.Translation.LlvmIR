using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Parser_unsigned_int128_parse_16
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal6ParserIoE5parseILi16EEEoPKc")]
	[DemangledName("unsigned __int128 __llvm_libc_20_1_2_::internal::Parser<unsigned __int128>::parse<16>(char const*)")]
	[return: NativeType("unsigned __int128")]
	public unsafe static Struct_fiz2nb Invoke([MangledName("str")][NativeType("char const*")] void* Str)
	{
		Llvm_libc_20_1_2_internal_DigitBuffer_cze9ca llvm_libc_20_1_2_internal_DigitBuffer_cze9ca = default(Llvm_libc_20_1_2_internal_DigitBuffer_cze9ca);
		Int128 @int = default(Int128);
		Llvm_lifetime_start_p0.Invoke(40L, &llvm_libc_20_1_2_internal_DigitBuffer_cze9ca);
		Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_internal_DigitBuffer_cze9ca, -86, 40L, isVolatile: false);
		DigitBuffer_unsigned_int128_16_Constructor.Invoke(&llvm_libc_20_1_2_internal_DigitBuffer_cze9ca, Str);
		Struct_fiz2nb struct_fiz2nb = Internal_accumulate_unsigned_int128.Invoke(16, &llvm_libc_20_1_2_internal_DigitBuffer_cze9ca.Digits, llvm_libc_20_1_2_internal_DigitBuffer_cze9ca.Size);
		Int128* num = &@int;
		Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
		unchecked
		{
			*(long*)num = struct_fiz2nb2.field_0;
			byte* num2 = (byte*)(&@int) + 8u;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			*(long*)num2 = struct_fiz2nb3.field_1;
			Int128 int2 = @int;
			Llvm_lifetime_end_p0.Invoke(40L, &llvm_libc_20_1_2_internal_DigitBuffer_cze9ca);
			return *(Struct_fiz2nb*)(&int2);
		}
	}
}

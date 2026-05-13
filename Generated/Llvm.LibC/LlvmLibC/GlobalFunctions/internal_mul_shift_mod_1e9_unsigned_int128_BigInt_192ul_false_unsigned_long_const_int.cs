using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal17mul_shift_mod_1e9EoRKNS_6BigIntILm192ELb0EmEEi")]
[DemangledName("__llvm_libc_20_1_2_::internal::mul_shift_mod_1e9(unsigned __int128, __llvm_libc_20_1_2_::BigInt<192ul, false, unsigned long> const&, int)")]
internal static partial class internal_mul_shift_mod_1e9_unsigned_int128_BigInt_192ul_false_unsigned_long_const_int
{
	public unsafe static int Invoke([MangledName("mantissa.coerce0")] long mantissa, [MangledName("mantissa.coerce1")] long large, [MangledName("large")] void* shift_amount, [MangledName("shift_amount")] int val)
	{
		Int128 @int = default(Int128);
		BigInt_76gxx6 bigInt_76gxx = default(BigInt_76gxx6);
		BigInt_76gxx6 bigInt_76gxx2 = default(BigInt_76gxx6);
		BigInt_76gxx6 bigInt_76gxx3 = default(BigInt_76gxx6);
		BigInt_76gxx6 bigInt_76gxx4 = default(BigInt_76gxx6);
		cpp_optional_w3bnnt cpp_optional_w3bnnt2 = default(cpp_optional_w3bnnt);
		unchecked
		{
			*(long*)(&@int) = mantissa;
			((long*)(&@int))[1] = large;
			Int128 int2 = @int;
			llvm_lifetime_start_p0.Invoke(40L, &bigInt_76gxx);
			llvm_memset_p0_i64.Invoke(&bigInt_76gxx, 0, 40L, isVolatile: false);
			InlineArray5_Int64* ptr = &bigInt_76gxx.val.Data;
			*(long*)ptr = -6148914691236517206L;
			((long*)ptr)[1] = -6148914691236517206L;
			((long*)ptr)[2] = -6148914691236517206L;
			((long*)ptr)[3] = -6148914691236517206L;
			((long*)ptr)[4] = -6148914691236517206L;
			BigInt_320ul_false_unsigned_long_BigInt_192ul_false_unsigned_long_BigInt_192ul_false_unsigned_long_const.Invoke(&bigInt_76gxx, (BigInt_ghrwnp*)shift_amount);
			llvm_lifetime_start_p0.Invoke(40L, &bigInt_76gxx2);
			llvm_lifetime_start_p0.Invoke(40L, &bigInt_76gxx3);
			llvm_lifetime_start_p0.Invoke(40L, &bigInt_76gxx4);
			Int128 int3 = int2;
			BigInt_320ul_false_unsigned_long_BigInt_unsigned_int128_void_unsigned_int128.Invoke(&bigInt_76gxx4, *(long*)(&int3), ((long*)(&int3))[1]);
			BigInt_320ul_false_unsigned_long_operator_BigInt_320ul_false_unsigned_long_const_const.Invoke(&bigInt_76gxx3, &bigInt_76gxx, &bigInt_76gxx4);
			BigInt_320ul_false_unsigned_long_operator_unsigned_long_const.Invoke(&bigInt_76gxx2, &bigInt_76gxx3, val);
			llvm_memcpy_p0_p0_i64.Invoke(&bigInt_76gxx, &bigInt_76gxx2, 40L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(40L, &bigInt_76gxx4);
			llvm_lifetime_end_p0.Invoke(40L, &bigInt_76gxx3);
			llvm_lifetime_end_p0.Invoke(40L, &bigInt_76gxx2);
			llvm_lifetime_start_p0.Invoke(48L, &cpp_optional_w3bnnt2);
			BigInt_320ul_false_unsigned_long_div_uint_half_times_pow_2_unsigned_int_unsigned_long.Invoke(&cpp_optional_w3bnnt2, &bigInt_76gxx, 1000000000, 0L);
			int result = BigInt_320ul_false_unsigned_long_operator_unsigned_int_unsigned_int_const.Invoke(cpp_optional_BigInt_320ul_false_unsigned_long_value.Invoke(&cpp_optional_w3bnnt2));
			llvm_lifetime_end_p0.Invoke(48L, &cpp_optional_w3bnnt2);
			llvm_lifetime_end_p0.Invoke(40L, &bigInt_76gxx);
			return result;
		}
	}
}

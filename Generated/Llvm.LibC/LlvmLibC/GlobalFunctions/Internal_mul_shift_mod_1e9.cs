using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_mul_shift_mod_1e9
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal17mul_shift_mod_1e9EoRKNS_6BigIntILm192ELb0EmEEi")]
	[DemangledName("__llvm_libc_20_1_2_::internal::mul_shift_mod_1e9(unsigned __int128, __llvm_libc_20_1_2_::BigInt<192ul, false, unsigned long> const&, int)")]
	public unsafe static int Invoke([MangledName("mantissa.coerce0")] long Mantissa, [MangledName("mantissa.coerce1")][NativeType("unsigned __int128")] long Large, [MangledName("large")][NativeType("__llvm_libc_20_1_2_::BigInt<192ul, false, unsigned long> const&")] void* Shift_amount, [MangledName("shift_amount")][NativeType("int")] int Val)
	{
		Int128 @int = default(Int128);
		Llvm_libc_20_1_2_BigInt_76gxx6 llvm_libc_20_1_2_BigInt_76gxx = default(Llvm_libc_20_1_2_BigInt_76gxx6);
		Llvm_libc_20_1_2_BigInt_76gxx6 llvm_libc_20_1_2_BigInt_76gxx2 = default(Llvm_libc_20_1_2_BigInt_76gxx6);
		Llvm_libc_20_1_2_BigInt_76gxx6 llvm_libc_20_1_2_BigInt_76gxx3 = default(Llvm_libc_20_1_2_BigInt_76gxx6);
		Llvm_libc_20_1_2_BigInt_76gxx6 llvm_libc_20_1_2_BigInt_76gxx4 = default(Llvm_libc_20_1_2_BigInt_76gxx6);
		Llvm_libc_20_1_2_cpp_optional_t82b4p llvm_libc_20_1_2_cpp_optional_t82b4p = default(Llvm_libc_20_1_2_cpp_optional_t82b4p);
		unchecked
		{
			*(long*)(&@int) = Mantissa;
			((long*)(&@int))[1] = Large;
			Int128 int2 = @int;
			Llvm_lifetime_start_p0.Invoke(40L, &llvm_libc_20_1_2_BigInt_76gxx);
			Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_BigInt_76gxx, 0, 40L, isVolatile: false);
			InlineArray5_Int64* ptr = &llvm_libc_20_1_2_BigInt_76gxx.Val.Data;
			*(long*)ptr = -6148914691236517206L;
			((long*)ptr)[1] = -6148914691236517206L;
			((long*)ptr)[2] = -6148914691236517206L;
			((long*)ptr)[3] = -6148914691236517206L;
			((long*)ptr)[4] = -6148914691236517206L;
			BigInt_320ul_false_unsigned_long_BigInt_192ul_false_unsigned_long.Invoke(&llvm_libc_20_1_2_BigInt_76gxx, (Llvm_libc_20_1_2_BigInt_khh67p*)Shift_amount);
			Llvm_lifetime_start_p0.Invoke(40L, &llvm_libc_20_1_2_BigInt_76gxx2);
			Llvm_lifetime_start_p0.Invoke(40L, &llvm_libc_20_1_2_BigInt_76gxx3);
			Llvm_lifetime_start_p0.Invoke(40L, &llvm_libc_20_1_2_BigInt_76gxx4);
			Int128 int3 = int2;
			BigInt_320ul_false_unsigned_long_BigInt_unsigned_int128_void.Invoke(&llvm_libc_20_1_2_BigInt_76gxx4, *(long*)(&int3), ((long*)(&int3))[1]);
			BigInt_320ul_false_unsigned_long_Multiply.Invoke(&llvm_libc_20_1_2_BigInt_76gxx3, &llvm_libc_20_1_2_BigInt_76gxx, &llvm_libc_20_1_2_BigInt_76gxx4);
			BigInt_320ul_false_unsigned_long_RightShift.Invoke(&llvm_libc_20_1_2_BigInt_76gxx2, &llvm_libc_20_1_2_BigInt_76gxx3, Val);
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_BigInt_76gxx, &llvm_libc_20_1_2_BigInt_76gxx2, 40L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(40L, &llvm_libc_20_1_2_BigInt_76gxx4);
			Llvm_lifetime_end_p0.Invoke(40L, &llvm_libc_20_1_2_BigInt_76gxx3);
			Llvm_lifetime_end_p0.Invoke(40L, &llvm_libc_20_1_2_BigInt_76gxx2);
			Llvm_lifetime_start_p0.Invoke(48L, &llvm_libc_20_1_2_cpp_optional_t82b4p);
			BigInt_320ul_false_unsigned_long_div_uint_half_times_pow_2.Invoke(&llvm_libc_20_1_2_cpp_optional_t82b4p, &llvm_libc_20_1_2_BigInt_76gxx, 1000000000, 0L);
			int result = BigInt_320ul_false_unsigned_long_Unsigned_int_unsigned_int.Invoke(Optional_BigInt_320ul_false_unsigned_long_value.Invoke(&llvm_libc_20_1_2_cpp_optional_t82b4p));
			Llvm_lifetime_end_p0.Invoke(48L, &llvm_libc_20_1_2_cpp_optional_t82b4p);
			Llvm_lifetime_end_p0.Invoke(40L, &llvm_libc_20_1_2_BigInt_76gxx);
			return result;
		}
	}
}

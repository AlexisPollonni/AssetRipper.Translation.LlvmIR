using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_shift_mantissa_BigInt_256ul_false_unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic8internal14shift_mantissaINS_6BigIntILm256ELb0EmEEEENS_3cpp9enable_ifIX33is_unsigned_integral_or_big_int_vIT_EEbE4typeEiRS8_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<is_unsigned_integral_or_big_int_v<__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>>, bool>::type __llvm_libc_20_1_2_::fputil::generic::internal::shift_mantissa<__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>>(int, __llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<is_unsigned_integral_or_big_int_v<__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>>, bool>::type")]
	public unsafe static bool Invoke([NativeType("int")] int shift_length, [NativeType("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>&")] BigInt_x9dsed* mant)
	{
		BigInt_x9dsed bigInt_x9dsed = default(BigInt_x9dsed);
		BigInt_x9dsed bigInt_x9dsed2 = default(BigInt_x9dsed);
		BigInt_x9dsed bigInt_x9dsed3 = default(BigInt_x9dsed);
		BigInt_x9dsed bigInt_x9dsed4 = default(BigInt_x9dsed);
		BigInt_x9dsed bigInt_x9dsed5 = default(BigInt_x9dsed);
		sbyte b = 0;
		BigInt_x9dsed bigInt_x9dsed6 = default(BigInt_x9dsed);
		BigInt_x9dsed bigInt_x9dsed7 = default(BigInt_x9dsed);
		unchecked
		{
			bool result;
			if (shift_length >= 256)
			{
				llvm_lifetime_start_p0.Invoke(32L, &bigInt_x9dsed);
				BigInt_256ul_false_unsigned_long_BigInt_int_void.Invoke(&bigInt_x9dsed, 0);
				llvm_memcpy_p0_p0_i64.Invoke(mant, &bigInt_x9dsed, 32L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(32L, &bigInt_x9dsed);
				result = true;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(32L, &bigInt_x9dsed2);
				sbyte* ptr = (sbyte*)(&bigInt_x9dsed2);
				*(long*)ptr = -6148914691236517206L;
				((long*)ptr)[1] = -6148914691236517206L;
				((long*)ptr)[2] = -6148914691236517206L;
				((long*)ptr)[3] = -6148914691236517206L;
				llvm_lifetime_start_p0.Invoke(32L, &bigInt_x9dsed3);
				llvm_lifetime_start_p0.Invoke(32L, &bigInt_x9dsed4);
				BigInt_256ul_false_unsigned_long_BigInt_int_void.Invoke(&bigInt_x9dsed4, 1);
				BigInt_256ul_false_unsigned_long_LeftShift.Invoke(&bigInt_x9dsed3, &bigInt_x9dsed4, shift_length);
				llvm_lifetime_start_p0.Invoke(32L, &bigInt_x9dsed5);
				BigInt_256ul_false_unsigned_long_BigInt_int_void.Invoke(&bigInt_x9dsed5, 1);
				BigInt_256ul_false_unsigned_long_Subtract_nar9qw.Invoke(&bigInt_x9dsed2, &bigInt_x9dsed3, &bigInt_x9dsed5);
				llvm_lifetime_end_p0.Invoke(32L, &bigInt_x9dsed5);
				llvm_lifetime_end_p0.Invoke(32L, &bigInt_x9dsed4);
				llvm_lifetime_end_p0.Invoke(32L, &bigInt_x9dsed3);
				llvm_lifetime_start_p0.Invoke(1L, &b);
				llvm_lifetime_start_p0.Invoke(32L, &bigInt_x9dsed6);
				BitwiseAnd.Invoke(&bigInt_x9dsed6, mant, &bigInt_x9dsed2);
				llvm_lifetime_start_p0.Invoke(32L, &bigInt_x9dsed7);
				BigInt_256ul_false_unsigned_long_BigInt_int_void.Invoke(&bigInt_x9dsed7, 0);
				bool num = NotEquals_j3a3qv.Invoke(&bigInt_x9dsed6, &bigInt_x9dsed7);
				llvm_lifetime_end_p0.Invoke(32L, &bigInt_x9dsed7);
				llvm_lifetime_end_p0.Invoke(32L, &bigInt_x9dsed6);
				b = (num ? ((sbyte)1) : ((sbyte)0));
				BigInt_256ul_false_unsigned_long_Operator_i2c6iz.Invoke(mant, shift_length);
				result = (b & 1) == 1;
				llvm_lifetime_end_p0.Invoke(1L, &b);
				llvm_lifetime_end_p0.Invoke(32L, &bigInt_x9dsed2);
			}
			return result;
		}
	}
}

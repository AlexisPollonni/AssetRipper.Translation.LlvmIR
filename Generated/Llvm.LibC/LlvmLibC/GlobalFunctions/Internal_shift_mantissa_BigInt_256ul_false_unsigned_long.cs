using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_shift_mantissa_BigInt_256ul_false_unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic8internal14shift_mantissaINS_6BigIntILm256ELb0EmEEEENS_3cpp9enable_ifIX33is_unsigned_integral_or_big_int_vIT_EEbE4typeEiRS8_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<is_unsigned_integral_or_big_int_v<__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>>, bool>::type __llvm_libc_20_1_2_::fputil::generic::internal::shift_mantissa<__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>>(int, __llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<is_unsigned_integral_or_big_int_v<__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>>, bool>::type")]
	public unsafe static bool Invoke([MangledName("shift_length")][NativeType("int")] int Shift_length, [MangledName("mant")][NativeType("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>&")] Llvm_libc_20_1_2_BigInt_x9dsed* Mant)
	{
		Llvm_libc_20_1_2_BigInt_x9dsed llvm_libc_20_1_2_BigInt_x9dsed = default(Llvm_libc_20_1_2_BigInt_x9dsed);
		Llvm_libc_20_1_2_BigInt_x9dsed llvm_libc_20_1_2_BigInt_x9dsed2 = default(Llvm_libc_20_1_2_BigInt_x9dsed);
		Llvm_libc_20_1_2_BigInt_x9dsed llvm_libc_20_1_2_BigInt_x9dsed3 = default(Llvm_libc_20_1_2_BigInt_x9dsed);
		Llvm_libc_20_1_2_BigInt_x9dsed llvm_libc_20_1_2_BigInt_x9dsed4 = default(Llvm_libc_20_1_2_BigInt_x9dsed);
		Llvm_libc_20_1_2_BigInt_x9dsed llvm_libc_20_1_2_BigInt_x9dsed5 = default(Llvm_libc_20_1_2_BigInt_x9dsed);
		sbyte b = 0;
		Llvm_libc_20_1_2_BigInt_x9dsed llvm_libc_20_1_2_BigInt_x9dsed6 = default(Llvm_libc_20_1_2_BigInt_x9dsed);
		Llvm_libc_20_1_2_BigInt_x9dsed llvm_libc_20_1_2_BigInt_x9dsed7 = default(Llvm_libc_20_1_2_BigInt_x9dsed);
		unchecked
		{
			bool result;
			if (Shift_length >= 256)
			{
				Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_BigInt_x9dsed);
				BigInt_256ul_false_unsigned_long_BigInt_int_void.Invoke(&llvm_libc_20_1_2_BigInt_x9dsed, 0);
				Llvm_memcpy_p0_p0_i64.Invoke(Mant, &llvm_libc_20_1_2_BigInt_x9dsed, 32L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_BigInt_x9dsed);
				result = true;
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_BigInt_x9dsed2);
				sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_BigInt_x9dsed2);
				*(long*)ptr = -6148914691236517206L;
				((long*)ptr)[1] = -6148914691236517206L;
				((long*)ptr)[2] = -6148914691236517206L;
				((long*)ptr)[3] = -6148914691236517206L;
				Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_BigInt_x9dsed3);
				Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_BigInt_x9dsed4);
				BigInt_256ul_false_unsigned_long_BigInt_int_void.Invoke(&llvm_libc_20_1_2_BigInt_x9dsed4, 1);
				BigInt_256ul_false_unsigned_long_LeftShift.Invoke(&llvm_libc_20_1_2_BigInt_x9dsed3, &llvm_libc_20_1_2_BigInt_x9dsed4, Shift_length);
				Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_BigInt_x9dsed5);
				BigInt_256ul_false_unsigned_long_BigInt_int_void.Invoke(&llvm_libc_20_1_2_BigInt_x9dsed5, 1);
				BigInt_256ul_false_unsigned_long_Subtract_nar9qw.Invoke(&llvm_libc_20_1_2_BigInt_x9dsed2, &llvm_libc_20_1_2_BigInt_x9dsed3, &llvm_libc_20_1_2_BigInt_x9dsed5);
				Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_BigInt_x9dsed5);
				Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_BigInt_x9dsed4);
				Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_BigInt_x9dsed3);
				Llvm_lifetime_start_p0.Invoke(1L, &b);
				Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_BigInt_x9dsed6);
				Llvm_libc_20_1_2_BitwiseAnd.Invoke(&llvm_libc_20_1_2_BigInt_x9dsed6, Mant, &llvm_libc_20_1_2_BigInt_x9dsed2);
				Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_BigInt_x9dsed7);
				BigInt_256ul_false_unsigned_long_BigInt_int_void.Invoke(&llvm_libc_20_1_2_BigInt_x9dsed7, 0);
				bool num = Llvm_libc_20_1_2_NotEquals_j3a3qv.Invoke(&llvm_libc_20_1_2_BigInt_x9dsed6, &llvm_libc_20_1_2_BigInt_x9dsed7);
				Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_BigInt_x9dsed7);
				Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_BigInt_x9dsed6);
				b = (num ? ((sbyte)1) : ((sbyte)0));
				BigInt_256ul_false_unsigned_long_Operator_i2c6iz.Invoke(Mant, Shift_length);
				result = (b & 1) == 1;
				Llvm_lifetime_end_p0.Invoke(1L, &b);
				Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_BigInt_x9dsed2);
			}
			return result;
		}
	}
}

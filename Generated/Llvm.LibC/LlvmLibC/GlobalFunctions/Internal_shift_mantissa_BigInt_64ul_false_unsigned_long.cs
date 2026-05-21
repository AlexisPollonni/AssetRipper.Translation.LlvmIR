using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_shift_mantissa_BigInt_64ul_false_unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic8internal14shift_mantissaINS_6BigIntILm64ELb0EmEEEENS_3cpp9enable_ifIX33is_unsigned_integral_or_big_int_vIT_EEbE4typeEiRS8_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<is_unsigned_integral_or_big_int_v<__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>>, bool>::type __llvm_libc_20_1_2_::fputil::generic::internal::shift_mantissa<__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>>(int, __llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<is_unsigned_integral_or_big_int_v<__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>>, bool>::type")]
	public unsafe static bool Invoke([MangledName("shift_length")][NativeType("int")] int Shift_length, [MangledName("mant")][NativeType("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>&")] Llvm_libc_20_1_2_BigInt_555ggs* Mant)
	{
		Llvm_libc_20_1_2_BigInt_555ggs llvm_libc_20_1_2_BigInt_555ggs = default(Llvm_libc_20_1_2_BigInt_555ggs);
		Llvm_libc_20_1_2_BigInt_555ggs llvm_libc_20_1_2_BigInt_555ggs2 = default(Llvm_libc_20_1_2_BigInt_555ggs);
		Llvm_libc_20_1_2_BigInt_555ggs llvm_libc_20_1_2_BigInt_555ggs3 = default(Llvm_libc_20_1_2_BigInt_555ggs);
		Llvm_libc_20_1_2_BigInt_555ggs llvm_libc_20_1_2_BigInt_555ggs4 = default(Llvm_libc_20_1_2_BigInt_555ggs);
		Llvm_libc_20_1_2_BigInt_555ggs llvm_libc_20_1_2_BigInt_555ggs5 = default(Llvm_libc_20_1_2_BigInt_555ggs);
		sbyte b = 0;
		Llvm_libc_20_1_2_BigInt_555ggs llvm_libc_20_1_2_BigInt_555ggs6 = default(Llvm_libc_20_1_2_BigInt_555ggs);
		Llvm_libc_20_1_2_BigInt_555ggs llvm_libc_20_1_2_BigInt_555ggs7 = default(Llvm_libc_20_1_2_BigInt_555ggs);
		unchecked
		{
			bool result;
			if (Shift_length >= 64)
			{
				Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs);
				BigInt_64ul_false_unsigned_long_BigInt_int_void.Invoke(&llvm_libc_20_1_2_BigInt_555ggs, 0);
				Llvm_memcpy_p0_p0_i64.Invoke(Mant, &llvm_libc_20_1_2_BigInt_555ggs, 8L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs);
				result = true;
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs2);
				*(long*)(&llvm_libc_20_1_2_BigInt_555ggs2) = -6148914691236517206L;
				Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs3);
				Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs4);
				BigInt_64ul_false_unsigned_long_BigInt_int_void.Invoke(&llvm_libc_20_1_2_BigInt_555ggs4, 1);
				long data = BigInt_64ul_false_unsigned_long_LeftShift.Invoke(&llvm_libc_20_1_2_BigInt_555ggs4, Shift_length);
				*(long*)(&llvm_libc_20_1_2_BigInt_555ggs3.Val.Data) = data;
				Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs5);
				BigInt_64ul_false_unsigned_long_BigInt_int_void.Invoke(&llvm_libc_20_1_2_BigInt_555ggs5, 1);
				long data2 = BigInt_64ul_false_unsigned_long_Subtract_dhppwb.Invoke(&llvm_libc_20_1_2_BigInt_555ggs3, &llvm_libc_20_1_2_BigInt_555ggs5);
				*(long*)(&llvm_libc_20_1_2_BigInt_555ggs2.Val.Data) = data2;
				Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs5);
				Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs4);
				Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs3);
				Llvm_lifetime_start_p0.Invoke(1L, &b);
				Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs6);
				long data3 = Llvm_libc_20_1_2_BitwiseAnd.Invoke(Mant, &llvm_libc_20_1_2_BigInt_555ggs2);
				*(long*)(&llvm_libc_20_1_2_BigInt_555ggs6.Val.Data) = data3;
				Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs7);
				BigInt_64ul_false_unsigned_long_BigInt_int_void.Invoke(&llvm_libc_20_1_2_BigInt_555ggs7, 0);
				bool num = Llvm_libc_20_1_2_NotEquals_b94f9b.Invoke(&llvm_libc_20_1_2_BigInt_555ggs6, &llvm_libc_20_1_2_BigInt_555ggs7);
				Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs7);
				Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs6);
				b = (num ? ((sbyte)1) : ((sbyte)0));
				BigInt_64ul_false_unsigned_long_Operator_4fggky.Invoke(Mant, Shift_length);
				result = (b & 1) == 1;
				Llvm_lifetime_end_p0.Invoke(1L, &b);
				Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs2);
			}
			return result;
		}
	}
}

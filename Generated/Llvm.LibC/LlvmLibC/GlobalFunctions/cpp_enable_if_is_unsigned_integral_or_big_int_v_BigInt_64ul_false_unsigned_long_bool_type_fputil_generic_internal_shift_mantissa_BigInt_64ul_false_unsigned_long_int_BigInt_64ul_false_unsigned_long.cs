using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic8internal14shift_mantissaINS_6BigIntILm64ELb0EmEEEENS_3cpp9enable_ifIX33is_unsigned_integral_or_big_int_vIT_EEbE4typeEiRS8_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<is_unsigned_integral_or_big_int_v<__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>>, bool>::type __llvm_libc_20_1_2_::fputil::generic::internal::shift_mantissa<__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>>(int, __llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>&)")]
internal static partial class cpp_enable_if_is_unsigned_integral_or_big_int_v_BigInt_64ul_false_unsigned_long_bool_type_fputil_generic_internal_shift_mantissa_BigInt_64ul_false_unsigned_long_int_BigInt_64ul_false_unsigned_long
{
	public unsafe static bool Invoke(int shift_length, BigInt_555ggs* mant)
	{
		BigInt_555ggs bigInt_555ggs = default(BigInt_555ggs);
		BigInt_555ggs bigInt_555ggs2 = default(BigInt_555ggs);
		BigInt_555ggs bigInt_555ggs3 = default(BigInt_555ggs);
		BigInt_555ggs bigInt_555ggs4 = default(BigInt_555ggs);
		BigInt_555ggs bigInt_555ggs5 = default(BigInt_555ggs);
		sbyte b = 0;
		BigInt_555ggs bigInt_555ggs6 = default(BigInt_555ggs);
		BigInt_555ggs bigInt_555ggs7 = default(BigInt_555ggs);
		unchecked
		{
			bool result;
			if (shift_length >= 64)
			{
				llvm_lifetime_start_p0.Invoke(8L, &bigInt_555ggs);
				BigInt_64ul_false_unsigned_long_BigInt_int_void_int.Invoke(&bigInt_555ggs, 0);
				llvm_memcpy_p0_p0_i64.Invoke(mant, &bigInt_555ggs, 8L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(8L, &bigInt_555ggs);
				result = true;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(8L, &bigInt_555ggs2);
				*(long*)(&bigInt_555ggs2) = -6148914691236517206L;
				llvm_lifetime_start_p0.Invoke(8L, &bigInt_555ggs3);
				llvm_lifetime_start_p0.Invoke(8L, &bigInt_555ggs4);
				BigInt_64ul_false_unsigned_long_BigInt_int_void_int.Invoke(&bigInt_555ggs4, 1);
				long data = BigInt_64ul_false_unsigned_long_operator_unsigned_long_const_vswmz5.Invoke(&bigInt_555ggs4, shift_length);
				*(long*)(&bigInt_555ggs3.val.Data) = data;
				llvm_lifetime_start_p0.Invoke(8L, &bigInt_555ggs5);
				BigInt_64ul_false_unsigned_long_BigInt_int_void_int.Invoke(&bigInt_555ggs5, 1);
				long data2 = BigInt_64ul_false_unsigned_long_operator_BigInt_64ul_false_unsigned_long_const_dhppwb.Invoke(&bigInt_555ggs3, &bigInt_555ggs5);
				*(long*)(&bigInt_555ggs2.val.Data) = data2;
				llvm_lifetime_end_p0.Invoke(8L, &bigInt_555ggs5);
				llvm_lifetime_end_p0.Invoke(8L, &bigInt_555ggs4);
				llvm_lifetime_end_p0.Invoke(8L, &bigInt_555ggs3);
				llvm_lifetime_start_p0.Invoke(1L, &b);
				llvm_lifetime_start_p0.Invoke(8L, &bigInt_555ggs6);
				long data3 = operator_BigInt_64ul_false_unsigned_long_const_BigInt_64ul_false_unsigned_long_const_ufy43f.Invoke(mant, &bigInt_555ggs2);
				*(long*)(&bigInt_555ggs6.val.Data) = data3;
				llvm_lifetime_start_p0.Invoke(8L, &bigInt_555ggs7);
				BigInt_64ul_false_unsigned_long_BigInt_int_void_int.Invoke(&bigInt_555ggs7, 0);
				bool num = operator_BigInt_64ul_false_unsigned_long_const_BigInt_64ul_false_unsigned_long_const_sx97vk.Invoke(&bigInt_555ggs6, &bigInt_555ggs7);
				llvm_lifetime_end_p0.Invoke(8L, &bigInt_555ggs7);
				llvm_lifetime_end_p0.Invoke(8L, &bigInt_555ggs6);
				b = (num ? ((sbyte)1) : ((sbyte)0));
				BigInt_64ul_false_unsigned_long_operator_unsigned_long_d49ii6.Invoke(mant, shift_length);
				result = (b & 1) == 1;
				llvm_lifetime_end_p0.Invoke(1L, &b);
				llvm_lifetime_end_p0.Invoke(8L, &bigInt_555ggs2);
			}
			return result;
		}
	}
}

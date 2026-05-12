using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic8internal14shift_mantissaINS_6BigIntILm128ELb0EmEEEENS_3cpp9enable_ifIX33is_unsigned_integral_or_big_int_vIT_EEbE4typeEiRS8_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<is_unsigned_integral_or_big_int_v<__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>>, bool>::type __llvm_libc_20_1_2_::fputil::generic::internal::shift_mantissa<__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>>(int, __llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>&)")]
internal static partial class cpp_enable_if_is_unsigned_integral_or_big_int_v_BigInt_128ul_false_unsigned_long_bool_type_fputil_generic_internal_shift_mantissa_BigInt_128ul_false_unsigned_long_int_BigInt_128ul_false_unsigned_long
{
	public unsafe static bool Invoke(int shift_length, anon_izyfb7* mant)
	{
		BigInt_qdkjbh bigInt_qdkjbh = default(BigInt_qdkjbh);
		BigInt_qdkjbh bigInt_qdkjbh2 = default(BigInt_qdkjbh);
		BigInt_qdkjbh bigInt_qdkjbh3 = default(BigInt_qdkjbh);
		BigInt_qdkjbh bigInt_qdkjbh4 = default(BigInt_qdkjbh);
		BigInt_qdkjbh bigInt_qdkjbh5 = default(BigInt_qdkjbh);
		sbyte b = 0;
		BigInt_qdkjbh bigInt_qdkjbh6 = default(BigInt_qdkjbh);
		BigInt_qdkjbh bigInt_qdkjbh7 = default(BigInt_qdkjbh);
		unchecked
		{
			bool result;
			if (shift_length >= 128)
			{
				llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh);
				BigInt_128ul_false_unsigned_long_BigInt_int_void_int.Invoke((anon_izyfb7*)(&bigInt_qdkjbh), 0);
				llvm_memcpy_p0_p0_i64.Invoke(mant, &bigInt_qdkjbh, 16L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh);
				result = true;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh2);
				sbyte* ptr = (sbyte*)(&bigInt_qdkjbh2);
				*(long*)ptr = -6148914691236517206L;
				((long*)ptr)[1] = -6148914691236517206L;
				llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh3);
				llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh4);
				BigInt_128ul_false_unsigned_long_BigInt_int_void_int.Invoke((anon_izyfb7*)(&bigInt_qdkjbh4), 1);
				Struct_fiz2nb struct_fiz2nb = BigInt_128ul_false_unsigned_long_operator_unsigned_long_const_dnm495.Invoke((anon_izyfb7*)(&bigInt_qdkjbh4), shift_length);
				InlineArray2_Int64* ptr2 = &bigInt_qdkjbh3.val.Data;
				Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
				((Struct_fiz2nb*)ptr2)->field_0 = struct_fiz2nb2.field_0;
				Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
				((Struct_fiz2nb*)ptr2)->field_1 = struct_fiz2nb3.field_1;
				llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh5);
				BigInt_128ul_false_unsigned_long_BigInt_int_void_int.Invoke((anon_izyfb7*)(&bigInt_qdkjbh5), 1);
				Struct_fiz2nb struct_fiz2nb4 = BigInt_128ul_false_unsigned_long_operator_BigInt_128ul_false_unsigned_long_const_gydwfz.Invoke((anon_izyfb7*)(&bigInt_qdkjbh3), (anon_izyfb7*)(&bigInt_qdkjbh5));
				InlineArray2_Int64* ptr3 = &bigInt_qdkjbh2.val.Data;
				Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
				((Struct_fiz2nb*)ptr3)->field_0 = struct_fiz2nb5.field_0;
				Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
				((Struct_fiz2nb*)ptr3)->field_1 = struct_fiz2nb6.field_1;
				llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh5);
				llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh4);
				llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh3);
				llvm_lifetime_start_p0.Invoke(1L, &b);
				llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh6);
				Struct_fiz2nb struct_fiz2nb7 = operator_BigInt_128ul_false_unsigned_long_const_BigInt_128ul_false_unsigned_long_const_bs7s6m.Invoke(mant, (anon_izyfb7*)(&bigInt_qdkjbh2));
				InlineArray2_Int64* ptr4 = &bigInt_qdkjbh6.val.Data;
				Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
				((Struct_fiz2nb*)ptr4)->field_0 = struct_fiz2nb8.field_0;
				Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
				((Struct_fiz2nb*)ptr4)->field_1 = struct_fiz2nb9.field_1;
				llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh7);
				BigInt_128ul_false_unsigned_long_BigInt_int_void_int.Invoke((anon_izyfb7*)(&bigInt_qdkjbh7), 0);
				bool num = operator_BigInt_128ul_false_unsigned_long_const_BigInt_128ul_false_unsigned_long_const_menjpd.Invoke((anon_izyfb7*)(&bigInt_qdkjbh6), (anon_izyfb7*)(&bigInt_qdkjbh7));
				llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh7);
				llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh6);
				b = (num ? ((sbyte)1) : ((sbyte)0));
				BigInt_128ul_false_unsigned_long_operator_unsigned_long_94ezwu.Invoke(mant, shift_length);
				result = (b & 1) == 1;
				llvm_lifetime_end_p0.Invoke(1L, &b);
				llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh2);
			}
			return result;
		}
	}
}

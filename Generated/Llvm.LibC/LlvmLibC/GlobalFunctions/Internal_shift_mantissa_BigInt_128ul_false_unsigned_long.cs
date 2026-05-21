using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_shift_mantissa_BigInt_128ul_false_unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic8internal14shift_mantissaINS_6BigIntILm128ELb0EmEEEENS_3cpp9enable_ifIX33is_unsigned_integral_or_big_int_vIT_EEbE4typeEiRS8_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<is_unsigned_integral_or_big_int_v<__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>>, bool>::type __llvm_libc_20_1_2_::fputil::generic::internal::shift_mantissa<__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>>(int, __llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<is_unsigned_integral_or_big_int_v<__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>>, bool>::type")]
	public unsafe static bool Invoke([MangledName("shift_length")][NativeType("int")] int Shift_length, [MangledName("mant")][NativeType("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>&")] Anon_izyfb7* Mant)
	{
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh2 = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh3 = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh4 = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh5 = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
		sbyte b = 0;
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh6 = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh7 = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
		unchecked
		{
			bool result;
			if (Shift_length >= 128)
			{
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh);
				BigInt_128ul_false_unsigned_long_BigInt_int_void.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh), 0);
				Llvm_memcpy_p0_p0_i64.Invoke(Mant, &llvm_libc_20_1_2_BigInt_qdkjbh, 16L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh);
				result = true;
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh2);
				sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_BigInt_qdkjbh2);
				*(long*)ptr = -6148914691236517206L;
				((long*)ptr)[1] = -6148914691236517206L;
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh3);
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh4);
				BigInt_128ul_false_unsigned_long_BigInt_int_void.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh4), 1);
				Struct_fiz2nb struct_fiz2nb = BigInt_128ul_false_unsigned_long_LeftShift.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh4), Shift_length);
				InlineArray2_Int64* ptr2 = &llvm_libc_20_1_2_BigInt_qdkjbh3.Val.Data;
				Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
				((Struct_fiz2nb*)ptr2)->field_0 = struct_fiz2nb2.field_0;
				Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
				((Struct_fiz2nb*)ptr2)->field_1 = struct_fiz2nb3.field_1;
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh5);
				BigInt_128ul_false_unsigned_long_BigInt_int_void.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh5), 1);
				Struct_fiz2nb struct_fiz2nb4 = BigInt_128ul_false_unsigned_long_Subtract_gydwfz.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh3), (Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh5));
				InlineArray2_Int64* ptr3 = &llvm_libc_20_1_2_BigInt_qdkjbh2.Val.Data;
				Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
				((Struct_fiz2nb*)ptr3)->field_0 = struct_fiz2nb5.field_0;
				Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
				((Struct_fiz2nb*)ptr3)->field_1 = struct_fiz2nb6.field_1;
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh5);
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh4);
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh3);
				Llvm_lifetime_start_p0.Invoke(1L, &b);
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh6);
				Struct_fiz2nb struct_fiz2nb7 = Llvm_libc_20_1_2_BitwiseAnd.Invoke(Mant, (Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh2));
				InlineArray2_Int64* ptr4 = &llvm_libc_20_1_2_BigInt_qdkjbh6.Val.Data;
				Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
				((Struct_fiz2nb*)ptr4)->field_0 = struct_fiz2nb8.field_0;
				Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
				((Struct_fiz2nb*)ptr4)->field_1 = struct_fiz2nb9.field_1;
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh7);
				BigInt_128ul_false_unsigned_long_BigInt_int_void.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh7), 0);
				bool num = Llvm_libc_20_1_2_NotEquals_tuz86b.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh6), (Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh7));
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh7);
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh6);
				b = (num ? ((sbyte)1) : ((sbyte)0));
				BigInt_128ul_false_unsigned_long_Operator_srrb86.Invoke(Mant, Shift_length);
				result = (b & 1) == 1;
				Llvm_lifetime_end_p0.Invoke(1L, &b);
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh2);
			}
			return result;
		}
	}
}

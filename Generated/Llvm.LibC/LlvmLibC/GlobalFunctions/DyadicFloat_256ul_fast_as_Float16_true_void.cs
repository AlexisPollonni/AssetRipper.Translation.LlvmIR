using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class DyadicFloat_256ul_fast_as_Float16_true_void
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11DyadicFloatILm256EE7fast_asIDF16_Lb1EvEET_v")]
	[DemangledName("_Float16 __llvm_libc_20_1_2_::fputil::DyadicFloat<256ul>::fast_as<_Float16, true, void>() const")]
	[return: NativeType("_Float16")]
	public unsafe static Half Invoke(fputil_DyadicFloat_jhcpjj* @this)
	{
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		int num = 0;
		short num2 = 0;
		int num3 = 0;
		Half half = default(Half);
		fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		Half half2 = default(Half);
		Half half3 = default(Half);
		fputil_FPBits_2fahva fputil_FPBits_2fahva4 = default(fputil_FPBits_2fahva);
		sbyte b = 0;
		int num4 = 0;
		int num5 = 0;
		BigInt_x9dsed bigInt_x9dsed = default(BigInt_x9dsed);
		Half half4 = default(Half);
		fputil_FPBits_2fahva fputil_FPBits_2fahva5 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		BigInt_x9dsed bigInt_x9dsed2 = default(BigInt_x9dsed);
		BigInt_x9dsed bigInt_x9dsed3 = default(BigInt_x9dsed);
		BigInt_x9dsed bigInt_x9dsed4 = default(BigInt_x9dsed);
		BigInt_x9dsed bigInt_x9dsed5 = default(BigInt_x9dsed);
		sbyte b2 = 0;
		BigInt_x9dsed bigInt_x9dsed6 = default(BigInt_x9dsed);
		sbyte b3 = 0;
		BigInt_x9dsed bigInt_x9dsed7 = default(BigInt_x9dsed);
		int num6 = 0;
		Half x = default(Half);
		int num7 = 0;
		Half half5 = default(Half);
		fputil_FPBits_2fahva fputil_FPBits_2fahva6 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		Half half6 = default(Half);
		fputil_FPBits_2fahva fputil_FPBits_2fahva7 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb12 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva8 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb13 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva9 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb14 = default(anon_izyfb7);
		Half half7 = default(Half);
		short num8 = 0;
		short num9 = 0;
		fputil_FPBits_2fahva fputil_FPBits_2fahva10 = default(fputil_FPBits_2fahva);
		fputil_FPBits_2fahva fputil_FPBits_2fahva11 = default(fputil_FPBits_2fahva);
		Half result;
		if (details_expects_bool_condition_bool.Invoke(BigInt_256ul_false_unsigned_long_is_zero.Invoke(&@this->mantissa), expected: false))
		{
			llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, &@this->sign, 1L, isVolatile: false);
			short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_zero.Invoke(anon_izyfb8.val);
			fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
			result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva2);
			llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		}
		else
		{
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = 11;
			llvm_lifetime_start_p0.Invoke(2L, &num2);
			num2 = 0;
			llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = @this->exponent + 270;
			unchecked
			{
				if (details_expects_bool_condition_bool.Invoke(num3 > 30, expected: false))
				{
					llvm_lifetime_start_p0.Invoke(2L, &half);
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, &@this->sign, 1L, isVolatile: false);
					short field_2 = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_create_value.Invoke(anon_izyfb9.val, 30, 0);
					fputil_FPBits_2fahva3.FPRepImpl.FPRepSem.FPStorage.field_0 = field_2;
					Half half8 = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva3);
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
					half = half8;
					llvm_lifetime_start_p0.Invoke(2L, &half2);
					half2 = default(Half);
					llvm_lifetime_start_p0.Invoke(2L, &half3);
					half3 = (Half)((float)half2 * (float)half);
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva4);
					FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva4, half3);
					bool num10 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_inf.Invoke((fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva4));
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva4);
					if (num10)
					{
						fputil_set_errno_if_required.Invoke(34);
					}
					result = half3;
					llvm_lifetime_end_p0.Invoke(2L, &half3);
					llvm_lifetime_end_p0.Invoke(2L, &half2);
					llvm_lifetime_end_p0.Invoke(2L, &half);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(1L, &b);
					b = 0;
					llvm_lifetime_start_p0.Invoke(4L, &num4);
					num4 = 245;
					if (details_expects_bool_condition_bool.Invoke(num3 <= 0, expected: false))
					{
						b = 1;
						num4 = (int)(245L + (long)(uint)checked(1 - num3));
						num3 = 15;
					}
					llvm_lifetime_start_p0.Invoke(4L, &num5);
					num5 = checked(num3 - 11 - 1);
					llvm_lifetime_start_p0.Invoke(32L, &bigInt_x9dsed);
					sbyte* ptr = (sbyte*)(&bigInt_x9dsed);
					*(long*)ptr = -6148914691236517206L;
					((long*)ptr)[1] = -6148914691236517206L;
					((long*)ptr)[2] = -6148914691236517206L;
					((long*)ptr)[3] = -6148914691236517206L;
					if ((ulong)(uint)num4 >= 256uL)
					{
						BigInt_256ul_false_unsigned_long_BigInt_int_void.Invoke(&bigInt_x9dsed, 0);
					}
					else
					{
						BigInt_256ul_false_unsigned_long_RightShift.Invoke(&bigInt_x9dsed, &@this->mantissa, (uint)num4);
					}
					llvm_lifetime_start_p0.Invoke(2L, &half4);
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva5);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, &@this->sign, 1L, isVolatile: false);
					short field_3 = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_create_value.Invoke(biased_exp: (short)num3, mantissa: (short)(((ushort)BigInt_256ul_false_unsigned_long_unsigned_short_unsigned_short.Invoke(&bigInt_x9dsed) & 0x3FF) | 0), sign: anon_izyfb10.val);
					fputil_FPBits_2fahva5.FPRepImpl.FPRepSem.FPStorage.field_0 = field_3;
					Half half9 = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva5);
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva5);
					half4 = half9;
					llvm_lifetime_start_p0.Invoke(32L, &bigInt_x9dsed2);
					sbyte* ptr2 = (sbyte*)(&bigInt_x9dsed2);
					*(long*)ptr2 = -6148914691236517206L;
					((long*)ptr2)[1] = -6148914691236517206L;
					((long*)ptr2)[2] = -6148914691236517206L;
					((long*)ptr2)[3] = -6148914691236517206L;
					bool num11 = (ulong)(uint)num4 > 256uL;
					llvm_lifetime_start_p0.Invoke(32L, &bigInt_x9dsed3);
					if (num11)
					{
						BigInt_256ul_false_unsigned_long_BigInt_int_void.Invoke(&bigInt_x9dsed2, 0);
					}
					else
					{
						BigInt_256ul_false_unsigned_long_BigInt_int_void.Invoke(&bigInt_x9dsed3, 1);
						BigInt_256ul_false_unsigned_long_LeftShift.Invoke(&bigInt_x9dsed2, &bigInt_x9dsed3, (uint)(num4 - 1));
					}
					llvm_lifetime_end_p0.Invoke(32L, &bigInt_x9dsed3);
					llvm_lifetime_start_p0.Invoke(32L, &bigInt_x9dsed4);
					sbyte* ptr3 = (sbyte*)(&bigInt_x9dsed4);
					*(long*)ptr3 = -6148914691236517206L;
					((long*)ptr3)[1] = -6148914691236517206L;
					((long*)ptr3)[2] = -6148914691236517206L;
					((long*)ptr3)[3] = -6148914691236517206L;
					llvm_lifetime_start_p0.Invoke(32L, &bigInt_x9dsed5);
					BigInt_256ul_false_unsigned_long_BigInt_int_void.Invoke(&bigInt_x9dsed5, 1);
					BigInt_256ul_false_unsigned_long_Subtract_nar9qw.Invoke(&bigInt_x9dsed4, &bigInt_x9dsed2, &bigInt_x9dsed5);
					llvm_lifetime_end_p0.Invoke(32L, &bigInt_x9dsed5);
					llvm_lifetime_start_p0.Invoke(1L, &b2);
					llvm_lifetime_start_p0.Invoke(32L, &bigInt_x9dsed6);
					BitwiseAnd.Invoke(&bigInt_x9dsed6, &@this->mantissa, &bigInt_x9dsed2);
					int num12 = (BigInt_256ul_false_unsigned_long_is_zero.Invoke(&bigInt_x9dsed6) ? 1 : 0) ^ -1;
					llvm_lifetime_end_p0.Invoke(32L, &bigInt_x9dsed6);
					b2 = (sbyte)(byte)num12;
					llvm_lifetime_start_p0.Invoke(1L, &b3);
					llvm_lifetime_start_p0.Invoke(32L, &bigInt_x9dsed7);
					BitwiseAnd.Invoke(&bigInt_x9dsed7, &@this->mantissa, &bigInt_x9dsed4);
					int num13 = (BigInt_256ul_false_unsigned_long_is_zero.Invoke(&bigInt_x9dsed7) ? 1 : 0) ^ -1;
					llvm_lifetime_end_p0.Invoke(32L, &bigInt_x9dsed7);
					b3 = (sbyte)(byte)num13;
					llvm_lifetime_start_p0.Invoke(4L, &num6);
					num6 = checked((((b2 & 1) == 1) ? 1 : 0) * 2 + (((b3 & 1) == 1) ? 1 : 0));
					llvm_lifetime_start_p0.Invoke(2L, &x);
					x = default(Half);
					if (details_expects_bool_condition_bool.Invoke(num5 <= 0, expected: false))
					{
						llvm_lifetime_start_p0.Invoke(4L, &num7);
						num7 = checked(1 - num5);
						llvm_lifetime_start_p0.Invoke(2L, &half5);
						llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva6);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, Sign_POS.Pointer, 1L, isVolatile: false);
						short field_4 = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_create_value.Invoke(biased_exp: (short)checked(15 + num7), sign: anon_izyfb11.val, mantissa: 0);
						fputil_FPBits_2fahva6.FPRepImpl.FPRepSem.FPStorage.field_0 = field_4;
						Half half10 = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva6);
						llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva6);
						half5 = half10;
						llvm_lifetime_start_p0.Invoke(2L, &half6);
						llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva7);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb12, Sign_POS.Pointer, 1L, isVolatile: false);
						short field_5 = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_create_value.Invoke(biased_exp: (short)checked(15 - num7), sign: anon_izyfb12.val, mantissa: 0);
						fputil_FPBits_2fahva7.FPRepImpl.FPRepSem.FPStorage.field_0 = field_5;
						Half half11 = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva7);
						llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva7);
						half6 = half11;
						llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva8);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, &@this->sign, 1L, isVolatile: false);
						short field_6 = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_create_value.Invoke(biased_exp: (short)checked(num5 + num7), sign: anon_izyfb13.val, mantissa: 0);
						fputil_FPBits_2fahva8.FPRepImpl.FPRepSem.FPStorage.field_0 = field_6;
						x = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva8);
						llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva8);
						result = (Half)((float)fputil_multiply_add_Float16.Invoke(x, (Half)num6, (Half)((float)half4 * (float)half5)) * (float)half6);
						llvm_lifetime_end_p0.Invoke(2L, &half6);
						llvm_lifetime_end_p0.Invoke(2L, &half5);
						llvm_lifetime_end_p0.Invoke(4L, &num7);
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva9);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb14, &@this->sign, 1L, isVolatile: false);
						short field_7 = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_create_value.Invoke(biased_exp: (short)num5, sign: anon_izyfb14.val, mantissa: 0);
						fputil_FPBits_2fahva9.FPRepImpl.FPRepSem.FPStorage.field_0 = field_7;
						x = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva9);
						llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva9);
						llvm_lifetime_start_p0.Invoke(2L, &half7);
						half7 = fputil_multiply_add_Float16.Invoke(x, (Half)num6, half4);
						if (details_expects_bool_condition_bool.Invoke((b & 1) == 1, expected: false))
						{
							llvm_lifetime_start_p0.Invoke(2L, &num8);
							num8 = (short)((ushort)(short)num3 << 10);
							llvm_lifetime_start_p0.Invoke(2L, &num9);
							llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva10);
							FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva10, half7);
							short num14 = (short)checked(unchecked((ushort)FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva10))) - unchecked((ushort)num8));
							llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva10);
							num9 = num14;
							if (((ushort)num9 & 0x7C00) == 0)
							{
								num9 = (short)checked(unchecked((ushort)num9) - 0);
								if (num6 != 0)
								{
									fputil_set_errno_if_required.Invoke(34);
									fputil_raise_except_if_required.Invoke(16);
								}
							}
							llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva11);
							FPBits_Float16_FPBits_unsigned_short.Invoke(&fputil_FPBits_2fahva11, num9);
							result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva11);
							llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva11);
							llvm_lifetime_end_p0.Invoke(2L, &num9);
							llvm_lifetime_end_p0.Invoke(2L, &num8);
						}
						else
						{
							result = half7;
						}
						llvm_lifetime_end_p0.Invoke(2L, &half7);
					}
					llvm_lifetime_end_p0.Invoke(2L, &x);
					llvm_lifetime_end_p0.Invoke(4L, &num6);
					llvm_lifetime_end_p0.Invoke(1L, &b3);
					llvm_lifetime_end_p0.Invoke(1L, &b2);
					llvm_lifetime_end_p0.Invoke(32L, &bigInt_x9dsed4);
					llvm_lifetime_end_p0.Invoke(32L, &bigInt_x9dsed2);
					llvm_lifetime_end_p0.Invoke(2L, &half4);
					llvm_lifetime_end_p0.Invoke(32L, &bigInt_x9dsed);
					llvm_lifetime_end_p0.Invoke(4L, &num5);
					llvm_lifetime_end_p0.Invoke(4L, &num4);
					llvm_lifetime_end_p0.Invoke(1L, &b);
				}
				llvm_lifetime_end_p0.Invoke(4L, &num3);
				llvm_lifetime_end_p0.Invoke(2L, &num2);
				llvm_lifetime_end_p0.Invoke(4L, &num);
			}
		}
		return result;
	}
}

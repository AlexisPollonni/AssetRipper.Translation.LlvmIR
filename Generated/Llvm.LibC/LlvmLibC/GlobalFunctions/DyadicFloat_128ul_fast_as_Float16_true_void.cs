using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class DyadicFloat_128ul_fast_as_Float16_true_void
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11DyadicFloatILm128EE7fast_asIDF16_Lb1EvEET_v")]
	[DemangledName("_Float16 __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>::fast_as<_Float16, true, void>() const")]
	[return: NativeType("_Float16")]
	public unsafe static Half Invoke(fputil_DyadicFloat_kt2kd4* @this)
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
		BigInt_qdkjbh bigInt_qdkjbh = default(BigInt_qdkjbh);
		Half half4 = default(Half);
		fputil_FPBits_2fahva fputil_FPBits_2fahva5 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		BigInt_qdkjbh bigInt_qdkjbh2 = default(BigInt_qdkjbh);
		BigInt_qdkjbh bigInt_qdkjbh3 = default(BigInt_qdkjbh);
		BigInt_qdkjbh bigInt_qdkjbh4 = default(BigInt_qdkjbh);
		BigInt_qdkjbh bigInt_qdkjbh5 = default(BigInt_qdkjbh);
		sbyte b2 = 0;
		BigInt_qdkjbh bigInt_qdkjbh6 = default(BigInt_qdkjbh);
		sbyte b3 = 0;
		BigInt_qdkjbh bigInt_qdkjbh7 = default(BigInt_qdkjbh);
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
		unchecked
		{
			Half result;
			if (details_expects_bool_condition_bool.Invoke(BigInt_128ul_false_unsigned_long_is_zero.Invoke((anon_izyfb7*)(&@this->mantissa)), expected: false))
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
				num3 = checked(@this->exponent + 142);
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
					num4 = 117;
					if (details_expects_bool_condition_bool.Invoke(num3 <= 0, expected: false))
					{
						b = 1;
						num4 = (int)(117L + (long)(uint)checked(1 - num3));
						num3 = 15;
					}
					llvm_lifetime_start_p0.Invoke(4L, &num5);
					num5 = checked(num3 - 11 - 1);
					llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh);
					sbyte* ptr = (sbyte*)(&bigInt_qdkjbh);
					*(long*)ptr = -6148914691236517206L;
					((long*)ptr)[1] = -6148914691236517206L;
					if ((ulong)(uint)num4 >= 128uL)
					{
						BigInt_128ul_false_unsigned_long_BigInt_int_void.Invoke((anon_izyfb7*)(&bigInt_qdkjbh), 0);
					}
					else
					{
						Struct_fiz2nb struct_fiz2nb = BigInt_128ul_false_unsigned_long_RightShift.Invoke((anon_izyfb7*)(&@this->mantissa), (uint)num4);
						InlineArray2_Int64* ptr2 = &bigInt_qdkjbh.val.Data;
						Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
						((Struct_fiz2nb*)ptr2)->field_0 = struct_fiz2nb2.field_0;
						Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
						((Struct_fiz2nb*)ptr2)->field_1 = struct_fiz2nb3.field_1;
					}
					llvm_lifetime_start_p0.Invoke(2L, &half4);
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva5);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, &@this->sign, 1L, isVolatile: false);
					short field_3 = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_create_value.Invoke(biased_exp: (short)num3, mantissa: (short)(((ushort)BigInt_128ul_false_unsigned_long_unsigned_short_unsigned_short.Invoke((anon_izyfb7*)(&bigInt_qdkjbh)) & 0x3FF) | 0), sign: anon_izyfb10.val);
					fputil_FPBits_2fahva5.FPRepImpl.FPRepSem.FPStorage.field_0 = field_3;
					Half half9 = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva5);
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva5);
					half4 = half9;
					llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh2);
					sbyte* ptr3 = (sbyte*)(&bigInt_qdkjbh2);
					*(long*)ptr3 = -6148914691236517206L;
					((long*)ptr3)[1] = -6148914691236517206L;
					bool num11 = (ulong)(uint)num4 > 128uL;
					llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh3);
					if (num11)
					{
						BigInt_128ul_false_unsigned_long_BigInt_int_void.Invoke((anon_izyfb7*)(&bigInt_qdkjbh2), 0);
					}
					else
					{
						BigInt_128ul_false_unsigned_long_BigInt_int_void.Invoke((anon_izyfb7*)(&bigInt_qdkjbh3), 1);
						Struct_fiz2nb struct_fiz2nb4 = BigInt_128ul_false_unsigned_long_LeftShift.Invoke((anon_izyfb7*)(&bigInt_qdkjbh3), (uint)(num4 - 1));
						InlineArray2_Int64* ptr4 = &bigInt_qdkjbh2.val.Data;
						Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
						((Struct_fiz2nb*)ptr4)->field_0 = struct_fiz2nb5.field_0;
						Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
						((Struct_fiz2nb*)ptr4)->field_1 = struct_fiz2nb6.field_1;
					}
					llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh3);
					llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh4);
					sbyte* ptr5 = (sbyte*)(&bigInt_qdkjbh4);
					*(long*)ptr5 = -6148914691236517206L;
					((long*)ptr5)[1] = -6148914691236517206L;
					llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh5);
					BigInt_128ul_false_unsigned_long_BigInt_int_void.Invoke((anon_izyfb7*)(&bigInt_qdkjbh5), 1);
					Struct_fiz2nb struct_fiz2nb7 = BigInt_128ul_false_unsigned_long_Subtract_gydwfz.Invoke((anon_izyfb7*)(&bigInt_qdkjbh2), (anon_izyfb7*)(&bigInt_qdkjbh5));
					InlineArray2_Int64* ptr6 = &bigInt_qdkjbh4.val.Data;
					Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
					((Struct_fiz2nb*)ptr6)->field_0 = struct_fiz2nb8.field_0;
					Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
					((Struct_fiz2nb*)ptr6)->field_1 = struct_fiz2nb9.field_1;
					llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh5);
					llvm_lifetime_start_p0.Invoke(1L, &b2);
					llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh6);
					Struct_fiz2nb struct_fiz2nb10 = BitwiseAnd.Invoke((anon_izyfb7*)(&@this->mantissa), (anon_izyfb7*)(&bigInt_qdkjbh2));
					InlineArray2_Int64* ptr7 = &bigInt_qdkjbh6.val.Data;
					Struct_fiz2nb struct_fiz2nb11 = struct_fiz2nb10;
					((Struct_fiz2nb*)ptr7)->field_0 = struct_fiz2nb11.field_0;
					Struct_fiz2nb struct_fiz2nb12 = struct_fiz2nb10;
					((Struct_fiz2nb*)ptr7)->field_1 = struct_fiz2nb12.field_1;
					int num12 = (BigInt_128ul_false_unsigned_long_is_zero.Invoke((anon_izyfb7*)(&bigInt_qdkjbh6)) ? 1 : 0) ^ -1;
					llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh6);
					b2 = (sbyte)(byte)num12;
					llvm_lifetime_start_p0.Invoke(1L, &b3);
					llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh7);
					Struct_fiz2nb struct_fiz2nb13 = BitwiseAnd.Invoke((anon_izyfb7*)(&@this->mantissa), (anon_izyfb7*)(&bigInt_qdkjbh4));
					InlineArray2_Int64* ptr8 = &bigInt_qdkjbh7.val.Data;
					Struct_fiz2nb struct_fiz2nb14 = struct_fiz2nb13;
					((Struct_fiz2nb*)ptr8)->field_0 = struct_fiz2nb14.field_0;
					Struct_fiz2nb struct_fiz2nb15 = struct_fiz2nb13;
					((Struct_fiz2nb*)ptr8)->field_1 = struct_fiz2nb15.field_1;
					int num13 = (BigInt_128ul_false_unsigned_long_is_zero.Invoke((anon_izyfb7*)(&bigInt_qdkjbh7)) ? 1 : 0) ^ -1;
					llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh7);
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
					llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh4);
					llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh2);
					llvm_lifetime_end_p0.Invoke(2L, &half4);
					llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh);
					llvm_lifetime_end_p0.Invoke(4L, &num5);
					llvm_lifetime_end_p0.Invoke(4L, &num4);
					llvm_lifetime_end_p0.Invoke(1L, &b);
				}
				llvm_lifetime_end_p0.Invoke(4L, &num3);
				llvm_lifetime_end_p0.Invoke(2L, &num2);
				llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			return result;
		}
	}
}

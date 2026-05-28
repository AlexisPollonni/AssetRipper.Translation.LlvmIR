using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class DyadicFloat_128ul_fast_as_double_true_void
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11DyadicFloatILm128EE7fast_asIdLb1EvEET_v")]
	[DemangledName("double __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>::fast_as<double, true, void>() const")]
	[return: NativeType("double")]
	public unsafe static double Invoke([MangledName("this")] Fputil_DyadicFloat_kt2kd4* This)
	{
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		int num = 0;
		long num2 = 0L;
		int num3 = 0;
		double num4 = 0.0;
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		double num5 = 0.0;
		double num6 = 0.0;
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(Fputil_FPBits_wjhbrm);
		sbyte b = 0;
		int num7 = 0;
		int num8 = 0;
		BigInt_qdkjbh bigInt_qdkjbh = default(BigInt_qdkjbh);
		double num9 = 0.0;
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		BigInt_qdkjbh bigInt_qdkjbh2 = default(BigInt_qdkjbh);
		BigInt_qdkjbh bigInt_qdkjbh3 = default(BigInt_qdkjbh);
		BigInt_qdkjbh bigInt_qdkjbh4 = default(BigInt_qdkjbh);
		BigInt_qdkjbh bigInt_qdkjbh5 = default(BigInt_qdkjbh);
		sbyte b2 = 0;
		BigInt_qdkjbh bigInt_qdkjbh6 = default(BigInt_qdkjbh);
		sbyte b3 = 0;
		BigInt_qdkjbh bigInt_qdkjbh7 = default(BigInt_qdkjbh);
		int num10 = 0;
		double x = 0.0;
		int num11 = 0;
		double num12 = 0.0;
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm5 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		double num13 = 0.0;
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm6 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb5 = default(Anon_izyfb7);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm7 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb6 = default(Anon_izyfb7);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm8 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb7 = default(Anon_izyfb7);
		double num14 = 0.0;
		long num15 = 0L;
		long num16 = 0L;
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm9 = default(Fputil_FPBits_wjhbrm);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm10 = default(Fputil_FPBits_wjhbrm);
		unchecked
		{
			double result;
			if (Details_expects_bool_condition_bool.Invoke(BigInt_128ul_false_unsigned_long_is_zero.Invoke((Anon_izyfb7*)(&This->Mantissa)), Expected: false))
			{
				Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, &This->Sign, 1L, isVolatile: false);
				long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_zero.Invoke(anon_izyfb.Val);
				fputil_FPBits_wjhbrm.FPRepImpl.FPRepSem.FPStorage.Val = val;
				result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm);
				Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				num = 53;
				Llvm_lifetime_start_p0.Invoke(8L, &num2);
				num2 = 0L;
				Llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = checked(This->Exponent + 1150);
				if (Details_expects_bool_condition_bool.Invoke(num3 > 2046, Expected: false))
				{
					Llvm_lifetime_start_p0.Invoke(8L, &num4);
					Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, &This->Sign, 1L, isVolatile: false);
					long val2 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_create_value.Invoke(anon_izyfb2.Val, 2046L, 0L);
					fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.Val = val2;
					double num17 = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm2);
					Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
					num4 = num17;
					Llvm_lifetime_start_p0.Invoke(8L, &num5);
					num5 = 2.0;
					Llvm_lifetime_start_p0.Invoke(8L, &num6);
					num6 = num5 * num4;
					Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
					FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm3, num6);
					bool num18 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_inf.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm3));
					Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
					if (num18)
					{
						Fputil_set_errno_if_required.Invoke(34);
					}
					result = num6;
					Llvm_lifetime_end_p0.Invoke(8L, &num6);
					Llvm_lifetime_end_p0.Invoke(8L, &num5);
					Llvm_lifetime_end_p0.Invoke(8L, &num4);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(1L, &b);
					b = 0;
					Llvm_lifetime_start_p0.Invoke(4L, &num7);
					num7 = 75;
					if (Details_expects_bool_condition_bool.Invoke(num3 <= 0, Expected: false))
					{
						b = 1;
						num7 = (int)(75L + (long)(uint)checked(1 - num3));
						num3 = 1023;
					}
					Llvm_lifetime_start_p0.Invoke(4L, &num8);
					num8 = checked(num3 - 53 - 1);
					Llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh);
					sbyte* ptr = (sbyte*)(&bigInt_qdkjbh);
					*(long*)ptr = -6148914691236517206L;
					((long*)ptr)[1] = -6148914691236517206L;
					if ((ulong)(uint)num7 >= 128uL)
					{
						BigInt_128ul_false_unsigned_long_BigInt_int_void.Invoke((Anon_izyfb7*)(&bigInt_qdkjbh), 0);
					}
					else
					{
						Struct_fiz2nb struct_fiz2nb = BigInt_128ul_false_unsigned_long_RightShift.Invoke((Anon_izyfb7*)(&This->Mantissa), (uint)num7);
						InlineArray2_Int64* ptr2 = &bigInt_qdkjbh.Val.Data;
						Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
						((Struct_fiz2nb*)ptr2)->field_0 = struct_fiz2nb2.field_0;
						Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
						((Struct_fiz2nb*)ptr2)->field_1 = struct_fiz2nb3.field_1;
					}
					Llvm_lifetime_start_p0.Invoke(8L, &num9);
					Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb3, &This->Sign, 1L, isVolatile: false);
					long val3 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_create_value.Invoke(Biased_exp: num3, Mantissa: (BigInt_128ul_false_unsigned_long_Unsigned_long_unsigned_long.Invoke((Anon_izyfb7*)(&bigInt_qdkjbh)) & 0xFFFFFFFFFFFFFL) | 0L, Sign: anon_izyfb3.Val);
					fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.Val = val3;
					double num19 = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm4);
					Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
					num9 = num19;
					Llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh2);
					sbyte* ptr3 = (sbyte*)(&bigInt_qdkjbh2);
					*(long*)ptr3 = -6148914691236517206L;
					((long*)ptr3)[1] = -6148914691236517206L;
					bool num20 = (ulong)(uint)num7 > 128uL;
					Llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh3);
					if (num20)
					{
						BigInt_128ul_false_unsigned_long_BigInt_int_void.Invoke((Anon_izyfb7*)(&bigInt_qdkjbh2), 0);
					}
					else
					{
						BigInt_128ul_false_unsigned_long_BigInt_int_void.Invoke((Anon_izyfb7*)(&bigInt_qdkjbh3), 1);
						Struct_fiz2nb struct_fiz2nb4 = BigInt_128ul_false_unsigned_long_LeftShift.Invoke((Anon_izyfb7*)(&bigInt_qdkjbh3), (uint)(num7 - 1));
						InlineArray2_Int64* ptr4 = &bigInt_qdkjbh2.Val.Data;
						Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
						((Struct_fiz2nb*)ptr4)->field_0 = struct_fiz2nb5.field_0;
						Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
						((Struct_fiz2nb*)ptr4)->field_1 = struct_fiz2nb6.field_1;
					}
					Llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh3);
					Llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh4);
					sbyte* ptr5 = (sbyte*)(&bigInt_qdkjbh4);
					*(long*)ptr5 = -6148914691236517206L;
					((long*)ptr5)[1] = -6148914691236517206L;
					Llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh5);
					BigInt_128ul_false_unsigned_long_BigInt_int_void.Invoke((Anon_izyfb7*)(&bigInt_qdkjbh5), 1);
					Struct_fiz2nb struct_fiz2nb7 = BigInt_128ul_false_unsigned_long_Subtract_gydwfz.Invoke((Anon_izyfb7*)(&bigInt_qdkjbh2), (Anon_izyfb7*)(&bigInt_qdkjbh5));
					InlineArray2_Int64* ptr6 = &bigInt_qdkjbh4.Val.Data;
					Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
					((Struct_fiz2nb*)ptr6)->field_0 = struct_fiz2nb8.field_0;
					Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
					((Struct_fiz2nb*)ptr6)->field_1 = struct_fiz2nb9.field_1;
					Llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh5);
					Llvm_lifetime_start_p0.Invoke(1L, &b2);
					Llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh6);
					Struct_fiz2nb struct_fiz2nb10 = BitwiseAnd.Invoke((Anon_izyfb7*)(&This->Mantissa), (Anon_izyfb7*)(&bigInt_qdkjbh2));
					InlineArray2_Int64* ptr7 = &bigInt_qdkjbh6.Val.Data;
					Struct_fiz2nb struct_fiz2nb11 = struct_fiz2nb10;
					((Struct_fiz2nb*)ptr7)->field_0 = struct_fiz2nb11.field_0;
					Struct_fiz2nb struct_fiz2nb12 = struct_fiz2nb10;
					((Struct_fiz2nb*)ptr7)->field_1 = struct_fiz2nb12.field_1;
					bool num21 = InstructionHelper.BooleanXor(BigInt_128ul_false_unsigned_long_is_zero.Invoke((Anon_izyfb7*)(&bigInt_qdkjbh6)), right: true);
					Llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh6);
					b2 = (num21 ? ((sbyte)1) : ((sbyte)0));
					Llvm_lifetime_start_p0.Invoke(1L, &b3);
					Llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh7);
					Struct_fiz2nb struct_fiz2nb13 = BitwiseAnd.Invoke((Anon_izyfb7*)(&This->Mantissa), (Anon_izyfb7*)(&bigInt_qdkjbh4));
					InlineArray2_Int64* ptr8 = &bigInt_qdkjbh7.Val.Data;
					Struct_fiz2nb struct_fiz2nb14 = struct_fiz2nb13;
					((Struct_fiz2nb*)ptr8)->field_0 = struct_fiz2nb14.field_0;
					Struct_fiz2nb struct_fiz2nb15 = struct_fiz2nb13;
					((Struct_fiz2nb*)ptr8)->field_1 = struct_fiz2nb15.field_1;
					bool num22 = InstructionHelper.BooleanXor(BigInt_128ul_false_unsigned_long_is_zero.Invoke((Anon_izyfb7*)(&bigInt_qdkjbh7)), right: true);
					Llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh7);
					b3 = (num22 ? ((sbyte)1) : ((sbyte)0));
					Llvm_lifetime_start_p0.Invoke(4L, &num10);
					num10 = checked((((b2 & 1) == 1) ? 1 : 0) * 2 + (((b3 & 1) == 1) ? 1 : 0));
					Llvm_lifetime_start_p0.Invoke(8L, &x);
					x = double.NaN;
					if (Details_expects_bool_condition_bool.Invoke(num8 <= 0, Expected: false))
					{
						Llvm_lifetime_start_p0.Invoke(4L, &num11);
						checked
						{
							num11 = 1 - num8;
							Llvm_lifetime_start_p0.Invoke(8L, &num12);
							Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
							Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb4, Sign_POS.Pointer, 1L, isVolatile: false);
							long val4 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_create_value.Invoke(Biased_exp: 1023 + num11, Sign: anon_izyfb4.Val, Mantissa: 0L);
							fputil_FPBits_wjhbrm5.FPRepImpl.FPRepSem.FPStorage.Val = val4;
							double num23 = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm5);
							Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
							num12 = num23;
							Llvm_lifetime_start_p0.Invoke(8L, &num13);
							Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
							Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb5, Sign_POS.Pointer, 1L, isVolatile: false);
							long val5 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_create_value.Invoke(Biased_exp: 1023 - num11, Sign: anon_izyfb5.Val, Mantissa: 0L);
							fputil_FPBits_wjhbrm6.FPRepImpl.FPRepSem.FPStorage.Val = val5;
							double num24 = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm6);
							Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
							num13 = num24;
							Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
							Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb6, &This->Sign, 1L, isVolatile: false);
							long val6 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_create_value.Invoke(Biased_exp: num8 + num11, Sign: anon_izyfb6.Val, Mantissa: 0L);
							fputil_FPBits_wjhbrm7.FPRepImpl.FPRepSem.FPStorage.Val = val6;
							x = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm7);
							Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
							result = Fputil_multiply_add_double.Invoke(x, num10, num9 * num12) * num13;
							Llvm_lifetime_end_p0.Invoke(8L, &num13);
							Llvm_lifetime_end_p0.Invoke(8L, &num12);
							Llvm_lifetime_end_p0.Invoke(4L, &num11);
						}
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm8);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb7, &This->Sign, 1L, isVolatile: false);
						long val7 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_create_value.Invoke(Biased_exp: num8, Sign: anon_izyfb7.Val, Mantissa: 0L);
						fputil_FPBits_wjhbrm8.FPRepImpl.FPRepSem.FPStorage.Val = val7;
						x = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm8);
						Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm8);
						Llvm_lifetime_start_p0.Invoke(8L, &num14);
						num14 = Fputil_multiply_add_double.Invoke(x, num10, num9);
						if (Details_expects_bool_condition_bool.Invoke((b & 1) == 1, Expected: false))
						{
							Llvm_lifetime_start_p0.Invoke(8L, &num15);
							num15 = (long)num3 << 52;
							Llvm_lifetime_start_p0.Invoke(8L, &num16);
							Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm9);
							FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm9, num14);
							long num25 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm9)) - num15;
							Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm9);
							num16 = num25;
							if ((num16 & 0x7FF0000000000000L) == 0L)
							{
								num16 -= 0L;
								if (num10 != 0)
								{
									Fputil_set_errno_if_required.Invoke(34);
									Fputil_raise_except_if_required.Invoke(16);
								}
							}
							Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm10);
							FPBits_double_FPBits_unsigned_long.Invoke(&fputil_FPBits_wjhbrm10, num16);
							result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm10);
							Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm10);
							Llvm_lifetime_end_p0.Invoke(8L, &num16);
							Llvm_lifetime_end_p0.Invoke(8L, &num15);
						}
						else
						{
							result = num14;
						}
						Llvm_lifetime_end_p0.Invoke(8L, &num14);
					}
					Llvm_lifetime_end_p0.Invoke(8L, &x);
					Llvm_lifetime_end_p0.Invoke(4L, &num10);
					Llvm_lifetime_end_p0.Invoke(1L, &b3);
					Llvm_lifetime_end_p0.Invoke(1L, &b2);
					Llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh4);
					Llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh2);
					Llvm_lifetime_end_p0.Invoke(8L, &num9);
					Llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh);
					Llvm_lifetime_end_p0.Invoke(4L, &num8);
					Llvm_lifetime_end_p0.Invoke(4L, &num7);
					Llvm_lifetime_end_p0.Invoke(1L, &b);
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num3);
				Llvm_lifetime_end_p0.Invoke(8L, &num2);
				Llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			return result;
		}
	}
}

using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11DyadicFloatILm128EE7fast_asIgLb1EvEET_v")]
[DemangledName("__float128 __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>::fast_as<__float128, true, void>() const")]
internal static partial class float128_fputil_DyadicFloat_128ul_fast_as_float128_true_void_const
{
	public unsafe static double Invoke(fputil_DyadicFloat_kt2kd4* @this)
	{
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		int num = 0;
		Int128 @int = default(Int128);
		int num2 = 0;
		double num3 = 0.0;
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		Int128 int2 = default(Int128);
		Int128 int3 = default(Int128);
		double num4 = 0.0;
		double num5 = 0.0;
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi5 = default(fputil_FPBits_ubgsi2);
		sbyte b = 0;
		int num6 = 0;
		int num7 = 0;
		BigInt_qdkjbh bigInt_qdkjbh = default(BigInt_qdkjbh);
		double num8 = 0.0;
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi6 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		Int128 x = default(Int128);
		Int128 int4 = default(Int128);
		Int128 int5 = default(Int128);
		BigInt_qdkjbh bigInt_qdkjbh2 = default(BigInt_qdkjbh);
		BigInt_qdkjbh bigInt_qdkjbh3 = default(BigInt_qdkjbh);
		BigInt_qdkjbh bigInt_qdkjbh4 = default(BigInt_qdkjbh);
		BigInt_qdkjbh bigInt_qdkjbh5 = default(BigInt_qdkjbh);
		sbyte b2 = 0;
		BigInt_qdkjbh bigInt_qdkjbh6 = default(BigInt_qdkjbh);
		sbyte b3 = 0;
		BigInt_qdkjbh bigInt_qdkjbh7 = default(BigInt_qdkjbh);
		int num9 = 0;
		double num10 = 0.0;
		int num11 = 0;
		double num12 = 0.0;
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi7 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		Int128 int6 = default(Int128);
		Int128 int7 = default(Int128);
		double num13 = 0.0;
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi8 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb12 = default(anon_izyfb7);
		Int128 int8 = default(Int128);
		Int128 int9 = default(Int128);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi9 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb13 = default(anon_izyfb7);
		Int128 int10 = default(Int128);
		Int128 int11 = default(Int128);
		double num14 = 0.0;
		double num15 = 0.0;
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi10 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb14 = default(anon_izyfb7);
		Int128 int12 = default(Int128);
		Int128 int13 = default(Int128);
		double num16 = 0.0;
		double num17 = 0.0;
		Int128 y = default(Int128);
		Int128 int14 = default(Int128);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi11 = default(fputil_FPBits_ubgsi2);
		Int128 x2 = default(Int128);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi12 = default(fputil_FPBits_ubgsi2);
		Int128 int15 = default(Int128);
		unchecked
		{
			double result;
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(BigInt_128ul_false_unsigned_long_is_zero_const.Invoke((anon_izyfb7*)(&@this->mantissa)), expected: false))
			{
				llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, &@this->sign, 1L, isVolatile: false);
				Struct_fiz2nb struct_fiz2nb = fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_zero_Sign.Invoke(anon_izyfb8.val);
				Int128* ptr = &fputil_FPBits_ubgsi3.val.Data.FPStorage.field_0;
				Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
				((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb2.field_0;
				Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
				((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb3.field_1;
				result = fputil_FPBits_float128_get_val_const.Invoke(&fputil_FPBits_ubgsi3);
				llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = 113;
				llvm_lifetime_start_p0.Invoke(16L, &@int);
				@int = 0L;
				llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = checked(@this->exponent + 16510);
				if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num2 > 32766, expected: false))
				{
					llvm_lifetime_start_p0.Invoke(16L, &num3);
					llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, &@this->sign, 1L, isVolatile: false);
					sbyte val = anon_izyfb9.val;
					int2 = 32766L;
					long biased_exp = *(long*)(&int2);
					long mantissa = ((long*)(&int2))[1];
					int3 = 0L;
					Struct_fiz2nb struct_fiz2nb4 = fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_create_value_Sign_unsigned_int128_unsigned_int128.Invoke(val, biased_exp, mantissa, *(long*)(&int3), ((long*)(&int3))[1]);
					Int128* ptr2 = &fputil_FPBits_ubgsi4.val.Data.FPStorage.field_0;
					Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
					((Struct_fiz2nb*)ptr2)->field_0 = struct_fiz2nb5.field_0;
					Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
					((Struct_fiz2nb*)ptr2)->field_1 = struct_fiz2nb6.field_1;
					double num18 = fputil_FPBits_float128_get_val_const.Invoke(&fputil_FPBits_ubgsi4);
					llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
					num3 = num18;
					llvm_lifetime_start_p0.Invoke(16L, &num4);
					num4 = 2.0;
					llvm_lifetime_start_p0.Invoke(16L, &num5);
					num5 = num4 * num3;
					llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
					fputil_FPBits_float128_FPBits_float128_float128.Invoke(&fputil_FPBits_ubgsi5, num5);
					bool num19 = fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_inf_const.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi5));
					llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
					if (num19)
					{
						fputil_set_errno_if_required_int.Invoke(34);
					}
					result = num5;
					llvm_lifetime_end_p0.Invoke(16L, &num5);
					llvm_lifetime_end_p0.Invoke(16L, &num4);
					llvm_lifetime_end_p0.Invoke(16L, &num3);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(1L, &b);
					b = 0;
					llvm_lifetime_start_p0.Invoke(4L, &num6);
					num6 = 15;
					if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num2 <= 0, expected: false))
					{
						b = 1;
						num6 = (int)(15L + (long)(uint)checked(1 - num2));
						num2 = 16383;
					}
					llvm_lifetime_start_p0.Invoke(4L, &num7);
					num7 = checked(num2 - 113 - 1);
					llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh);
					sbyte* ptr3 = (sbyte*)(&bigInt_qdkjbh);
					*(long*)ptr3 = -6148914691236517206L;
					((long*)ptr3)[1] = -6148914691236517206L;
					if ((ulong)(uint)num6 >= 128uL)
					{
						BigInt_128ul_false_unsigned_long_BigInt_int_void_int.Invoke((anon_izyfb7*)(&bigInt_qdkjbh), 0);
					}
					else
					{
						Struct_fiz2nb struct_fiz2nb7 = BigInt_128ul_false_unsigned_long_operator_unsigned_long_const_99u38u.Invoke((anon_izyfb7*)(&@this->mantissa), (uint)num6);
						InlineArray2_Int64* ptr4 = &bigInt_qdkjbh.val.Data;
						Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
						((Struct_fiz2nb*)ptr4)->field_0 = struct_fiz2nb8.field_0;
						Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
						((Struct_fiz2nb*)ptr4)->field_1 = struct_fiz2nb9.field_1;
					}
					llvm_lifetime_start_p0.Invoke(16L, &num8);
					llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi6);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, &@this->sign, 1L, isVolatile: false);
					Int128 int16 = num2;
					Struct_fiz2nb struct_fiz2nb10 = BigInt_128ul_false_unsigned_long_operator_unsigned_int128_unsigned_int128_const.Invoke((anon_izyfb7*)(&bigInt_qdkjbh));
					Int128* num20 = &x;
					Struct_fiz2nb struct_fiz2nb11 = struct_fiz2nb10;
					*(long*)num20 = struct_fiz2nb11.field_0;
					byte* num21 = (byte*)(&x) + 8u;
					Struct_fiz2nb struct_fiz2nb12 = struct_fiz2nb10;
					*(long*)num21 = struct_fiz2nb12.field_1;
					Int128 int17 = NumericHelper.BitwiseOr(NumericHelper.BitwiseAnd(x, -1L), 0L);
					sbyte val2 = anon_izyfb10.val;
					int4 = int16;
					long biased_exp2 = *(long*)(&int4);
					long mantissa2 = ((long*)(&int4))[1];
					int5 = int17;
					Struct_fiz2nb struct_fiz2nb13 = fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_create_value_Sign_unsigned_int128_unsigned_int128.Invoke(val2, biased_exp2, mantissa2, *(long*)(&int5), ((long*)(&int5))[1]);
					Int128* ptr5 = &fputil_FPBits_ubgsi6.val.Data.FPStorage.field_0;
					Struct_fiz2nb struct_fiz2nb14 = struct_fiz2nb13;
					((Struct_fiz2nb*)ptr5)->field_0 = struct_fiz2nb14.field_0;
					Struct_fiz2nb struct_fiz2nb15 = struct_fiz2nb13;
					((Struct_fiz2nb*)ptr5)->field_1 = struct_fiz2nb15.field_1;
					double num22 = fputil_FPBits_float128_get_val_const.Invoke(&fputil_FPBits_ubgsi6);
					llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi6);
					num8 = num22;
					llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh2);
					sbyte* ptr6 = (sbyte*)(&bigInt_qdkjbh2);
					*(long*)ptr6 = -6148914691236517206L;
					((long*)ptr6)[1] = -6148914691236517206L;
					bool num23 = (ulong)(uint)num6 > 128uL;
					llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh3);
					if (num23)
					{
						BigInt_128ul_false_unsigned_long_BigInt_int_void_int.Invoke((anon_izyfb7*)(&bigInt_qdkjbh2), 0);
					}
					else
					{
						BigInt_128ul_false_unsigned_long_BigInt_int_void_int.Invoke((anon_izyfb7*)(&bigInt_qdkjbh3), 1);
						Struct_fiz2nb struct_fiz2nb16 = BigInt_128ul_false_unsigned_long_operator_unsigned_long_const_dnm495.Invoke((anon_izyfb7*)(&bigInt_qdkjbh3), (uint)(num6 - 1));
						InlineArray2_Int64* ptr7 = &bigInt_qdkjbh2.val.Data;
						Struct_fiz2nb struct_fiz2nb17 = struct_fiz2nb16;
						((Struct_fiz2nb*)ptr7)->field_0 = struct_fiz2nb17.field_0;
						Struct_fiz2nb struct_fiz2nb18 = struct_fiz2nb16;
						((Struct_fiz2nb*)ptr7)->field_1 = struct_fiz2nb18.field_1;
					}
					llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh3);
					llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh4);
					sbyte* ptr8 = (sbyte*)(&bigInt_qdkjbh4);
					*(long*)ptr8 = -6148914691236517206L;
					((long*)ptr8)[1] = -6148914691236517206L;
					llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh5);
					BigInt_128ul_false_unsigned_long_BigInt_int_void_int.Invoke((anon_izyfb7*)(&bigInt_qdkjbh5), 1);
					Struct_fiz2nb struct_fiz2nb19 = BigInt_128ul_false_unsigned_long_operator_BigInt_128ul_false_unsigned_long_const_gydwfz.Invoke((anon_izyfb7*)(&bigInt_qdkjbh2), (anon_izyfb7*)(&bigInt_qdkjbh5));
					InlineArray2_Int64* ptr9 = &bigInt_qdkjbh4.val.Data;
					Struct_fiz2nb struct_fiz2nb20 = struct_fiz2nb19;
					((Struct_fiz2nb*)ptr9)->field_0 = struct_fiz2nb20.field_0;
					Struct_fiz2nb struct_fiz2nb21 = struct_fiz2nb19;
					((Struct_fiz2nb*)ptr9)->field_1 = struct_fiz2nb21.field_1;
					llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh5);
					llvm_lifetime_start_p0.Invoke(1L, &b2);
					llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh6);
					Struct_fiz2nb struct_fiz2nb22 = operator_BigInt_128ul_false_unsigned_long_const_BigInt_128ul_false_unsigned_long_const_bs7s6m.Invoke((anon_izyfb7*)(&@this->mantissa), (anon_izyfb7*)(&bigInt_qdkjbh2));
					InlineArray2_Int64* ptr10 = &bigInt_qdkjbh6.val.Data;
					Struct_fiz2nb struct_fiz2nb23 = struct_fiz2nb22;
					((Struct_fiz2nb*)ptr10)->field_0 = struct_fiz2nb23.field_0;
					Struct_fiz2nb struct_fiz2nb24 = struct_fiz2nb22;
					((Struct_fiz2nb*)ptr10)->field_1 = struct_fiz2nb24.field_1;
					int num24 = (BigInt_128ul_false_unsigned_long_is_zero_const.Invoke((anon_izyfb7*)(&bigInt_qdkjbh6)) ? 1 : 0) ^ -1;
					llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh6);
					b2 = (sbyte)(byte)num24;
					llvm_lifetime_start_p0.Invoke(1L, &b3);
					llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh7);
					Struct_fiz2nb struct_fiz2nb25 = operator_BigInt_128ul_false_unsigned_long_const_BigInt_128ul_false_unsigned_long_const_bs7s6m.Invoke((anon_izyfb7*)(&@this->mantissa), (anon_izyfb7*)(&bigInt_qdkjbh4));
					InlineArray2_Int64* ptr11 = &bigInt_qdkjbh7.val.Data;
					Struct_fiz2nb struct_fiz2nb26 = struct_fiz2nb25;
					((Struct_fiz2nb*)ptr11)->field_0 = struct_fiz2nb26.field_0;
					Struct_fiz2nb struct_fiz2nb27 = struct_fiz2nb25;
					((Struct_fiz2nb*)ptr11)->field_1 = struct_fiz2nb27.field_1;
					int num25 = (BigInt_128ul_false_unsigned_long_is_zero_const.Invoke((anon_izyfb7*)(&bigInt_qdkjbh7)) ? 1 : 0) ^ -1;
					llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh7);
					b3 = (sbyte)(byte)num25;
					llvm_lifetime_start_p0.Invoke(4L, &num9);
					num9 = checked((((b2 & 1) == 1) ? 1 : 0) * 2 + (((b3 & 1) == 1) ? 1 : 0));
					llvm_lifetime_start_p0.Invoke(16L, &num10);
					num10 = double.NaN;
					if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num7 <= 0, expected: false))
					{
						llvm_lifetime_start_p0.Invoke(4L, &num11);
						sbyte val3;
						checked
						{
							num11 = 1 - num7;
							llvm_lifetime_start_p0.Invoke(16L, &num12);
							llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi7);
							llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, Sign_POS.Pointer, 1L, isVolatile: false);
							Int128 int18 = 16383 + num11;
							val3 = anon_izyfb11.val;
							int6 = int18;
						}
						long biased_exp3 = *(long*)(&int6);
						long mantissa3 = ((long*)(&int6))[1];
						int7 = 0L;
						Struct_fiz2nb struct_fiz2nb28 = fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_create_value_Sign_unsigned_int128_unsigned_int128.Invoke(val3, biased_exp3, mantissa3, *(long*)(&int7), ((long*)(&int7))[1]);
						Int128* ptr12 = &fputil_FPBits_ubgsi7.val.Data.FPStorage.field_0;
						Struct_fiz2nb struct_fiz2nb29 = struct_fiz2nb28;
						((Struct_fiz2nb*)ptr12)->field_0 = struct_fiz2nb29.field_0;
						Struct_fiz2nb struct_fiz2nb30 = struct_fiz2nb28;
						((Struct_fiz2nb*)ptr12)->field_1 = struct_fiz2nb30.field_1;
						double num26 = fputil_FPBits_float128_get_val_const.Invoke(&fputil_FPBits_ubgsi7);
						llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi7);
						num12 = num26;
						llvm_lifetime_start_p0.Invoke(16L, &num13);
						llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi8);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb12, Sign_POS.Pointer, 1L, isVolatile: false);
						Int128 int19 = checked(16383 - num11);
						sbyte val4 = anon_izyfb12.val;
						int8 = int19;
						long biased_exp4 = *(long*)(&int8);
						long mantissa4 = ((long*)(&int8))[1];
						int9 = 0L;
						Struct_fiz2nb struct_fiz2nb31 = fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_create_value_Sign_unsigned_int128_unsigned_int128.Invoke(val4, biased_exp4, mantissa4, *(long*)(&int9), ((long*)(&int9))[1]);
						Int128* ptr13 = &fputil_FPBits_ubgsi8.val.Data.FPStorage.field_0;
						Struct_fiz2nb struct_fiz2nb32 = struct_fiz2nb31;
						((Struct_fiz2nb*)ptr13)->field_0 = struct_fiz2nb32.field_0;
						Struct_fiz2nb struct_fiz2nb33 = struct_fiz2nb31;
						((Struct_fiz2nb*)ptr13)->field_1 = struct_fiz2nb33.field_1;
						double num27 = fputil_FPBits_float128_get_val_const.Invoke(&fputil_FPBits_ubgsi8);
						llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi8);
						num13 = num27;
						llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi9);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, &@this->sign, 1L, isVolatile: false);
						Int128 int20 = checked(num7 + num11);
						sbyte val5 = anon_izyfb13.val;
						int10 = int20;
						long biased_exp5 = *(long*)(&int10);
						long mantissa5 = ((long*)(&int10))[1];
						int11 = 0L;
						Struct_fiz2nb struct_fiz2nb34 = fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_create_value_Sign_unsigned_int128_unsigned_int128.Invoke(val5, biased_exp5, mantissa5, *(long*)(&int11), ((long*)(&int11))[1]);
						Int128* ptr14 = &fputil_FPBits_ubgsi9.val.Data.FPStorage.field_0;
						Struct_fiz2nb struct_fiz2nb35 = struct_fiz2nb34;
						((Struct_fiz2nb*)ptr14)->field_0 = struct_fiz2nb35.field_0;
						Struct_fiz2nb struct_fiz2nb36 = struct_fiz2nb34;
						((Struct_fiz2nb*)ptr14)->field_1 = struct_fiz2nb36.field_1;
						num10 = fputil_FPBits_float128_get_val_const.Invoke(&fputil_FPBits_ubgsi9);
						llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi9);
						llvm_lifetime_start_p0.Invoke(16L, &num14);
						num14 = num9;
						llvm_lifetime_start_p0.Invoke(16L, &num15);
						num15 = num8 * num12;
						result = cpp_enable_if_sizeof_float128_8ul_float128_type_fputil_multiply_add_float128_float128_const_float128_const_float128_const.Invoke(&num10, &num14, &num15) * num13;
						llvm_lifetime_end_p0.Invoke(16L, &num15);
						llvm_lifetime_end_p0.Invoke(16L, &num14);
						llvm_lifetime_end_p0.Invoke(16L, &num13);
						llvm_lifetime_end_p0.Invoke(16L, &num12);
						llvm_lifetime_end_p0.Invoke(4L, &num11);
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi10);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb14, &@this->sign, 1L, isVolatile: false);
						Int128 int21 = num7;
						sbyte val6 = anon_izyfb14.val;
						int12 = int21;
						long biased_exp6 = *(long*)(&int12);
						long mantissa6 = ((long*)(&int12))[1];
						int13 = 0L;
						Struct_fiz2nb struct_fiz2nb37 = fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_create_value_Sign_unsigned_int128_unsigned_int128.Invoke(val6, biased_exp6, mantissa6, *(long*)(&int13), ((long*)(&int13))[1]);
						Int128* ptr15 = &fputil_FPBits_ubgsi10.val.Data.FPStorage.field_0;
						Struct_fiz2nb struct_fiz2nb38 = struct_fiz2nb37;
						((Struct_fiz2nb*)ptr15)->field_0 = struct_fiz2nb38.field_0;
						Struct_fiz2nb struct_fiz2nb39 = struct_fiz2nb37;
						((Struct_fiz2nb*)ptr15)->field_1 = struct_fiz2nb39.field_1;
						num10 = fputil_FPBits_float128_get_val_const.Invoke(&fputil_FPBits_ubgsi10);
						llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi10);
						llvm_lifetime_start_p0.Invoke(16L, &num16);
						llvm_lifetime_start_p0.Invoke(16L, &num17);
						num17 = num9;
						double num28 = cpp_enable_if_sizeof_float128_8ul_float128_type_fputil_multiply_add_float128_float128_const_float128_const_float128_const.Invoke(&num10, &num17, &num8);
						llvm_lifetime_end_p0.Invoke(16L, &num17);
						num16 = num28;
						if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((b & 1) == 1, expected: false))
						{
							llvm_lifetime_start_p0.Invoke(16L, &y);
							y = NumericHelper.ShiftLeft((Int128)num2, (Int128)112L);
							llvm_lifetime_start_p0.Invoke(16L, &int14);
							llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi11);
							fputil_FPBits_float128_FPBits_float128_float128.Invoke(&fputil_FPBits_ubgsi11, num16);
							Struct_fiz2nb struct_fiz2nb40 = fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_uintval_const.Invoke(&fputil_FPBits_ubgsi11);
							Int128* num29 = &x2;
							Struct_fiz2nb struct_fiz2nb41 = struct_fiz2nb40;
							*(long*)num29 = struct_fiz2nb41.field_0;
							byte* num30 = (byte*)(&x2) + 8u;
							Struct_fiz2nb struct_fiz2nb42 = struct_fiz2nb40;
							*(long*)num30 = struct_fiz2nb42.field_1;
							Int128 int22 = NumericHelper.Subtract(x2, y);
							llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi11);
							int14 = int22;
							if (!NumericHelper.IntCmpNe(NumericHelper.BitwiseAnd(int14, 0L), 0L))
							{
								int14 = NumericHelper.Subtract(int14, 0L);
								if (num9 != 0)
								{
									fputil_set_errno_if_required_int.Invoke(34);
									fputil_raise_except_if_required_int.Invoke(16);
								}
							}
							llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi12);
							int15 = int14;
							fputil_FPBits_float128_FPBits_unsigned_int128_unsigned_int128.Invoke(&fputil_FPBits_ubgsi12, *(long*)(&int15), ((long*)(&int15))[1]);
							result = fputil_FPBits_float128_get_val_const.Invoke(&fputil_FPBits_ubgsi12);
							llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi12);
							llvm_lifetime_end_p0.Invoke(16L, &int14);
							llvm_lifetime_end_p0.Invoke(16L, &y);
						}
						else
						{
							result = num16;
						}
						llvm_lifetime_end_p0.Invoke(16L, &num16);
					}
					llvm_lifetime_end_p0.Invoke(16L, &num10);
					llvm_lifetime_end_p0.Invoke(4L, &num9);
					llvm_lifetime_end_p0.Invoke(1L, &b3);
					llvm_lifetime_end_p0.Invoke(1L, &b2);
					llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh4);
					llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh2);
					llvm_lifetime_end_p0.Invoke(16L, &num8);
					llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh);
					llvm_lifetime_end_p0.Invoke(4L, &num7);
					llvm_lifetime_end_p0.Invoke(4L, &num6);
					llvm_lifetime_end_p0.Invoke(1L, &b);
				}
				llvm_lifetime_end_p0.Invoke(4L, &num2);
				llvm_lifetime_end_p0.Invoke(16L, &@int);
				llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			return result;
		}
	}
}

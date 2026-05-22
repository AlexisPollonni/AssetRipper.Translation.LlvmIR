using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class DyadicFloat_128ul_fast_as_long_double_true_void
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11DyadicFloatILm128EE7fast_asIeLb1EvEET_v")]
	[DemangledName("long double __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>::fast_as<long double, true, void>() const")]
	[return: NativeType("long double")]
	public unsafe static double Invoke([MangledName("this")] Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4* This)
	{
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		int num = 0;
		Int128 @int = default(Int128);
		int num2 = 0;
		double num3 = 0.0;
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi2 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Int128 int2 = default(Int128);
		Int128 int3 = default(Int128);
		double num4 = 0.0;
		double num5 = 0.0;
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi3 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		sbyte b = 0;
		int num6 = 0;
		int num7 = 0;
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
		double num8 = 0.0;
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi4 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Int128 x = default(Int128);
		Int128 int4 = default(Int128);
		Int128 int5 = default(Int128);
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh2 = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh3 = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh4 = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh5 = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
		sbyte b2 = 0;
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh6 = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
		sbyte b3 = 0;
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh7 = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
		int num9 = 0;
		double num10 = 0.0;
		int num11 = 0;
		double num12 = 0.0;
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi5 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		Int128 int6 = default(Int128);
		Int128 int7 = default(Int128);
		double num13 = 0.0;
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi6 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb5 = default(Anon_izyfb7);
		Int128 int8 = default(Int128);
		Int128 int9 = default(Int128);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi7 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb6 = default(Anon_izyfb7);
		Int128 int10 = default(Int128);
		Int128 int11 = default(Int128);
		double num14 = 0.0;
		double num15 = 0.0;
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi8 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb7 = default(Anon_izyfb7);
		Int128 int12 = default(Int128);
		Int128 int13 = default(Int128);
		double num16 = 0.0;
		double num17 = 0.0;
		Int128 y = default(Int128);
		Int128 int14 = default(Int128);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi9 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Int128 x2 = default(Int128);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi10 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Int128 int15 = default(Int128);
		unchecked
		{
			double result;
			if (Details_expects_bool_condition_bool.Invoke(BigInt_128ul_false_unsigned_long_is_zero.Invoke((Anon_izyfb7*)(&This->Mantissa)), Expected: false))
			{
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, &This->Sign, 1L, isVolatile: false);
				Struct_fiz2nb struct_fiz2nb = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_zero.Invoke(anon_izyfb.Val);
				Int128* ptr = &llvm_libc_20_1_2_fputil_FPBits_ubgsi.Val.Data.FPStorage.field_0;
				Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
				((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb2.field_0;
				Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
				((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb3.field_1;
				result = FPBits_long_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi);
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				num = 64;
				Llvm_lifetime_start_p0.Invoke(16L, &@int);
				@int = long.MinValue;
				Llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = checked(This->Exponent + 16510);
				if (Details_expects_bool_condition_bool.Invoke(num2 > 32766, Expected: false))
				{
					Llvm_lifetime_start_p0.Invoke(16L, &num3);
					Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, &This->Sign, 1L, isVolatile: false);
					sbyte val = anon_izyfb2.Val;
					int2 = 32766L;
					long biased_exp = *(long*)(&int2);
					long mantissa = ((long*)(&int2))[1];
					int3 = long.MinValue;
					Struct_fiz2nb struct_fiz2nb4 = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_create_value.Invoke(val, biased_exp, mantissa, *(long*)(&int3), ((long*)(&int3))[1]);
					Int128* ptr2 = &llvm_libc_20_1_2_fputil_FPBits_ubgsi2.Val.Data.FPStorage.field_0;
					Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
					((Struct_fiz2nb*)ptr2)->field_0 = struct_fiz2nb5.field_0;
					Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
					((Struct_fiz2nb*)ptr2)->field_1 = struct_fiz2nb6.field_1;
					double num18 = FPBits_long_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
					Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
					num3 = num18;
					Llvm_lifetime_start_p0.Invoke(16L, &num4);
					num4 = 2.0;
					Llvm_lifetime_start_p0.Invoke(16L, &num5);
					num5 = num4 * num3;
					Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi3);
					FPBits_long_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi3, num5);
					bool num19 = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_inf.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi3);
					Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi3);
					if (num19)
					{
						Fputil_set_errno_if_required.Invoke(34);
					}
					result = num5;
					Llvm_lifetime_end_p0.Invoke(16L, &num5);
					Llvm_lifetime_end_p0.Invoke(16L, &num4);
					Llvm_lifetime_end_p0.Invoke(16L, &num3);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(1L, &b);
					b = 0;
					Llvm_lifetime_start_p0.Invoke(4L, &num6);
					num6 = 64;
					if (Details_expects_bool_condition_bool.Invoke(num2 <= 0, Expected: false))
					{
						b = 1;
						num6 = (int)(64L + (long)(uint)checked(1 - num2));
						num2 = 16383;
					}
					Llvm_lifetime_start_p0.Invoke(4L, &num7);
					num7 = checked(num2 - 64 - 1);
					Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh);
					sbyte* ptr3 = (sbyte*)(&llvm_libc_20_1_2_BigInt_qdkjbh);
					*(long*)ptr3 = -6148914691236517206L;
					((long*)ptr3)[1] = -6148914691236517206L;
					if ((ulong)(uint)num6 >= 128uL)
					{
						BigInt_128ul_false_unsigned_long_BigInt_int_void.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh), 0);
					}
					else
					{
						Struct_fiz2nb struct_fiz2nb7 = BigInt_128ul_false_unsigned_long_RightShift.Invoke((Anon_izyfb7*)(&This->Mantissa), (uint)num6);
						InlineArray2_Int64* ptr4 = &llvm_libc_20_1_2_BigInt_qdkjbh.Val.Data;
						Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
						((Struct_fiz2nb*)ptr4)->field_0 = struct_fiz2nb8.field_0;
						Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
						((Struct_fiz2nb*)ptr4)->field_1 = struct_fiz2nb9.field_1;
					}
					Llvm_lifetime_start_p0.Invoke(16L, &num8);
					Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi4);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb3, &This->Sign, 1L, isVolatile: false);
					Int128 int16 = num2;
					Struct_fiz2nb struct_fiz2nb10 = BigInt_128ul_false_unsigned_long_Unsigned_int128_unsigned_int128.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh));
					Int128* num20 = &x;
					Struct_fiz2nb struct_fiz2nb11 = struct_fiz2nb10;
					*(long*)num20 = struct_fiz2nb11.field_0;
					byte* num21 = (byte*)(&x) + 8u;
					Struct_fiz2nb struct_fiz2nb12 = struct_fiz2nb10;
					*(long*)num21 = struct_fiz2nb12.field_1;
					Int128 int17 = NumericHelper.BitwiseOr(NumericHelper.BitwiseAnd(x, -1L), long.MinValue);
					sbyte val2 = anon_izyfb3.Val;
					int4 = int16;
					long biased_exp2 = *(long*)(&int4);
					long mantissa2 = ((long*)(&int4))[1];
					int5 = int17;
					Struct_fiz2nb struct_fiz2nb13 = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_create_value.Invoke(val2, biased_exp2, mantissa2, *(long*)(&int5), ((long*)(&int5))[1]);
					Int128* ptr5 = &llvm_libc_20_1_2_fputil_FPBits_ubgsi4.Val.Data.FPStorage.field_0;
					Struct_fiz2nb struct_fiz2nb14 = struct_fiz2nb13;
					((Struct_fiz2nb*)ptr5)->field_0 = struct_fiz2nb14.field_0;
					Struct_fiz2nb struct_fiz2nb15 = struct_fiz2nb13;
					((Struct_fiz2nb*)ptr5)->field_1 = struct_fiz2nb15.field_1;
					double num22 = FPBits_long_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi4);
					Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi4);
					num8 = num22;
					Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh2);
					sbyte* ptr6 = (sbyte*)(&llvm_libc_20_1_2_BigInt_qdkjbh2);
					*(long*)ptr6 = -6148914691236517206L;
					((long*)ptr6)[1] = -6148914691236517206L;
					bool num23 = (ulong)(uint)num6 > 128uL;
					Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh3);
					if (num23)
					{
						BigInt_128ul_false_unsigned_long_BigInt_int_void.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh2), 0);
					}
					else
					{
						BigInt_128ul_false_unsigned_long_BigInt_int_void.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh3), 1);
						Struct_fiz2nb struct_fiz2nb16 = BigInt_128ul_false_unsigned_long_LeftShift.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh3), (uint)(num6 - 1));
						InlineArray2_Int64* ptr7 = &llvm_libc_20_1_2_BigInt_qdkjbh2.Val.Data;
						Struct_fiz2nb struct_fiz2nb17 = struct_fiz2nb16;
						((Struct_fiz2nb*)ptr7)->field_0 = struct_fiz2nb17.field_0;
						Struct_fiz2nb struct_fiz2nb18 = struct_fiz2nb16;
						((Struct_fiz2nb*)ptr7)->field_1 = struct_fiz2nb18.field_1;
					}
					Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh3);
					Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh4);
					sbyte* ptr8 = (sbyte*)(&llvm_libc_20_1_2_BigInt_qdkjbh4);
					*(long*)ptr8 = -6148914691236517206L;
					((long*)ptr8)[1] = -6148914691236517206L;
					Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh5);
					BigInt_128ul_false_unsigned_long_BigInt_int_void.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh5), 1);
					Struct_fiz2nb struct_fiz2nb19 = BigInt_128ul_false_unsigned_long_Subtract_gydwfz.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh2), (Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh5));
					InlineArray2_Int64* ptr9 = &llvm_libc_20_1_2_BigInt_qdkjbh4.Val.Data;
					Struct_fiz2nb struct_fiz2nb20 = struct_fiz2nb19;
					((Struct_fiz2nb*)ptr9)->field_0 = struct_fiz2nb20.field_0;
					Struct_fiz2nb struct_fiz2nb21 = struct_fiz2nb19;
					((Struct_fiz2nb*)ptr9)->field_1 = struct_fiz2nb21.field_1;
					Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh5);
					Llvm_lifetime_start_p0.Invoke(1L, &b2);
					Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh6);
					Struct_fiz2nb struct_fiz2nb22 = Llvm_libc_20_1_2_BitwiseAnd.Invoke((Anon_izyfb7*)(&This->Mantissa), (Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh2));
					InlineArray2_Int64* ptr10 = &llvm_libc_20_1_2_BigInt_qdkjbh6.Val.Data;
					Struct_fiz2nb struct_fiz2nb23 = struct_fiz2nb22;
					((Struct_fiz2nb*)ptr10)->field_0 = struct_fiz2nb23.field_0;
					Struct_fiz2nb struct_fiz2nb24 = struct_fiz2nb22;
					((Struct_fiz2nb*)ptr10)->field_1 = struct_fiz2nb24.field_1;
					bool num24 = InstructionHelper.BooleanXor(BigInt_128ul_false_unsigned_long_is_zero.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh6)), right: true);
					Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh6);
					b2 = (num24 ? ((sbyte)1) : ((sbyte)0));
					Llvm_lifetime_start_p0.Invoke(1L, &b3);
					Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh7);
					Struct_fiz2nb struct_fiz2nb25 = Llvm_libc_20_1_2_BitwiseAnd.Invoke((Anon_izyfb7*)(&This->Mantissa), (Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh4));
					InlineArray2_Int64* ptr11 = &llvm_libc_20_1_2_BigInt_qdkjbh7.Val.Data;
					Struct_fiz2nb struct_fiz2nb26 = struct_fiz2nb25;
					((Struct_fiz2nb*)ptr11)->field_0 = struct_fiz2nb26.field_0;
					Struct_fiz2nb struct_fiz2nb27 = struct_fiz2nb25;
					((Struct_fiz2nb*)ptr11)->field_1 = struct_fiz2nb27.field_1;
					bool num25 = InstructionHelper.BooleanXor(BigInt_128ul_false_unsigned_long_is_zero.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh7)), right: true);
					Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh7);
					b3 = (num25 ? ((sbyte)1) : ((sbyte)0));
					Llvm_lifetime_start_p0.Invoke(4L, &num9);
					num9 = checked((((b2 & 1) == 1) ? 1 : 0) * 2 + (((b3 & 1) == 1) ? 1 : 0));
					Llvm_lifetime_start_p0.Invoke(16L, &num10);
					num10 = double.NaN;
					if (Details_expects_bool_condition_bool.Invoke(num7 <= 0, Expected: false))
					{
						Llvm_lifetime_start_p0.Invoke(4L, &num11);
						sbyte val3;
						checked
						{
							num11 = 1 - num7;
							Llvm_lifetime_start_p0.Invoke(16L, &num12);
							Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi5);
							Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb4, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
							Int128 int18 = 16383 + num11;
							val3 = anon_izyfb4.Val;
							int6 = int18;
						}
						long biased_exp3 = *(long*)(&int6);
						long mantissa3 = ((long*)(&int6))[1];
						int7 = long.MinValue;
						Struct_fiz2nb struct_fiz2nb28 = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_create_value.Invoke(val3, biased_exp3, mantissa3, *(long*)(&int7), ((long*)(&int7))[1]);
						Int128* ptr12 = &llvm_libc_20_1_2_fputil_FPBits_ubgsi5.Val.Data.FPStorage.field_0;
						Struct_fiz2nb struct_fiz2nb29 = struct_fiz2nb28;
						((Struct_fiz2nb*)ptr12)->field_0 = struct_fiz2nb29.field_0;
						Struct_fiz2nb struct_fiz2nb30 = struct_fiz2nb28;
						((Struct_fiz2nb*)ptr12)->field_1 = struct_fiz2nb30.field_1;
						double num26 = FPBits_long_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi5);
						Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi5);
						num12 = num26;
						Llvm_lifetime_start_p0.Invoke(16L, &num13);
						Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi6);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb5, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
						Int128 int19 = checked(16383 - num11);
						sbyte val4 = anon_izyfb5.Val;
						int8 = int19;
						long biased_exp4 = *(long*)(&int8);
						long mantissa4 = ((long*)(&int8))[1];
						int9 = long.MinValue;
						Struct_fiz2nb struct_fiz2nb31 = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_create_value.Invoke(val4, biased_exp4, mantissa4, *(long*)(&int9), ((long*)(&int9))[1]);
						Int128* ptr13 = &llvm_libc_20_1_2_fputil_FPBits_ubgsi6.Val.Data.FPStorage.field_0;
						Struct_fiz2nb struct_fiz2nb32 = struct_fiz2nb31;
						((Struct_fiz2nb*)ptr13)->field_0 = struct_fiz2nb32.field_0;
						Struct_fiz2nb struct_fiz2nb33 = struct_fiz2nb31;
						((Struct_fiz2nb*)ptr13)->field_1 = struct_fiz2nb33.field_1;
						double num27 = FPBits_long_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi6);
						Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi6);
						num13 = num27;
						Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi7);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb6, &This->Sign, 1L, isVolatile: false);
						Int128 int20 = checked(num7 + num11);
						sbyte val5 = anon_izyfb6.Val;
						int10 = int20;
						long biased_exp5 = *(long*)(&int10);
						long mantissa5 = ((long*)(&int10))[1];
						int11 = long.MinValue;
						Struct_fiz2nb struct_fiz2nb34 = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_create_value.Invoke(val5, biased_exp5, mantissa5, *(long*)(&int11), ((long*)(&int11))[1]);
						Int128* ptr14 = &llvm_libc_20_1_2_fputil_FPBits_ubgsi7.Val.Data.FPStorage.field_0;
						Struct_fiz2nb struct_fiz2nb35 = struct_fiz2nb34;
						((Struct_fiz2nb*)ptr14)->field_0 = struct_fiz2nb35.field_0;
						Struct_fiz2nb struct_fiz2nb36 = struct_fiz2nb34;
						((Struct_fiz2nb*)ptr14)->field_1 = struct_fiz2nb36.field_1;
						num10 = FPBits_long_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi7);
						Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi7);
						Llvm_lifetime_start_p0.Invoke(16L, &num14);
						num14 = num9;
						Llvm_lifetime_start_p0.Invoke(16L, &num15);
						num15 = num8 * num12;
						result = Fputil_multiply_add_long_double.Invoke(&num10, &num14, &num15) * num13;
						Llvm_lifetime_end_p0.Invoke(16L, &num15);
						Llvm_lifetime_end_p0.Invoke(16L, &num14);
						Llvm_lifetime_end_p0.Invoke(16L, &num13);
						Llvm_lifetime_end_p0.Invoke(16L, &num12);
						Llvm_lifetime_end_p0.Invoke(4L, &num11);
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi8);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb7, &This->Sign, 1L, isVolatile: false);
						Int128 int21 = num7;
						sbyte val6 = anon_izyfb7.Val;
						int12 = int21;
						long biased_exp6 = *(long*)(&int12);
						long mantissa6 = ((long*)(&int12))[1];
						int13 = long.MinValue;
						Struct_fiz2nb struct_fiz2nb37 = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_create_value.Invoke(val6, biased_exp6, mantissa6, *(long*)(&int13), ((long*)(&int13))[1]);
						Int128* ptr15 = &llvm_libc_20_1_2_fputil_FPBits_ubgsi8.Val.Data.FPStorage.field_0;
						Struct_fiz2nb struct_fiz2nb38 = struct_fiz2nb37;
						((Struct_fiz2nb*)ptr15)->field_0 = struct_fiz2nb38.field_0;
						Struct_fiz2nb struct_fiz2nb39 = struct_fiz2nb37;
						((Struct_fiz2nb*)ptr15)->field_1 = struct_fiz2nb39.field_1;
						num10 = FPBits_long_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi8);
						Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi8);
						Llvm_lifetime_start_p0.Invoke(16L, &num16);
						Llvm_lifetime_start_p0.Invoke(16L, &num17);
						num17 = num9;
						double num28 = Fputil_multiply_add_long_double.Invoke(&num10, &num17, &num8);
						Llvm_lifetime_end_p0.Invoke(16L, &num17);
						num16 = num28;
						if (Details_expects_bool_condition_bool.Invoke((b & 1) == 1, Expected: false))
						{
							Llvm_lifetime_start_p0.Invoke(16L, &y);
							y = NumericHelper.ShiftLeft((Int128)num2, (Int128)64L);
							Llvm_lifetime_start_p0.Invoke(16L, &int14);
							Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi9);
							FPBits_long_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi9, num16);
							Struct_fiz2nb struct_fiz2nb40 = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_uintval.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi9);
							Int128* num29 = &x2;
							Struct_fiz2nb struct_fiz2nb41 = struct_fiz2nb40;
							*(long*)num29 = struct_fiz2nb41.field_0;
							byte* num30 = (byte*)(&x2) + 8u;
							Struct_fiz2nb struct_fiz2nb42 = struct_fiz2nb40;
							*(long*)num30 = struct_fiz2nb42.field_1;
							Int128 int22 = NumericHelper.Subtract(x2, y);
							Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi9);
							int14 = int22;
							if (!NumericHelper.IntCmpNe(NumericHelper.BitwiseAnd(int14, 0L), 0L))
							{
								int14 = NumericHelper.Subtract(int14, long.MinValue);
								if (num9 != 0)
								{
									Fputil_set_errno_if_required.Invoke(34);
									Fputil_raise_except_if_required.Invoke(16);
								}
							}
							Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi10);
							int15 = int14;
							FPBits_long_double_FPBits_unsigned_int128.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi10, *(long*)(&int15), ((long*)(&int15))[1]);
							result = FPBits_long_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi10);
							Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi10);
							Llvm_lifetime_end_p0.Invoke(16L, &int14);
							Llvm_lifetime_end_p0.Invoke(16L, &y);
						}
						else
						{
							result = num16;
						}
						Llvm_lifetime_end_p0.Invoke(16L, &num16);
					}
					Llvm_lifetime_end_p0.Invoke(16L, &num10);
					Llvm_lifetime_end_p0.Invoke(4L, &num9);
					Llvm_lifetime_end_p0.Invoke(1L, &b3);
					Llvm_lifetime_end_p0.Invoke(1L, &b2);
					Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh4);
					Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh2);
					Llvm_lifetime_end_p0.Invoke(16L, &num8);
					Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh);
					Llvm_lifetime_end_p0.Invoke(4L, &num7);
					Llvm_lifetime_end_p0.Invoke(4L, &num6);
					Llvm_lifetime_end_p0.Invoke(1L, &b);
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num2);
				Llvm_lifetime_end_p0.Invoke(16L, &@int);
				Llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			return result;
		}
	}
}

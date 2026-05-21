using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FMod_float128_unsigned_int128_fputil_generic_FModDivisionSimpleHelper_unsigned_int128_eval_internal
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic4FModIgoNS1_24FModDivisionSimpleHelperIoEEE13eval_internalENS0_6FPBitsIgEES7_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::generic::FMod<__float128, unsigned __int128, __llvm_libc_20_1_2_::fputil::generic::FModDivisionSimpleHelper<unsigned __int128>>::eval_internal(__llvm_libc_20_1_2_::fputil::FPBits<__float128>, __llvm_libc_20_1_2_::fputil::FPBits<__float128>)")]
	public unsafe static Struct_fiz2nb Invoke([MangledName("sx.coerce0")] long sx, [MangledName("sx.coerce1")] long sy, [MangledName("sy.coerce0")] long e_x, [MangledName("sy.coerce1")] long e_y)
	{
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi5 = default(fputil_FPBits_ubgsi2);
		Int128 @int = default(Int128);
		Int128 y = default(Int128);
		Int128 int2 = default(Int128);
		Int128 y2 = default(Int128);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		int num = 0;
		int num2 = 0;
		Int128 x = default(Int128);
		Int128 int3 = default(Int128);
		Int128 y3 = default(Int128);
		Int128 int4 = default(Int128);
		Int128 int5 = default(Int128);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		Int128 int6 = default(Int128);
		Int128 int7 = default(Int128);
		Int128 y4 = default(Int128);
		Int128 int8 = default(Int128);
		Int128 int9 = default(Int128);
		Int128 int10 = default(Int128);
		Int128 int11 = default(Int128);
		Int128 int12 = default(Int128);
		int num3 = 0;
		int num4 = 0;
		Int128 int13 = default(Int128);
		Int128 int14 = default(Int128);
		int num5 = 0;
		Int128 int15 = default(Int128);
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		int num9 = 0;
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		Int128 int16 = default(Int128);
		Int128 int17 = default(Int128);
		Int128 int18 = default(Int128);
		Int128 int19 = default(Int128);
		Int128 int20 = default(Int128);
		unchecked
		{
			*(long*)(&fputil_FPBits_ubgsi4) = sx;
			((long*)(&fputil_FPBits_ubgsi4))[1] = sy;
			*(long*)(&fputil_FPBits_ubgsi5) = e_x;
			((long*)(&fputil_FPBits_ubgsi5))[1] = e_y;
			Struct_fiz2nb struct_fiz2nb = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_uintval.Invoke(&fputil_FPBits_ubgsi4);
			Int128* num10 = &@int;
			Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
			*(long*)num10 = struct_fiz2nb2.field_0;
			byte* num11 = (byte*)(&@int) + 8u;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			*(long*)num11 = struct_fiz2nb3.field_1;
			Int128 x2 = @int;
			Struct_fiz2nb struct_fiz2nb4 = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_uintval.Invoke(&fputil_FPBits_ubgsi5);
			Int128* num12 = &y;
			Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
			*(long*)num12 = struct_fiz2nb5.field_0;
			byte* num13 = (byte*)(&y) + 8u;
			Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
			*(long*)num13 = struct_fiz2nb6.field_1;
			if (details_expects_bool_condition_bool.Invoke(NumericHelper.IntCmpUle(x2, y), expected: true))
			{
				Struct_fiz2nb struct_fiz2nb7 = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_uintval.Invoke(&fputil_FPBits_ubgsi4);
				Int128* num14 = &int2;
				Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
				*(long*)num14 = struct_fiz2nb8.field_0;
				byte* num15 = (byte*)(&int2) + 8u;
				Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
				*(long*)num15 = struct_fiz2nb9.field_1;
				Int128 x3 = int2;
				Struct_fiz2nb struct_fiz2nb10 = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_uintval.Invoke(&fputil_FPBits_ubgsi5);
				Int128* num16 = &y2;
				Struct_fiz2nb struct_fiz2nb11 = struct_fiz2nb10;
				*(long*)num16 = struct_fiz2nb11.field_0;
				byte* num17 = (byte*)(&y2) + 8u;
				Struct_fiz2nb struct_fiz2nb12 = struct_fiz2nb10;
				*(long*)num17 = struct_fiz2nb12.field_1;
				if (NumericHelper.IntCmpUlt(x3, y2))
				{
					llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi3, &fputil_FPBits_ubgsi4, 16L, isVolatile: false);
				}
				else
				{
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
					Struct_fiz2nb struct_fiz2nb13 = FPRepSem_fputil_FPType_3_fputil_FPBits_float128_zero.Invoke(anon_izyfb8.val);
					Int128* ptr = &fputil_FPBits_ubgsi3.val.Data.FPStorage.field_0;
					Struct_fiz2nb struct_fiz2nb14 = struct_fiz2nb13;
					((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb14.field_0;
					Struct_fiz2nb struct_fiz2nb15 = struct_fiz2nb13;
					((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb15.field_1;
				}
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = (ushort)FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_biased_exponent.Invoke(&fputil_FPBits_ubgsi4);
				llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = (ushort)FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_biased_exponent.Invoke(&fputil_FPBits_ubgsi5);
				if (details_expects_bool_condition_bool.Invoke(num2 > 112 && checked(num - num2) <= 15, expected: true))
				{
					llvm_lifetime_start_p0.Invoke(16L, &x);
					Struct_fiz2nb struct_fiz2nb16 = FPRepSem_fputil_FPType_3_fputil_FPBits_float128_get_explicit_mantissa.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi4));
					Int128* num18 = &int3;
					Struct_fiz2nb struct_fiz2nb17 = struct_fiz2nb16;
					*(long*)num18 = struct_fiz2nb17.field_0;
					byte* num19 = (byte*)(&int3) + 8u;
					Struct_fiz2nb struct_fiz2nb18 = struct_fiz2nb16;
					*(long*)num19 = struct_fiz2nb18.field_1;
					x = int3;
					llvm_lifetime_start_p0.Invoke(16L, &y3);
					Struct_fiz2nb struct_fiz2nb19 = FPRepSem_fputil_FPType_3_fputil_FPBits_float128_get_explicit_mantissa.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi5));
					Int128* num20 = &int4;
					Struct_fiz2nb struct_fiz2nb20 = struct_fiz2nb19;
					*(long*)num20 = struct_fiz2nb20.field_0;
					byte* num21 = (byte*)(&int4) + 8u;
					Struct_fiz2nb struct_fiz2nb21 = struct_fiz2nb19;
					*(long*)num21 = struct_fiz2nb21.field_1;
					y3 = int4;
					llvm_lifetime_start_p0.Invoke(16L, &int5);
					int5 = ((num != num2) ? NumericHelper.RemainderUnsigned(NumericHelper.ShiftLeft(x, (Int128)(UInt128)(uint)checked(num - num2)), y3) : NumericHelper.Subtract(x, y3));
					if (NumericHelper.IntCmpEq(int5, 0L))
					{
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
						Struct_fiz2nb struct_fiz2nb22 = FPRepSem_fputil_FPType_3_fputil_FPBits_float128_zero.Invoke(anon_izyfb9.val);
						Int128* ptr2 = &fputil_FPBits_ubgsi3.val.Data.FPStorage.field_0;
						Struct_fiz2nb struct_fiz2nb23 = struct_fiz2nb22;
						((Struct_fiz2nb*)ptr2)->field_0 = struct_fiz2nb23.field_0;
						Struct_fiz2nb struct_fiz2nb24 = struct_fiz2nb22;
						((Struct_fiz2nb*)ptr2)->field_1 = struct_fiz2nb24.field_1;
					}
					else
					{
						Int128 int21 = int5;
						int result = checked(num2 - 1);
						int6 = int21;
						Struct_fiz2nb struct_fiz2nb25 = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_make_value.Invoke(*(long*)(&int6), ((long*)(&int6))[1], result);
						Int128* ptr3 = &fputil_FPBits_ubgsi3.val.Data.FPStorage.field_0;
						Struct_fiz2nb struct_fiz2nb26 = struct_fiz2nb25;
						((Struct_fiz2nb*)ptr3)->field_0 = struct_fiz2nb26.field_0;
						Struct_fiz2nb struct_fiz2nb27 = struct_fiz2nb25;
						((Struct_fiz2nb*)ptr3)->field_1 = struct_fiz2nb27.field_1;
					}
					llvm_lifetime_end_p0.Invoke(16L, &int5);
					llvm_lifetime_end_p0.Invoke(16L, &y3);
					llvm_lifetime_end_p0.Invoke(16L, &x);
				}
				else if (details_expects_bool_condition_bool.Invoke(num == 0 && num2 == 0, expected: false))
				{
					*(Int128*)(&fputil_FPBits_ubgsi3) = -6148914691236517206L;
					FPBits_float128_Constructor.Invoke(&fputil_FPBits_ubgsi3);
					Struct_fiz2nb struct_fiz2nb28 = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_uintval.Invoke(&fputil_FPBits_ubgsi4);
					Int128* num22 = &int7;
					Struct_fiz2nb struct_fiz2nb29 = struct_fiz2nb28;
					*(long*)num22 = struct_fiz2nb29.field_0;
					byte* num23 = (byte*)(&int7) + 8u;
					Struct_fiz2nb struct_fiz2nb30 = struct_fiz2nb28;
					*(long*)num23 = struct_fiz2nb30.field_1;
					Int128 x4 = int7;
					Struct_fiz2nb struct_fiz2nb31 = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_uintval.Invoke(&fputil_FPBits_ubgsi5);
					Int128* num24 = &y4;
					Struct_fiz2nb struct_fiz2nb32 = struct_fiz2nb31;
					*(long*)num24 = struct_fiz2nb32.field_0;
					byte* num25 = (byte*)(&y4) + 8u;
					Struct_fiz2nb struct_fiz2nb33 = struct_fiz2nb31;
					*(long*)num25 = struct_fiz2nb33.field_1;
					int8 = NumericHelper.RemainderUnsigned(x4, y4);
					FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_set_mantissa.Invoke(&fputil_FPBits_ubgsi3, *(long*)(&int8), ((long*)(&int8))[1]);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(16L, &int9);
					Struct_fiz2nb struct_fiz2nb34 = FPRepSem_fputil_FPType_3_fputil_FPBits_float128_get_explicit_mantissa.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi4));
					Int128* num26 = &int10;
					Struct_fiz2nb struct_fiz2nb35 = struct_fiz2nb34;
					*(long*)num26 = struct_fiz2nb35.field_0;
					byte* num27 = (byte*)(&int10) + 8u;
					Struct_fiz2nb struct_fiz2nb36 = struct_fiz2nb34;
					*(long*)num27 = struct_fiz2nb36.field_1;
					int9 = int10;
					num = checked(num + -1);
					llvm_lifetime_start_p0.Invoke(16L, &int11);
					Struct_fiz2nb struct_fiz2nb37 = FPRepSem_fputil_FPType_3_fputil_FPBits_float128_get_explicit_mantissa.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi5));
					Int128* num28 = &int12;
					Struct_fiz2nb struct_fiz2nb38 = struct_fiz2nb37;
					*(long*)num28 = struct_fiz2nb38.field_0;
					byte* num29 = (byte*)(&int12) + 8u;
					Struct_fiz2nb struct_fiz2nb39 = struct_fiz2nb37;
					*(long*)num29 = struct_fiz2nb39.field_1;
					int11 = int12;
					llvm_lifetime_start_p0.Invoke(4L, &num3);
					num3 = 15;
					llvm_lifetime_start_p0.Invoke(4L, &num4);
					num4 = 15;
					if (details_expects_bool_condition_bool.Invoke(num2 > 0, expected: true))
					{
						num2 = checked(num2 + -1);
					}
					else
					{
						Struct_fiz2nb struct_fiz2nb40 = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_mantissa.Invoke(&fputil_FPBits_ubgsi5);
						Int128* num30 = &int13;
						Struct_fiz2nb struct_fiz2nb41 = struct_fiz2nb40;
						*(long*)num30 = struct_fiz2nb41.field_0;
						byte* num31 = (byte*)(&int13) + 8u;
						Struct_fiz2nb struct_fiz2nb42 = struct_fiz2nb40;
						*(long*)num31 = struct_fiz2nb42.field_1;
						int11 = int13;
						int14 = int11;
						num4 = cpp_countl_zero_unsigned_int128.Invoke(*(long*)(&int14), ((long*)(&int14))[1]);
					}
					llvm_lifetime_start_p0.Invoke(4L, &num5);
					int15 = int11;
					num5 = cpp_countr_zero_unsigned_int128.Invoke(*(long*)(&int15), ((long*)(&int15))[1]);
					llvm_lifetime_start_p0.Invoke(4L, &num6);
					checked
					{
						num6 = num4 + num5;
						llvm_lifetime_start_p0.Invoke(4L, &num7);
						num7 = num - num2;
						llvm_lifetime_start_p0.Invoke(4L, &num8);
						num8 = ((num7 >= num5) ? num5 : num7);
						int11 = NumericHelper.ShiftRightLogical(int11, unchecked((Int128)(UInt128)(uint)num8));
						num7 -= num8;
						num2 += num8;
						llvm_lifetime_end_p0.Invoke(4L, &num8);
						llvm_lifetime_start_p0.Invoke(4L, &num9);
						num9 = ((num7 >= 15) ? 15 : num7);
						int9 = NumericHelper.ShiftLeft(int9, unchecked((Int128)(UInt128)(uint)num9));
						num7 -= num9;
						llvm_lifetime_end_p0.Invoke(4L, &num9);
						int9 = NumericHelper.RemainderUnsigned(int9, int11);
					}
					if (details_expects_bool_condition_bool.Invoke(NumericHelper.IntCmpEq(int9, 0L), expected: false))
					{
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, Sign_POS.Pointer, 1L, isVolatile: false);
						Struct_fiz2nb struct_fiz2nb43 = FPRepSem_fputil_FPType_3_fputil_FPBits_float128_zero.Invoke(anon_izyfb10.val);
						Int128* ptr4 = &fputil_FPBits_ubgsi3.val.Data.FPStorage.field_0;
						Struct_fiz2nb struct_fiz2nb44 = struct_fiz2nb43;
						((Struct_fiz2nb*)ptr4)->field_0 = struct_fiz2nb44.field_0;
						Struct_fiz2nb struct_fiz2nb45 = struct_fiz2nb43;
						((Struct_fiz2nb*)ptr4)->field_1 = struct_fiz2nb45.field_1;
					}
					else if (num7 == 0)
					{
						Int128 int22 = int9;
						int result2 = num2;
						int16 = int22;
						Struct_fiz2nb struct_fiz2nb46 = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_make_value.Invoke(*(long*)(&int16), ((long*)(&int16))[1], result2);
						Int128* ptr5 = &fputil_FPBits_ubgsi3.val.Data.FPStorage.field_0;
						Struct_fiz2nb struct_fiz2nb47 = struct_fiz2nb46;
						((Struct_fiz2nb*)ptr5)->field_0 = struct_fiz2nb47.field_0;
						Struct_fiz2nb struct_fiz2nb48 = struct_fiz2nb46;
						((Struct_fiz2nb*)ptr5)->field_1 = struct_fiz2nb48.field_1;
					}
					else
					{
						int exp_diff = num7;
						int sides_zeroes_count = num6;
						Int128 int23 = int9;
						Int128 int24 = int11;
						int17 = int23;
						long x5 = *(long*)(&int17);
						long y5 = ((long*)(&int17))[1];
						int18 = int24;
						Struct_fiz2nb struct_fiz2nb49 = FModDivisionSimpleHelper_unsigned_int128_execute.Invoke(exp_diff, sides_zeroes_count, x5, y5, *(long*)(&int18), ((long*)(&int18))[1]);
						Int128* num32 = &int19;
						Struct_fiz2nb struct_fiz2nb50 = struct_fiz2nb49;
						*(long*)num32 = struct_fiz2nb50.field_0;
						byte* num33 = (byte*)(&int19) + 8u;
						Struct_fiz2nb struct_fiz2nb51 = struct_fiz2nb49;
						*(long*)num33 = struct_fiz2nb51.field_1;
						int9 = int19;
						Int128 int25 = int9;
						int result3 = num2;
						int20 = int25;
						Struct_fiz2nb struct_fiz2nb52 = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_make_value.Invoke(*(long*)(&int20), ((long*)(&int20))[1], result3);
						Int128* ptr6 = &fputil_FPBits_ubgsi3.val.Data.FPStorage.field_0;
						Struct_fiz2nb struct_fiz2nb53 = struct_fiz2nb52;
						((Struct_fiz2nb*)ptr6)->field_0 = struct_fiz2nb53.field_0;
						Struct_fiz2nb struct_fiz2nb54 = struct_fiz2nb52;
						((Struct_fiz2nb*)ptr6)->field_1 = struct_fiz2nb54.field_1;
					}
					llvm_lifetime_end_p0.Invoke(4L, &num7);
					llvm_lifetime_end_p0.Invoke(4L, &num6);
					llvm_lifetime_end_p0.Invoke(4L, &num5);
					llvm_lifetime_end_p0.Invoke(4L, &num4);
					llvm_lifetime_end_p0.Invoke(4L, &num3);
					llvm_lifetime_end_p0.Invoke(16L, &int11);
					llvm_lifetime_end_p0.Invoke(16L, &int9);
				}
				llvm_lifetime_end_p0.Invoke(4L, &num2);
				llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			return *(Struct_fiz2nb*)(&fputil_FPBits_ubgsi3.val.Data.FPStorage.field_0);
		}
	}
}

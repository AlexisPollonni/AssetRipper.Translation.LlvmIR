using System.Runtime.CompilerServices;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_118powf_double_doubleEidddRKNS_10NumberPairIdEE")]
[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::powf_double_double(int, double, double, double, __llvm_libc_20_1_2_::NumberPair<double> const&)")]
internal static partial class anonymous_namespace_powf_double_double_int_double_double_double_NumberPair_double_const
{
	public unsafe static double Invoke(int idx_x, double dx, double y6, double lo6_hi, NumberPair* exp2_hi_mid)
	{
		int num = 0;
		double num2 = 0.0;
		InlineArray6_NumberPair inlineArray6_NumberPair = default(InlineArray6_NumberPair);
		NumberPair numberPair = default(NumberPair);
		NumberPair numberPair2 = default(NumberPair);
		NumberPair numberPair3 = default(NumberPair);
		NumberPair numberPair4 = default(NumberPair);
		NumberPair numberPair5 = default(NumberPair);
		NumberPair numberPair6 = default(NumberPair);
		NumberPair numberPair7 = default(NumberPair);
		NumberPair numberPair8 = default(NumberPair);
		NumberPair numberPair9 = default(NumberPair);
		InlineArray10_NumberPair inlineArray10_NumberPair = default(InlineArray10_NumberPair);
		NumberPair numberPair10 = default(NumberPair);
		NumberPair numberPair11 = default(NumberPair);
		NumberPair numberPair12 = default(NumberPair);
		long num3 = 0L;
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(4L, &num);
		unchecked
		{
			num = (int)fputil_nearest_integer_double.Invoke(fputil_multiply_add_double_double_double.Invoke(dx, 16384.0, 64.0));
			llvm_lifetime_start_p0.Invoke(8L, &num2);
			double x = 1.0 + dx;
			long num4 = num;
			num2 = fputil_multiply_add_double_double_double.Invoke(x, ((double*)R2.Pointer)[num4], -1.0);
			llvm_lifetime_start_p0.Invoke(96L, &inlineArray6_NumberPair);
			llvm_memcpy_p0_p0_i64.Invoke(&inlineArray6_NumberPair, COEFFS_yazmcg.Pointer, 96L, isVolatile: false);
			llvm_lifetime_start_p0.Invoke(16L, &numberPair);
			*(double*)(&numberPair) = double.NaN;
			((double*)(&numberPair))[1] = double.NaN;
			numberPair.lo = 0.0;
			numberPair.hi = num2;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair2);
			*(double*)(&numberPair2) = double.NaN;
			((double*)(&numberPair2))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja = cpp_enable_if_sizeof_NumberPair_double_8ul_NumberPair_double_type_fputil_polyeval_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_const_NumberPair_double_const_NumberPair_double_const_NumberPair_double_const_NumberPair_double_const_NumberPair_double_const_NumberPair_double_const.Invoke(&numberPair, (NumberPair*)(&inlineArray6_NumberPair), (NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray6_NumberPair, sizeof(NumberPair))), (NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray6_NumberPair, (nint)2 * sizeof(NumberPair))), (NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray6_NumberPair, (nint)3 * sizeof(NumberPair))), (NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray6_NumberPair, (nint)4 * sizeof(NumberPair))), (NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray6_NumberPair, (nint)5 * sizeof(NumberPair))));
			NumberPair* num5 = &numberPair2;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num5 = struct_4ydhja2.field_0;
			byte* num6 = (byte*)(&numberPair2) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num6 = struct_4ydhja3.field_1;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair3);
			*(double*)(&numberPair3) = double.NaN;
			((double*)(&numberPair3))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja4 = fputil_quick_mult_double_NumberPair_double_const.Invoke(num2, &numberPair2);
			NumberPair* num7 = &numberPair3;
			Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
			*(double*)num7 = struct_4ydhja5.field_0;
			byte* num8 = (byte*)(&numberPair3) + 8u;
			Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
			*(double*)num8 = struct_4ydhja6.field_1;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair4);
			*(double*)(&numberPair4) = double.NaN;
			((double*)(&numberPair4))[1] = double.NaN;
			numberPair4.lo = ((fputil_TripleDouble*)anonymous_namespace_LOG2_R_TD.Pointer)[idx_x].lo;
			numberPair4.hi = ((fputil_TripleDouble*)anonymous_namespace_LOG2_R_TD.Pointer)[idx_x].mid;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair5);
			*(double*)(&numberPair5) = double.NaN;
			((double*)(&numberPair5))[1] = double.NaN;
			long num9 = num;
			Struct_4ydhja struct_4ydhja7 = fputil_add_NumberPair_double_const_NumberPair_double_const.Invoke((NumberPair*)anonymous_namespace_LOG2_R2_DD.Pointer + num9, &numberPair4);
			NumberPair* num10 = &numberPair5;
			Struct_4ydhja struct_4ydhja8 = struct_4ydhja7;
			*(double*)num10 = struct_4ydhja8.field_0;
			byte* num11 = (byte*)(&numberPair5) + 8u;
			Struct_4ydhja struct_4ydhja9 = struct_4ydhja7;
			*(double*)num11 = struct_4ydhja9.field_1;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair6);
			*(double*)(&numberPair6) = double.NaN;
			((double*)(&numberPair6))[1] = double.NaN;
			if (anonymous_namespace_larger_exponent_double_double.Invoke(numberPair5.hi, numberPair3.hi))
			{
				Struct_4ydhja struct_4ydhja10 = fputil_add_NumberPair_double_const_NumberPair_double_const.Invoke(&numberPair5, &numberPair3);
				NumberPair* num12 = &numberPair6;
				Struct_4ydhja struct_4ydhja11 = struct_4ydhja10;
				*(double*)num12 = struct_4ydhja11.field_0;
				byte* num13 = (byte*)(&numberPair6) + 8u;
				Struct_4ydhja struct_4ydhja12 = struct_4ydhja10;
				*(double*)num13 = struct_4ydhja12.field_1;
			}
			else
			{
				Struct_4ydhja struct_4ydhja13 = fputil_add_NumberPair_double_const_NumberPair_double_const.Invoke(&numberPair3, &numberPair5);
				NumberPair* num14 = &numberPair6;
				Struct_4ydhja struct_4ydhja14 = struct_4ydhja13;
				*(double*)num14 = struct_4ydhja14.field_0;
				byte* num15 = (byte*)(&numberPair6) + 8u;
				Struct_4ydhja struct_4ydhja15 = struct_4ydhja13;
				*(double*)num15 = struct_4ydhja15.field_1;
			}
			llvm_lifetime_start_p0.Invoke(16L, &numberPair7);
			*(double*)(&numberPair7) = double.NaN;
			((double*)(&numberPair7))[1] = double.NaN;
			numberPair7.lo = 0.0;
			numberPair7.hi = lo6_hi;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair8);
			*(double*)(&numberPair8) = double.NaN;
			((double*)(&numberPair8))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja16 = fputil_quick_mult_double_NumberPair_double_const.Invoke(y6, &numberPair6);
			NumberPair* num16 = &numberPair8;
			Struct_4ydhja struct_4ydhja17 = struct_4ydhja16;
			*(double*)num16 = struct_4ydhja17.field_0;
			byte* num17 = (byte*)(&numberPair8) + 8u;
			Struct_4ydhja struct_4ydhja18 = struct_4ydhja16;
			*(double*)num17 = struct_4ydhja18.field_1;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair9);
			*(double*)(&numberPair9) = double.NaN;
			((double*)(&numberPair9))[1] = double.NaN;
			if (anonymous_namespace_larger_exponent_double_double.Invoke(numberPair8.hi, lo6_hi))
			{
				Struct_4ydhja struct_4ydhja19 = fputil_add_NumberPair_double_const_NumberPair_double_const.Invoke(&numberPair8, &numberPair7);
				NumberPair* num18 = &numberPair9;
				Struct_4ydhja struct_4ydhja20 = struct_4ydhja19;
				*(double*)num18 = struct_4ydhja20.field_0;
				byte* num19 = (byte*)(&numberPair9) + 8u;
				Struct_4ydhja struct_4ydhja21 = struct_4ydhja19;
				*(double*)num19 = struct_4ydhja21.field_1;
			}
			else
			{
				Struct_4ydhja struct_4ydhja22 = fputil_add_NumberPair_double_const_NumberPair_double_const.Invoke(&numberPair7, &numberPair8);
				NumberPair* num20 = &numberPair9;
				Struct_4ydhja struct_4ydhja23 = struct_4ydhja22;
				*(double*)num20 = struct_4ydhja23.field_0;
				byte* num21 = (byte*)(&numberPair9) + 8u;
				Struct_4ydhja struct_4ydhja24 = struct_4ydhja22;
				*(double*)num21 = struct_4ydhja24.field_1;
			}
			llvm_lifetime_start_p0.Invoke(160L, &inlineArray10_NumberPair);
			llvm_memcpy_p0_p0_i64.Invoke(&inlineArray10_NumberPair, EXP2_COEFFS.Pointer, 160L, isVolatile: false);
			llvm_lifetime_start_p0.Invoke(16L, &numberPair10);
			*(double*)(&numberPair10) = double.NaN;
			((double*)(&numberPair10))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja25 = cpp_enable_if_sizeof_NumberPair_double_8ul_NumberPair_double_type_fputil_polyeval_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_const_NumberPair_double_const_NumberPair_double_const_NumberPair_double_const_NumberPair_double_const_NumberPair_double_const_NumberPair_double_const_NumberPair_double_const_NumberPair_double_const_NumberPair_double_const_NumberPair_double_const.Invoke(&numberPair9, (NumberPair*)(&inlineArray10_NumberPair), (NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray10_NumberPair, sizeof(NumberPair))), (NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray10_NumberPair, (nint)2 * sizeof(NumberPair))), (NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray10_NumberPair, (nint)3 * sizeof(NumberPair))), (NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray10_NumberPair, (nint)4 * sizeof(NumberPair))), (NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray10_NumberPair, (nint)5 * sizeof(NumberPair))), (NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray10_NumberPair, (nint)6 * sizeof(NumberPair))), (NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray10_NumberPair, (nint)7 * sizeof(NumberPair))), (NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray10_NumberPair, (nint)8 * sizeof(NumberPair))), (NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray10_NumberPair, (nint)9 * sizeof(NumberPair))));
			NumberPair* num22 = &numberPair10;
			Struct_4ydhja struct_4ydhja26 = struct_4ydhja25;
			*(double*)num22 = struct_4ydhja26.field_0;
			byte* num23 = (byte*)(&numberPair10) + 8u;
			Struct_4ydhja struct_4ydhja27 = struct_4ydhja25;
			*(double*)num23 = struct_4ydhja27.field_1;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair11);
			*(double*)(&numberPair11) = double.NaN;
			((double*)(&numberPair11))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja28 = NumberPair_double_fputil_quick_mult_27ul_NumberPair_double_const_NumberPair_double_const.Invoke(exp2_hi_mid, &numberPair10);
			NumberPair* num24 = &numberPair11;
			Struct_4ydhja struct_4ydhja29 = struct_4ydhja28;
			*(double*)num24 = struct_4ydhja29.field_0;
			byte* num25 = (byte*)(&numberPair11) + 8u;
			Struct_4ydhja struct_4ydhja30 = struct_4ydhja28;
			*(double*)num25 = struct_4ydhja30.field_1;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair12);
			*(double*)(&numberPair12) = double.NaN;
			((double*)(&numberPair12))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja31 = NumberPair_double_fputil_exact_add_true_double_double.Invoke(numberPair11.hi, numberPair11.lo);
			NumberPair* num26 = &numberPair12;
			Struct_4ydhja struct_4ydhja32 = struct_4ydhja31;
			*(double*)num26 = struct_4ydhja32.field_0;
			byte* num27 = (byte*)(&numberPair12) + 8u;
			Struct_4ydhja struct_4ydhja33 = struct_4ydhja31;
			*(double*)num27 = struct_4ydhja33.field_1;
			llvm_lifetime_start_p0.Invoke(8L, &num3);
			num3 = cpp_enable_if_sizeof_unsigned_long_sizeof_double_cpp_is_trivially_constructible_unsigned_long_value_cpp_is_trivially_copyable_unsigned_long_value_cpp_is_trivially_copyable_double_value_unsigned_long_type_cpp_bit_cast_unsigned_long_double_double_const.Invoke(&numberPair12.hi);
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((num3 & 0xFFFFFFFL) == 0L && NumericHelper.IsUnorderedOrNotEquals(numberPair12.lo, 0.0), expected: false))
			{
				llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
				*(sbyte*)(&anon_izyfb8) = -86;
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
				fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm2, numberPair12.hi);
				anon_izyfb8.val = fputil_internal_FPStorage_fputil_FPType_2_sign_const.Invoke(&fputil_FPBits_wjhbrm2);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
				llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb9);
				*(sbyte*)(&anon_izyfb9) = -86;
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
				fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm3, numberPair12.lo);
				anon_izyfb9.val = fputil_internal_FPStorage_fputil_FPType_2_sign_const.Invoke(&fputil_FPBits_wjhbrm3);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, &anon_izyfb8, 1L, isVolatile: false);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, &anon_izyfb9, 1L, isVolatile: false);
				if (operator_Sign_Sign_fy8fvt.Invoke(anon_izyfb10.val, anon_izyfb11.val))
				{
					num3++;
				}
				else if ((ulong)(num3 & 0xFFFFFFFFFFFFFL) > 0uL)
				{
					num3 += -1L;
				}
				llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb9);
				llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
			}
			double result = cpp_enable_if_sizeof_double_sizeof_unsigned_long_cpp_is_trivially_constructible_double_value_cpp_is_trivially_copyable_double_value_cpp_is_trivially_copyable_unsigned_long_value_double_type_cpp_bit_cast_double_unsigned_long_unsigned_long_const.Invoke(&num3);
			llvm_lifetime_end_p0.Invoke(8L, &num3);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair12);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair11);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair10);
			llvm_lifetime_end_p0.Invoke(160L, &inlineArray10_NumberPair);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair9);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair8);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair7);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair6);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair5);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair4);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair3);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair2);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair);
			llvm_lifetime_end_p0.Invoke(96L, &inlineArray6_NumberPair);
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}

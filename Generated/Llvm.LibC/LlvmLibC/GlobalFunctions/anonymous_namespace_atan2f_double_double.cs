using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class anonymous_namespace_atan2f_double_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_120atan2f_double_doubleEdddiddRKNS_10NumberPairIdEE")]
	[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::atan2f_double_double(double, double, double, int, double, double, __llvm_libc_20_1_2_::NumberPair<double> const&)")]
	public unsafe static float Invoke([NativeType("double")] double num_d, [NativeType("double")] double den_d, [NativeType("double")] double q_d, [NativeType("int")] int idx, [NativeType("double")] double k_d, [NativeType("double")] double final_sign, [NativeType("__llvm_libc_20_1_2_::NumberPair<double> const&")] NumberPair* const_term)
	{
		NumberPair numberPair = default(NumberPair);
		double num = 0.0;
		double num2 = 0.0;
		NumberPair numberPair2 = default(NumberPair);
		double z = 0.0;
		double num3 = 0.0;
		NumberPair numberPair3 = default(NumberPair);
		NumberPair numberPair4 = default(NumberPair);
		NumberPair numberPair5 = default(NumberPair);
		NumberPair numberPair6 = default(NumberPair);
		NumberPair numberPair7 = default(NumberPair);
		long num4 = 0L;
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		double num5 = k_d;
		llvm_lifetime_start_p0.Invoke(16L, &numberPair);
		unchecked
		{
			*(double*)(&numberPair) = double.NaN;
			((double*)(&numberPair))[1] = double.NaN;
			NumberPair_double_Constructor.Invoke(&numberPair);
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = double.NaN;
			llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = double.NaN;
			if (idx != 0)
			{
				num5 *= 0.0625;
				num = fputil_multiply_add_double.Invoke(num5, 0.0 - den_d, num_d);
				num2 = fputil_multiply_add_double.Invoke(num5, num_d, den_d);
				numberPair.hi = num / num2;
			}
			else
			{
				numberPair.hi = q_d;
				num = num_d;
				num2 = den_d;
			}
			llvm_lifetime_start_p0.Invoke(16L, &numberPair2);
			*(double*)(&numberPair2) = double.NaN;
			((double*)(&numberPair2))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja = anonymous_namespace_split_d.Invoke(numberPair.hi);
			NumberPair* num6 = &numberPair2;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num6 = struct_4ydhja2.field_0;
			byte* num7 = (byte*)(&numberPair2) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num7 = struct_4ydhja3.field_1;
			llvm_lifetime_start_p0.Invoke(8L, &z);
			z = fputil_multiply_add_double.Invoke(numberPair2.hi, 0.0 - num2, num);
			llvm_lifetime_start_p0.Invoke(8L, &num3);
			num3 = fputil_multiply_add_double.Invoke(numberPair2.lo, 0.0 - num2, z);
			numberPair.lo = num3 / num2;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair3);
			*(double*)(&numberPair3) = double.NaN;
			((double*)(&numberPair3))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja4 = fputil_quick_mult_27ul.Invoke(&numberPair, &numberPair);
			NumberPair* num8 = &numberPair3;
			Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
			*(double*)num8 = struct_4ydhja5.field_0;
			byte* num9 = (byte*)(&numberPair3) + 8u;
			Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
			*(double*)num9 = struct_4ydhja6.field_1;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair4);
			*(double*)(&numberPair4) = double.NaN;
			((double*)(&numberPair4))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja7 = fputil_polyeval_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double.Invoke(&numberPair3, (NumberPair*)anonymous_namespace_COEFFS_61.Pointer, (NumberPair*)anonymous_namespace_COEFFS_61.Pointer + 1, (NumberPair*)anonymous_namespace_COEFFS_61.Pointer + 2L, (NumberPair*)anonymous_namespace_COEFFS_61.Pointer + 3L, (NumberPair*)anonymous_namespace_COEFFS_61.Pointer + 4L, (NumberPair*)anonymous_namespace_COEFFS_61.Pointer + 5L, (NumberPair*)anonymous_namespace_COEFFS_61.Pointer + 6L, (NumberPair*)anonymous_namespace_COEFFS_61.Pointer + 7L, (NumberPair*)anonymous_namespace_COEFFS_61.Pointer + 8L);
			NumberPair* num10 = &numberPair4;
			Struct_4ydhja struct_4ydhja8 = struct_4ydhja7;
			*(double*)num10 = struct_4ydhja8.field_0;
			byte* num11 = (byte*)(&numberPair4) + 8u;
			Struct_4ydhja struct_4ydhja9 = struct_4ydhja7;
			*(double*)num11 = struct_4ydhja9.field_1;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair5);
			*(double*)(&numberPair5) = double.NaN;
			((double*)(&numberPair5))[1] = double.NaN;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair6);
			Struct_4ydhja struct_4ydhja10 = fputil_multiply_add_NumberPair_double.Invoke(&numberPair, &numberPair4, (NumberPair*)anonymous_namespace_ATAN_I.Pointer + idx);
			NumberPair* num12 = &numberPair6;
			Struct_4ydhja struct_4ydhja11 = struct_4ydhja10;
			*(double*)num12 = struct_4ydhja11.field_0;
			byte* num13 = (byte*)(&numberPair6) + 8u;
			Struct_4ydhja struct_4ydhja12 = struct_4ydhja10;
			*(double*)num13 = struct_4ydhja12.field_1;
			Struct_4ydhja struct_4ydhja13 = fputil_add.Invoke(const_term, &numberPair6);
			NumberPair* num14 = &numberPair5;
			Struct_4ydhja struct_4ydhja14 = struct_4ydhja13;
			*(double*)num14 = struct_4ydhja14.field_0;
			byte* num15 = (byte*)(&numberPair5) + 8u;
			Struct_4ydhja struct_4ydhja15 = struct_4ydhja13;
			*(double*)num15 = struct_4ydhja15.field_1;
			llvm_lifetime_end_p0.Invoke(16L, &numberPair6);
			numberPair5.hi *= final_sign;
			numberPair5.lo *= final_sign;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair7);
			*(double*)(&numberPair7) = double.NaN;
			((double*)(&numberPair7))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja16 = fputil_exact_add_true.Invoke(numberPair5.hi, numberPair5.lo);
			NumberPair* num16 = &numberPair7;
			Struct_4ydhja struct_4ydhja17 = struct_4ydhja16;
			*(double*)num16 = struct_4ydhja17.field_0;
			byte* num17 = (byte*)(&numberPair7) + 8u;
			Struct_4ydhja struct_4ydhja18 = struct_4ydhja16;
			*(double*)num17 = struct_4ydhja18.field_1;
			llvm_lifetime_start_p0.Invoke(8L, &num4);
			num4 = cpp_bit_cast_unsigned_long_double.Invoke(&numberPair7.hi);
			if (details_expects_bool_condition_bool.Invoke((num4 & 0xFFFFFFFL) == 0L && NumericHelper.IsUnorderedOrNotEquals(numberPair7.lo, 0.0), expected: false))
			{
				llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
				*(sbyte*)(&anon_izyfb8) = -86;
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
				FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm2, numberPair7.hi);
				anon_izyfb8.val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm2);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
				llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb9);
				*(sbyte*)(&anon_izyfb9) = -86;
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
				FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm3, numberPair7.lo);
				anon_izyfb9.val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm3);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, &anon_izyfb8, 1L, isVolatile: false);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, &anon_izyfb9, 1L, isVolatile: false);
				if (Equals_fy8fvt.Invoke(anon_izyfb10.val, anon_izyfb11.val))
				{
					num4++;
				}
				else if ((ulong)(num4 & 0xFFFFFFFFFFFFFL) > 0uL)
				{
					num4 += -1L;
				}
				llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb9);
				llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
			}
			float result = (float)cpp_bit_cast_double_unsigned_long.Invoke(&num4);
			llvm_lifetime_end_p0.Invoke(8L, &num4);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair7);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair5);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair4);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair3);
			llvm_lifetime_end_p0.Invoke(8L, &num3);
			llvm_lifetime_end_p0.Invoke(8L, &z);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair2);
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair);
			return result;
		}
	}
}

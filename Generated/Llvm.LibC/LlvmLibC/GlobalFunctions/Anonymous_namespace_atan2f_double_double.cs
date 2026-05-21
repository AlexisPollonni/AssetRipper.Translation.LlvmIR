using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Anonymous_namespace_atan2f_double_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_120atan2f_double_doubleEdddiddRKNS_10NumberPairIdEE")]
	[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::atan2f_double_double(double, double, double, int, double, double, __llvm_libc_20_1_2_::NumberPair<double> const&)")]
	public unsafe static float Invoke([MangledName("num_d")][NativeType("double")] double Num_d, [MangledName("den_d")][NativeType("double")] double Den_d, [MangledName("q_d")][NativeType("double")] double Q_d, [MangledName("idx")][NativeType("int")] int Idx, [MangledName("k_d")][NativeType("double")] double K_d, [MangledName("final_sign")][NativeType("double")] double Final_sign, [MangledName("const_term")][NativeType("__llvm_libc_20_1_2_::NumberPair<double> const&")] Llvm_libc_20_1_2_NumberPair* Const_term)
	{
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair = default(Llvm_libc_20_1_2_NumberPair);
		double num = 0.0;
		double num2 = 0.0;
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair2 = default(Llvm_libc_20_1_2_NumberPair);
		double z = 0.0;
		double num3 = 0.0;
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair3 = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair4 = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair5 = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair6 = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair7 = default(Llvm_libc_20_1_2_NumberPair);
		long num4 = 0L;
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm2 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		double num5 = K_d;
		Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair);
		unchecked
		{
			*(double*)(&llvm_libc_20_1_2_NumberPair) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair))[1] = double.NaN;
			NumberPair_double_Constructor.Invoke(&llvm_libc_20_1_2_NumberPair);
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = double.NaN;
			Llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = double.NaN;
			if (Idx != 0)
			{
				num5 *= 0.0625;
				num = Fputil_multiply_add_double.Invoke(num5, 0.0 - Den_d, Num_d);
				num2 = Fputil_multiply_add_double.Invoke(num5, Num_d, Den_d);
				llvm_libc_20_1_2_NumberPair.Hi = num / num2;
			}
			else
			{
				llvm_libc_20_1_2_NumberPair.Hi = Q_d;
				num = Num_d;
				num2 = Den_d;
			}
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair2);
			*(double*)(&llvm_libc_20_1_2_NumberPair2) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair2))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja = Anonymous_namespace_split_d.Invoke(llvm_libc_20_1_2_NumberPair.Hi);
			Llvm_libc_20_1_2_NumberPair* num6 = &llvm_libc_20_1_2_NumberPair2;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num6 = struct_4ydhja2.field_0;
			byte* num7 = (byte*)(&llvm_libc_20_1_2_NumberPair2) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num7 = struct_4ydhja3.field_1;
			Llvm_lifetime_start_p0.Invoke(8L, &z);
			z = Fputil_multiply_add_double.Invoke(llvm_libc_20_1_2_NumberPair2.Hi, 0.0 - num2, num);
			Llvm_lifetime_start_p0.Invoke(8L, &num3);
			num3 = Fputil_multiply_add_double.Invoke(llvm_libc_20_1_2_NumberPair2.Lo, 0.0 - num2, z);
			llvm_libc_20_1_2_NumberPair.Lo = num3 / num2;
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair3);
			*(double*)(&llvm_libc_20_1_2_NumberPair3) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair3))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja4 = Fputil_quick_mult_27ul.Invoke(&llvm_libc_20_1_2_NumberPair, &llvm_libc_20_1_2_NumberPair);
			Llvm_libc_20_1_2_NumberPair* num8 = &llvm_libc_20_1_2_NumberPair3;
			Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
			*(double*)num8 = struct_4ydhja5.field_0;
			byte* num9 = (byte*)(&llvm_libc_20_1_2_NumberPair3) + 8u;
			Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
			*(double*)num9 = struct_4ydhja6.field_1;
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair4);
			*(double*)(&llvm_libc_20_1_2_NumberPair4) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair4))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja7 = Fputil_polyeval_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double.Invoke(&llvm_libc_20_1_2_NumberPair3, (Llvm_libc_20_1_2_NumberPair*)Llvm_libc_20_1_2_anonymous_namespace_COEFFS_61.Pointer, (Llvm_libc_20_1_2_NumberPair*)Llvm_libc_20_1_2_anonymous_namespace_COEFFS_61.Pointer + 1, (Llvm_libc_20_1_2_NumberPair*)Llvm_libc_20_1_2_anonymous_namespace_COEFFS_61.Pointer + 2L, (Llvm_libc_20_1_2_NumberPair*)Llvm_libc_20_1_2_anonymous_namespace_COEFFS_61.Pointer + 3L, (Llvm_libc_20_1_2_NumberPair*)Llvm_libc_20_1_2_anonymous_namespace_COEFFS_61.Pointer + 4L, (Llvm_libc_20_1_2_NumberPair*)Llvm_libc_20_1_2_anonymous_namespace_COEFFS_61.Pointer + 5L, (Llvm_libc_20_1_2_NumberPair*)Llvm_libc_20_1_2_anonymous_namespace_COEFFS_61.Pointer + 6L, (Llvm_libc_20_1_2_NumberPair*)Llvm_libc_20_1_2_anonymous_namespace_COEFFS_61.Pointer + 7L, (Llvm_libc_20_1_2_NumberPair*)Llvm_libc_20_1_2_anonymous_namespace_COEFFS_61.Pointer + 8L);
			Llvm_libc_20_1_2_NumberPair* num10 = &llvm_libc_20_1_2_NumberPair4;
			Struct_4ydhja struct_4ydhja8 = struct_4ydhja7;
			*(double*)num10 = struct_4ydhja8.field_0;
			byte* num11 = (byte*)(&llvm_libc_20_1_2_NumberPair4) + 8u;
			Struct_4ydhja struct_4ydhja9 = struct_4ydhja7;
			*(double*)num11 = struct_4ydhja9.field_1;
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair5);
			*(double*)(&llvm_libc_20_1_2_NumberPair5) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair5))[1] = double.NaN;
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair6);
			Struct_4ydhja struct_4ydhja10 = Fputil_multiply_add_NumberPair_double.Invoke(&llvm_libc_20_1_2_NumberPair, &llvm_libc_20_1_2_NumberPair4, (Llvm_libc_20_1_2_NumberPair*)Llvm_libc_20_1_2_anonymous_namespace_ATAN_I.Pointer + Idx);
			Llvm_libc_20_1_2_NumberPair* num12 = &llvm_libc_20_1_2_NumberPair6;
			Struct_4ydhja struct_4ydhja11 = struct_4ydhja10;
			*(double*)num12 = struct_4ydhja11.field_0;
			byte* num13 = (byte*)(&llvm_libc_20_1_2_NumberPair6) + 8u;
			Struct_4ydhja struct_4ydhja12 = struct_4ydhja10;
			*(double*)num13 = struct_4ydhja12.field_1;
			Struct_4ydhja struct_4ydhja13 = Fputil_add.Invoke(Const_term, &llvm_libc_20_1_2_NumberPair6);
			Llvm_libc_20_1_2_NumberPair* num14 = &llvm_libc_20_1_2_NumberPair5;
			Struct_4ydhja struct_4ydhja14 = struct_4ydhja13;
			*(double*)num14 = struct_4ydhja14.field_0;
			byte* num15 = (byte*)(&llvm_libc_20_1_2_NumberPair5) + 8u;
			Struct_4ydhja struct_4ydhja15 = struct_4ydhja13;
			*(double*)num15 = struct_4ydhja15.field_1;
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair6);
			llvm_libc_20_1_2_NumberPair5.Hi *= Final_sign;
			llvm_libc_20_1_2_NumberPair5.Lo *= Final_sign;
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair7);
			*(double*)(&llvm_libc_20_1_2_NumberPair7) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair7))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja16 = Fputil_exact_add_true.Invoke(llvm_libc_20_1_2_NumberPair5.Hi, llvm_libc_20_1_2_NumberPair5.Lo);
			Llvm_libc_20_1_2_NumberPair* num16 = &llvm_libc_20_1_2_NumberPair7;
			Struct_4ydhja struct_4ydhja17 = struct_4ydhja16;
			*(double*)num16 = struct_4ydhja17.field_0;
			byte* num17 = (byte*)(&llvm_libc_20_1_2_NumberPair7) + 8u;
			Struct_4ydhja struct_4ydhja18 = struct_4ydhja16;
			*(double*)num17 = struct_4ydhja18.field_1;
			Llvm_lifetime_start_p0.Invoke(8L, &num4);
			num4 = Cpp_bit_cast_unsigned_long_double.Invoke(&llvm_libc_20_1_2_NumberPair7.Hi);
			if (Details_expects_bool_condition_bool.Invoke((num4 & 0xFFFFFFFL) == 0L && NumericHelper.IsUnorderedOrNotEquals(llvm_libc_20_1_2_NumberPair7.Lo, 0.0), Expected: false))
			{
				Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb);
				*(sbyte*)(&anon_izyfb) = -86;
				Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
				FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm, llvm_libc_20_1_2_NumberPair7.Hi);
				anon_izyfb.Val = FPStorage_fputil_FPType_2_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
				Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
				Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb2);
				*(sbyte*)(&anon_izyfb2) = -86;
				Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
				FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2, llvm_libc_20_1_2_NumberPair7.Lo);
				anon_izyfb2.Val = FPStorage_fputil_FPType_2_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
				Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb3, &anon_izyfb, 1L, isVolatile: false);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb4, &anon_izyfb2, 1L, isVolatile: false);
				if (Llvm_libc_20_1_2_Equals_fy8fvt.Invoke(anon_izyfb3.Val, anon_izyfb4.Val))
				{
					num4++;
				}
				else if ((ulong)(num4 & 0xFFFFFFFFFFFFFL) > 0uL)
				{
					num4 += -1L;
				}
				Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb2);
				Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb);
			}
			float result = (float)Cpp_bit_cast_double_unsigned_long.Invoke(&num4);
			Llvm_lifetime_end_p0.Invoke(8L, &num4);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair7);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair5);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair4);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair3);
			Llvm_lifetime_end_p0.Invoke(8L, &num3);
			Llvm_lifetime_end_p0.Invoke(8L, &z);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair2);
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair);
			return result;
		}
	}
}

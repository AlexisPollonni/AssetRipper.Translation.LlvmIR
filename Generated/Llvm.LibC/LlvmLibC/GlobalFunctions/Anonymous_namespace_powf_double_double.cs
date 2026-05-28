using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Anonymous_namespace_powf_double_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_118powf_double_doubleEidddRKNS_10NumberPairIdEE")]
	[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::powf_double_double(int, double, double, double, __llvm_libc_20_1_2_::NumberPair<double> const&)")]
	public unsafe static double Invoke([MangledName("idx_x")][NativeType("int")] int Idx_x, [MangledName("dx")][NativeType("double")] double Dx, [MangledName("y6")][NativeType("double")] double Y6, [MangledName("lo6_hi")][NativeType("double")] double Lo6_hi, [MangledName("exp2_hi_mid")][NativeType("__llvm_libc_20_1_2_::NumberPair<double> const&")] NumberPair* Exp2_hi_mid)
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
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		unchecked
		{
			num = (int)Fputil_nearest_integer.Invoke(Fputil_multiply_add_double.Invoke(Dx, 16384.0, 64.0));
			Llvm_lifetime_start_p0.Invoke(8L, &num2);
			double x = 1.0 + Dx;
			long num4 = num;
			num2 = Fputil_multiply_add_double.Invoke(x, ((double*)R2.Pointer)[num4], -1.0);
			Llvm_lifetime_start_p0.Invoke(96L, &inlineArray6_NumberPair);
			Llvm_memcpy_p0_p0_i64.Invoke(&inlineArray6_NumberPair, COEFFS_yazmcg.Pointer, 96L, isVolatile: false);
			Llvm_lifetime_start_p0.Invoke(16L, &numberPair);
			*(double*)(&numberPair) = double.NaN;
			((double*)(&numberPair))[1] = double.NaN;
			numberPair.Lo = 0.0;
			numberPair.Hi = num2;
			Llvm_lifetime_start_p0.Invoke(16L, &numberPair2);
			*(double*)(&numberPair2) = double.NaN;
			((double*)(&numberPair2))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja = Fputil_polyeval_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double.Invoke(&numberPair, (NumberPair*)(&inlineArray6_NumberPair), (NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray6_NumberPair, sizeof(NumberPair))), (NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray6_NumberPair, (nint)2 * sizeof(NumberPair))), (NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray6_NumberPair, (nint)3 * sizeof(NumberPair))), (NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray6_NumberPair, (nint)4 * sizeof(NumberPair))), (NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray6_NumberPair, (nint)5 * sizeof(NumberPair))));
			NumberPair* num5 = &numberPair2;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num5 = struct_4ydhja2.field_0;
			byte* num6 = (byte*)(&numberPair2) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num6 = struct_4ydhja3.field_1;
			Llvm_lifetime_start_p0.Invoke(16L, &numberPair3);
			*(double*)(&numberPair3) = double.NaN;
			((double*)(&numberPair3))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja4 = Fputil_quick_mult.Invoke(num2, &numberPair2);
			NumberPair* num7 = &numberPair3;
			Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
			*(double*)num7 = struct_4ydhja5.field_0;
			byte* num8 = (byte*)(&numberPair3) + 8u;
			Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
			*(double*)num8 = struct_4ydhja6.field_1;
			Llvm_lifetime_start_p0.Invoke(16L, &numberPair4);
			*(double*)(&numberPair4) = double.NaN;
			((double*)(&numberPair4))[1] = double.NaN;
			numberPair4.Lo = ((Fputil_TripleDouble*)Anonymous_namespace_LOG2_R_TD.Pointer)[Idx_x].Lo;
			numberPair4.Hi = ((Fputil_TripleDouble*)Anonymous_namespace_LOG2_R_TD.Pointer)[Idx_x].Mid;
			Llvm_lifetime_start_p0.Invoke(16L, &numberPair5);
			*(double*)(&numberPair5) = double.NaN;
			((double*)(&numberPair5))[1] = double.NaN;
			long num9 = num;
			Struct_4ydhja struct_4ydhja7 = Fputil_add.Invoke((NumberPair*)Anonymous_namespace_LOG2_R2_DD.Pointer + num9, &numberPair4);
			NumberPair* num10 = &numberPair5;
			Struct_4ydhja struct_4ydhja8 = struct_4ydhja7;
			*(double*)num10 = struct_4ydhja8.field_0;
			byte* num11 = (byte*)(&numberPair5) + 8u;
			Struct_4ydhja struct_4ydhja9 = struct_4ydhja7;
			*(double*)num11 = struct_4ydhja9.field_1;
			Llvm_lifetime_start_p0.Invoke(16L, &numberPair6);
			*(double*)(&numberPair6) = double.NaN;
			((double*)(&numberPair6))[1] = double.NaN;
			if (Anonymous_namespace_larger_exponent.Invoke(numberPair5.Hi, numberPair3.Hi))
			{
				Struct_4ydhja struct_4ydhja10 = Fputil_add.Invoke(&numberPair5, &numberPair3);
				NumberPair* num12 = &numberPair6;
				Struct_4ydhja struct_4ydhja11 = struct_4ydhja10;
				*(double*)num12 = struct_4ydhja11.field_0;
				byte* num13 = (byte*)(&numberPair6) + 8u;
				Struct_4ydhja struct_4ydhja12 = struct_4ydhja10;
				*(double*)num13 = struct_4ydhja12.field_1;
			}
			else
			{
				Struct_4ydhja struct_4ydhja13 = Fputil_add.Invoke(&numberPair3, &numberPair5);
				NumberPair* num14 = &numberPair6;
				Struct_4ydhja struct_4ydhja14 = struct_4ydhja13;
				*(double*)num14 = struct_4ydhja14.field_0;
				byte* num15 = (byte*)(&numberPair6) + 8u;
				Struct_4ydhja struct_4ydhja15 = struct_4ydhja13;
				*(double*)num15 = struct_4ydhja15.field_1;
			}
			Llvm_lifetime_start_p0.Invoke(16L, &numberPair7);
			*(double*)(&numberPair7) = double.NaN;
			((double*)(&numberPair7))[1] = double.NaN;
			numberPair7.Lo = 0.0;
			numberPair7.Hi = Lo6_hi;
			Llvm_lifetime_start_p0.Invoke(16L, &numberPair8);
			*(double*)(&numberPair8) = double.NaN;
			((double*)(&numberPair8))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja16 = Fputil_quick_mult.Invoke(Y6, &numberPair6);
			NumberPair* num16 = &numberPair8;
			Struct_4ydhja struct_4ydhja17 = struct_4ydhja16;
			*(double*)num16 = struct_4ydhja17.field_0;
			byte* num17 = (byte*)(&numberPair8) + 8u;
			Struct_4ydhja struct_4ydhja18 = struct_4ydhja16;
			*(double*)num17 = struct_4ydhja18.field_1;
			Llvm_lifetime_start_p0.Invoke(16L, &numberPair9);
			*(double*)(&numberPair9) = double.NaN;
			((double*)(&numberPair9))[1] = double.NaN;
			if (Anonymous_namespace_larger_exponent.Invoke(numberPair8.Hi, Lo6_hi))
			{
				Struct_4ydhja struct_4ydhja19 = Fputil_add.Invoke(&numberPair8, &numberPair7);
				NumberPair* num18 = &numberPair9;
				Struct_4ydhja struct_4ydhja20 = struct_4ydhja19;
				*(double*)num18 = struct_4ydhja20.field_0;
				byte* num19 = (byte*)(&numberPair9) + 8u;
				Struct_4ydhja struct_4ydhja21 = struct_4ydhja19;
				*(double*)num19 = struct_4ydhja21.field_1;
			}
			else
			{
				Struct_4ydhja struct_4ydhja22 = Fputil_add.Invoke(&numberPair7, &numberPair8);
				NumberPair* num20 = &numberPair9;
				Struct_4ydhja struct_4ydhja23 = struct_4ydhja22;
				*(double*)num20 = struct_4ydhja23.field_0;
				byte* num21 = (byte*)(&numberPair9) + 8u;
				Struct_4ydhja struct_4ydhja24 = struct_4ydhja22;
				*(double*)num21 = struct_4ydhja24.field_1;
			}
			Llvm_lifetime_start_p0.Invoke(160L, &inlineArray10_NumberPair);
			Llvm_memcpy_p0_p0_i64.Invoke(&inlineArray10_NumberPair, EXP2_COEFFS.Pointer, 160L, isVolatile: false);
			Llvm_lifetime_start_p0.Invoke(16L, &numberPair10);
			*(double*)(&numberPair10) = double.NaN;
			((double*)(&numberPair10))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja25 = Fputil_polyeval_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double.Invoke(&numberPair9, (NumberPair*)(&inlineArray10_NumberPair), (NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray10_NumberPair, sizeof(NumberPair))), (NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray10_NumberPair, (nint)2 * sizeof(NumberPair))), (NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray10_NumberPair, (nint)3 * sizeof(NumberPair))), (NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray10_NumberPair, (nint)4 * sizeof(NumberPair))), (NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray10_NumberPair, (nint)5 * sizeof(NumberPair))), (NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray10_NumberPair, (nint)6 * sizeof(NumberPair))), (NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray10_NumberPair, (nint)7 * sizeof(NumberPair))), (NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray10_NumberPair, (nint)8 * sizeof(NumberPair))), (NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray10_NumberPair, (nint)9 * sizeof(NumberPair))));
			NumberPair* num22 = &numberPair10;
			Struct_4ydhja struct_4ydhja26 = struct_4ydhja25;
			*(double*)num22 = struct_4ydhja26.field_0;
			byte* num23 = (byte*)(&numberPair10) + 8u;
			Struct_4ydhja struct_4ydhja27 = struct_4ydhja25;
			*(double*)num23 = struct_4ydhja27.field_1;
			Llvm_lifetime_start_p0.Invoke(16L, &numberPair11);
			*(double*)(&numberPair11) = double.NaN;
			((double*)(&numberPair11))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja28 = Fputil_quick_mult_27ul.Invoke(Exp2_hi_mid, &numberPair10);
			NumberPair* num24 = &numberPair11;
			Struct_4ydhja struct_4ydhja29 = struct_4ydhja28;
			*(double*)num24 = struct_4ydhja29.field_0;
			byte* num25 = (byte*)(&numberPair11) + 8u;
			Struct_4ydhja struct_4ydhja30 = struct_4ydhja28;
			*(double*)num25 = struct_4ydhja30.field_1;
			Llvm_lifetime_start_p0.Invoke(16L, &numberPair12);
			*(double*)(&numberPair12) = double.NaN;
			((double*)(&numberPair12))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja31 = Fputil_exact_add_true.Invoke(numberPair11.Hi, numberPair11.Lo);
			NumberPair* num26 = &numberPair12;
			Struct_4ydhja struct_4ydhja32 = struct_4ydhja31;
			*(double*)num26 = struct_4ydhja32.field_0;
			byte* num27 = (byte*)(&numberPair12) + 8u;
			Struct_4ydhja struct_4ydhja33 = struct_4ydhja31;
			*(double*)num27 = struct_4ydhja33.field_1;
			Llvm_lifetime_start_p0.Invoke(8L, &num3);
			num3 = Cpp_bit_cast_unsigned_long_double.Invoke(&numberPair12.Hi);
			if (Details_expects_bool_condition_bool.Invoke((num3 & 0xFFFFFFFL) == 0L && NumericHelper.IsUnorderedOrNotEquals(numberPair12.Lo, 0.0), Expected: false))
			{
				Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb);
				*(sbyte*)(&anon_izyfb) = -86;
				Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
				FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm, numberPair12.Hi);
				anon_izyfb.Val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm);
				Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
				Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb2);
				*(sbyte*)(&anon_izyfb2) = -86;
				Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
				FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm2, numberPair12.Lo);
				anon_izyfb2.Val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm2);
				Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb3, &anon_izyfb, 1L, isVolatile: false);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb4, &anon_izyfb2, 1L, isVolatile: false);
				if (Equals_fy8fvt.Invoke(anon_izyfb3.Val, anon_izyfb4.Val))
				{
					num3++;
				}
				else if ((ulong)(num3 & 0xFFFFFFFFFFFFFL) > 0uL)
				{
					num3 += -1L;
				}
				Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb2);
				Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb);
			}
			double result = Cpp_bit_cast_double_unsigned_long.Invoke(&num3);
			Llvm_lifetime_end_p0.Invoke(8L, &num3);
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair12);
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair11);
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair10);
			Llvm_lifetime_end_p0.Invoke(160L, &inlineArray10_NumberPair);
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair9);
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair8);
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair7);
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair6);
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair5);
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair4);
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair3);
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair2);
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair);
			Llvm_lifetime_end_p0.Invoke(96L, &inlineArray6_NumberPair);
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}

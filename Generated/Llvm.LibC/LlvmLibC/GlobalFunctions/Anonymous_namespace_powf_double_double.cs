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
	public unsafe static double Invoke([MangledName("idx_x")][NativeType("int")] int Idx_x, [MangledName("dx")][NativeType("double")] double Dx, [MangledName("y6")][NativeType("double")] double Y6, [MangledName("lo6_hi")][NativeType("double")] double Lo6_hi, [MangledName("exp2_hi_mid")][NativeType("__llvm_libc_20_1_2_::NumberPair<double> const&")] Llvm_libc_20_1_2_NumberPair* Exp2_hi_mid)
	{
		int num = 0;
		double num2 = 0.0;
		InlineArray6_Llvm_libc_20_1_2_NumberPair inlineArray6_Llvm_libc_20_1_2_NumberPair = default(InlineArray6_Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair2 = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair3 = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair4 = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair5 = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair6 = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair7 = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair8 = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair9 = default(Llvm_libc_20_1_2_NumberPair);
		InlineArray10_Llvm_libc_20_1_2_NumberPair inlineArray10_Llvm_libc_20_1_2_NumberPair = default(InlineArray10_Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair10 = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair11 = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair12 = default(Llvm_libc_20_1_2_NumberPair);
		long num3 = 0L;
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm2 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		unchecked
		{
			num = (int)Fputil_nearest_integer.Invoke(Fputil_multiply_add_double.Invoke(Dx, 16384.0, 64.0));
			Llvm_lifetime_start_p0.Invoke(8L, &num2);
			double x = 1.0 + Dx;
			long num4 = num;
			num2 = Fputil_multiply_add_double.Invoke(x, ((double*)Llvm_libc_20_1_2_R2.Pointer)[num4], -1.0);
			Llvm_lifetime_start_p0.Invoke(96L, &inlineArray6_Llvm_libc_20_1_2_NumberPair);
			Llvm_memcpy_p0_p0_i64.Invoke(&inlineArray6_Llvm_libc_20_1_2_NumberPair, COEFFS_yazmcg.Pointer, 96L, isVolatile: false);
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair);
			*(double*)(&llvm_libc_20_1_2_NumberPair) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair))[1] = double.NaN;
			llvm_libc_20_1_2_NumberPair.Lo = 0.0;
			llvm_libc_20_1_2_NumberPair.Hi = num2;
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair2);
			*(double*)(&llvm_libc_20_1_2_NumberPair2) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair2))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja = Fputil_polyeval_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double.Invoke(&llvm_libc_20_1_2_NumberPair, (Llvm_libc_20_1_2_NumberPair*)(&inlineArray6_Llvm_libc_20_1_2_NumberPair), (Llvm_libc_20_1_2_NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray6_Llvm_libc_20_1_2_NumberPair, sizeof(Llvm_libc_20_1_2_NumberPair))), (Llvm_libc_20_1_2_NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray6_Llvm_libc_20_1_2_NumberPair, (nint)2 * sizeof(Llvm_libc_20_1_2_NumberPair))), (Llvm_libc_20_1_2_NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray6_Llvm_libc_20_1_2_NumberPair, (nint)3 * sizeof(Llvm_libc_20_1_2_NumberPair))), (Llvm_libc_20_1_2_NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray6_Llvm_libc_20_1_2_NumberPair, (nint)4 * sizeof(Llvm_libc_20_1_2_NumberPair))), (Llvm_libc_20_1_2_NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray6_Llvm_libc_20_1_2_NumberPair, (nint)5 * sizeof(Llvm_libc_20_1_2_NumberPair))));
			Llvm_libc_20_1_2_NumberPair* num5 = &llvm_libc_20_1_2_NumberPair2;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num5 = struct_4ydhja2.field_0;
			byte* num6 = (byte*)(&llvm_libc_20_1_2_NumberPair2) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num6 = struct_4ydhja3.field_1;
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair3);
			*(double*)(&llvm_libc_20_1_2_NumberPair3) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair3))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja4 = Fputil_quick_mult.Invoke(num2, &llvm_libc_20_1_2_NumberPair2);
			Llvm_libc_20_1_2_NumberPair* num7 = &llvm_libc_20_1_2_NumberPair3;
			Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
			*(double*)num7 = struct_4ydhja5.field_0;
			byte* num8 = (byte*)(&llvm_libc_20_1_2_NumberPair3) + 8u;
			Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
			*(double*)num8 = struct_4ydhja6.field_1;
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair4);
			*(double*)(&llvm_libc_20_1_2_NumberPair4) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair4))[1] = double.NaN;
			llvm_libc_20_1_2_NumberPair4.Lo = ((Llvm_libc_20_1_2_fputil_TripleDouble*)Llvm_libc_20_1_2_anonymous_namespace_LOG2_R_TD.Pointer)[Idx_x].Lo;
			llvm_libc_20_1_2_NumberPair4.Hi = ((Llvm_libc_20_1_2_fputil_TripleDouble*)Llvm_libc_20_1_2_anonymous_namespace_LOG2_R_TD.Pointer)[Idx_x].Mid;
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair5);
			*(double*)(&llvm_libc_20_1_2_NumberPair5) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair5))[1] = double.NaN;
			long num9 = num;
			Struct_4ydhja struct_4ydhja7 = Fputil_add.Invoke((Llvm_libc_20_1_2_NumberPair*)Llvm_libc_20_1_2_anonymous_namespace_LOG2_R2_DD.Pointer + num9, &llvm_libc_20_1_2_NumberPair4);
			Llvm_libc_20_1_2_NumberPair* num10 = &llvm_libc_20_1_2_NumberPair5;
			Struct_4ydhja struct_4ydhja8 = struct_4ydhja7;
			*(double*)num10 = struct_4ydhja8.field_0;
			byte* num11 = (byte*)(&llvm_libc_20_1_2_NumberPair5) + 8u;
			Struct_4ydhja struct_4ydhja9 = struct_4ydhja7;
			*(double*)num11 = struct_4ydhja9.field_1;
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair6);
			*(double*)(&llvm_libc_20_1_2_NumberPair6) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair6))[1] = double.NaN;
			if (Anonymous_namespace_larger_exponent.Invoke(llvm_libc_20_1_2_NumberPair5.Hi, llvm_libc_20_1_2_NumberPair3.Hi))
			{
				Struct_4ydhja struct_4ydhja10 = Fputil_add.Invoke(&llvm_libc_20_1_2_NumberPair5, &llvm_libc_20_1_2_NumberPair3);
				Llvm_libc_20_1_2_NumberPair* num12 = &llvm_libc_20_1_2_NumberPair6;
				Struct_4ydhja struct_4ydhja11 = struct_4ydhja10;
				*(double*)num12 = struct_4ydhja11.field_0;
				byte* num13 = (byte*)(&llvm_libc_20_1_2_NumberPair6) + 8u;
				Struct_4ydhja struct_4ydhja12 = struct_4ydhja10;
				*(double*)num13 = struct_4ydhja12.field_1;
			}
			else
			{
				Struct_4ydhja struct_4ydhja13 = Fputil_add.Invoke(&llvm_libc_20_1_2_NumberPair3, &llvm_libc_20_1_2_NumberPair5);
				Llvm_libc_20_1_2_NumberPair* num14 = &llvm_libc_20_1_2_NumberPair6;
				Struct_4ydhja struct_4ydhja14 = struct_4ydhja13;
				*(double*)num14 = struct_4ydhja14.field_0;
				byte* num15 = (byte*)(&llvm_libc_20_1_2_NumberPair6) + 8u;
				Struct_4ydhja struct_4ydhja15 = struct_4ydhja13;
				*(double*)num15 = struct_4ydhja15.field_1;
			}
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair7);
			*(double*)(&llvm_libc_20_1_2_NumberPair7) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair7))[1] = double.NaN;
			llvm_libc_20_1_2_NumberPair7.Lo = 0.0;
			llvm_libc_20_1_2_NumberPair7.Hi = Lo6_hi;
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair8);
			*(double*)(&llvm_libc_20_1_2_NumberPair8) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair8))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja16 = Fputil_quick_mult.Invoke(Y6, &llvm_libc_20_1_2_NumberPair6);
			Llvm_libc_20_1_2_NumberPair* num16 = &llvm_libc_20_1_2_NumberPair8;
			Struct_4ydhja struct_4ydhja17 = struct_4ydhja16;
			*(double*)num16 = struct_4ydhja17.field_0;
			byte* num17 = (byte*)(&llvm_libc_20_1_2_NumberPair8) + 8u;
			Struct_4ydhja struct_4ydhja18 = struct_4ydhja16;
			*(double*)num17 = struct_4ydhja18.field_1;
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair9);
			*(double*)(&llvm_libc_20_1_2_NumberPair9) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair9))[1] = double.NaN;
			if (Anonymous_namespace_larger_exponent.Invoke(llvm_libc_20_1_2_NumberPair8.Hi, Lo6_hi))
			{
				Struct_4ydhja struct_4ydhja19 = Fputil_add.Invoke(&llvm_libc_20_1_2_NumberPair8, &llvm_libc_20_1_2_NumberPair7);
				Llvm_libc_20_1_2_NumberPair* num18 = &llvm_libc_20_1_2_NumberPair9;
				Struct_4ydhja struct_4ydhja20 = struct_4ydhja19;
				*(double*)num18 = struct_4ydhja20.field_0;
				byte* num19 = (byte*)(&llvm_libc_20_1_2_NumberPair9) + 8u;
				Struct_4ydhja struct_4ydhja21 = struct_4ydhja19;
				*(double*)num19 = struct_4ydhja21.field_1;
			}
			else
			{
				Struct_4ydhja struct_4ydhja22 = Fputil_add.Invoke(&llvm_libc_20_1_2_NumberPair7, &llvm_libc_20_1_2_NumberPair8);
				Llvm_libc_20_1_2_NumberPair* num20 = &llvm_libc_20_1_2_NumberPair9;
				Struct_4ydhja struct_4ydhja23 = struct_4ydhja22;
				*(double*)num20 = struct_4ydhja23.field_0;
				byte* num21 = (byte*)(&llvm_libc_20_1_2_NumberPair9) + 8u;
				Struct_4ydhja struct_4ydhja24 = struct_4ydhja22;
				*(double*)num21 = struct_4ydhja24.field_1;
			}
			Llvm_lifetime_start_p0.Invoke(160L, &inlineArray10_Llvm_libc_20_1_2_NumberPair);
			Llvm_memcpy_p0_p0_i64.Invoke(&inlineArray10_Llvm_libc_20_1_2_NumberPair, EXP2_COEFFS.Pointer, 160L, isVolatile: false);
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair10);
			*(double*)(&llvm_libc_20_1_2_NumberPair10) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair10))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja25 = Fputil_polyeval_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double.Invoke(&llvm_libc_20_1_2_NumberPair9, (Llvm_libc_20_1_2_NumberPair*)(&inlineArray10_Llvm_libc_20_1_2_NumberPair), (Llvm_libc_20_1_2_NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray10_Llvm_libc_20_1_2_NumberPair, sizeof(Llvm_libc_20_1_2_NumberPair))), (Llvm_libc_20_1_2_NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray10_Llvm_libc_20_1_2_NumberPair, (nint)2 * sizeof(Llvm_libc_20_1_2_NumberPair))), (Llvm_libc_20_1_2_NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray10_Llvm_libc_20_1_2_NumberPair, (nint)3 * sizeof(Llvm_libc_20_1_2_NumberPair))), (Llvm_libc_20_1_2_NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray10_Llvm_libc_20_1_2_NumberPair, (nint)4 * sizeof(Llvm_libc_20_1_2_NumberPair))), (Llvm_libc_20_1_2_NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray10_Llvm_libc_20_1_2_NumberPair, (nint)5 * sizeof(Llvm_libc_20_1_2_NumberPair))), (Llvm_libc_20_1_2_NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray10_Llvm_libc_20_1_2_NumberPair, (nint)6 * sizeof(Llvm_libc_20_1_2_NumberPair))), (Llvm_libc_20_1_2_NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray10_Llvm_libc_20_1_2_NumberPair, (nint)7 * sizeof(Llvm_libc_20_1_2_NumberPair))), (Llvm_libc_20_1_2_NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray10_Llvm_libc_20_1_2_NumberPair, (nint)8 * sizeof(Llvm_libc_20_1_2_NumberPair))), (Llvm_libc_20_1_2_NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray10_Llvm_libc_20_1_2_NumberPair, (nint)9 * sizeof(Llvm_libc_20_1_2_NumberPair))));
			Llvm_libc_20_1_2_NumberPair* num22 = &llvm_libc_20_1_2_NumberPair10;
			Struct_4ydhja struct_4ydhja26 = struct_4ydhja25;
			*(double*)num22 = struct_4ydhja26.field_0;
			byte* num23 = (byte*)(&llvm_libc_20_1_2_NumberPair10) + 8u;
			Struct_4ydhja struct_4ydhja27 = struct_4ydhja25;
			*(double*)num23 = struct_4ydhja27.field_1;
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair11);
			*(double*)(&llvm_libc_20_1_2_NumberPair11) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair11))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja28 = Fputil_quick_mult_27ul.Invoke(Exp2_hi_mid, &llvm_libc_20_1_2_NumberPair10);
			Llvm_libc_20_1_2_NumberPair* num24 = &llvm_libc_20_1_2_NumberPair11;
			Struct_4ydhja struct_4ydhja29 = struct_4ydhja28;
			*(double*)num24 = struct_4ydhja29.field_0;
			byte* num25 = (byte*)(&llvm_libc_20_1_2_NumberPair11) + 8u;
			Struct_4ydhja struct_4ydhja30 = struct_4ydhja28;
			*(double*)num25 = struct_4ydhja30.field_1;
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair12);
			*(double*)(&llvm_libc_20_1_2_NumberPair12) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair12))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja31 = Fputil_exact_add_true.Invoke(llvm_libc_20_1_2_NumberPair11.Hi, llvm_libc_20_1_2_NumberPair11.Lo);
			Llvm_libc_20_1_2_NumberPair* num26 = &llvm_libc_20_1_2_NumberPair12;
			Struct_4ydhja struct_4ydhja32 = struct_4ydhja31;
			*(double*)num26 = struct_4ydhja32.field_0;
			byte* num27 = (byte*)(&llvm_libc_20_1_2_NumberPair12) + 8u;
			Struct_4ydhja struct_4ydhja33 = struct_4ydhja31;
			*(double*)num27 = struct_4ydhja33.field_1;
			Llvm_lifetime_start_p0.Invoke(8L, &num3);
			num3 = Cpp_bit_cast_unsigned_long_double.Invoke(&llvm_libc_20_1_2_NumberPair12.Hi);
			if (Details_expects_bool_condition_bool.Invoke((num3 & 0xFFFFFFFL) == 0L && NumericHelper.IsUnorderedOrNotEquals(llvm_libc_20_1_2_NumberPair12.Lo, 0.0), Expected: false))
			{
				Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb);
				*(sbyte*)(&anon_izyfb) = -86;
				Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
				FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm, llvm_libc_20_1_2_NumberPair12.Hi);
				anon_izyfb.Val = FPStorage_fputil_FPType_2_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
				Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
				Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb2);
				*(sbyte*)(&anon_izyfb2) = -86;
				Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
				FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2, llvm_libc_20_1_2_NumberPair12.Lo);
				anon_izyfb2.Val = FPStorage_fputil_FPType_2_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
				Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb3, &anon_izyfb, 1L, isVolatile: false);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb4, &anon_izyfb2, 1L, isVolatile: false);
				if (Llvm_libc_20_1_2_Equals_fy8fvt.Invoke(anon_izyfb3.Val, anon_izyfb4.Val))
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
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair12);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair11);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair10);
			Llvm_lifetime_end_p0.Invoke(160L, &inlineArray10_Llvm_libc_20_1_2_NumberPair);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair9);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair8);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair7);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair6);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair5);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair4);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair3);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair2);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair);
			Llvm_lifetime_end_p0.Invoke(96L, &inlineArray6_Llvm_libc_20_1_2_NumberPair);
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}

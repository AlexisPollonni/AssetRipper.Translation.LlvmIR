using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Generic_sincos_eval
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic11sincos_evalERKNS_10NumberPairIdEERS2_S5_")]
	[DemangledName("__llvm_libc_20_1_2_::generic::sincos_eval(__llvm_libc_20_1_2_::NumberPair<double> const&, __llvm_libc_20_1_2_::NumberPair<double>&, __llvm_libc_20_1_2_::NumberPair<double>&)")]
	public unsafe static double Invoke([MangledName("u")][NativeType("__llvm_libc_20_1_2_::NumberPair<double> const&")] NumberPair* U, [MangledName("sin_u")][NativeType("__llvm_libc_20_1_2_::NumberPair<double>&")] NumberPair* Sin_u, [MangledName("cos_u")][NativeType("__llvm_libc_20_1_2_::NumberPair<double>&")] NumberPair* Cos_u)
	{
		double num = 0.0;
		double y = 0.0;
		double y2 = 0.0;
		double x = 0.0;
		double y3 = 0.0;
		double num2 = 0.0;
		double b = 0.0;
		double b2 = 0.0;
		NumberPair numberPair = default(NumberPair);
		NumberPair numberPair2 = default(NumberPair);
		NumberPair numberPair3 = default(NumberPair);
		double y4 = 0.0;
		double y5 = 0.0;
		double x2 = 0.0;
		double x3 = 0.0;
		double y6 = 0.0;
		double z = 0.0;
		double b3 = 0.0;
		NumberPair numberPair4 = default(NumberPair);
		NumberPair numberPair5 = default(NumberPair);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm = default(Fputil_FPBits_wjhbrm);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(Fputil_FPBits_wjhbrm);
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = U->Hi * U->Hi;
		Llvm_lifetime_start_p0.Invoke(8L, &y);
		y = Fputil_multiply_add_double.Invoke(num, -0.0001984126984126984, 1.0 / 120.0);
		Llvm_lifetime_start_p0.Invoke(8L, &y2);
		y2 = Fputil_multiply_add_double.Invoke(num, 1.0 / 24.0, -0.5);
		Llvm_lifetime_start_p0.Invoke(8L, &x);
		x = num * U->Hi;
		Llvm_lifetime_start_p0.Invoke(8L, &y3);
		y3 = Fputil_multiply_add_double.Invoke(num, y, -1.0 / 6.0);
		Llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = Fputil_multiply_add_double.Invoke(num, y2, 1.0);
		Llvm_lifetime_start_p0.Invoke(8L, &b);
		b = Fputil_multiply_add_double.Invoke(x, y3, U->Lo * num2);
		Llvm_lifetime_start_p0.Invoke(8L, &b2);
		b2 = -0.5 * U->Hi;
		Llvm_lifetime_start_p0.Invoke(16L, &numberPair);
		unchecked
		{
			*(double*)(&numberPair) = double.NaN;
			((double*)(&numberPair))[1] = double.NaN;
			NumberPair_double_Constructor.Invoke(&numberPair);
			Llvm_lifetime_start_p0.Invoke(16L, &numberPair2);
			*(double*)(&numberPair2) = double.NaN;
			((double*)(&numberPair2))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja = Fputil_exact_mult_27ul.Invoke(U->Hi, b2);
			NumberPair* num3 = &numberPair2;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num3 = struct_4ydhja2.field_0;
			byte* num4 = (byte*)(&numberPair2) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num4 = struct_4ydhja3.field_1;
			Llvm_lifetime_start_p0.Invoke(16L, &numberPair3);
			Struct_4ydhja struct_4ydhja4 = Fputil_exact_add_true.Invoke(1.0, numberPair2.Hi);
			NumberPair* num5 = &numberPair3;
			Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
			*(double*)num5 = struct_4ydhja5.field_0;
			byte* num6 = (byte*)(&numberPair3) + 8u;
			Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
			*(double*)num6 = struct_4ydhja6.field_1;
			Llvm_memcpy_p0_p0_i64.Invoke(&numberPair, &numberPair3, 16L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair3);
			double lo = numberPair2.Lo;
			numberPair.Lo += lo;
			Llvm_lifetime_start_p0.Invoke(8L, &y4);
			y4 = Fputil_multiply_add_double.Invoke(num, 2.48015873015873E-05, -1.0 / 720.0);
			Llvm_lifetime_start_p0.Invoke(8L, &y5);
			y5 = Fputil_multiply_add_double.Invoke(num, 1.0 / 6.0, -1.0);
			Llvm_lifetime_start_p0.Invoke(8L, &x2);
			x2 = num * num;
			Llvm_lifetime_start_p0.Invoke(8L, &x3);
			x3 = U->Hi * U->Lo;
			Llvm_lifetime_start_p0.Invoke(8L, &y6);
			y6 = Fputil_multiply_add_double.Invoke(num, y4, 1.0 / 24.0);
			Llvm_lifetime_start_p0.Invoke(8L, &z);
			z = Fputil_multiply_add_double.Invoke(x3, y5, numberPair.Lo);
			Llvm_lifetime_start_p0.Invoke(8L, &b3);
			b3 = Fputil_multiply_add_double.Invoke(x2, y6, z);
			Llvm_lifetime_start_p0.Invoke(16L, &numberPair4);
			Struct_4ydhja struct_4ydhja7 = Fputil_exact_add_true.Invoke(U->Hi, b);
			NumberPair* num7 = &numberPair4;
			Struct_4ydhja struct_4ydhja8 = struct_4ydhja7;
			*(double*)num7 = struct_4ydhja8.field_0;
			byte* num8 = (byte*)(&numberPair4) + 8u;
			Struct_4ydhja struct_4ydhja9 = struct_4ydhja7;
			*(double*)num8 = struct_4ydhja9.field_1;
			Llvm_memcpy_p0_p0_i64.Invoke(Sin_u, &numberPair4, 16L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair4);
			Llvm_lifetime_start_p0.Invoke(16L, &numberPair5);
			Struct_4ydhja struct_4ydhja10 = Fputil_exact_add_true.Invoke(numberPair.Hi, b3);
			NumberPair* num9 = &numberPair5;
			Struct_4ydhja struct_4ydhja11 = struct_4ydhja10;
			*(double*)num9 = struct_4ydhja11.field_0;
			byte* num10 = (byte*)(&numberPair5) + 8u;
			Struct_4ydhja struct_4ydhja12 = struct_4ydhja10;
			*(double*)num10 = struct_4ydhja12.field_1;
			Llvm_memcpy_p0_p0_i64.Invoke(Cos_u, &numberPair5, 16L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair5);
			Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
			Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm2, x);
			long val = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_abs.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
			fputil_FPBits_wjhbrm.FPRepImpl.FPRepSem.FPStorage.Val = val;
			double result = Fputil_multiply_add_double.Invoke(FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm), 4.440892098500626E-16, 2.465190328815662E-32);
			Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
			Llvm_lifetime_end_p0.Invoke(8L, &b3);
			Llvm_lifetime_end_p0.Invoke(8L, &z);
			Llvm_lifetime_end_p0.Invoke(8L, &y6);
			Llvm_lifetime_end_p0.Invoke(8L, &x3);
			Llvm_lifetime_end_p0.Invoke(8L, &x2);
			Llvm_lifetime_end_p0.Invoke(8L, &y5);
			Llvm_lifetime_end_p0.Invoke(8L, &y4);
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair2);
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair);
			Llvm_lifetime_end_p0.Invoke(8L, &b2);
			Llvm_lifetime_end_p0.Invoke(8L, &b);
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(8L, &y3);
			Llvm_lifetime_end_p0.Invoke(8L, &x);
			Llvm_lifetime_end_p0.Invoke(8L, &y2);
			Llvm_lifetime_end_p0.Invoke(8L, &y);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_7generic11sincos_evalERKNS_6fputil11DyadicFloatILm128EEERS3_S6_")]
	[DemangledName("__llvm_libc_20_1_2_::generic::sincos_eval(__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&, __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>&, __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>&)")]
	public unsafe static void Invoke([MangledName("u")][NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&")] Fputil_DyadicFloat_kt2kd4* U, [MangledName("sin_u")][NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>&")] Fputil_DyadicFloat_kt2kd4* Sin_u, [MangledName("cos_u")][NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>&")] Fputil_DyadicFloat_kt2kd4* Cos_u)
	{
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd = default(Fputil_DyadicFloat_kt2kd4);
		InlineArray7_Fputil_DyadicFloat_kt2kd4 inlineArray7_Fputil_DyadicFloat_kt2kd = default(InlineArray7_Fputil_DyadicFloat_kt2kd4);
		InlineArray7_Fputil_DyadicFloat_kt2kd4 inlineArray7_Fputil_DyadicFloat_kt2kd2 = default(InlineArray7_Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd2 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd3 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd4 = default(Fputil_DyadicFloat_kt2kd4);
		Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd);
		unchecked
		{
			*(sbyte*)(&fputil_DyadicFloat_kt2kd) = -86;
			sbyte* ptr = (sbyte*)(&fputil_DyadicFloat_kt2kd) + 1;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			((int*)(&fputil_DyadicFloat_kt2kd))[1] = -1431655766;
			sbyte* ptr2 = (sbyte*)(&fputil_DyadicFloat_kt2kd) + 8;
			*(long*)ptr2 = -6148914691236517206L;
			((long*)ptr2)[1] = -6148914691236517206L;
			Fputil_quick_mul_128ul.Invoke(&fputil_DyadicFloat_kt2kd, U, U);
			Llvm_lifetime_start_p0.Invoke(168L, &inlineArray7_Fputil_DyadicFloat_kt2kd);
			Llvm_memcpy_p0_p0_i64.Invoke(&inlineArray7_Fputil_DyadicFloat_kt2kd, SIN_COEFFS.Pointer, 168L, isVolatile: false);
			Llvm_lifetime_start_p0.Invoke(168L, &inlineArray7_Fputil_DyadicFloat_kt2kd2);
			Llvm_memcpy_p0_p0_i64.Invoke(&inlineArray7_Fputil_DyadicFloat_kt2kd2, COS_COEFFS.Pointer, 168L, isVolatile: false);
			Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd2);
			Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd3);
			Fputil_polyeval_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul.Invoke(&fputil_DyadicFloat_kt2kd3, &fputil_DyadicFloat_kt2kd, (Fputil_DyadicFloat_kt2kd4*)(&inlineArray7_Fputil_DyadicFloat_kt2kd), (Fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_Fputil_DyadicFloat_kt2kd, sizeof(Fputil_DyadicFloat_kt2kd4))), (Fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_Fputil_DyadicFloat_kt2kd, (nint)2 * sizeof(Fputil_DyadicFloat_kt2kd4))), (Fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_Fputil_DyadicFloat_kt2kd, (nint)3 * sizeof(Fputil_DyadicFloat_kt2kd4))), (Fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_Fputil_DyadicFloat_kt2kd, (nint)4 * sizeof(Fputil_DyadicFloat_kt2kd4))), (Fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_Fputil_DyadicFloat_kt2kd, (nint)5 * sizeof(Fputil_DyadicFloat_kt2kd4))), (Fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_Fputil_DyadicFloat_kt2kd, (nint)6 * sizeof(Fputil_DyadicFloat_kt2kd4))));
			Fputil_quick_mul_128ul.Invoke(&fputil_DyadicFloat_kt2kd2, U, &fputil_DyadicFloat_kt2kd3);
			Llvm_memcpy_p0_p0_i64.Invoke(Sin_u, &fputil_DyadicFloat_kt2kd2, 24L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd3);
			Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd2);
			Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd4);
			Fputil_polyeval_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul.Invoke(&fputil_DyadicFloat_kt2kd4, &fputil_DyadicFloat_kt2kd, (Fputil_DyadicFloat_kt2kd4*)(&inlineArray7_Fputil_DyadicFloat_kt2kd2), (Fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_Fputil_DyadicFloat_kt2kd2, sizeof(Fputil_DyadicFloat_kt2kd4))), (Fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_Fputil_DyadicFloat_kt2kd2, (nint)2 * sizeof(Fputil_DyadicFloat_kt2kd4))), (Fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_Fputil_DyadicFloat_kt2kd2, (nint)3 * sizeof(Fputil_DyadicFloat_kt2kd4))), (Fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_Fputil_DyadicFloat_kt2kd2, (nint)4 * sizeof(Fputil_DyadicFloat_kt2kd4))), (Fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_Fputil_DyadicFloat_kt2kd2, (nint)5 * sizeof(Fputil_DyadicFloat_kt2kd4))), (Fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_Fputil_DyadicFloat_kt2kd2, (nint)6 * sizeof(Fputil_DyadicFloat_kt2kd4))));
			Llvm_memcpy_p0_p0_i64.Invoke(Cos_u, &fputil_DyadicFloat_kt2kd4, 24L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd4);
			Llvm_lifetime_end_p0.Invoke(168L, &inlineArray7_Fputil_DyadicFloat_kt2kd2);
			Llvm_lifetime_end_p0.Invoke(168L, &inlineArray7_Fputil_DyadicFloat_kt2kd);
			Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd);
		}
	}
}

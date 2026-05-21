using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class generic_sincos_eval
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic11sincos_evalERKNS_10NumberPairIdEERS2_S5_")]
	[DemangledName("__llvm_libc_20_1_2_::generic::sincos_eval(__llvm_libc_20_1_2_::NumberPair<double> const&, __llvm_libc_20_1_2_::NumberPair<double>&, __llvm_libc_20_1_2_::NumberPair<double>&)")]
	public unsafe static double Invoke([NativeType("__llvm_libc_20_1_2_::NumberPair<double> const&")] NumberPair* u, [NativeType("__llvm_libc_20_1_2_::NumberPair<double>&")] NumberPair* sin_u, [NativeType("__llvm_libc_20_1_2_::NumberPair<double>&")] NumberPair* cos_u)
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
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = u->hi * u->hi;
		llvm_lifetime_start_p0.Invoke(8L, &y);
		y = fputil_multiply_add_double.Invoke(num, -0.0001984126984126984, 1.0 / 120.0);
		llvm_lifetime_start_p0.Invoke(8L, &y2);
		y2 = fputil_multiply_add_double.Invoke(num, 1.0 / 24.0, -0.5);
		llvm_lifetime_start_p0.Invoke(8L, &x);
		x = num * u->hi;
		llvm_lifetime_start_p0.Invoke(8L, &y3);
		y3 = fputil_multiply_add_double.Invoke(num, y, -1.0 / 6.0);
		llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = fputil_multiply_add_double.Invoke(num, y2, 1.0);
		llvm_lifetime_start_p0.Invoke(8L, &b);
		b = fputil_multiply_add_double.Invoke(x, y3, u->lo * num2);
		llvm_lifetime_start_p0.Invoke(8L, &b2);
		b2 = -0.5 * u->hi;
		llvm_lifetime_start_p0.Invoke(16L, &numberPair);
		unchecked
		{
			*(double*)(&numberPair) = double.NaN;
			((double*)(&numberPair))[1] = double.NaN;
			NumberPair_double_Constructor.Invoke(&numberPair);
			llvm_lifetime_start_p0.Invoke(16L, &numberPair2);
			*(double*)(&numberPair2) = double.NaN;
			((double*)(&numberPair2))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja = fputil_exact_mult_27ul.Invoke(u->hi, b2);
			NumberPair* num3 = &numberPair2;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num3 = struct_4ydhja2.field_0;
			byte* num4 = (byte*)(&numberPair2) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num4 = struct_4ydhja3.field_1;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair3);
			Struct_4ydhja struct_4ydhja4 = fputil_exact_add_true.Invoke(1.0, numberPair2.hi);
			NumberPair* num5 = &numberPair3;
			Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
			*(double*)num5 = struct_4ydhja5.field_0;
			byte* num6 = (byte*)(&numberPair3) + 8u;
			Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
			*(double*)num6 = struct_4ydhja6.field_1;
			llvm_memcpy_p0_p0_i64.Invoke(&numberPair, &numberPair3, 16L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair3);
			double lo = numberPair2.lo;
			numberPair.lo += lo;
			llvm_lifetime_start_p0.Invoke(8L, &y4);
			y4 = fputil_multiply_add_double.Invoke(num, 2.48015873015873E-05, -1.0 / 720.0);
			llvm_lifetime_start_p0.Invoke(8L, &y5);
			y5 = fputil_multiply_add_double.Invoke(num, 1.0 / 6.0, -1.0);
			llvm_lifetime_start_p0.Invoke(8L, &x2);
			x2 = num * num;
			llvm_lifetime_start_p0.Invoke(8L, &x3);
			x3 = u->hi * u->lo;
			llvm_lifetime_start_p0.Invoke(8L, &y6);
			y6 = fputil_multiply_add_double.Invoke(num, y4, 1.0 / 24.0);
			llvm_lifetime_start_p0.Invoke(8L, &z);
			z = fputil_multiply_add_double.Invoke(x3, y5, numberPair.lo);
			llvm_lifetime_start_p0.Invoke(8L, &b3);
			b3 = fputil_multiply_add_double.Invoke(x2, y6, z);
			llvm_lifetime_start_p0.Invoke(16L, &numberPair4);
			Struct_4ydhja struct_4ydhja7 = fputil_exact_add_true.Invoke(u->hi, b);
			NumberPair* num7 = &numberPair4;
			Struct_4ydhja struct_4ydhja8 = struct_4ydhja7;
			*(double*)num7 = struct_4ydhja8.field_0;
			byte* num8 = (byte*)(&numberPair4) + 8u;
			Struct_4ydhja struct_4ydhja9 = struct_4ydhja7;
			*(double*)num8 = struct_4ydhja9.field_1;
			llvm_memcpy_p0_p0_i64.Invoke(sin_u, &numberPair4, 16L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair4);
			llvm_lifetime_start_p0.Invoke(16L, &numberPair5);
			Struct_4ydhja struct_4ydhja10 = fputil_exact_add_true.Invoke(numberPair.hi, b3);
			NumberPair* num9 = &numberPair5;
			Struct_4ydhja struct_4ydhja11 = struct_4ydhja10;
			*(double*)num9 = struct_4ydhja11.field_0;
			byte* num10 = (byte*)(&numberPair5) + 8u;
			Struct_4ydhja struct_4ydhja12 = struct_4ydhja10;
			*(double*)num10 = struct_4ydhja12.field_1;
			llvm_memcpy_p0_p0_i64.Invoke(cos_u, &numberPair5, 16L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair5);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm3, x);
			long val = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_abs.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm3));
			fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.val = val;
			double result = fputil_multiply_add_double.Invoke(FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm2), 4.440892098500626E-16, 2.465190328815662E-32);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			llvm_lifetime_end_p0.Invoke(8L, &b3);
			llvm_lifetime_end_p0.Invoke(8L, &z);
			llvm_lifetime_end_p0.Invoke(8L, &y6);
			llvm_lifetime_end_p0.Invoke(8L, &x3);
			llvm_lifetime_end_p0.Invoke(8L, &x2);
			llvm_lifetime_end_p0.Invoke(8L, &y5);
			llvm_lifetime_end_p0.Invoke(8L, &y4);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair2);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair);
			llvm_lifetime_end_p0.Invoke(8L, &b2);
			llvm_lifetime_end_p0.Invoke(8L, &b);
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &y3);
			llvm_lifetime_end_p0.Invoke(8L, &x);
			llvm_lifetime_end_p0.Invoke(8L, &y2);
			llvm_lifetime_end_p0.Invoke(8L, &y);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_7generic11sincos_evalERKNS_6fputil11DyadicFloatILm128EEERS3_S6_")]
	[DemangledName("__llvm_libc_20_1_2_::generic::sincos_eval(__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&, __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>&, __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>&)")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&")] fputil_DyadicFloat_kt2kd4* u, [NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>&")] fputil_DyadicFloat_kt2kd4* sin_u, [NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>&")] fputil_DyadicFloat_kt2kd4* cos_u)
	{
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd5 = default(fputil_DyadicFloat_kt2kd4);
		InlineArray7_fputil_DyadicFloat_kt2kd4 inlineArray7_fputil_DyadicFloat_kt2kd = default(InlineArray7_fputil_DyadicFloat_kt2kd4);
		InlineArray7_fputil_DyadicFloat_kt2kd4 inlineArray7_fputil_DyadicFloat_kt2kd2 = default(InlineArray7_fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd6 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd7 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd8 = default(fputil_DyadicFloat_kt2kd4);
		llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
		unchecked
		{
			*(sbyte*)(&fputil_DyadicFloat_kt2kd5) = -86;
			sbyte* ptr = (sbyte*)(&fputil_DyadicFloat_kt2kd5) + 1;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			((int*)(&fputil_DyadicFloat_kt2kd5))[1] = -1431655766;
			sbyte* ptr2 = (sbyte*)(&fputil_DyadicFloat_kt2kd5) + 8;
			*(long*)ptr2 = -6148914691236517206L;
			((long*)ptr2)[1] = -6148914691236517206L;
			fputil_quick_mul_128ul.Invoke(&fputil_DyadicFloat_kt2kd5, u, u);
			llvm_lifetime_start_p0.Invoke(168L, &inlineArray7_fputil_DyadicFloat_kt2kd);
			llvm_memcpy_p0_p0_i64.Invoke(&inlineArray7_fputil_DyadicFloat_kt2kd, SIN_COEFFS.Pointer, 168L, isVolatile: false);
			llvm_lifetime_start_p0.Invoke(168L, &inlineArray7_fputil_DyadicFloat_kt2kd2);
			llvm_memcpy_p0_p0_i64.Invoke(&inlineArray7_fputil_DyadicFloat_kt2kd2, COS_COEFFS.Pointer, 168L, isVolatile: false);
			llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd6);
			llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd7);
			fputil_polyeval_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul.Invoke(&fputil_DyadicFloat_kt2kd7, &fputil_DyadicFloat_kt2kd5, (fputil_DyadicFloat_kt2kd4*)(&inlineArray7_fputil_DyadicFloat_kt2kd), (fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_fputil_DyadicFloat_kt2kd, sizeof(fputil_DyadicFloat_kt2kd4))), (fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_fputil_DyadicFloat_kt2kd, (nint)2 * sizeof(fputil_DyadicFloat_kt2kd4))), (fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_fputil_DyadicFloat_kt2kd, (nint)3 * sizeof(fputil_DyadicFloat_kt2kd4))), (fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_fputil_DyadicFloat_kt2kd, (nint)4 * sizeof(fputil_DyadicFloat_kt2kd4))), (fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_fputil_DyadicFloat_kt2kd, (nint)5 * sizeof(fputil_DyadicFloat_kt2kd4))), (fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_fputil_DyadicFloat_kt2kd, (nint)6 * sizeof(fputil_DyadicFloat_kt2kd4))));
			fputil_quick_mul_128ul.Invoke(&fputil_DyadicFloat_kt2kd6, u, &fputil_DyadicFloat_kt2kd7);
			llvm_memcpy_p0_p0_i64.Invoke(sin_u, &fputil_DyadicFloat_kt2kd6, 24L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd7);
			llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd6);
			llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd8);
			fputil_polyeval_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul.Invoke(&fputil_DyadicFloat_kt2kd8, &fputil_DyadicFloat_kt2kd5, (fputil_DyadicFloat_kt2kd4*)(&inlineArray7_fputil_DyadicFloat_kt2kd2), (fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_fputil_DyadicFloat_kt2kd2, sizeof(fputil_DyadicFloat_kt2kd4))), (fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_fputil_DyadicFloat_kt2kd2, (nint)2 * sizeof(fputil_DyadicFloat_kt2kd4))), (fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_fputil_DyadicFloat_kt2kd2, (nint)3 * sizeof(fputil_DyadicFloat_kt2kd4))), (fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_fputil_DyadicFloat_kt2kd2, (nint)4 * sizeof(fputil_DyadicFloat_kt2kd4))), (fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_fputil_DyadicFloat_kt2kd2, (nint)5 * sizeof(fputil_DyadicFloat_kt2kd4))), (fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_fputil_DyadicFloat_kt2kd2, (nint)6 * sizeof(fputil_DyadicFloat_kt2kd4))));
			llvm_memcpy_p0_p0_i64.Invoke(cos_u, &fputil_DyadicFloat_kt2kd8, 24L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd8);
			llvm_lifetime_end_p0.Invoke(168L, &inlineArray7_fputil_DyadicFloat_kt2kd2);
			llvm_lifetime_end_p0.Invoke(168L, &inlineArray7_fputil_DyadicFloat_kt2kd);
			llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
		}
	}
}

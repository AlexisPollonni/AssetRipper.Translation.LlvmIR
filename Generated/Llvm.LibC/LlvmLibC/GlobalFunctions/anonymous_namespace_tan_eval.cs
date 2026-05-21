using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class anonymous_namespace_tan_eval
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_18tan_evalERKNS_10NumberPairIdEERS2_")]
	[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::tan_eval(__llvm_libc_20_1_2_::NumberPair<double> const&, __llvm_libc_20_1_2_::NumberPair<double>&)")]
	public unsafe static double Invoke([NativeType("__llvm_libc_20_1_2_::NumberPair<double> const&")] NumberPair* u, [NativeType("__llvm_libc_20_1_2_::NumberPair<double>&")] NumberPair* result)
	{
		double num = 0.0;
		double y = 0.0;
		double z = 0.0;
		double y2 = 0.0;
		double x = 0.0;
		double x2 = 0.0;
		double y3 = 0.0;
		double num2 = 0.0;
		double b = 0.0;
		NumberPair numberPair = default(NumberPair);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = u->hi * u->hi;
		llvm_lifetime_start_p0.Invoke(8L, &y);
		y = fputil_multiply_add_double.Invoke(num, 0.021869488536155203, 17.0 / 315.0);
		llvm_lifetime_start_p0.Invoke(8L, &z);
		z = fputil_multiply_add_double.Invoke(num, 2.0 / 15.0, 1.0 / 3.0);
		llvm_lifetime_start_p0.Invoke(8L, &y2);
		y2 = fputil_multiply_add_double.Invoke(num, 2.0 / 3.0, 1.0);
		llvm_lifetime_start_p0.Invoke(8L, &x);
		x = num * u->hi;
		llvm_lifetime_start_p0.Invoke(8L, &x2);
		x2 = num * num;
		llvm_lifetime_start_p0.Invoke(8L, &y3);
		y3 = fputil_multiply_add_double.Invoke(x2, y, z);
		llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = fputil_multiply_add_double.Invoke(num, y2, 1.0);
		llvm_lifetime_start_p0.Invoke(8L, &b);
		b = fputil_multiply_add_double.Invoke(x, y3, u->lo * num2);
		llvm_lifetime_start_p0.Invoke(16L, &numberPair);
		Struct_4ydhja struct_4ydhja = fputil_exact_add_true.Invoke(u->hi, b);
		NumberPair* num3 = &numberPair;
		Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
		unchecked
		{
			*(double*)num3 = struct_4ydhja2.field_0;
			byte* num4 = (byte*)(&numberPair) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num4 = struct_4ydhja3.field_1;
			llvm_memcpy_p0_p0_i64.Invoke(result, &numberPair, 16L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm3, x);
			long val = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_abs.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm3));
			fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.val = val;
			double result2 = fputil_multiply_add_double.Invoke(FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm2), 4.440892098500626E-16, 1.9721522630525295E-31);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			llvm_lifetime_end_p0.Invoke(8L, &b);
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &y3);
			llvm_lifetime_end_p0.Invoke(8L, &x2);
			llvm_lifetime_end_p0.Invoke(8L, &x);
			llvm_lifetime_end_p0.Invoke(8L, &y2);
			llvm_lifetime_end_p0.Invoke(8L, &z);
			llvm_lifetime_end_p0.Invoke(8L, &y);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result2;
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_18tan_evalERKNS_6fputil11DyadicFloatILm128EEE")]
	[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::tan_eval(__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&)")]
	public unsafe static void Invoke([MangledName("agg.result")] fputil_DyadicFloat_kt2kd4* agg_result, [NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&")] fputil_DyadicFloat_kt2kd4* u)
	{
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd5 = default(fputil_DyadicFloat_kt2kd4);
		InlineArray9_fputil_DyadicFloat_kt2kd4 inlineArray9_fputil_DyadicFloat_kt2kd = default(InlineArray9_fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd6 = default(fputil_DyadicFloat_kt2kd4);
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
			llvm_lifetime_start_p0.Invoke(216L, &inlineArray9_fputil_DyadicFloat_kt2kd);
			llvm_memcpy_p0_p0_i64.Invoke(&inlineArray9_fputil_DyadicFloat_kt2kd, TAN_COEFFS.Pointer, 216L, isVolatile: false);
			llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd6);
			fputil_polyeval_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul.Invoke(&fputil_DyadicFloat_kt2kd6, &fputil_DyadicFloat_kt2kd5, (fputil_DyadicFloat_kt2kd4*)(&inlineArray9_fputil_DyadicFloat_kt2kd), (fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray9_fputil_DyadicFloat_kt2kd, sizeof(fputil_DyadicFloat_kt2kd4))), (fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray9_fputil_DyadicFloat_kt2kd, (nint)2 * sizeof(fputil_DyadicFloat_kt2kd4))), (fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray9_fputil_DyadicFloat_kt2kd, (nint)3 * sizeof(fputil_DyadicFloat_kt2kd4))), (fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray9_fputil_DyadicFloat_kt2kd, (nint)4 * sizeof(fputil_DyadicFloat_kt2kd4))), (fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray9_fputil_DyadicFloat_kt2kd, (nint)5 * sizeof(fputil_DyadicFloat_kt2kd4))), (fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray9_fputil_DyadicFloat_kt2kd, (nint)6 * sizeof(fputil_DyadicFloat_kt2kd4))), (fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray9_fputil_DyadicFloat_kt2kd, (nint)7 * sizeof(fputil_DyadicFloat_kt2kd4))), (fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray9_fputil_DyadicFloat_kt2kd, (nint)8 * sizeof(fputil_DyadicFloat_kt2kd4))));
			fputil_quick_mul_128ul.Invoke(agg_result, u, &fputil_DyadicFloat_kt2kd6);
			llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd6);
			llvm_lifetime_end_p0.Invoke(216L, &inlineArray9_fputil_DyadicFloat_kt2kd);
			llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
		}
	}
}

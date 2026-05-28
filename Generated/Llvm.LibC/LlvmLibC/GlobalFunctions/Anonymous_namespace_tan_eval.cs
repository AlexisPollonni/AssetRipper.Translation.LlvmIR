using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Anonymous_namespace_tan_eval
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_18tan_evalERKNS_10NumberPairIdEERS2_")]
	[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::tan_eval(__llvm_libc_20_1_2_::NumberPair<double> const&, __llvm_libc_20_1_2_::NumberPair<double>&)")]
	public unsafe static double Invoke([MangledName("u")][NativeType("__llvm_libc_20_1_2_::NumberPair<double> const&")] NumberPair* U, [MangledName("result")][NativeType("__llvm_libc_20_1_2_::NumberPair<double>&")] NumberPair* Result)
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
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm = default(Fputil_FPBits_wjhbrm);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(Fputil_FPBits_wjhbrm);
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = U->Hi * U->Hi;
		Llvm_lifetime_start_p0.Invoke(8L, &y);
		y = Fputil_multiply_add_double.Invoke(num, 0.021869488536155203, 17.0 / 315.0);
		Llvm_lifetime_start_p0.Invoke(8L, &z);
		z = Fputil_multiply_add_double.Invoke(num, 2.0 / 15.0, 1.0 / 3.0);
		Llvm_lifetime_start_p0.Invoke(8L, &y2);
		y2 = Fputil_multiply_add_double.Invoke(num, 2.0 / 3.0, 1.0);
		Llvm_lifetime_start_p0.Invoke(8L, &x);
		x = num * U->Hi;
		Llvm_lifetime_start_p0.Invoke(8L, &x2);
		x2 = num * num;
		Llvm_lifetime_start_p0.Invoke(8L, &y3);
		y3 = Fputil_multiply_add_double.Invoke(x2, y, z);
		Llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = Fputil_multiply_add_double.Invoke(num, y2, 1.0);
		Llvm_lifetime_start_p0.Invoke(8L, &b);
		b = Fputil_multiply_add_double.Invoke(x, y3, U->Lo * num2);
		Llvm_lifetime_start_p0.Invoke(16L, &numberPair);
		Struct_4ydhja struct_4ydhja = Fputil_exact_add_true.Invoke(U->Hi, b);
		NumberPair* num3 = &numberPair;
		Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
		unchecked
		{
			*(double*)num3 = struct_4ydhja2.field_0;
			byte* num4 = (byte*)(&numberPair) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num4 = struct_4ydhja3.field_1;
			Llvm_memcpy_p0_p0_i64.Invoke(Result, &numberPair, 16L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair);
			Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
			Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm2, x);
			long val = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_abs.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
			fputil_FPBits_wjhbrm.FPRepImpl.FPRepSem.FPStorage.Val = val;
			double result = Fputil_multiply_add_double.Invoke(FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm), 4.440892098500626E-16, 1.9721522630525295E-31);
			Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
			Llvm_lifetime_end_p0.Invoke(8L, &b);
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(8L, &y3);
			Llvm_lifetime_end_p0.Invoke(8L, &x2);
			Llvm_lifetime_end_p0.Invoke(8L, &x);
			Llvm_lifetime_end_p0.Invoke(8L, &y2);
			Llvm_lifetime_end_p0.Invoke(8L, &z);
			Llvm_lifetime_end_p0.Invoke(8L, &y);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_18tan_evalERKNS_6fputil11DyadicFloatILm128EEE")]
	[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::tan_eval(__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&)")]
	public unsafe static void Invoke([MangledName("agg.result")] Fputil_DyadicFloat_kt2kd4* Agg_result, [MangledName("u")][NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&")] Fputil_DyadicFloat_kt2kd4* U)
	{
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd = default(Fputil_DyadicFloat_kt2kd4);
		InlineArray9_Fputil_DyadicFloat_kt2kd4 inlineArray9_Fputil_DyadicFloat_kt2kd = default(InlineArray9_Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd2 = default(Fputil_DyadicFloat_kt2kd4);
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
			Llvm_lifetime_start_p0.Invoke(216L, &inlineArray9_Fputil_DyadicFloat_kt2kd);
			Llvm_memcpy_p0_p0_i64.Invoke(&inlineArray9_Fputil_DyadicFloat_kt2kd, TAN_COEFFS.Pointer, 216L, isVolatile: false);
			Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd2);
			Fputil_polyeval_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul.Invoke(&fputil_DyadicFloat_kt2kd2, &fputil_DyadicFloat_kt2kd, (Fputil_DyadicFloat_kt2kd4*)(&inlineArray9_Fputil_DyadicFloat_kt2kd), (Fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray9_Fputil_DyadicFloat_kt2kd, sizeof(Fputil_DyadicFloat_kt2kd4))), (Fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray9_Fputil_DyadicFloat_kt2kd, (nint)2 * sizeof(Fputil_DyadicFloat_kt2kd4))), (Fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray9_Fputil_DyadicFloat_kt2kd, (nint)3 * sizeof(Fputil_DyadicFloat_kt2kd4))), (Fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray9_Fputil_DyadicFloat_kt2kd, (nint)4 * sizeof(Fputil_DyadicFloat_kt2kd4))), (Fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray9_Fputil_DyadicFloat_kt2kd, (nint)5 * sizeof(Fputil_DyadicFloat_kt2kd4))), (Fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray9_Fputil_DyadicFloat_kt2kd, (nint)6 * sizeof(Fputil_DyadicFloat_kt2kd4))), (Fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray9_Fputil_DyadicFloat_kt2kd, (nint)7 * sizeof(Fputil_DyadicFloat_kt2kd4))), (Fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray9_Fputil_DyadicFloat_kt2kd, (nint)8 * sizeof(Fputil_DyadicFloat_kt2kd4))));
			Fputil_quick_mul_128ul.Invoke(Agg_result, U, &fputil_DyadicFloat_kt2kd2);
			Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd2);
			Llvm_lifetime_end_p0.Invoke(216L, &inlineArray9_Fputil_DyadicFloat_kt2kd);
			Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd);
		}
	}
}

using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_exact_mult_27ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil10exact_multILm27EEENS_10NumberPairIdEERKS3_dd")]
	[DemangledName("__llvm_libc_20_1_2_::NumberPair<double> __llvm_libc_20_1_2_::fputil::exact_mult<27ul>(__llvm_libc_20_1_2_::NumberPair<double> const&, double, double)")]
	[return: NativeType("__llvm_libc_20_1_2_::NumberPair<double>")]
	public unsafe static Struct_4ydhja Invoke([MangledName("as")][NativeType("__llvm_libc_20_1_2_::NumberPair<double> const&")] Llvm_libc_20_1_2_NumberPair* As, [MangledName("a")][NativeType("double")] double A, [MangledName("b")][NativeType("double")] double B)
	{
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair2 = default(Llvm_libc_20_1_2_NumberPair);
		double parameter_ = 0.0;
		double parameter_2 = 0.0;
		double parameter_3 = 0.0;
		Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair2);
		unchecked
		{
			*(double*)(&llvm_libc_20_1_2_NumberPair2) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair2))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja = Fputil_split_27ul.Invoke(B);
			Llvm_libc_20_1_2_NumberPair* num = &llvm_libc_20_1_2_NumberPair2;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num = struct_4ydhja2.field_0;
			byte* num2 = (byte*)(&llvm_libc_20_1_2_NumberPair2) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num2 = struct_4ydhja3.field_1;
			*(double*)(&llvm_libc_20_1_2_NumberPair) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair))[1] = double.NaN;
			llvm_libc_20_1_2_NumberPair.Lo = 0.0;
			llvm_libc_20_1_2_NumberPair.Hi = 0.0;
			llvm_libc_20_1_2_NumberPair.Hi = A * B;
			Llvm_lifetime_start_p0.Invoke(8L, &parameter_);
			parameter_ = Llvm_fmuladd_f64.Invoke(As->Hi, llvm_libc_20_1_2_NumberPair2.Hi, 0.0 - llvm_libc_20_1_2_NumberPair.Hi);
			Llvm_lifetime_start_p0.Invoke(8L, &parameter_2);
			parameter_2 = Llvm_fmuladd_f64.Invoke(As->Hi, llvm_libc_20_1_2_NumberPair2.Lo, parameter_);
			Llvm_lifetime_start_p0.Invoke(8L, &parameter_3);
			parameter_3 = Llvm_fmuladd_f64.Invoke(As->Lo, llvm_libc_20_1_2_NumberPair2.Hi, parameter_2);
			llvm_libc_20_1_2_NumberPair.Lo = Llvm_fmuladd_f64.Invoke(As->Lo, llvm_libc_20_1_2_NumberPair2.Lo, parameter_3);
			Llvm_lifetime_end_p0.Invoke(8L, &parameter_3);
			Llvm_lifetime_end_p0.Invoke(8L, &parameter_2);
			Llvm_lifetime_end_p0.Invoke(8L, &parameter_);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair2);
			return *(Struct_4ydhja*)(&llvm_libc_20_1_2_NumberPair);
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil10exact_multILm27EEENS_10NumberPairIdEEdd")]
	[DemangledName("__llvm_libc_20_1_2_::NumberPair<double> __llvm_libc_20_1_2_::fputil::exact_mult<27ul>(double, double)")]
	[return: NativeType("__llvm_libc_20_1_2_::NumberPair<double>")]
	public unsafe static Struct_4ydhja Invoke([MangledName("a")][NativeType("double")] double A, [MangledName("b")][NativeType("double")] double B)
	{
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair2 = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair3 = default(Llvm_libc_20_1_2_NumberPair);
		unchecked
		{
			*(double*)(&llvm_libc_20_1_2_NumberPair) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair))[1] = double.NaN;
			llvm_libc_20_1_2_NumberPair.Lo = 0.0;
			llvm_libc_20_1_2_NumberPair.Hi = 0.0;
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair2);
			*(double*)(&llvm_libc_20_1_2_NumberPair2) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair2))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja = Fputil_split_27ul.Invoke(A);
			Llvm_libc_20_1_2_NumberPair* num = &llvm_libc_20_1_2_NumberPair2;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num = struct_4ydhja2.field_0;
			byte* num2 = (byte*)(&llvm_libc_20_1_2_NumberPair2) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num2 = struct_4ydhja3.field_1;
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair3);
			Struct_4ydhja struct_4ydhja4 = Invoke(&llvm_libc_20_1_2_NumberPair2, A, B);
			Llvm_libc_20_1_2_NumberPair* num3 = &llvm_libc_20_1_2_NumberPair3;
			Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
			*(double*)num3 = struct_4ydhja5.field_0;
			byte* num4 = (byte*)(&llvm_libc_20_1_2_NumberPair3) + 8u;
			Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
			*(double*)num4 = struct_4ydhja6.field_1;
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_NumberPair, &llvm_libc_20_1_2_NumberPair3, 16L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair3);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair2);
			return *(Struct_4ydhja*)(&llvm_libc_20_1_2_NumberPair);
		}
	}
}

using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil10exact_multILm27EEENS_10NumberPairIdEERKS3_dd")]
[DemangledName("__llvm_libc_20_1_2_::NumberPair<double> __llvm_libc_20_1_2_::fputil::exact_mult<27ul>(__llvm_libc_20_1_2_::NumberPair<double> const&, double, double)")]
internal static partial class NumberPair_double_fputil_exact_mult_27ul_NumberPair_double_const_double_double
{
	public unsafe static Struct_4ydhja Invoke(NumberPair* @as, double a, double b)
	{
		NumberPair numberPair = default(NumberPair);
		NumberPair numberPair2 = default(NumberPair);
		double parameter_ = 0.0;
		double parameter_2 = 0.0;
		double parameter_3 = 0.0;
		llvm_lifetime_start_p0.Invoke(16L, &numberPair2);
		unchecked
		{
			*(double*)(&numberPair2) = double.NaN;
			((double*)(&numberPair2))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja = NumberPair_double_fputil_split_27ul_double.Invoke(b);
			NumberPair* num = &numberPair2;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num = struct_4ydhja2.field_0;
			byte* num2 = (byte*)(&numberPair2) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num2 = struct_4ydhja3.field_1;
			*(double*)(&numberPair) = double.NaN;
			((double*)(&numberPair))[1] = double.NaN;
			numberPair.lo = 0.0;
			numberPair.hi = 0.0;
			numberPair.hi = a * b;
			llvm_lifetime_start_p0.Invoke(8L, &parameter_);
			parameter_ = llvm_fmuladd_f64.Invoke(@as->hi, numberPair2.hi, 0.0 - numberPair.hi);
			llvm_lifetime_start_p0.Invoke(8L, &parameter_2);
			parameter_2 = llvm_fmuladd_f64.Invoke(@as->hi, numberPair2.lo, parameter_);
			llvm_lifetime_start_p0.Invoke(8L, &parameter_3);
			parameter_3 = llvm_fmuladd_f64.Invoke(@as->lo, numberPair2.hi, parameter_2);
			numberPair.lo = llvm_fmuladd_f64.Invoke(@as->lo, numberPair2.lo, parameter_3);
			llvm_lifetime_end_p0.Invoke(8L, &parameter_3);
			llvm_lifetime_end_p0.Invoke(8L, &parameter_2);
			llvm_lifetime_end_p0.Invoke(8L, &parameter_);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair2);
			return *(Struct_4ydhja*)(&numberPair);
		}
	}
}

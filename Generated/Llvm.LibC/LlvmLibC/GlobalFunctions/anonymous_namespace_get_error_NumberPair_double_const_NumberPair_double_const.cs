using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_19get_errorERKNS_10NumberPairIdEES4_")]
[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::get_error(__llvm_libc_20_1_2_::NumberPair<double> const&, __llvm_libc_20_1_2_::NumberPair<double> const&)")]
internal static partial class anonymous_namespace_get_error_NumberPair_double_const_NumberPair_double_const
{
	public unsafe static double Invoke(NumberPair* x_3, NumberPair* a_sq)
	{
		NumberPair numberPair = default(NumberPair);
		llvm_lifetime_start_p0.Invoke(16L, &numberPair);
		unchecked
		{
			*(double*)(&numberPair) = double.NaN;
			((double*)(&numberPair))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja = NumberPair_double_fputil_quick_mult_27ul_NumberPair_double_const_NumberPair_double_const.Invoke(a_sq, x_3);
			NumberPair* num = &numberPair;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num = struct_4ydhja2.field_0;
			byte* num2 = (byte*)(&numberPair) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num2 = struct_4ydhja3.field_1;
			double result = numberPair.hi - 1.0 + numberPair.lo;
			llvm_lifetime_end_p0.Invoke(16L, &numberPair);
			return result;
		}
	}
}

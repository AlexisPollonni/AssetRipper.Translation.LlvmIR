using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Anonymous_namespace_get_error
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_19get_errorERKNS_10NumberPairIdEES4_")]
	[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::get_error(__llvm_libc_20_1_2_::NumberPair<double> const&, __llvm_libc_20_1_2_::NumberPair<double> const&)")]
	public unsafe static double Invoke([MangledName("x_3")][NativeType("__llvm_libc_20_1_2_::NumberPair<double> const&")] NumberPair* X_3, [MangledName("a_sq")][NativeType("__llvm_libc_20_1_2_::NumberPair<double> const&")] NumberPair* A_sq)
	{
		NumberPair numberPair = default(NumberPair);
		Llvm_lifetime_start_p0.Invoke(16L, &numberPair);
		unchecked
		{
			*(double*)(&numberPair) = double.NaN;
			((double*)(&numberPair))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja = Fputil_quick_mult_27ul.Invoke(A_sq, X_3);
			NumberPair* num = &numberPair;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num = struct_4ydhja2.field_0;
			byte* num2 = (byte*)(&numberPair) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num2 = struct_4ydhja3.field_1;
			double result = numberPair.Hi - 1.0 + numberPair.Lo;
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair);
			return result;
		}
	}
}

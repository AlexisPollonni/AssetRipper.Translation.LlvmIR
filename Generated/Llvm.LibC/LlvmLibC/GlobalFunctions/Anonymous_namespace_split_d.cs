using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Anonymous_namespace_split_d
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_17split_dEd")]
	[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::split_d(double)")]
	public unsafe static Struct_4ydhja Invoke([MangledName("a")][NativeType("double")] double A)
	{
		NumberPair numberPair = default(NumberPair);
		double num = 0.0;
		double num2 = 0.0;
		double num3 = 0.0;
		unchecked
		{
			*(double*)(&numberPair) = double.NaN;
			((double*)(&numberPair))[1] = double.NaN;
			numberPair.Lo = 0.0;
			numberPair.Hi = 0.0;
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = 8589934593.0;
			Llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = 8589934593.0 * A;
			Llvm_lifetime_start_p0.Invoke(8L, &num3);
			num3 = A - num2;
			numberPair.Hi = num2 + num3;
			numberPair.Lo = A - numberPair.Hi;
			Llvm_lifetime_end_p0.Invoke(8L, &num3);
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return *(Struct_4ydhja*)(&numberPair);
		}
	}
}

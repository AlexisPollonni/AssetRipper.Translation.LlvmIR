using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class anonymous_namespace_split_d
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_17split_dEd")]
	[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::split_d(double)")]
	public unsafe static Struct_4ydhja Invoke([NativeType("double")] double a)
	{
		NumberPair numberPair = default(NumberPair);
		double num = 0.0;
		double num2 = 0.0;
		double num3 = 0.0;
		unchecked
		{
			*(double*)(&numberPair) = double.NaN;
			((double*)(&numberPair))[1] = double.NaN;
			numberPair.lo = 0.0;
			numberPair.hi = 0.0;
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = 8589934593.0;
			llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = 8589934593.0 * a;
			llvm_lifetime_start_p0.Invoke(8L, &num3);
			num3 = a - num2;
			numberPair.hi = num2 + num3;
			numberPair.lo = a - numberPair.hi;
			llvm_lifetime_end_p0.Invoke(8L, &num3);
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return *(Struct_4ydhja*)(&numberPair);
		}
	}
}

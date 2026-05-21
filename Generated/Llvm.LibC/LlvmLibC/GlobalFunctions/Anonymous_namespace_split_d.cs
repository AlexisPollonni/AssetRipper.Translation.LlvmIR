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
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair = default(Llvm_libc_20_1_2_NumberPair);
		double num = 0.0;
		double num2 = 0.0;
		double num3 = 0.0;
		unchecked
		{
			*(double*)(&llvm_libc_20_1_2_NumberPair) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair))[1] = double.NaN;
			llvm_libc_20_1_2_NumberPair.Lo = 0.0;
			llvm_libc_20_1_2_NumberPair.Hi = 0.0;
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = 8589934593.0;
			Llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = 8589934593.0 * A;
			Llvm_lifetime_start_p0.Invoke(8L, &num3);
			num3 = A - num2;
			llvm_libc_20_1_2_NumberPair.Hi = num2 + num3;
			llvm_libc_20_1_2_NumberPair.Lo = A - llvm_libc_20_1_2_NumberPair.Hi;
			Llvm_lifetime_end_p0.Invoke(8L, &num3);
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return *(Struct_4ydhja*)(&llvm_libc_20_1_2_NumberPair);
		}
	}
}

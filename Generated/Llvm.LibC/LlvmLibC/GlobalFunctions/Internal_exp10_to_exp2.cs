using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_exp10_to_exp2
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal13exp10_to_exp2Ei")]
	[DemangledName("__llvm_libc_20_1_2_::internal::exp10_to_exp2(int)")]
	public static int Invoke([MangledName("exp10")][NativeType("int")] int Exp10)
	{
		unchecked
		{
			return (int)(checked(217706L * Exp10) >> 16);
		}
	}
}

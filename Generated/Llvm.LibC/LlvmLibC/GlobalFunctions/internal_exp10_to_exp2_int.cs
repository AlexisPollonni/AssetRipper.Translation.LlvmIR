using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal13exp10_to_exp2Ei")]
[DemangledName("__llvm_libc_20_1_2_::internal::exp10_to_exp2(int)")]
internal static partial class internal_exp10_to_exp2_int
{
	public static int Invoke(int exp10)
	{
		unchecked
		{
			return (int)(checked(217706L * exp10) >> 16);
		}
	}
}

using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_fwait
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal5fwaitEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::fwait()")]
	public static void Invoke()
	{
		IntrinsicFunctions.AsmFwait();
	}
}

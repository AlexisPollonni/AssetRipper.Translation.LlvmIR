using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal5fwaitEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::fwait()")]
internal static partial class fputil_internal_fwait
{
	public static void Invoke()
	{
		IntrinsicFunctions.AsmFwait();
	}
}

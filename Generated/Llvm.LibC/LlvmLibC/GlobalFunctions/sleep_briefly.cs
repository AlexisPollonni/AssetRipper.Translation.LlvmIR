using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class sleep_briefly
{
	[MangledName("_ZN19__llvm_libc_20_1_2_13sleep_brieflyEv")]
	[DemangledName("__llvm_libc_20_1_2_::sleep_briefly()")]
	public static void Invoke()
	{
		llvm_x86_sse2_pause.Invoke();
	}
}

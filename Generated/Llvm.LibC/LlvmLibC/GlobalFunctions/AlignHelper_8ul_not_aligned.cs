using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class AlignHelper_8ul_not_aligned
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_11AlignHelperILm8EE11not_alignedEv")]
	[DemangledName("__llvm_libc_20_1_2_::AlignHelper<8ul>::not_aligned() const")]
	public unsafe static bool Invoke(void* @this)
	{
		return unchecked((fputil_internal_FPStorage_v3nexn*)@this)->val != 8L;
	}
}

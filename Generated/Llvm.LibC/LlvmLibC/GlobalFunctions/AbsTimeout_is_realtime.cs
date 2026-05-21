using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class AbsTimeout_is_realtime
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_8internal10AbsTimeout11is_realtimeEv")]
	[DemangledName("__llvm_libc_20_1_2_::internal::AbsTimeout::is_realtime() const")]
	public unsafe static bool Invoke(internal_AbsTimeout* @this)
	{
		return (@this->realtime_flag & 1) == 1;
	}
}

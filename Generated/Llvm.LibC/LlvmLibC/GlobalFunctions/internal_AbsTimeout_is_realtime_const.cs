using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_8internal10AbsTimeout11is_realtimeEv")]
[DemangledName("__llvm_libc_20_1_2_::internal::AbsTimeout::is_realtime() const")]
internal static partial class internal_AbsTimeout_is_realtime_const
{
	public unsafe static bool Invoke(void* @this)
	{
		return (unchecked((internal_AbsTimeout*)@this)->realtime_flag & 1) == 1;
	}
}

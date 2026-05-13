using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_8internal10AbsTimeout12get_timespecEv")]
[DemangledName("__llvm_libc_20_1_2_::internal::AbsTimeout::get_timespec() const")]
internal static partial class internal_AbsTimeout_get_timespec_const
{
	public unsafe static AuxEntry* Invoke(internal_AbsTimeout* @this)
	{
		return &@this->timeout;
	}
}

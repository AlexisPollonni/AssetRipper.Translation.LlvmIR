using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class AbsTimeout_get_timespec
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_8internal10AbsTimeout12get_timespecEv")]
	[DemangledName("__llvm_libc_20_1_2_::internal::AbsTimeout::get_timespec() const")]
	public unsafe static AuxEntry* Invoke([MangledName("this")] Internal_AbsTimeout* This)
	{
		return &This->Timeout;
	}
}

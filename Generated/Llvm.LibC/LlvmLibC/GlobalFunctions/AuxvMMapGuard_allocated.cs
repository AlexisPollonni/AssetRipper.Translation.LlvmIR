using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class AuxvMMapGuard_allocated
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_13AuxvMMapGuard9allocatedEv")]
	[DemangledName("__llvm_libc_20_1_2_::AuxvMMapGuard::allocated() const")]
	public unsafe static bool Invoke(void* @this)
	{
		return unchecked(((anon_5uk363*)@this)->field_0 != (void*)(-1L));
	}
}

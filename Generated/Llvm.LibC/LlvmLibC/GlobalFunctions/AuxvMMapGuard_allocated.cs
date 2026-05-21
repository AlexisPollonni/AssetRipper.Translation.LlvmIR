using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class AuxvMMapGuard_allocated
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_13AuxvMMapGuard9allocatedEv")]
	[DemangledName("__llvm_libc_20_1_2_::AuxvMMapGuard::allocated() const")]
	public unsafe static bool Invoke([MangledName("this")] void* This)
	{
		return unchecked(((Anon_5uk363*)This)->field_0 != (void*)(-1L));
	}
}

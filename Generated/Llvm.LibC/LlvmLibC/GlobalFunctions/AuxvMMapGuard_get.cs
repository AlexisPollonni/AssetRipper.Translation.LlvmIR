using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class AuxvMMapGuard_get
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_13AuxvMMapGuard3getEv")]
	[DemangledName("__llvm_libc_20_1_2_::AuxvMMapGuard::get() const")]
	public unsafe static void* Invoke([MangledName("this")] void* This)
	{
		return unchecked((Anon_5uk363*)This)->field_0;
	}
}

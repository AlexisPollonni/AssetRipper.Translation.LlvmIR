using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class AuxvFdGuard_get
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_11AuxvFdGuard3getEv")]
	[DemangledName("__llvm_libc_20_1_2_::AuxvFdGuard::get() const")]
	public unsafe static int Invoke([MangledName("this")] void* This)
	{
		return unchecked((Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)This)->field_0;
	}
}

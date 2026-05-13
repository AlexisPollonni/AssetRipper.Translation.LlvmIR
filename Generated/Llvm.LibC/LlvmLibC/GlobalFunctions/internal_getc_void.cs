using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal4getcEPv")]
[DemangledName("__llvm_libc_20_1_2_::internal::getc(void*)")]
internal static partial class internal_getc_void
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<void*, int>)(&Invoke));

	public unsafe static int Invoke(void* f)
	{
		return getc.Invoke(f);
	}
}

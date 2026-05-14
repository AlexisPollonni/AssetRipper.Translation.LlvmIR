using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal6ungetcEiPv")]
[DemangledName("__llvm_libc_20_1_2_::internal::ungetc(int, void*)")]
internal static partial class internal_ungetc_int_void
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<int, void*, void>)(&Invoke));

	public unsafe static void Invoke(int c, void* f)
	{
		ungetc.Invoke(c, f);
	}
}

using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_getc
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<void*, int>)(&Invoke));

	[MangledName("_ZN19__llvm_libc_20_1_2_8internal4getcEPv")]
	[DemangledName("__llvm_libc_20_1_2_::internal::getc(void*)")]
	public unsafe static int Invoke([NativeType("void*")] void* f)
	{
		return getc.Invoke(f);
	}
}

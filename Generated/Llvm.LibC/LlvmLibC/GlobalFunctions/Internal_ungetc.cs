using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_ungetc
{
	public unsafe static readonly void* __pointer = (delegate*<int, void*, void>)(&Invoke);

	[MangledName("_ZN19__llvm_libc_20_1_2_8internal6ungetcEiPv")]
	[DemangledName("__llvm_libc_20_1_2_::internal::ungetc(int, void*)")]
	public unsafe static void Invoke([MangledName("c")][NativeType("int")] int C, [MangledName("f")][NativeType("void*")] void* F)
	{
		Ungetc.Invoke(C, F);
	}
}

using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_flockfile
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal9flockfileEP8_IO_FILE")]
	[DemangledName("__llvm_libc_20_1_2_::internal::flockfile(_IO_FILE*)")]
	public unsafe static void Invoke([MangledName("f")][NativeType("_IO_FILE*")] void* F)
	{
		Flockfile.Invoke(F);
	}
}

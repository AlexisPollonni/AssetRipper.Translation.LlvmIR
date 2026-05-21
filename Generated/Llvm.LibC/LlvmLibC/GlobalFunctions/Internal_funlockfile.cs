using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_funlockfile
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal11funlockfileEP8_IO_FILE")]
	[DemangledName("__llvm_libc_20_1_2_::internal::funlockfile(_IO_FILE*)")]
	public unsafe static void Invoke([MangledName("f")][NativeType("_IO_FILE*")] void* F)
	{
		Funlockfile.Invoke(F);
	}
}

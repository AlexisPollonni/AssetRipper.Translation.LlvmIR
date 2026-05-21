using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_ferror_unlocked
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal15ferror_unlockedEP8_IO_FILE")]
	[DemangledName("__llvm_libc_20_1_2_::internal::ferror_unlocked(_IO_FILE*)")]
	public unsafe static int Invoke([MangledName("f")][NativeType("_IO_FILE*")] void* F)
	{
		return Ferror_unlocked.Invoke(F);
	}
}

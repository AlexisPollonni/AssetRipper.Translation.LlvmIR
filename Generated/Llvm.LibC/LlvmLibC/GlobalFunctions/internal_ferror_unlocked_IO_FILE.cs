using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal15ferror_unlockedEP8_IO_FILE")]
[DemangledName("__llvm_libc_20_1_2_::internal::ferror_unlocked(_IO_FILE*)")]
internal static partial class internal_ferror_unlocked_IO_FILE
{
	public unsafe static int Invoke(void* f)
	{
		return ferror_unlocked.Invoke(f);
	}
}

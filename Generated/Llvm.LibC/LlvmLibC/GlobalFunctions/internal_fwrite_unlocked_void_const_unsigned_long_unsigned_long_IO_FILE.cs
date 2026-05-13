using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Unimplemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal15fwrite_unlockedEPKvmmP8_IO_FILE")]
[DemangledName("__llvm_libc_20_1_2_::internal::fwrite_unlocked(void const*, unsigned long, unsigned long, _IO_FILE*)")]
internal static partial class internal_fwrite_unlocked_void_const_unsigned_long_unsigned_long_IO_FILE
{
	public unsafe static long Invoke(void* ptr, long size, long nmemb, void* f)
	{
		return fwrite_unlocked.Invoke(ptr, size, nmemb, f);
	}
}

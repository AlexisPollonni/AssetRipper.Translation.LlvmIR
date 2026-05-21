using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_fwrite_unlocked
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal15fwrite_unlockedEPKvmmP8_IO_FILE")]
	[DemangledName("__llvm_libc_20_1_2_::internal::fwrite_unlocked(void const*, unsigned long, unsigned long, _IO_FILE*)")]
	public unsafe static long Invoke([NativeType("void const*")] void* ptr, [NativeType("unsigned long")] long size, [NativeType("unsigned long")] long nmemb, [NativeType("_IO_FILE*")] void* f)
	{
		return fwrite_unlocked.Invoke(ptr, size, nmemb, f);
	}
}

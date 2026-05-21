using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_fwrite_unlocked
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal15fwrite_unlockedEPKvmmP8_IO_FILE")]
	[DemangledName("__llvm_libc_20_1_2_::internal::fwrite_unlocked(void const*, unsigned long, unsigned long, _IO_FILE*)")]
	public unsafe static long Invoke([MangledName("ptr")][NativeType("void const*")] void* Ptr, [MangledName("size")][NativeType("unsigned long")] long Size, [MangledName("nmemb")][NativeType("unsigned long")] long Nmemb, [MangledName("f")][NativeType("_IO_FILE*")] void* F)
	{
		return Fwrite_unlocked.Invoke(Ptr, Size, Nmemb, F);
	}
}

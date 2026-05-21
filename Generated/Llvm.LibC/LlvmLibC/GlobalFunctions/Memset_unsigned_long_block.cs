using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memset_unsigned_long_block
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic6MemsetImE5blockEPNS_3cpp4byteEh")]
	[DemangledName("__llvm_libc_20_1_2_::generic::Memset<unsigned long>::block(__llvm_libc_20_1_2_::cpp::byte*, unsigned char)")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* dst, [NativeType("unsigned char")] sbyte value)
	{
		generic_store_unsigned_long.Invoke(dst, generic_splat_unsigned_long.Invoke(value));
	}
}

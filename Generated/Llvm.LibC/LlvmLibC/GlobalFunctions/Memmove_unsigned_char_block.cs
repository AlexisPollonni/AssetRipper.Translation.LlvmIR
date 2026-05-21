using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memmove_unsigned_char_block
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic7MemmoveIhE5blockEPNS_3cpp4byteEPKS4_")]
	[DemangledName("__llvm_libc_20_1_2_::generic::Memmove<unsigned char>::block(__llvm_libc_20_1_2_::cpp::byte*, __llvm_libc_20_1_2_::cpp::byte const*)")]
	public unsafe static void Invoke([MangledName("dst")][NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* Dst, [MangledName("src")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* Src)
	{
		Generic_store_unsigned_char.Invoke(Dst, Generic_load_unsigned_char.Invoke(Src));
	}
}

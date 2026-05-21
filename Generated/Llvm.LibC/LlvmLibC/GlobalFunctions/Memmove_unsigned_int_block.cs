using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memmove_unsigned_int_block
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic7MemmoveIjE5blockEPNS_3cpp4byteEPKS4_")]
	[DemangledName("__llvm_libc_20_1_2_::generic::Memmove<unsigned int>::block(__llvm_libc_20_1_2_::cpp::byte*, __llvm_libc_20_1_2_::cpp::byte const*)")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* dst, [NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* src)
	{
		generic_store_unsigned_int.Invoke(dst, generic_load_unsigned_int.Invoke(src));
	}
}

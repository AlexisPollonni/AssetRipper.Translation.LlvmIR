using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memcpy_8ul_block
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7builtin6MemcpyILm8EE5blockEPNS_3cpp4byteEPKS4_")]
	[DemangledName("__llvm_libc_20_1_2_::builtin::Memcpy<8ul>::block(__llvm_libc_20_1_2_::cpp::byte*, __llvm_libc_20_1_2_::cpp::byte const*)")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* dst, [NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* src)
	{
		Memcpy_8ul_block_offset.Invoke(dst, src, 0L);
	}
}

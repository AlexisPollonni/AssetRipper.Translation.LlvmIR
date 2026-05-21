using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memcpy_8ul_block_offset
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7builtin6MemcpyILm8EE12block_offsetEPNS_3cpp4byteEPKS4_m")]
	[DemangledName("__llvm_libc_20_1_2_::builtin::Memcpy<8ul>::block_offset(__llvm_libc_20_1_2_::cpp::byte*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
	public unsafe static void Invoke([MangledName("dst")][NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* Dst, [MangledName("src")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* Src, [MangledName("offset")][NativeType("unsigned long")] long Offset)
	{
		unchecked
		{
			Llvm_libc_20_1_2_memcpy_inline_8ul.Invoke((byte*)Dst + Offset, (byte*)Src + Offset);
		}
	}
}

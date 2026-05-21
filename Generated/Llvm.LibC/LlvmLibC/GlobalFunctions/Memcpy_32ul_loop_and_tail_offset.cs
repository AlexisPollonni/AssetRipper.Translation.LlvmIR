using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memcpy_32ul_loop_and_tail_offset
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7builtin6MemcpyILm32EE20loop_and_tail_offsetEPNS_3cpp4byteEPKS4_mm")]
	[DemangledName("__llvm_libc_20_1_2_::builtin::Memcpy<32ul>::loop_and_tail_offset(__llvm_libc_20_1_2_::cpp::byte*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long, unsigned long)")]
	public unsafe static void Invoke([MangledName("dst")][NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* Dst, [MangledName("src")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* Src, [MangledName("count")][NativeType("unsigned long")] long Count, [MangledName("offset")][NativeType("unsigned long")] long Offset)
	{
		long num = Offset;
		unchecked
		{
			do
			{
				Memcpy_32ul_block_offset.Invoke(Dst, Src, num);
				num += 32L;
			}
			while ((ulong)num < (ulong)(Count - 32L));
			Memcpy_32ul_tail.Invoke(Dst, Src, Count);
		}
	}
}

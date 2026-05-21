using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memcpy_32ul_loop_and_tail_offset
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7builtin6MemcpyILm32EE20loop_and_tail_offsetEPNS_3cpp4byteEPKS4_mm")]
	[DemangledName("__llvm_libc_20_1_2_::builtin::Memcpy<32ul>::loop_and_tail_offset(__llvm_libc_20_1_2_::cpp::byte*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long, unsigned long)")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* dst, [NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* src, [NativeType("unsigned long")] long count, [NativeType("unsigned long")] long offset)
	{
		long num = offset;
		unchecked
		{
			do
			{
				Memcpy_32ul_block_offset.Invoke(dst, src, num);
				num += 32L;
			}
			while ((ulong)num < (ulong)(count - 32L));
			Memcpy_32ul_tail.Invoke(dst, src, count);
		}
	}
}

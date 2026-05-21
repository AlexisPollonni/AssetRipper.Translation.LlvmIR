using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memset_cpp_array_unsigned_char_vector_16_2ul_loop_and_tail_offset
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic6MemsetINS_3cpp5arrayIDv16_hLm2EEEE20loop_and_tail_offsetEPNS2_4byteEhmm")]
	[DemangledName("__llvm_libc_20_1_2_::generic::Memset<__llvm_libc_20_1_2_::cpp::array<unsigned char vector[16], 2ul>>::loop_and_tail_offset(__llvm_libc_20_1_2_::cpp::byte*, unsigned char, unsigned long, unsigned long)")]
	public unsafe static void Invoke([MangledName("dst")][NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* Dst, [MangledName("value")][NativeType("unsigned char")] sbyte Value, [MangledName("count")][NativeType("unsigned long")] long Count, [MangledName("offset")][NativeType("unsigned long")] long Offset)
	{
		sbyte value = Value;
		long num = Offset;
		unchecked
		{
			do
			{
				Memset_cpp_array_unsigned_char_vector_16_2ul_block.Invoke((byte*)Dst + num, value);
				num += 32L;
			}
			while ((ulong)num < (ulong)(Count - 32L));
			Memset_cpp_array_unsigned_char_vector_16_2ul_tail.Invoke(Dst, value, Count);
		}
	}
}

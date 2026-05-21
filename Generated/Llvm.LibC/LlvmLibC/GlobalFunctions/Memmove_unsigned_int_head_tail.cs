using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memmove_unsigned_int_head_tail
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic7MemmoveIjE9head_tailEPNS_3cpp4byteEPKS4_m")]
	[DemangledName("__llvm_libc_20_1_2_::generic::Memmove<unsigned int>::head_tail(__llvm_libc_20_1_2_::cpp::byte*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* dst, [NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* src, [NativeType("unsigned long")] long count)
	{
		long num = 0L;
		int value = 0;
		int value2 = 0;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			num = count - 4L;
			llvm_lifetime_start_p0.Invoke(4L, &value);
			value = generic_load_unsigned_int.Invoke(src);
			llvm_lifetime_start_p0.Invoke(4L, &value2);
			value2 = generic_load_unsigned_int.Invoke((byte*)src + num);
			generic_store_unsigned_int.Invoke(dst, value);
			generic_store_unsigned_int.Invoke((byte*)dst + num, value2);
			llvm_lifetime_end_p0.Invoke(4L, &value2);
			llvm_lifetime_end_p0.Invoke(4L, &value);
			llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}

using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memmove_unsigned_long_head_tail
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic7MemmoveImE9head_tailEPNS_3cpp4byteEPKS4_m")]
	[DemangledName("__llvm_libc_20_1_2_::generic::Memmove<unsigned long>::head_tail(__llvm_libc_20_1_2_::cpp::byte*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* dst, [NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* src, [NativeType("unsigned long")] long count)
	{
		long num = 0L;
		long value = 0L;
		long value2 = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			num = count - 8L;
			llvm_lifetime_start_p0.Invoke(8L, &value);
			value = generic_load_unsigned_long.Invoke(src);
			llvm_lifetime_start_p0.Invoke(8L, &value2);
			value2 = generic_load_unsigned_long.Invoke((byte*)src + num);
			generic_store_unsigned_long.Invoke(dst, value);
			generic_store_unsigned_long.Invoke((byte*)dst + num, value2);
			llvm_lifetime_end_p0.Invoke(8L, &value2);
			llvm_lifetime_end_p0.Invoke(8L, &value);
			llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}

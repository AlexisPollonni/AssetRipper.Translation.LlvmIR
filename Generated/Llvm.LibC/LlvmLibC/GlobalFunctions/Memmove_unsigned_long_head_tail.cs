using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memmove_unsigned_long_head_tail
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic7MemmoveImE9head_tailEPNS_3cpp4byteEPKS4_m")]
	[DemangledName("__llvm_libc_20_1_2_::generic::Memmove<unsigned long>::head_tail(__llvm_libc_20_1_2_::cpp::byte*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
	public unsafe static void Invoke([MangledName("dst")][NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* Dst, [MangledName("src")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* Src, [MangledName("count")][NativeType("unsigned long")] long Count)
	{
		long num = 0L;
		long value = 0L;
		long value2 = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			num = Count - 8L;
			Llvm_lifetime_start_p0.Invoke(8L, &value);
			value = Generic_load_unsigned_long.Invoke(Src);
			Llvm_lifetime_start_p0.Invoke(8L, &value2);
			value2 = Generic_load_unsigned_long.Invoke((byte*)Src + num);
			Generic_store_unsigned_long.Invoke(Dst, value);
			Generic_store_unsigned_long.Invoke((byte*)Dst + num, value2);
			Llvm_lifetime_end_p0.Invoke(8L, &value2);
			Llvm_lifetime_end_p0.Invoke(8L, &value);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}

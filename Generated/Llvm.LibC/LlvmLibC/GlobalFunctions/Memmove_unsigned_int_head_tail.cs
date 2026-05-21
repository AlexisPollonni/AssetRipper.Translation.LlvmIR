using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memmove_unsigned_int_head_tail
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic7MemmoveIjE9head_tailEPNS_3cpp4byteEPKS4_m")]
	[DemangledName("__llvm_libc_20_1_2_::generic::Memmove<unsigned int>::head_tail(__llvm_libc_20_1_2_::cpp::byte*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
	public unsafe static void Invoke([MangledName("dst")][NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* Dst, [MangledName("src")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* Src, [MangledName("count")][NativeType("unsigned long")] long Count)
	{
		long num = 0L;
		int value = 0;
		int value2 = 0;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			num = Count - 4L;
			Llvm_lifetime_start_p0.Invoke(4L, &value);
			value = Generic_load_unsigned_int.Invoke(Src);
			Llvm_lifetime_start_p0.Invoke(4L, &value2);
			value2 = Generic_load_unsigned_int.Invoke((byte*)Src + num);
			Generic_store_unsigned_int.Invoke(Dst, value);
			Generic_store_unsigned_int.Invoke((byte*)Dst + num, value2);
			Llvm_lifetime_end_p0.Invoke(4L, &value2);
			Llvm_lifetime_end_p0.Invoke(4L, &value);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}

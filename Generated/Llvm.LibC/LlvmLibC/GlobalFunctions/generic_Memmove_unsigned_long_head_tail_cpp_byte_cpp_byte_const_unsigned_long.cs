using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic7MemmoveImE9head_tailEPNS_3cpp4byteEPKS4_m")]
[DemangledName("__llvm_libc_20_1_2_::generic::Memmove<unsigned long>::head_tail(__llvm_libc_20_1_2_::cpp::byte*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
internal static partial class generic_Memmove_unsigned_long_head_tail_cpp_byte_cpp_byte_const_unsigned_long
{
	public unsafe static void Invoke(void* dst, void* src, long count)
	{
		long num = 0L;
		long value = 0L;
		long value2 = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			num = count - 8L;
			llvm_lifetime_start_p0.Invoke(8L, &value);
			value = unsigned_long_generic_load_unsigned_long_cpp_byte_const.Invoke(src);
			llvm_lifetime_start_p0.Invoke(8L, &value2);
			value2 = unsigned_long_generic_load_unsigned_long_cpp_byte_const.Invoke((byte*)src + num);
			void_generic_store_unsigned_long_cpp_byte_unsigned_long.Invoke(dst, value);
			void_generic_store_unsigned_long_cpp_byte_unsigned_long.Invoke((byte*)dst + num, value2);
			llvm_lifetime_end_p0.Invoke(8L, &value2);
			llvm_lifetime_end_p0.Invoke(8L, &value);
			llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}

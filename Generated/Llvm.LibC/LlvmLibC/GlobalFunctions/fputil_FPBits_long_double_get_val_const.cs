using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil6FPBitsIeE7get_valEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<long double>::get_val() const")]
internal static partial class fputil_FPBits_long_double_get_val_const
{
	public unsafe static double Invoke(void* @this)
	{
		return cpp_enable_if_sizeof_long_double_sizeof_unsigned_int128_cpp_is_trivially_constructible_long_double_value_cpp_is_trivially_copyable_long_double_value_cpp_is_trivially_copyable_unsigned_int128_value_long_double_type_cpp_bit_cast_long_double_unsigned_int128_unsigned_int128_const.Invoke(&unchecked((fputil_internal_FPStorage_w3h7gw*)@this)->field_0);
	}
}

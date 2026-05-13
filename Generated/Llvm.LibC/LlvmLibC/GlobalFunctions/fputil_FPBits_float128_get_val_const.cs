using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil6FPBitsIgE7get_valEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<__float128>::get_val() const")]
internal static partial class fputil_FPBits_float128_get_val_const
{
	public unsafe static double Invoke(void* @this)
	{
		return cpp_enable_if_sizeof_float128_sizeof_unsigned_int128_cpp_is_trivially_constructible_float128_value_cpp_is_trivially_copyable_float128_value_cpp_is_trivially_copyable_unsigned_int128_value_float128_type_cpp_bit_cast_float128_unsigned_int128_unsigned_int128_const.Invoke(&unchecked((fputil_internal_FPStorage_w3h7gw*)@this)->field_0);
	}
}

using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil6FPBitsIdE7get_valEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<double>::get_val() const")]
internal static partial class fputil_FPBits_double_get_val_const
{
	public unsafe static double Invoke(void* @this)
	{
		return cpp_enable_if_sizeof_double_sizeof_unsigned_long_cpp_is_trivially_constructible_double_value_cpp_is_trivially_copyable_double_value_cpp_is_trivially_copyable_unsigned_long_value_double_type_cpp_bit_cast_double_unsigned_long_unsigned_long_const.Invoke(&unchecked((fputil_internal_FPStorage_v3nexn*)@this)->val);
	}
}

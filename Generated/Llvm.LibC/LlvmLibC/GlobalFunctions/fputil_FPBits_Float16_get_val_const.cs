using System;
using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil6FPBitsIDF16_E7get_valEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<_Float16>::get_val() const")]
internal static partial class fputil_FPBits_Float16_get_val_const
{
	public unsafe static Half Invoke(fputil_FPBits_2fahva* @this)
	{
		return cpp_enable_if_sizeof_Float16_sizeof_unsigned_short_cpp_is_trivially_constructible_Float16_value_cpp_is_trivially_copyable_Float16_value_cpp_is_trivially_copyable_unsigned_short_value_Float16_type_cpp_bit_cast_Float16_unsigned_short_unsigned_short_const.Invoke(&unchecked((fputil_internal_FPStorage_za9n4f*)@this)->field_0);
	}
}

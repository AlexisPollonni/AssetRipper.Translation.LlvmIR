using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil6FPBitsIfE7get_valEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<float>::get_val() const")]
internal static partial class fputil_FPBits_float_get_val_const
{
	public unsafe static float Invoke(void* @this)
	{
		return cpp_enable_if_sizeof_float_sizeof_unsigned_int_cpp_is_trivially_constructible_float_value_cpp_is_trivially_copyable_float_value_cpp_is_trivially_copyable_unsigned_int_value_float_type_cpp_bit_cast_float_unsigned_int_unsigned_int_const.Invoke(&unchecked((fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)@this)->field_0);
	}
}

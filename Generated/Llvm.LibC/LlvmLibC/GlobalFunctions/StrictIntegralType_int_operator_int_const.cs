using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_18StrictIntegralTypeIiEcviEv")]
[DemangledName("__llvm_libc_20_1_2_::StrictIntegralType<int>::operator int() const")]
internal static partial class StrictIntegralType_int_operator_int_const
{
	public unsafe static int Invoke(void* @this)
	{
		return cpp_enable_if_sizeof_int_sizeof_int_cpp_is_trivially_constructible_int_value_cpp_is_trivially_copyable_int_value_cpp_is_trivially_copyable_int_value_int_type_cpp_bit_cast_int_int_int_const.Invoke(&unchecked((fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)@this)->field_0);
	}
}

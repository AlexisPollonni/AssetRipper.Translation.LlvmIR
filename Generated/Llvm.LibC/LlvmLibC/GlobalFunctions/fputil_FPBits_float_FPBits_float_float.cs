using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil6FPBitsIfEC2IfEET_")]
[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<float>::FPBits<float>(float)")]
internal static partial class fputil_FPBits_float_FPBits_float_float
{
	public unsafe static void Invoke(void* @this, float x)
	{
		float num = x;
		fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_FPRepImpl.Invoke(@this);
		unchecked((fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)@this)->field_0 = cpp_enable_if_sizeof_unsigned_int_sizeof_float_cpp_is_trivially_constructible_unsigned_int_value_cpp_is_trivially_copyable_unsigned_int_value_cpp_is_trivially_copyable_float_value_unsigned_int_type_cpp_bit_cast_unsigned_int_float_float_const.Invoke(&num);
	}
}

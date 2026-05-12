using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil6FPBitsIdEC2IdEET_")]
[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<double>::FPBits<double>(double)")]
internal static partial class fputil_FPBits_double_FPBits_double_double
{
	public unsafe static void Invoke(void* @this, double x)
	{
		double num = x;
		unchecked
		{
			fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_FPRepImpl.Invoke((fputil_internal_FPRepImpl_ucubaq*)@this);
			((fputil_internal_FPStorage_v3nexn*)@this)->val = cpp_enable_if_sizeof_unsigned_long_sizeof_double_cpp_is_trivially_constructible_unsigned_long_value_cpp_is_trivially_copyable_unsigned_long_value_cpp_is_trivially_copyable_double_value_unsigned_long_type_cpp_bit_cast_unsigned_long_double_double_const.Invoke(&num);
		}
	}
}

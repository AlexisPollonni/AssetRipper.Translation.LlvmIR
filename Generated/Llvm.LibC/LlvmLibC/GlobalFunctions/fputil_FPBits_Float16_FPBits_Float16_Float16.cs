using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil6FPBitsIDF16_EC2IDF16_EET_")]
[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<_Float16>::FPBits<_Float16>(_Float16)")]
internal static partial class fputil_FPBits_Float16_FPBits_Float16_Float16
{
	public unsafe static void Invoke(fputil_FPBits_2fahva* @this, Half x)
	{
		Half half = x;
		unchecked
		{
			fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_FPRepImpl.Invoke((fputil_internal_FPRepImpl_7z3gh9*)@this);
			((fputil_internal_FPStorage_za9n4f*)@this)->field_0 = cpp_enable_if_sizeof_unsigned_short_sizeof_Float16_cpp_is_trivially_constructible_unsigned_short_value_cpp_is_trivially_copyable_unsigned_short_value_cpp_is_trivially_copyable_Float16_value_unsigned_short_type_cpp_bit_cast_unsigned_short_Float16_Float16_const.Invoke(&half);
		}
	}
}

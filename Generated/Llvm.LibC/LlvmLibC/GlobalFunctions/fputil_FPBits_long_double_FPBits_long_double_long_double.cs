using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil6FPBitsIeEC2IeEET_")]
[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<long double>::FPBits<long double>(long double)")]
internal static partial class fputil_FPBits_long_double_FPBits_long_double_long_double
{
	public unsafe static void Invoke(void* @this, double x)
	{
		Int128 field_ = default(Int128);
		double num = x;
		fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_FPRepImpl.Invoke(@this);
		Struct_fiz2nb struct_fiz2nb = cpp_enable_if_sizeof_unsigned_int128_sizeof_long_double_cpp_is_trivially_constructible_unsigned_int128_value_cpp_is_trivially_copyable_unsigned_int128_value_cpp_is_trivially_copyable_long_double_value_unsigned_int128_type_cpp_bit_cast_unsigned_int128_long_double_long_double_const.Invoke(&num);
		Int128* num2 = &field_;
		Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
		unchecked
		{
			*(long*)num2 = struct_fiz2nb2.field_0;
			byte* num3 = (byte*)(&field_) + 8u;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			*(long*)num3 = struct_fiz2nb3.field_1;
			((fputil_internal_FPStorage_w3h7gw*)@this)->field_0 = field_;
		}
	}
}

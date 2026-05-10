using System;
using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal8FPRepSemILNS0_6FPTypeE4ENS0_6FPBitsIeEEE21get_explicit_mantissaEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepSem<(__llvm_libc_20_1_2_::fputil::FPType)4, __llvm_libc_20_1_2_::fputil::FPBits<long double>>::get_explicit_mantissa() const")]
internal static partial class fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_get_explicit_mantissa_const
{
	public unsafe static Struct_fiz2nb Invoke(void* @this)
	{
		Int128 @int = default(Int128);
		Struct_fiz2nb struct_fiz2nb = fputil_internal_FPStorage_fputil_FPType_4_sig_bits_const.Invoke(@this);
		Int128* num = &@int;
		Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
		unchecked
		{
			*(long*)num = struct_fiz2nb2.field_0;
			byte* num2 = (byte*)(&@int) + 8u;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			*(long*)num2 = struct_fiz2nb3.field_1;
			Int128 int2 = @int;
			return *(Struct_fiz2nb*)(&int2);
		}
	}
}

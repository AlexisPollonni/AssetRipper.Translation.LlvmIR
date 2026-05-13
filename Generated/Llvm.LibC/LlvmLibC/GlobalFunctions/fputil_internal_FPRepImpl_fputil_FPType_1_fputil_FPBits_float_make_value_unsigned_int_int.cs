using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE1ENS0_6FPBitsIfEEE10make_valueEji")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)1, __llvm_libc_20_1_2_::fputil::FPBits<float>>::make_value(unsigned int, int)")]
internal static partial class fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_make_value_unsigned_int_int
{
	public unsafe static int Invoke(int number, int ep)
	{
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		fputil_internal_FPRepImpl_vhj4tm fputil_internal_FPRepImpl_vhj4tm2 = default(fputil_internal_FPRepImpl_vhj4tm);
		int num = 0;
		int num2 = number;
		int num3 = ep;
		llvm_lifetime_start_p0.Invoke(4L, &fputil_internal_FPRepImpl_vhj4tm2);
		*unchecked((int*)(&fputil_internal_FPRepImpl_vhj4tm2)) = -1431655766;
		fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_FPRepImpl_unsigned_int.Invoke(&fputil_internal_FPRepImpl_vhj4tm2, 0);
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 24 - (32 - cpp_enable_if_cpp_is_unsigned_v_unsigned_int_int_type_cpp_countl_zero_unsigned_int_unsigned_int.Invoke(num2));
		num2 <<= num;
		num3 -= num;
		if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num3 >= 0, expected: true))
		{
			fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_set_significand_unsigned_int.Invoke(&fputil_internal_FPRepImpl_vhj4tm2, num2);
			fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_set_biased_exponent_unsigned_int.Invoke(&fputil_internal_FPRepImpl_vhj4tm2, num3 + 1);
		}
		else
		{
			fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_set_significand_unsigned_int.Invoke(&fputil_internal_FPRepImpl_vhj4tm2, num2 >>> -num3);
		}
		fputil_FPBits_float_FPBits_unsigned_int_unsigned_int.Invoke(&fputil_FPBits_5nkvcs2, fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke(&fputil_internal_FPRepImpl_vhj4tm2));
		llvm_lifetime_end_p0.Invoke(4L, &num);
		llvm_lifetime_end_p0.Invoke(4L, &fputil_internal_FPRepImpl_vhj4tm2);
		return fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0;
	}
}

using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepImpl_fputil_FPType_1_fputil_FPBits_float_make_value
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE1ENS0_6FPBitsIfEEE10make_valueEji")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)1, __llvm_libc_20_1_2_::fputil::FPBits<float>>::make_value(unsigned int, int)")]
	public unsafe static int Invoke([NativeType("unsigned int")] int number, [NativeType("int")] int ep)
	{
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		fputil_internal_FPRepImpl_vhj4tm fputil_internal_FPRepImpl_vhj4tm2 = default(fputil_internal_FPRepImpl_vhj4tm);
		int num = 0;
		int num2 = number;
		int num3 = ep;
		llvm_lifetime_start_p0.Invoke(4L, &fputil_internal_FPRepImpl_vhj4tm2);
		*unchecked((int*)(&fputil_internal_FPRepImpl_vhj4tm2)) = -1431655766;
		FPRepImpl_fputil_FPType_1_fputil_FPBits_float_Constructor.Invoke(&fputil_internal_FPRepImpl_vhj4tm2, 0);
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 24 - (32 - cpp_countl_zero_unsigned_int.Invoke(num2));
		num2 <<= num;
		num3 -= num;
		if (details_expects_bool_condition_bool.Invoke(num3 >= 0, expected: true))
		{
			FPRepImpl_fputil_FPType_1_fputil_FPBits_float_set_significand.Invoke(&fputil_internal_FPRepImpl_vhj4tm2, num2);
			FPRepImpl_fputil_FPType_1_fputil_FPBits_float_set_biased_exponent.Invoke(&fputil_internal_FPRepImpl_vhj4tm2, num3 + 1);
		}
		else
		{
			FPRepImpl_fputil_FPType_1_fputil_FPBits_float_set_significand.Invoke(&fputil_internal_FPRepImpl_vhj4tm2, num2 >>> -num3);
		}
		FPBits_float_FPBits_unsigned_int.Invoke(&fputil_FPBits_5nkvcs2, FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke(&fputil_internal_FPRepImpl_vhj4tm2));
		llvm_lifetime_end_p0.Invoke(4L, &num);
		llvm_lifetime_end_p0.Invoke(4L, &fputil_internal_FPRepImpl_vhj4tm2);
		return fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0;
	}
}

using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepImpl_fputil_FPType_1_fputil_FPBits_float_make_value
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE1ENS0_6FPBitsIfEEE10make_valueEji")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)1, __llvm_libc_20_1_2_::fputil::FPBits<float>>::make_value(unsigned int, int)")]
	public unsafe static int Invoke([MangledName("number")][NativeType("unsigned int")] int Number, [MangledName("ep")][NativeType("int")] int Ep)
	{
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm = default(Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm);
		int num = 0;
		int num2 = Number;
		int num3 = Ep;
		Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm);
		*unchecked((int*)(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm)) = -1431655766;
		FPRepImpl_fputil_FPType_1_fputil_FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm, 0);
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 24 - (32 - Cpp_countl_zero_unsigned_int.Invoke(num2));
		num2 <<= num;
		num3 -= num;
		if (Details_expects_bool_condition_bool.Invoke(num3 >= 0, Expected: true))
		{
			FPRepImpl_fputil_FPType_1_fputil_FPBits_float_set_significand.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm, num2);
			FPRepImpl_fputil_FPType_1_fputil_FPBits_float_set_biased_exponent.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm, num3 + 1);
		}
		else
		{
			FPRepImpl_fputil_FPType_1_fputil_FPBits_float_set_significand.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm, num2 >>> -num3);
		}
		FPBits_float_FPBits_unsigned_int.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs, FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm));
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm);
		return llvm_libc_20_1_2_fputil_FPBits_5nkvcs.FPRepImpl.FPRepSem.field_0.field_0;
	}
}

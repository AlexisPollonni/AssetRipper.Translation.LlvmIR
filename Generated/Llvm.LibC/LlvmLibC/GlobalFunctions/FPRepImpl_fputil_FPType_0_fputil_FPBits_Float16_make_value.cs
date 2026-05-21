using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_make_value
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE0ENS0_6FPBitsIDF16_EEE10make_valueEti")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)0, __llvm_libc_20_1_2_::fputil::FPBits<_Float16>>::make_value(unsigned short, int)")]
	public unsafe static short Invoke([NativeType("unsigned short")] short number, [NativeType("int")] int ep)
	{
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		fputil_internal_FPRepImpl_7z3gh9 fputil_internal_FPRepImpl_7z3gh10 = default(fputil_internal_FPRepImpl_7z3gh9);
		int num = 0;
		short num2 = number;
		int num3 = ep;
		llvm_lifetime_start_p0.Invoke(2L, &fputil_internal_FPRepImpl_7z3gh10);
		*unchecked((short*)(&fputil_internal_FPRepImpl_7z3gh10)) = -21846;
		FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_Constructor.Invoke(&fputil_internal_FPRepImpl_7z3gh10, 0);
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 11 - (16 - cpp_countl_zero_unsigned_short.Invoke(num2));
		num2 = unchecked((short)((ushort)num2 << num));
		num3 -= num;
		unchecked
		{
			if (details_expects_bool_condition_bool.Invoke(num3 >= 0, expected: true))
			{
				FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_set_significand.Invoke(&fputil_internal_FPRepImpl_7z3gh10, num2);
				FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_set_biased_exponent.Invoke(&fputil_internal_FPRepImpl_7z3gh10, (short)checked(num3 + 1));
			}
			else
			{
				FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_set_significand.Invoke(&fputil_internal_FPRepImpl_7z3gh10, (short)((ushort)num2 >> checked(-num3)));
			}
			FPBits_Float16_FPBits_unsigned_short.Invoke(&fputil_FPBits_2fahva2, FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval.Invoke(&fputil_internal_FPRepImpl_7z3gh10));
			llvm_lifetime_end_p0.Invoke(4L, &num);
			llvm_lifetime_end_p0.Invoke(2L, &fputil_internal_FPRepImpl_7z3gh10);
			return fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0;
		}
	}
}

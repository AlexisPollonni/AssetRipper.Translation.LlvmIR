using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_make_value
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE0ENS0_6FPBitsIDF16_EEE10make_valueEti")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)0, __llvm_libc_20_1_2_::fputil::FPBits<_Float16>>::make_value(unsigned short, int)")]
	public unsafe static short Invoke([MangledName("number")][NativeType("unsigned short")] short Number, [MangledName("ep")][NativeType("int")] int Ep)
	{
		Fputil_FPBits_2fahva fputil_FPBits_2fahva = default(Fputil_FPBits_2fahva);
		Fputil_internal_FPRepImpl_7z3gh9 fputil_internal_FPRepImpl_7z3gh = default(Fputil_internal_FPRepImpl_7z3gh9);
		int num = 0;
		short num2 = Number;
		int num3 = Ep;
		Llvm_lifetime_start_p0.Invoke(2L, &fputil_internal_FPRepImpl_7z3gh);
		*unchecked((short*)(&fputil_internal_FPRepImpl_7z3gh)) = -21846;
		FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_Constructor.Invoke(&fputil_internal_FPRepImpl_7z3gh, 0);
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 11 - (16 - Cpp_countl_zero_unsigned_short.Invoke(num2));
		num2 = unchecked((short)((ushort)num2 << num));
		num3 -= num;
		unchecked
		{
			if (Details_expects_bool_condition_bool.Invoke(num3 >= 0, Expected: true))
			{
				FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_set_significand.Invoke(&fputil_internal_FPRepImpl_7z3gh, num2);
				FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_set_biased_exponent.Invoke(&fputil_internal_FPRepImpl_7z3gh, (short)checked(num3 + 1));
			}
			else
			{
				FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_set_significand.Invoke(&fputil_internal_FPRepImpl_7z3gh, (short)((ushort)num2 >> checked(-num3)));
			}
			FPBits_Float16_FPBits_unsigned_short.Invoke(&fputil_FPBits_2fahva, FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval.Invoke(&fputil_internal_FPRepImpl_7z3gh));
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			Llvm_lifetime_end_p0.Invoke(2L, &fputil_internal_FPRepImpl_7z3gh);
			return fputil_FPBits_2fahva.FPRepImpl.FPRepSem.FPStorage.field_0;
		}
	}
}

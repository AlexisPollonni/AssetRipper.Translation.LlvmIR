using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepSem_fputil_FPType_3_fputil_FPBits_float128_get_explicit_mantissa
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal8FPRepSemILNS0_6FPTypeE3ENS0_6FPBitsIgEEE21get_explicit_mantissaEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepSem<(__llvm_libc_20_1_2_::fputil::FPType)3, __llvm_libc_20_1_2_::fputil::FPBits<__float128>>::get_explicit_mantissa() const")]
	public unsafe static Struct_fiz2nb Invoke(fputil_internal_FPRepSem_f94eua* @this)
	{
		Int128 @int = default(Int128);
		Int128 int2 = default(Int128);
		unchecked
		{
			Int128 int3;
			if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_subnormal.Invoke(@this))
			{
				Struct_fiz2nb struct_fiz2nb = FPStorage_fputil_FPType_3_sig_bits.Invoke(@this);
				Int128* num = &@int;
				Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
				*(long*)num = struct_fiz2nb2.field_0;
				byte* num2 = (byte*)(&@int) + 8u;
				Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
				*(long*)num2 = struct_fiz2nb3.field_1;
				int3 = @int;
			}
			else
			{
				Struct_fiz2nb struct_fiz2nb4 = FPStorage_fputil_FPType_3_sig_bits.Invoke(@this);
				Int128* num3 = &int2;
				Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
				*(long*)num3 = struct_fiz2nb5.field_0;
				byte* num4 = (byte*)(&int2) + 8u;
				Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
				*(long*)num4 = struct_fiz2nb6.field_1;
				int3 = NumericHelper.BitwiseOr(y: int2, x: 0L);
			}
			return *(Struct_fiz2nb*)(&int3);
		}
	}
}

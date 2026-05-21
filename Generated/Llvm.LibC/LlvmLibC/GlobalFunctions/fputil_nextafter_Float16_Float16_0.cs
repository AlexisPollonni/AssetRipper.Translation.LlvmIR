using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_nextafter_Float16_Float16_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil9nextafterIDF16_DF16_TnNS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS4_stS5_EiE4typeELi0EEES4_S4_S5_")]
	[DemangledName("_Float16 __llvm_libc_20_1_2_::fputil::nextafter<_Float16, _Float16, 0>(_Float16, _Float16)")]
	[return: NativeType("_Float16")]
	public unsafe static Half Invoke([NativeType("_Float16")] Half from, [NativeType("_Float16")] Half to)
	{
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(fputil_FPBits_2fahva);
		fputil_FPBits_2fahva fputil_FPBits_2fahva4 = default(fputil_FPBits_2fahva);
		fputil_FPBits_2fahva fputil_FPBits_2fahva5 = default(fputil_FPBits_2fahva);
		fputil_FPBits_2fahva fputil_FPBits_2fahva6 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva2) = -21846;
			FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva2, from);
			Half result;
			if (FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_nan.Invoke((fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva2)))
			{
				result = from;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
				*(short*)(&fputil_FPBits_2fahva3) = -21846;
				FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva3, to);
				if (FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_nan.Invoke((fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva3)))
				{
					result = fputil_cast_Float16_Float16.Invoke(to);
				}
				else if (NumericHelper.FcmpOeq(fputil_cast_Float16_Float16.Invoke(from), to))
				{
					result = fputil_cast_Float16_Float16.Invoke(to);
				}
				else
				{
					if (NumericHelper.IsUnorderedOrNotEquals(from, default(Half)))
					{
						if (NumericHelper.FcmpOlt(fputil_cast_Float16_Float16.Invoke(from), to) == NumericHelper.FcmpOgt(from, default(Half)))
						{
							llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva4);
							FPBits_Float16_FPBits_unsigned_short.Invoke(&fputil_FPBits_2fahva4, (short)checked(unchecked((ushort)FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2))) + 1));
							llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_2fahva2, &fputil_FPBits_2fahva4, 2L, isVolatile: false);
							llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva4);
						}
						else
						{
							llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva5);
							FPBits_Float16_FPBits_unsigned_short.Invoke(&fputil_FPBits_2fahva5, (short)checked(unchecked((ushort)FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2))) - 1));
							llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_2fahva2, &fputil_FPBits_2fahva5, 2L, isVolatile: false);
							llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva5);
						}
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva6);
						anon_izyfb8.val = FPStorage_fputil_FPType_0_sign.Invoke(&fputil_FPBits_2fahva3);
						short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_min_subnormal.Invoke(anon_izyfb8.val);
						fputil_FPBits_2fahva6.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_2fahva2, &fputil_FPBits_2fahva6, 2L, isVolatile: false);
						llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva6);
					}
					if (FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_subnormal.Invoke((fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva2)))
					{
						fputil_raise_except_if_required.Invoke(48);
					}
					else if (FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_inf.Invoke((fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva2)))
					{
						fputil_raise_except_if_required.Invoke(40);
					}
					result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva2);
				}
				llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
			}
			llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
			return result;
		}
	}
}

using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_nextafter_Float16_Float16_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil9nextafterIDF16_DF16_TnNS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS4_stS5_EiE4typeELi0EEES4_S4_S5_")]
	[DemangledName("_Float16 __llvm_libc_20_1_2_::fputil::nextafter<_Float16, _Float16, 0>(_Float16, _Float16)")]
	[return: NativeType("_Float16")]
	public unsafe static Half Invoke([MangledName("from")][NativeType("_Float16")] Half From, [MangledName("to")][NativeType("_Float16")] Half To)
	{
		Fputil_FPBits_2fahva fputil_FPBits_2fahva = default(Fputil_FPBits_2fahva);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(Fputil_FPBits_2fahva);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(Fputil_FPBits_2fahva);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva4 = default(Fputil_FPBits_2fahva);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva5 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva) = -21846;
			FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva, From);
			Half result;
			if (FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_nan.Invoke((Fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva)))
			{
				result = From;
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
				*(short*)(&fputil_FPBits_2fahva2) = -21846;
				FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva2, To);
				if (FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_nan.Invoke((Fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva2)))
				{
					result = Fputil_cast_Float16_Float16.Invoke(To);
				}
				else if (NumericHelper.FcmpOeq(Fputil_cast_Float16_Float16.Invoke(From), To))
				{
					result = Fputil_cast_Float16_Float16.Invoke(To);
				}
				else
				{
					if (NumericHelper.IsUnorderedOrNotEquals(From, default(Half)))
					{
						if (NumericHelper.FcmpOlt(Fputil_cast_Float16_Float16.Invoke(From), To) == NumericHelper.FcmpOgt(From, default(Half)))
						{
							Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
							FPBits_Float16_FPBits_unsigned_short.Invoke(&fputil_FPBits_2fahva3, (short)checked(unchecked((ushort)FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva))) + 1));
							Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_2fahva, &fputil_FPBits_2fahva3, 2L, isVolatile: false);
							Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
						}
						else
						{
							Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva4);
							FPBits_Float16_FPBits_unsigned_short.Invoke(&fputil_FPBits_2fahva4, (short)checked(unchecked((ushort)FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva))) - 1));
							Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_2fahva, &fputil_FPBits_2fahva4, 2L, isVolatile: false);
							Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva4);
						}
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva5);
						anon_izyfb.Val = FPStorage_fputil_FPType_0_sign.Invoke(&fputil_FPBits_2fahva2);
						short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_min_subnormal.Invoke(anon_izyfb.Val);
						fputil_FPBits_2fahva5.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
						Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_2fahva, &fputil_FPBits_2fahva5, 2L, isVolatile: false);
						Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva5);
					}
					if (FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_subnormal.Invoke((Fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva)))
					{
						Fputil_raise_except_if_required.Invoke(48);
					}
					else if (FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_inf.Invoke((Fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva)))
					{
						Fputil_raise_except_if_required.Invoke(40);
					}
					result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva);
				}
				Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
			}
			Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva);
			return result;
		}
	}
}

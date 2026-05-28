using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_nextafter_float128_float128_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil9nextafterIggTnNS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS4_stS5_EiE4typeELi0EEES4_S4_S5_")]
	[DemangledName("__float128 __llvm_libc_20_1_2_::fputil::nextafter<__float128, __float128, 0>(__float128, __float128)")]
	[return: NativeType("__float128")]
	public unsafe static double Invoke([MangledName("from")][NativeType("__float128")] double From, [MangledName("to")][NativeType("__float128")] double To)
	{
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi = default(Fputil_FPBits_ubgsi2);
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi2 = default(Fputil_FPBits_ubgsi2);
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(Fputil_FPBits_ubgsi2);
		Int128 x = default(Int128);
		Int128 @int = default(Int128);
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(Fputil_FPBits_ubgsi2);
		Int128 x2 = default(Int128);
		Int128 int2 = default(Int128);
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi5 = default(Fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi);
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi) = -6148914691236517206L;
			FPBits_float128_Constructor.Invoke(&fputil_FPBits_ubgsi, From);
			double result;
			if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_nan.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi)))
			{
				result = From;
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi2);
				*(Int128*)(&fputil_FPBits_ubgsi2) = -6148914691236517206L;
				FPBits_float128_Constructor.Invoke(&fputil_FPBits_ubgsi2, To);
				if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_nan.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi2)))
				{
					result = Fputil_cast_float128_float128.Invoke(To);
				}
				else if (Fputil_cast_float128_float128.Invoke(From) == To)
				{
					result = Fputil_cast_float128_float128.Invoke(To);
				}
				else
				{
					if (NumericHelper.IsUnorderedOrNotEquals(From, 0.0))
					{
						if (Fputil_cast_float128_float128.Invoke(From) < To == From > 0.0)
						{
							Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
							Struct_fiz2nb struct_fiz2nb = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_uintval.Invoke(&fputil_FPBits_ubgsi);
							Int128* num = &x;
							Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
							*(long*)num = struct_fiz2nb2.field_0;
							byte* num2 = (byte*)(&x) + 8u;
							Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
							*(long*)num2 = struct_fiz2nb3.field_1;
							@int = NumericHelper.Add(x, 1L);
							FPBits_float128_FPBits_unsigned_int128.Invoke(&fputil_FPBits_ubgsi3, *(long*)(&@int), ((long*)(&@int))[1]);
							Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi, &fputil_FPBits_ubgsi3, 16L, isVolatile: false);
							Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
						}
						else
						{
							Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
							Struct_fiz2nb struct_fiz2nb4 = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_uintval.Invoke(&fputil_FPBits_ubgsi);
							Int128* num3 = &x2;
							Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
							*(long*)num3 = struct_fiz2nb5.field_0;
							byte* num4 = (byte*)(&x2) + 8u;
							Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
							*(long*)num4 = struct_fiz2nb6.field_1;
							int2 = NumericHelper.Subtract(x2, 1L);
							FPBits_float128_FPBits_unsigned_int128.Invoke(&fputil_FPBits_ubgsi4, *(long*)(&int2), ((long*)(&int2))[1]);
							Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi, &fputil_FPBits_ubgsi4, 16L, isVolatile: false);
							Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
						}
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
						anon_izyfb.Val = FPStorage_fputil_FPType_3_sign.Invoke(&fputil_FPBits_ubgsi2);
						Struct_fiz2nb struct_fiz2nb7 = FPRepSem_fputil_FPType_3_fputil_FPBits_float128_min_subnormal.Invoke(anon_izyfb.Val);
						Int128* ptr = &fputil_FPBits_ubgsi5.Val.Data.FPStorage.field_0;
						Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
						((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb8.field_0;
						Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
						((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb9.field_1;
						Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi, &fputil_FPBits_ubgsi5, 16L, isVolatile: false);
						Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
					}
					if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_subnormal.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi)))
					{
						Fputil_raise_except_if_required.Invoke(48);
					}
					else if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_inf.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi)))
					{
						Fputil_raise_except_if_required.Invoke(40);
					}
					result = FPBits_float128_get_val.Invoke(&fputil_FPBits_ubgsi);
				}
				Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi2);
			}
			Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi);
			return result;
		}
	}
}

using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class NormalFloat_float128_Float128
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11NormalFloatIgEcvgEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<__float128>::operator __float128() const")]
	public unsafe static double Invoke([MangledName("this")] Fputil_NormalFloat_wqb3ie* This)
	{
		int num = 0;
		int num2 = 0;
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi = default(Fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi2 = default(Fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		int num3 = 0;
		int num4 = 0;
		Int128 y = default(Int128);
		Int128 x = default(Int128);
		Int128 y2 = default(Int128);
		Int128 @int = default(Int128);
		Int128 int2 = default(Int128);
		Int128 int3 = default(Int128);
		Int128 int4 = default(Int128);
		Int128 x2 = default(Int128);
		Int128 int5 = default(Int128);
		Int128 int6 = default(Int128);
		Int128 int7 = default(Int128);
		Int128 int8 = default(Int128);
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = This->Exponent + 16383;
		Llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = 32766;
		unchecked
		{
			double result;
			if (num > 32766)
			{
				Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, &This->Sign, 1L, isVolatile: false);
				Struct_fiz2nb struct_fiz2nb = FPRepSem_fputil_FPType_3_fputil_FPBits_float128_inf.Invoke(anon_izyfb.Val);
				Int128* ptr = &fputil_FPBits_ubgsi.Val.Data.FPStorage.field_0;
				Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
				((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb2.field_0;
				Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
				((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb3.field_1;
				result = FPBits_float128_get_val.Invoke(&fputil_FPBits_ubgsi);
				Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi);
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi2);
				*(Int128*)(&fputil_FPBits_ubgsi2) = -6148914691236517206L;
				FPBits_float128_Constructor.Invoke(&fputil_FPBits_ubgsi2, 0.0);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, &This->Sign, 1L, isVolatile: false);
				FPStorage_fputil_FPType_3_set_sign.Invoke(&fputil_FPBits_ubgsi2, anon_izyfb2.Val);
				Llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = -16382;
				if (This->Exponent < -16382)
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num4);
					num4 = checked(-16382 - This->Exponent);
					if ((uint)num4 <= 113u)
					{
						Llvm_lifetime_start_p0.Invoke(16L, &y);
						y = NumericHelper.Subtract(NumericHelper.ShiftLeft(y: (Int128)(UInt128)(uint)num4, x: 1L), 1L);
						Llvm_lifetime_start_p0.Invoke(16L, &x);
						x = NumericHelper.BitwiseAnd(This->Mantissa, y);
						Llvm_lifetime_start_p0.Invoke(16L, &y2);
						y2 = NumericHelper.ShiftLeft(y: (Int128)(UInt128)(uint)(num4 - 1), x: 1L);
						@int = 0L;
						FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_set_biased_exponent.Invoke(&fputil_FPBits_ubgsi2, *(long*)(&@int), ((long*)(&@int))[1]);
						int2 = NumericHelper.ShiftRightLogical(This->Mantissa, (Int128)(UInt128)(uint)num4);
						FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_set_mantissa.Invoke(&fputil_FPBits_ubgsi2, *(long*)(&int2), ((long*)(&int2))[1]);
						Llvm_lifetime_start_p0.Invoke(16L, &int3);
						Struct_fiz2nb struct_fiz2nb4 = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_mantissa.Invoke(&fputil_FPBits_ubgsi2);
						Int128* num5 = &int4;
						Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
						*(long*)num5 = struct_fiz2nb5.field_0;
						byte* num6 = (byte*)(&int4) + 8u;
						Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
						*(long*)num6 = struct_fiz2nb6.field_1;
						int3 = int4;
						if (NumericHelper.IntCmpUgt(x, y2))
						{
							int3 = NumericHelper.Add(int3, 1L);
						}
						else if (NumericHelper.IntCmpEq(x, y2))
						{
							Struct_fiz2nb struct_fiz2nb7 = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_mantissa.Invoke(&fputil_FPBits_ubgsi2);
							Int128* num7 = &x2;
							Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
							*(long*)num7 = struct_fiz2nb8.field_0;
							byte* num8 = (byte*)(&x2) + 8u;
							Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
							*(long*)num8 = struct_fiz2nb9.field_1;
							if (NumericHelper.IntCmpNe(NumericHelper.BitwiseAnd(x2, 1L), 0L))
							{
								int3 = NumericHelper.Add(int3, 1L);
							}
						}
						int5 = int3;
						FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_set_mantissa.Invoke(&fputil_FPBits_ubgsi2, *(long*)(&int5), ((long*)(&int5))[1]);
						if (NumericHelper.IntCmpEq(int3, 0L))
						{
							int6 = 1L;
							FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_set_biased_exponent.Invoke(&fputil_FPBits_ubgsi2, *(long*)(&int6), ((long*)(&int6))[1]);
						}
						result = FPBits_float128_get_val.Invoke(&fputil_FPBits_ubgsi2);
						Llvm_lifetime_end_p0.Invoke(16L, &int3);
						Llvm_lifetime_end_p0.Invoke(16L, &y2);
						Llvm_lifetime_end_p0.Invoke(16L, &x);
						Llvm_lifetime_end_p0.Invoke(16L, &y);
					}
					else
					{
						result = FPBits_float128_get_val.Invoke(&fputil_FPBits_ubgsi2);
					}
					Llvm_lifetime_end_p0.Invoke(4L, &num4);
				}
				else
				{
					int7 = checked(This->Exponent + 16383);
					FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_set_biased_exponent.Invoke(&fputil_FPBits_ubgsi2, *(long*)(&int7), ((long*)(&int7))[1]);
					int8 = This->Mantissa;
					FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_set_mantissa.Invoke(&fputil_FPBits_ubgsi2, *(long*)(&int8), ((long*)(&int8))[1]);
					result = FPBits_float128_get_val.Invoke(&fputil_FPBits_ubgsi2);
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num3);
				Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi2);
			}
			Llvm_lifetime_end_p0.Invoke(4L, &num2);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}

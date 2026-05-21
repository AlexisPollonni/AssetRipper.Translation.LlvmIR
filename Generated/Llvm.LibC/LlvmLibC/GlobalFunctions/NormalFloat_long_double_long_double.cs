using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class NormalFloat_long_double_long_double
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11NormalFloatIeEcveEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<long double>::operator long double() const")]
	public unsafe static double Invoke(void* @this)
	{
		int num = 0;
		int num2 = 0;
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
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
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = unchecked((fputil_NormalFloat_wqb3ie*)@this)->exponent + 16383;
		llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = 32766;
		unchecked
		{
			double result;
			if (num > 32766)
			{
				llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, &((fputil_NormalFloat_wqb3ie*)@this)->sign, 1L, isVolatile: false);
				Struct_fiz2nb struct_fiz2nb = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_inf.Invoke(anon_izyfb8.val);
				Int128* ptr = &fputil_FPBits_ubgsi3.val.Data.FPStorage.field_0;
				Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
				((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb2.field_0;
				Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
				((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb3.field_1;
				result = FPBits_long_double_get_val.Invoke(&fputil_FPBits_ubgsi3);
				llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
				*(Int128*)(&fputil_FPBits_ubgsi4) = -6148914691236517206L;
				FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi4, 0.0);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, &((fputil_NormalFloat_wqb3ie*)@this)->sign, 1L, isVolatile: false);
				FPStorage_fputil_FPType_4_set_sign.Invoke(&fputil_FPBits_ubgsi4, anon_izyfb9.val);
				llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = -16382;
				if (((fputil_NormalFloat_wqb3ie*)@this)->exponent < -16382)
				{
					llvm_lifetime_start_p0.Invoke(4L, &num4);
					checked
					{
						num4 = -16382 - unchecked((fputil_NormalFloat_wqb3ie*)@this)->exponent;
					}
					if ((uint)num4 <= 64u)
					{
						llvm_lifetime_start_p0.Invoke(16L, &y);
						y = NumericHelper.Subtract(NumericHelper.ShiftLeft(y: (Int128)(UInt128)(uint)num4, x: 1L), 1L);
						llvm_lifetime_start_p0.Invoke(16L, &x);
						x = NumericHelper.BitwiseAnd(((fputil_NormalFloat_wqb3ie*)@this)->mantissa, y);
						llvm_lifetime_start_p0.Invoke(16L, &y2);
						y2 = NumericHelper.ShiftLeft(y: (Int128)(UInt128)(uint)(num4 - 1), x: 1L);
						@int = 0L;
						FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_set_biased_exponent.Invoke(&fputil_FPBits_ubgsi4, *(long*)(&@int), ((long*)(&@int))[1]);
						int2 = NumericHelper.ShiftRightLogical(((fputil_NormalFloat_wqb3ie*)@this)->mantissa, (Int128)(UInt128)(uint)num4);
						FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_set_mantissa.Invoke(&fputil_FPBits_ubgsi4, *(long*)(&int2), ((long*)(&int2))[1]);
						llvm_lifetime_start_p0.Invoke(16L, &int3);
						Struct_fiz2nb struct_fiz2nb4 = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_mantissa.Invoke(&fputil_FPBits_ubgsi4);
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
							Struct_fiz2nb struct_fiz2nb7 = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_mantissa.Invoke(&fputil_FPBits_ubgsi4);
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
						FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_set_mantissa.Invoke(&fputil_FPBits_ubgsi4, *(long*)(&int5), ((long*)(&int5))[1]);
						if (NumericHelper.IntCmpEq(int3, long.MinValue))
						{
							int6 = 1L;
							FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_set_biased_exponent.Invoke(&fputil_FPBits_ubgsi4, *(long*)(&int6), ((long*)(&int6))[1]);
							FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_set_implicit_bit.Invoke(&fputil_FPBits_ubgsi4, implicitVal: true);
						}
						else
						{
							FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_set_implicit_bit.Invoke(&fputil_FPBits_ubgsi4, implicitVal: false);
						}
						result = FPBits_long_double_get_val.Invoke(&fputil_FPBits_ubgsi4);
						llvm_lifetime_end_p0.Invoke(16L, &int3);
						llvm_lifetime_end_p0.Invoke(16L, &y2);
						llvm_lifetime_end_p0.Invoke(16L, &x);
						llvm_lifetime_end_p0.Invoke(16L, &y);
					}
					else
					{
						result = FPBits_long_double_get_val.Invoke(&fputil_FPBits_ubgsi4);
					}
					llvm_lifetime_end_p0.Invoke(4L, &num4);
				}
				else
				{
					int7 = num;
					FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_set_biased_exponent.Invoke(&fputil_FPBits_ubgsi4, *(long*)(&int7), ((long*)(&int7))[1]);
					int8 = ((fputil_NormalFloat_wqb3ie*)@this)->mantissa;
					FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_set_mantissa.Invoke(&fputil_FPBits_ubgsi4, *(long*)(&int8), ((long*)(&int8))[1]);
					FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_set_implicit_bit.Invoke(&fputil_FPBits_ubgsi4, implicitVal: true);
					result = FPBits_long_double_get_val.Invoke(&fputil_FPBits_ubgsi4);
				}
				llvm_lifetime_end_p0.Invoke(4L, &num3);
				llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
			}
			llvm_lifetime_end_p0.Invoke(4L, &num2);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}

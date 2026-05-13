using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil4sqrtIfeEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS4_stS5_ES4_E4typeES5_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float> && cpp::is_floating_point_v<long double> && sizeof (float) <= sizeof (long double), float>::type __llvm_libc_20_1_2_::fputil::sqrt<float, long double>(long double)")]
internal static partial class cpp_enable_if_cpp_is_floating_point_v_float_cpp_is_floating_point_v_long_double_sizeof_float_sizeof_long_double_float_type_fputil_sqrt_float_long_double_long_double
{
	public unsafe static float Invoke(double x)
	{
		Int128 @int = default(Int128);
		float num = 0f;
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		fputil_internal_FPRepImpl_jrxud9 fputil_internal_FPRepImpl_jrxud10 = default(fputil_internal_FPRepImpl_jrxud9);
		fputil_internal_FPRepImpl_jrxud9 fputil_internal_FPRepImpl_jrxud11 = default(fputil_internal_FPRepImpl_jrxud9);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		int num2 = 0;
		Int128 x2 = default(Int128);
		Int128 int2 = default(Int128);
		Int128 int3 = default(Int128);
		Int128 x3 = default(Int128);
		Int128 int4 = default(Int128);
		Int128 y = default(Int128);
		Int128 y2 = default(Int128);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd5 = default(fputil_DyadicFloat_kt2kd4);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		BigInt_qdkjbh bigInt_qdkjbh = default(BigInt_qdkjbh);
		Int128 int5 = default(Int128);
		llvm_lifetime_start_p0.Invoke(16L, &@int);
		@int = long.MinValue;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = float.NaN;
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi3) = -6148914691236517206L;
			fputil_FPBits_long_double_FPBits_long_double_long_double.Invoke(&fputil_FPBits_ubgsi3, x);
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_jrxud10, &fputil_FPBits_ubgsi3, 16L, isVolatile: false);
			llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
			Struct_fiz2nb struct_fiz2nb = fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_inf_Sign.Invoke(anon_izyfb8.val);
			Int128* ptr = &fputil_FPBits_ubgsi4.val.Data.FPStorage.field_0;
			Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
			((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb2.field_0;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb3.field_1;
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_jrxud11, &fputil_FPBits_ubgsi4, 16L, isVolatile: false);
			int num3 = (fputil_internal_operator_fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double.Invoke(*(long*)(&fputil_internal_FPRepImpl_jrxud10), ((long*)(&fputil_internal_FPRepImpl_jrxud10))[1], *(long*)(&fputil_internal_FPRepImpl_jrxud11), ((long*)(&fputil_internal_FPRepImpl_jrxud11))[1]) ? (-1) : ((!fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_zero_const.Invoke(&fputil_FPBits_ubgsi3)) ? (fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_nan_const.Invoke(&fputil_FPBits_ubgsi3) ? 1 : 0) : (-1)));
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
			float result;
			if (num3 != 0)
			{
				result = cpp_enable_if_cpp_is_floating_point_v_float_cpp_is_floating_point_v_long_double_float_type_fputil_cast_float_long_double_long_double.Invoke(x);
			}
			else if (fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_neg_const.Invoke(&fputil_FPBits_ubgsi3))
			{
				result = float.NaN;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_exponent_const.Invoke(&fputil_FPBits_ubgsi3);
				llvm_lifetime_start_p0.Invoke(16L, &x2);
				Struct_fiz2nb struct_fiz2nb4 = fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_mantissa_const.Invoke(&fputil_FPBits_ubgsi3);
				Int128* num4 = &int2;
				Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
				*(long*)num4 = struct_fiz2nb5.field_0;
				byte* num5 = (byte*)(&int2) + 8u;
				Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
				*(long*)num5 = struct_fiz2nb6.field_1;
				x2 = int2;
				checked
				{
					if (fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_subnormal_const.Invoke(&fputil_FPBits_ubgsi3))
					{
						num2++;
						void_fputil_internal_normalize_long_double_int_fputil_FPBits_long_double_StorageType.Invoke(&num2, &x2);
					}
					else
					{
						x2 = NumericHelper.BitwiseOr(x2, long.MinValue);
					}
					if ((num2 & 1) != 0)
					{
						num2 += -1;
						x2 = NumericHelper.ShiftLeft(x2, 1L);
					}
					llvm_lifetime_start_p0.Invoke(16L, &int3);
					int3 = long.MinValue;
					llvm_lifetime_start_p0.Invoke(16L, &x3);
					x3 = NumericHelper.Subtract(x2, long.MinValue);
					llvm_lifetime_start_p0.Invoke(16L, &int4);
					int4 = 4611686018427387904L;
					while (NumericHelper.IntCmpNe(int4, 0L))
					{
						x3 = NumericHelper.ShiftLeft(x3, 1L);
						llvm_lifetime_start_p0.Invoke(16L, &y);
						y = NumericHelper.Add(NumericHelper.ShiftLeft(int3, 1L), int4);
						if (NumericHelper.IntCmpUge(x3, y))
						{
							x3 = NumericHelper.Subtract(x3, y);
							int3 = NumericHelper.Add(int3, int4);
						}
						llvm_lifetime_end_p0.Invoke(16L, &y);
						int4 = NumericHelper.ShiftRightLogical(int4, 1L);
					}
					llvm_lifetime_end_p0.Invoke(16L, &int4);
					x3 = NumericHelper.ShiftLeft(x3, 2L);
					int3 = NumericHelper.ShiftLeft(int3, 2L);
					llvm_lifetime_start_p0.Invoke(16L, &y2);
					y2 = NumericHelper.Add(int3, 1L);
					if (NumericHelper.IntCmpUge(x3, y2))
					{
						x3 = NumericHelper.Subtract(x3, y2);
						int3 = NumericHelper.BitwiseOr(int3, 2L);
					}
				}
				int3 = NumericHelper.BitwiseOr(y: (Int128)(UInt128)(NumericHelper.IntCmpNe(x3, 0L) ? 1u : 0u), x: int3);
				llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
				*(sbyte*)(&fputil_DyadicFloat_kt2kd5) = -86;
				sbyte* ptr2 = (sbyte*)(&fputil_DyadicFloat_kt2kd5) + 1;
				*ptr2 = -86;
				ptr2[1] = -86;
				ptr2[2] = -86;
				((int*)(&fputil_DyadicFloat_kt2kd5))[1] = -1431655766;
				sbyte* ptr3 = (sbyte*)(&fputil_DyadicFloat_kt2kd5) + 8;
				*(long*)ptr3 = -6148914691236517206L;
				((long*)ptr3)[1] = -6148914691236517206L;
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
				int e = checked((num2 >> 1) - 2 - 63);
				int5 = int3;
				BigInt_128ul_false_unsigned_long_BigInt_unsigned_int128_void_unsigned_int128.Invoke((anon_izyfb7*)(&bigInt_qdkjbh), *(long*)(&int5), ((long*)(&int5))[1]);
				fputil_DyadicFloat_128ul_DyadicFloat_Sign_int_BigInt_128ul_false_unsigned_long.Invoke(&fputil_DyadicFloat_kt2kd5, anon_izyfb9.val, e, *(long*)(&bigInt_qdkjbh), ((long*)(&bigInt_qdkjbh))[1]);
				result = float_fputil_DyadicFloat_128ul_as_float_true_void_const.Invoke(&fputil_DyadicFloat_kt2kd5);
				llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
				llvm_lifetime_end_p0.Invoke(16L, &y2);
				llvm_lifetime_end_p0.Invoke(16L, &x3);
				llvm_lifetime_end_p0.Invoke(16L, &int3);
				llvm_lifetime_end_p0.Invoke(16L, &x2);
				llvm_lifetime_end_p0.Invoke(4L, &num2);
			}
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			llvm_lifetime_end_p0.Invoke(16L, &@int);
			return result;
		}
	}
}

using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_sqrt_Float16_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil4sqrtIDF16_eEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS4_stS5_ES4_E4typeES5_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16> && cpp::is_floating_point_v<long double> && sizeof (_Float16) <= sizeof (long double), _Float16>::type __llvm_libc_20_1_2_::fputil::sqrt<_Float16, long double>(long double)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16> && cpp::is_floating_point_v<long double> && sizeof (_Float16) <= sizeof (long double), _Float16>::type")]
	public unsafe static Half Invoke([NativeType("long double")] double x)
	{
		Int128 @int = default(Int128);
		Half half = default(Half);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		fputil_internal_FPRepImpl_jrxud9 fputil_internal_FPRepImpl_jrxud10 = default(fputil_internal_FPRepImpl_jrxud9);
		fputil_internal_FPRepImpl_jrxud9 fputil_internal_FPRepImpl_jrxud11 = default(fputil_internal_FPRepImpl_jrxud9);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		int num = 0;
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
		llvm_lifetime_start_p0.Invoke(2L, &half);
		half = default(Half);
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi3) = -6148914691236517206L;
			FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi3, x);
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_jrxud10, &fputil_FPBits_ubgsi3, 16L, isVolatile: false);
			llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
			Struct_fiz2nb struct_fiz2nb = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_inf.Invoke(anon_izyfb8.val);
			Int128* ptr = &fputil_FPBits_ubgsi4.val.Data.FPStorage.field_0;
			Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
			((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb2.field_0;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb3.field_1;
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_jrxud11, &fputil_FPBits_ubgsi4, 16L, isVolatile: false);
			int num2 = (internal_Equals_jif2sf.Invoke(*(long*)(&fputil_internal_FPRepImpl_jrxud10), ((long*)(&fputil_internal_FPRepImpl_jrxud10))[1], *(long*)(&fputil_internal_FPRepImpl_jrxud11), ((long*)(&fputil_internal_FPRepImpl_jrxud11))[1]) ? (-1) : ((!FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_zero.Invoke(&fputil_FPBits_ubgsi3)) ? (FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_nan.Invoke(&fputil_FPBits_ubgsi3) ? 1 : 0) : (-1)));
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
			Half result;
			if (num2 != 0)
			{
				result = fputil_cast_Float16_long_double.Invoke(x);
			}
			else if (FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_neg.Invoke(&fputil_FPBits_ubgsi3))
			{
				result = default(Half);
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_exponent.Invoke(&fputil_FPBits_ubgsi3);
				llvm_lifetime_start_p0.Invoke(16L, &x2);
				Struct_fiz2nb struct_fiz2nb4 = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_mantissa.Invoke(&fputil_FPBits_ubgsi3);
				Int128* num3 = &int2;
				Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
				*(long*)num3 = struct_fiz2nb5.field_0;
				byte* num4 = (byte*)(&int2) + 8u;
				Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
				*(long*)num4 = struct_fiz2nb6.field_1;
				x2 = int2;
				checked
				{
					if (FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_subnormal.Invoke(&fputil_FPBits_ubgsi3))
					{
						num++;
						internal_normalize_long_double.Invoke(&num, &x2);
					}
					else
					{
						x2 = NumericHelper.BitwiseOr(x2, long.MinValue);
					}
					if ((num & 1) != 0)
					{
						num += -1;
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
				int e = checked((num >> 1) - 2 - 63);
				int5 = int3;
				BigInt_128ul_false_unsigned_long_BigInt_unsigned_int128_void.Invoke((anon_izyfb7*)(&bigInt_qdkjbh), *(long*)(&int5), ((long*)(&int5))[1]);
				DyadicFloat_128ul_Constructor.Invoke(&fputil_DyadicFloat_kt2kd5, anon_izyfb9.val, e, *(long*)(&bigInt_qdkjbh), ((long*)(&bigInt_qdkjbh))[1]);
				result = DyadicFloat_128ul_as_Float16_true_void.Invoke(&fputil_DyadicFloat_kt2kd5);
				llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
				llvm_lifetime_end_p0.Invoke(16L, &y2);
				llvm_lifetime_end_p0.Invoke(16L, &x3);
				llvm_lifetime_end_p0.Invoke(16L, &int3);
				llvm_lifetime_end_p0.Invoke(16L, &x2);
				llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
			llvm_lifetime_end_p0.Invoke(2L, &half);
			llvm_lifetime_end_p0.Invoke(16L, &@int);
			return result;
		}
	}
}

using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_sqrt_Float16_float128
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil4sqrtIDF16_gEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS4_stS5_ES4_E4typeES5_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16> && cpp::is_floating_point_v<__float128> && sizeof (_Float16) <= sizeof (__float128), _Float16>::type __llvm_libc_20_1_2_::fputil::sqrt<_Float16, __float128>(__float128)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16> && cpp::is_floating_point_v<__float128> && sizeof (_Float16) <= sizeof (__float128), _Float16>::type")]
	public unsafe static Half Invoke([MangledName("x")][NativeType("__float128")] double X)
	{
		Int128 @int = default(Int128);
		Half half = default(Half);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud9 llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud = default(Llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud9);
		Llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud9 llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud2 = default(Llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud9);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi2 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		int num = 0;
		Int128 x = default(Int128);
		Int128 int2 = default(Int128);
		Int128 int3 = default(Int128);
		Int128 x2 = default(Int128);
		Int128 int4 = default(Int128);
		Int128 y = default(Int128);
		Int128 y2 = default(Int128);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
		Int128 int5 = default(Int128);
		Llvm_lifetime_start_p0.Invoke(16L, &@int);
		@int = 0L;
		Llvm_lifetime_start_p0.Invoke(2L, &half);
		half = default(Half);
		Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi);
		unchecked
		{
			*(Int128*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi) = -6148914691236517206L;
			FPBits_float128_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, X);
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud, &llvm_libc_20_1_2_fputil_FPBits_ubgsi, 16L, isVolatile: false);
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
			Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
			Struct_fiz2nb struct_fiz2nb = FPRepSem_fputil_FPType_3_fputil_FPBits_float128_inf.Invoke(anon_izyfb.Val);
			Int128* ptr = &llvm_libc_20_1_2_fputil_FPBits_ubgsi2.Val.Data.FPStorage.field_0;
			Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
			((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb2.field_0;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb3.field_1;
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud2, &llvm_libc_20_1_2_fputil_FPBits_ubgsi2, 16L, isVolatile: false);
			bool num2 = Internal_Equals_svxrxh.Invoke(*(long*)(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud), ((long*)(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud))[1], *(long*)(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud2), ((long*)(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud2))[1]) || FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_zero.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi)) || FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi));
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
			Half result;
			if (num2)
			{
				result = Fputil_cast_Float16_float128.Invoke(X);
			}
			else if (FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_is_neg.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi))
			{
				result = default(Half);
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				num = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_exponent.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
				Llvm_lifetime_start_p0.Invoke(16L, &x);
				Struct_fiz2nb struct_fiz2nb4 = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_mantissa.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
				Int128* num3 = &int2;
				Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
				*(long*)num3 = struct_fiz2nb5.field_0;
				byte* num4 = (byte*)(&int2) + 8u;
				Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
				*(long*)num4 = struct_fiz2nb6.field_1;
				x = int2;
				if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_subnormal.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi)))
				{
					num = checked(num + 1);
					Internal_normalize_float128.Invoke(&num, &x);
				}
				else
				{
					x = NumericHelper.BitwiseOr(x, 0L);
				}
				if ((num & 1) != 0)
				{
					num = checked(num + -1);
					x = NumericHelper.ShiftLeft(x, 1L);
				}
				Llvm_lifetime_start_p0.Invoke(16L, &int3);
				int3 = 0L;
				Llvm_lifetime_start_p0.Invoke(16L, &x2);
				x2 = NumericHelper.Subtract(x, 0L);
				Llvm_lifetime_start_p0.Invoke(16L, &int4);
				int4 = 0L;
				while (NumericHelper.IntCmpNe(int4, 0L))
				{
					x2 = NumericHelper.ShiftLeft(x2, 1L);
					Llvm_lifetime_start_p0.Invoke(16L, &y);
					y = NumericHelper.Add(NumericHelper.ShiftLeft(int3, 1L), int4);
					if (NumericHelper.IntCmpUge(x2, y))
					{
						x2 = NumericHelper.Subtract(x2, y);
						int3 = NumericHelper.Add(int3, int4);
					}
					Llvm_lifetime_end_p0.Invoke(16L, &y);
					int4 = NumericHelper.ShiftRightLogical(int4, 1L);
				}
				Llvm_lifetime_end_p0.Invoke(16L, &int4);
				x2 = NumericHelper.ShiftLeft(x2, 2L);
				int3 = NumericHelper.ShiftLeft(int3, 2L);
				Llvm_lifetime_start_p0.Invoke(16L, &y2);
				y2 = NumericHelper.Add(int3, 1L);
				if (NumericHelper.IntCmpUge(x2, y2))
				{
					x2 = NumericHelper.Subtract(x2, y2);
					int3 = NumericHelper.BitwiseOr(int3, 2L);
				}
				int3 = NumericHelper.BitwiseOr(y: (Int128)(UInt128)(NumericHelper.IntCmpNe(x2, 0L) ? 1u : 0u), x: int3);
				Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd);
				*(sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd) = -86;
				sbyte* ptr2 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd) + 1;
				*ptr2 = -86;
				ptr2[1] = -86;
				ptr2[2] = -86;
				((int*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd))[1] = -1431655766;
				sbyte* ptr3 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd) + 8;
				*(long*)ptr3 = -6148914691236517206L;
				((long*)ptr3)[1] = -6148914691236517206L;
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
				int e = checked((num >> 1) - 2 - 112);
				int5 = int3;
				BigInt_128ul_false_unsigned_long_BigInt_unsigned_int128_void.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh), *(long*)(&int5), ((long*)(&int5))[1]);
				DyadicFloat_128ul_Constructor.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd, anon_izyfb2.Val, e, *(long*)(&llvm_libc_20_1_2_BigInt_qdkjbh), ((long*)(&llvm_libc_20_1_2_BigInt_qdkjbh))[1]);
				result = DyadicFloat_128ul_as_Float16_true_void.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd);
				Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd);
				Llvm_lifetime_end_p0.Invoke(16L, &y2);
				Llvm_lifetime_end_p0.Invoke(16L, &x2);
				Llvm_lifetime_end_p0.Invoke(16L, &int3);
				Llvm_lifetime_end_p0.Invoke(16L, &x);
				Llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi);
			Llvm_lifetime_end_p0.Invoke(2L, &half);
			Llvm_lifetime_end_p0.Invoke(16L, &@int);
			return result;
		}
	}
}

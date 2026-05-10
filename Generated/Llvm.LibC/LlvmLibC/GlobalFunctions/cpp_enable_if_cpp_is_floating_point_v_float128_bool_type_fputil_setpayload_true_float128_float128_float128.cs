using System;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil10setpayloadILb1EgEENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT0_EEbE4typeERS4_S4_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<__float128>, bool>::type __llvm_libc_20_1_2_::fputil::setpayload<true, __float128>(__float128&, __float128)")]
internal static partial class cpp_enable_if_cpp_is_floating_point_v_float128_bool_type_fputil_setpayload_true_float128_float128_float128
{
	public unsafe static bool Invoke(void* res, double pl)
	{
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		int num = 0;
		Int128 x = default(Int128);
		Int128 @int = default(Int128);
		Int128 x2 = default(Int128);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		Int128 int2 = default(Int128);
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		bool result;
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi3) = -6148914691236517206L;
			fputil_FPBits_float128_FPBits_float128_float128.Invoke(&fputil_FPBits_ubgsi3, pl);
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_exponent_const.Invoke(&fputil_FPBits_ubgsi3);
			if (!fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_is_neg_const.Invoke(&fputil_FPBits_ubgsi3) && num >= 0 && num < 111)
			{
				Struct_fiz2nb struct_fiz2nb = fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_mantissa_const.Invoke(&fputil_FPBits_ubgsi3);
				Int128* num2 = &x;
				Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
				*(long*)num2 = struct_fiz2nb2.field_0;
				byte* num3 = (byte*)(&x) + 8u;
				Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
				*(long*)num3 = struct_fiz2nb3.field_1;
				if (!NumericHelper.IntCmpNe(NumericHelper.BitwiseAnd(NumericHelper.ShiftLeft(x, (Int128)(UInt128)(uint)num), -1L), 0L))
				{
					llvm_lifetime_start_p0.Invoke(16L, &@int);
					Struct_fiz2nb struct_fiz2nb4 = fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_get_explicit_mantissa_const.Invoke(&fputil_FPBits_ubgsi3);
					Int128* num4 = &x2;
					Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
					*(long*)num4 = struct_fiz2nb5.field_0;
					byte* num5 = (byte*)(&x2) + 8u;
					Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
					*(long*)num5 = struct_fiz2nb6.field_1;
					@int = NumericHelper.ShiftRightLogical(x2, (Int128)(UInt128)(uint)checked(112 - num));
					llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
					Int128 int3 = @int;
					sbyte val = anon_izyfb8.val;
					int2 = int3;
					Struct_fiz2nb struct_fiz2nb7 = fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_signaling_nan_Sign_unsigned_int128.Invoke(val, *(long*)(&int2), ((long*)(&int2))[1]);
					Int128* ptr = &fputil_FPBits_ubgsi4.val.Data.FPStorage.field_0;
					Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
					((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb8.field_0;
					Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
					((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb9.field_1;
					*(double*)res = fputil_FPBits_float128_get_val_const.Invoke(&fputil_FPBits_ubgsi4);
					llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
					result = false;
					llvm_lifetime_end_p0.Invoke(16L, &@int);
					goto IL_0234;
				}
			}
			*(double*)res = 0.0;
			result = true;
			goto IL_0234;
		}
		IL_0234:
		llvm_lifetime_end_p0.Invoke(4L, &num);
		llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		return result;
	}
}

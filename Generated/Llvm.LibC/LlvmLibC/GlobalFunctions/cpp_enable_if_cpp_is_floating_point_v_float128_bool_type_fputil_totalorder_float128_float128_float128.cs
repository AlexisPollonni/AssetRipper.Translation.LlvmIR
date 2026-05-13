using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil10totalorderIgEENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEbE4typeES4_S4_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<__float128>, bool>::type __llvm_libc_20_1_2_::fputil::totalorder<__float128>(__float128, __float128)")]
internal static partial class cpp_enable_if_cpp_is_floating_point_v_float128_bool_type_fputil_totalorder_float128_float128_float128
{
	public unsafe static bool Invoke(double x, double y)
	{
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(fputil_FPBits_ubgsi2);
		Int128 x2 = default(Int128);
		Int128 @int = default(Int128);
		Int128 y2 = default(Int128);
		Int128 int2 = default(Int128);
		sbyte b = 0;
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi3) = -6148914691236517206L;
			fputil_FPBits_float128_FPBits_float128_float128.Invoke(&fputil_FPBits_ubgsi3, x);
			llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
			*(Int128*)(&fputil_FPBits_ubgsi4) = -6148914691236517206L;
			fputil_FPBits_float128_FPBits_float128_float128.Invoke(&fputil_FPBits_ubgsi4, y);
			llvm_lifetime_start_p0.Invoke(16L, &x2);
			Struct_fiz2nb struct_fiz2nb = fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_uintval_const.Invoke(&fputil_FPBits_ubgsi3);
			Int128* num = &@int;
			Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
			*(long*)num = struct_fiz2nb2.field_0;
			byte* num2 = (byte*)(&@int) + 8u;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			*(long*)num2 = struct_fiz2nb3.field_1;
			x2 = @int;
			llvm_lifetime_start_p0.Invoke(16L, &y2);
			Struct_fiz2nb struct_fiz2nb4 = fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_uintval_const.Invoke(&fputil_FPBits_ubgsi4);
			Int128* num3 = &int2;
			Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
			*(long*)num3 = struct_fiz2nb5.field_0;
			byte* num4 = (byte*)(&int2) + 8u;
			Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
			*(long*)num4 = struct_fiz2nb6.field_1;
			y2 = int2;
			llvm_lifetime_start_p0.Invoke(1L, &b);
			b = (NumericHelper.IntCmpNe(NumericHelper.BitwiseAnd(NumericHelper.BitwiseOr(x2, y2), 0L), 0L) ? ((sbyte)1) : ((sbyte)0));
			int result = ((!NumericHelper.IntCmpEq(x2, y2)) ? ((NumericHelper.IntCmpUlt(x2, y2) != ((b & 1) == 1)) ? 1 : 0) : (-1));
			llvm_lifetime_end_p0.Invoke(1L, &b);
			llvm_lifetime_end_p0.Invoke(16L, &y2);
			llvm_lifetime_end_p0.Invoke(16L, &x2);
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
			return (byte)result != 0;
		}
	}
}

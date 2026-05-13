using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil13totalordermagIeEENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEbE4typeES4_S4_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<long double>, bool>::type __llvm_libc_20_1_2_::fputil::totalordermag<long double>(long double, long double)")]
internal static partial class cpp_enable_if_cpp_is_floating_point_v_long_double_bool_type_fputil_totalordermag_long_double_long_double_long_double
{
	public unsafe static bool Invoke(double x, double y)
	{
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(fputil_FPBits_ubgsi2);
		Int128 @int = default(Int128);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi5 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi6 = default(fputil_FPBits_ubgsi2);
		Int128 y2 = default(Int128);
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
		fputil_FPBits_long_double_FPBits_long_double_long_double.Invoke(&fputil_FPBits_ubgsi4, x);
		Struct_fiz2nb struct_fiz2nb = fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_abs_const.Invoke(&fputil_FPBits_ubgsi4);
		Int128* ptr = &fputil_FPBits_ubgsi3.val.Data.FPStorage.field_0;
		Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
		unchecked
		{
			((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb2.field_0;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb3.field_1;
			Struct_fiz2nb struct_fiz2nb4 = fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_uintval_const.Invoke(&fputil_FPBits_ubgsi3);
			Int128* num = &@int;
			Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
			*(long*)num = struct_fiz2nb5.field_0;
			byte* num2 = (byte*)(&@int) + 8u;
			Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
			*(long*)num2 = struct_fiz2nb6.field_1;
			Int128 x2 = @int;
			llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
			llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi6);
			fputil_FPBits_long_double_FPBits_long_double_long_double.Invoke(&fputil_FPBits_ubgsi6, y);
			Struct_fiz2nb struct_fiz2nb7 = fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_abs_const.Invoke(&fputil_FPBits_ubgsi6);
			Int128* ptr2 = &fputil_FPBits_ubgsi5.val.Data.FPStorage.field_0;
			Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
			((Struct_fiz2nb*)ptr2)->field_0 = struct_fiz2nb8.field_0;
			Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
			((Struct_fiz2nb*)ptr2)->field_1 = struct_fiz2nb9.field_1;
			Struct_fiz2nb struct_fiz2nb10 = fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_uintval_const.Invoke(&fputil_FPBits_ubgsi5);
			Int128* num3 = &y2;
			Struct_fiz2nb struct_fiz2nb11 = struct_fiz2nb10;
			*(long*)num3 = struct_fiz2nb11.field_0;
			byte* num4 = (byte*)(&y2) + 8u;
			Struct_fiz2nb struct_fiz2nb12 = struct_fiz2nb10;
			*(long*)num4 = struct_fiz2nb12.field_1;
			bool result = NumericHelper.IntCmpUle(x2, y2);
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi6);
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
			return result;
		}
	}
}

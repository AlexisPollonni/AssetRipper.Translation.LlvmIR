using System;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil13totalordermagIDF16_EENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEbE4typeES4_S4_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16>, bool>::type __llvm_libc_20_1_2_::fputil::totalordermag<_Float16>(_Float16, _Float16)")]
internal static partial class cpp_enable_if_cpp_is_floating_point_v_Float16_bool_type_fputil_totalordermag_Float16_Float16_Float16
{
	public unsafe static bool Invoke(Half x, Half y)
	{
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(fputil_FPBits_2fahva);
		fputil_FPBits_2fahva fputil_FPBits_2fahva4 = default(fputil_FPBits_2fahva);
		fputil_FPBits_2fahva fputil_FPBits_2fahva5 = default(fputil_FPBits_2fahva);
		llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
		fputil_FPBits_Float16_FPBits_Float16_Float16.Invoke(&fputil_FPBits_2fahva3, x);
		short field_ = fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_abs_const.Invoke(&fputil_FPBits_2fahva3);
		fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
		unchecked
		{
			ushort num = (ushort)fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval_const.Invoke(&fputil_FPBits_2fahva2);
			llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva4);
			llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva5);
			fputil_FPBits_Float16_FPBits_Float16_Float16.Invoke(&fputil_FPBits_2fahva5, y);
			short field_2 = fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_abs_const.Invoke(&fputil_FPBits_2fahva5);
			fputil_FPBits_2fahva4.FPRepImpl.FPRepSem.FPStorage.field_0 = field_2;
			bool result = num <= (ushort)fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval_const.Invoke(&fputil_FPBits_2fahva4);
			llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva5);
			llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva4);
			llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
			llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
			return result;
		}
	}
}

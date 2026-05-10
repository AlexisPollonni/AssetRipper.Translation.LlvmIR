using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil13totalordermagIfEENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEbE4typeES4_S4_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float>, bool>::type __llvm_libc_20_1_2_::fputil::totalordermag<float>(float, float)")]
internal static partial class cpp_enable_if_cpp_is_floating_point_v_float_bool_type_fputil_totalordermag_float_float_float
{
	public unsafe static bool Invoke(float x, float y)
	{
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs4 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs5 = default(fputil_FPBits_5nkvcs);
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
		fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs3, x);
		int field_ = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_abs_const.Invoke(&fputil_FPBits_5nkvcs3);
		fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_;
		int num = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke(&fputil_FPBits_5nkvcs2);
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
		fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs5, y);
		int field_2 = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_abs_const.Invoke(&fputil_FPBits_5nkvcs5);
		fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
		bool result = unchecked((uint)num <= (uint)fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke(&fputil_FPBits_5nkvcs4));
		llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
		llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
		llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
		llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		return result;
	}
}

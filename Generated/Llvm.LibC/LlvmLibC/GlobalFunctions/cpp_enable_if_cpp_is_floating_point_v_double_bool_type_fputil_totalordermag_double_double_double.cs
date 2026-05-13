using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil13totalordermagIdEENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEbE4typeES4_S4_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double>, bool>::type __llvm_libc_20_1_2_::fputil::totalordermag<double>(double, double)")]
internal static partial class cpp_enable_if_cpp_is_floating_point_v_double_bool_type_fputil_totalordermag_double_double_double
{
	public unsafe static bool Invoke(double x, double y)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm5 = default(fputil_FPBits_wjhbrm);
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
		fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm3, x);
		unchecked
		{
			long val = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_abs_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm3));
			fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.val = val;
			long num = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
			fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm5, y);
			long val2 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_abs_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm5));
			fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.val = val2;
			bool result = (ulong)num <= (ulong)fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm4));
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			return result;
		}
	}
}

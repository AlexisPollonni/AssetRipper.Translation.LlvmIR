using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_totalordermag_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil13totalordermagIdEENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEbE4typeES4_S4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double>, bool>::type __llvm_libc_20_1_2_::fputil::totalordermag<double>(double, double)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double>, bool>::type")]
	public unsafe static bool Invoke([NativeType("double")] double x, [NativeType("double")] double y)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm5 = default(fputil_FPBits_wjhbrm);
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
		FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm3, x);
		unchecked
		{
			long val = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_abs.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm3));
			fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.val = val;
			long num = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm5, y);
			long val2 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_abs.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm5));
			fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.val = val2;
			bool result = (ulong)num <= (ulong)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm4));
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			return result;
		}
	}
}

using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_totalordermag_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil13totalordermagIfEENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEbE4typeES4_S4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float>, bool>::type __llvm_libc_20_1_2_::fputil::totalordermag<float>(float, float)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float>, bool>::type")]
	public unsafe static bool Invoke([NativeType("float")] float x, [NativeType("float")] float y)
	{
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs4 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs5 = default(fputil_FPBits_5nkvcs);
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
		FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs3, x);
		unchecked
		{
			int field_ = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_abs.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs3));
			fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_;
			int num = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2));
			llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
			llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs5, y);
			int field_2 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_abs.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs5));
			fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
			bool result = (uint)num <= (uint)FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs4));
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			return result;
		}
	}
}

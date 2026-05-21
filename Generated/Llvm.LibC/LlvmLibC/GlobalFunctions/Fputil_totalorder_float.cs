using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_totalorder_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil10totalorderIfEENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEbE4typeES4_S4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float>, bool>::type __llvm_libc_20_1_2_::fputil::totalorder<float>(float, float)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float>, bool>::type")]
	public unsafe static bool Invoke([MangledName("x")][NativeType("float")] float X, [MangledName("y")][NativeType("float")] float Y)
	{
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs2 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		int num = 0;
		int num2 = 0;
		sbyte b = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		unchecked
		{
			*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs) = -1431655766;
			FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs, X);
			Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
			*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2) = -1431655766;
			FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2, Y);
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs));
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2));
			Llvm_lifetime_start_p0.Invoke(1L, &b);
			b = ((((num | num2) & int.MinValue) != 0) ? ((sbyte)1) : ((sbyte)0));
			int result = ((num != num2) ? (((uint)num < (uint)num2 != ((b & 1) == 1)) ? 1 : 0) : (-1));
			Llvm_lifetime_end_p0.Invoke(1L, &b);
			Llvm_lifetime_end_p0.Invoke(4L, &num2);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
			Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
			return (byte)result != 0;
		}
	}
}

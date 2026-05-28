using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_min_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal3minIeEENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EES5_E4typeES5_S5_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<long double>, long double>::type __llvm_libc_20_1_2_::fputil::internal::min<long double>(long double, long double)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<long double>, long double>::type")]
	public unsafe static double Invoke([MangledName("x")][NativeType("long double")] double X, [MangledName("y")][NativeType("long double")] double Y)
	{
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi = default(Fputil_FPBits_ubgsi2);
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi2 = default(Fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi);
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi) = -6148914691236517206L;
			FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi, X);
			Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi2);
			*(Int128*)(&fputil_FPBits_ubgsi2) = -6148914691236517206L;
			FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi2, Y);
			anon_izyfb.Val = FPStorage_fputil_FPType_4_sign.Invoke(&fputil_FPBits_ubgsi);
			anon_izyfb2.Val = FPStorage_fputil_FPType_4_sign.Invoke(&fputil_FPBits_ubgsi2);
			double result = ((!NotEquals_rpctvi.Invoke(anon_izyfb.Val, anon_izyfb2.Val)) ? ((!(X < Y)) ? Y : X) : ((!FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_neg.Invoke(&fputil_FPBits_ubgsi)) ? Y : X));
			Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi2);
			Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi);
			return result;
		}
	}
}

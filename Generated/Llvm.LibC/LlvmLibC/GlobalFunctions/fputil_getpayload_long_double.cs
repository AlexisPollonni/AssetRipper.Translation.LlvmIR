using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_getpayload_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil10getpayloadIeEENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EES4_E4typeES4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<long double>, long double>::type __llvm_libc_20_1_2_::fputil::getpayload<long double>(long double)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<long double>, long double>::type")]
	public unsafe static double Invoke([NativeType("long double")] double x)
	{
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		Int128 @int = default(Int128);
		Int128 x2 = default(Int128);
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi3) = -6148914691236517206L;
			FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi3, x);
			double result;
			if (!FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_nan.Invoke(&fputil_FPBits_ubgsi3))
			{
				result = -1.0;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(16L, &@int);
				Struct_fiz2nb struct_fiz2nb = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_uintval.Invoke(&fputil_FPBits_ubgsi3);
				Int128* num = &x2;
				Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
				*(long*)num = struct_fiz2nb2.field_0;
				byte* num2 = (byte*)(&x2) + 8u;
				Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
				*(long*)num2 = struct_fiz2nb3.field_1;
				@int = NumericHelper.BitwiseAnd(x2, 4611686018427387903L);
				result = (double)@int;
				llvm_lifetime_end_p0.Invoke(16L, &@int);
			}
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
			return result;
		}
	}
}

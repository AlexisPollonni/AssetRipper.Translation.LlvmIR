using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_normalize_float128
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9normalizeIgEEvRiRNS0_6FPBitsIT_E11StorageTypeE")]
	[DemangledName("void __llvm_libc_20_1_2_::fputil::internal::normalize<__float128>(int&, __llvm_libc_20_1_2_::fputil::FPBits<__float128>::StorageType&)")]
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("int&")] void* exponent, [NativeType("__llvm_libc_20_1_2_::fputil::FPBits<__float128>::StorageType&")] void* mantissa)
	{
		int num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		Int128 @int = *unchecked((Int128*)mantissa);
		num = unchecked(cpp_countl_zero_unsigned_int128.Invoke(*(long*)(&@int), ((long*)(&@int))[1])) - 15;
		*unchecked((int*)exponent) -= num;
		int num2 = num;
		unchecked
		{
			*(Int128*)mantissa = NumericHelper.ShiftLeft(*(Int128*)mantissa, (Int128)(UInt128)(uint)num2);
			llvm_lifetime_end_p0.Invoke(4L, &num);
		}
	}
}

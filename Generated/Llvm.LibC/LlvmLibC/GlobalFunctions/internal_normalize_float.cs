using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_normalize_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9normalizeIfEEvRiRNS0_6FPBitsIT_E11StorageTypeE")]
	[DemangledName("void __llvm_libc_20_1_2_::fputil::internal::normalize<float>(int&, __llvm_libc_20_1_2_::fputil::FPBits<float>::StorageType&)")]
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("int&")] void* exponent, [NativeType("__llvm_libc_20_1_2_::fputil::FPBits<float>::StorageType&")] void* mantissa)
	{
		int num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = cpp_countl_zero_unsigned_int.Invoke(*unchecked((int*)mantissa)) - 8;
		*unchecked((int*)exponent) -= num;
		*unchecked((int*)mantissa) <<= num;
		llvm_lifetime_end_p0.Invoke(4L, &num);
	}
}

using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_normalize_Float16
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9normalizeIDF16_EEvRiRNS0_6FPBitsIT_E11StorageTypeE")]
	[DemangledName("void __llvm_libc_20_1_2_::fputil::internal::normalize<_Float16>(int&, __llvm_libc_20_1_2_::fputil::FPBits<_Float16>::StorageType&)")]
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("int&")] void* exponent, [NativeType("__llvm_libc_20_1_2_::fputil::FPBits<_Float16>::StorageType&")] void* mantissa)
	{
		int num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = cpp_countl_zero_unsigned_short.Invoke(*unchecked((short*)mantissa)) - 5;
		*unchecked((int*)exponent) -= num;
		int num2 = num;
		unchecked
		{
			*(short*)mantissa = (short)((ushort)(*(short*)mantissa) << num2);
			llvm_lifetime_end_p0.Invoke(4L, &num);
		}
	}
}

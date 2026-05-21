using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_normalize_Float16
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9normalizeIDF16_EEvRiRNS0_6FPBitsIT_E11StorageTypeE")]
	[DemangledName("void __llvm_libc_20_1_2_::fputil::internal::normalize<_Float16>(int&, __llvm_libc_20_1_2_::fputil::FPBits<_Float16>::StorageType&)")]
	[return: NativeType("void")]
	public unsafe static void Invoke([MangledName("exponent")][NativeType("int&")] void* Exponent, [MangledName("mantissa")][NativeType("__llvm_libc_20_1_2_::fputil::FPBits<_Float16>::StorageType&")] void* Mantissa)
	{
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = Cpp_countl_zero_unsigned_short.Invoke(*unchecked((short*)Mantissa)) - 5;
		*unchecked((int*)Exponent) -= num;
		int num2 = num;
		unchecked
		{
			*(short*)Mantissa = (short)((ushort)(*(short*)Mantissa) << num2);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
		}
	}
}

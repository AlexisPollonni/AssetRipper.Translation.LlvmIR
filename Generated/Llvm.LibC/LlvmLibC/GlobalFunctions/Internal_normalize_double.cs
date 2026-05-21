using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_normalize_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9normalizeIdEEvRiRNS0_6FPBitsIT_E11StorageTypeE")]
	[DemangledName("void __llvm_libc_20_1_2_::fputil::internal::normalize<double>(int&, __llvm_libc_20_1_2_::fputil::FPBits<double>::StorageType&)")]
	[return: NativeType("void")]
	public unsafe static void Invoke([MangledName("exponent")][NativeType("int&")] void* Exponent, [MangledName("mantissa")][NativeType("__llvm_libc_20_1_2_::fputil::FPBits<double>::StorageType&")] void* Mantissa)
	{
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = Cpp_countl_zero_unsigned_long.Invoke(*unchecked((long*)Mantissa)) - 11;
		*unchecked((int*)Exponent) -= num;
		unchecked
		{
			*(long*)Mantissa <<= (int)(uint)num;
			Llvm_lifetime_end_p0.Invoke(4L, &num);
		}
	}
}

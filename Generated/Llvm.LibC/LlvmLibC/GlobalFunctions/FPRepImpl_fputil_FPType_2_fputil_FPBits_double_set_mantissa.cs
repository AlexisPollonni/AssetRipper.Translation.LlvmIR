using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepImpl_fputil_FPType_2_fputil_FPBits_double_set_mantissa
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE2ENS0_6FPBitsIdEEE12set_mantissaEm")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)2, __llvm_libc_20_1_2_::fputil::FPBits<double>>::set_mantissa(unsigned long)")]
	public unsafe static void Invoke(fputil_internal_FPRepImpl_ucubaq* @this, [NativeType("unsigned long")] long mantVal)
	{
		unchecked
		{
			((fputil_internal_FPStorage_v3nexn*)@this)->val = FPStorage_fputil_FPType_2_merge.Invoke(((fputil_internal_FPStorage_v3nexn*)@this)->val, mantVal, 4503599627370495L);
		}
	}
}

using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_set_mantissa
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE0ENS0_6FPBitsIDF16_EEE12set_mantissaEt")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)0, __llvm_libc_20_1_2_::fputil::FPBits<_Float16>>::set_mantissa(unsigned short)")]
	public unsafe static void Invoke(fputil_internal_FPRepImpl_7z3gh9* @this, [NativeType("unsigned short")] short mantVal)
	{
		short b = mantVal;
		unchecked
		{
			((fputil_internal_FPStorage_za9n4f*)@this)->field_0 = FPStorage_fputil_FPType_0_merge.Invoke(((fputil_internal_FPStorage_za9n4f*)@this)->field_0, b, 1023);
		}
	}
}

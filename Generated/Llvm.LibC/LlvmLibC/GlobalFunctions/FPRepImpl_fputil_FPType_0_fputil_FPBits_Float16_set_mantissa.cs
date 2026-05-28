using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_set_mantissa
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE0ENS0_6FPBitsIDF16_EEE12set_mantissaEt")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)0, __llvm_libc_20_1_2_::fputil::FPBits<_Float16>>::set_mantissa(unsigned short)")]
	public unsafe static void Invoke([MangledName("this")] Fputil_internal_FPRepImpl_7z3gh9* This, [MangledName("mantVal")][NativeType("unsigned short")] short MantVal)
	{
		short b = MantVal;
		unchecked
		{
			((Fputil_internal_FPStorage_za9n4f*)This)->field_0 = FPStorage_fputil_FPType_0_merge.Invoke(((Fputil_internal_FPStorage_za9n4f*)This)->field_0, b, 1023);
		}
	}
}

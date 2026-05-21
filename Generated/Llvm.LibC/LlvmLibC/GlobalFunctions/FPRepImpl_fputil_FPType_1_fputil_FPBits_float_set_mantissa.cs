using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepImpl_fputil_FPType_1_fputil_FPBits_float_set_mantissa
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE1ENS0_6FPBitsIfEEE12set_mantissaEj")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)1, __llvm_libc_20_1_2_::fputil::FPBits<float>>::set_mantissa(unsigned int)")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm* This, [MangledName("mantVal")][NativeType("unsigned int")] int MantVal)
	{
		unchecked
		{
			((Llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)This)->field_0 = FPStorage_fputil_FPType_1_merge.Invoke(((Llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)This)->field_0, MantVal, 8388607);
		}
	}
}

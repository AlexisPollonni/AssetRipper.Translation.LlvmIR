using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11NormalFloatIdEC2ENS0_6FPBitsIdEE")]
[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<double>::NormalFloat(__llvm_libc_20_1_2_::fputil::FPBits<double>)")]
internal static partial class fputil_NormalFloat_double_NormalFloat_fputil_FPBits_double
{
	public unsafe static void Invoke(fputil_NormalFloat_n2h9ta* @this, [MangledName("bits.coerce")] long bits)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.val = bits;
		llvm_memcpy_p0_p0_i64.Invoke(&@this->sign, Sign_POS.Pointer, 1L, isVolatile: false);
		llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm3, &fputil_FPBits_wjhbrm2, 8L, isVolatile: false);
		fputil_NormalFloat_double_init_from_bits_fputil_FPBits_double.Invoke(@this, fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.val);
	}
}
